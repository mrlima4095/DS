namespace Analytics.NET;

/// <summary>Analisa métricas físicas de arquivos de código de um diretório local.</summary>
public static class ProjectAnalyzer
{
    private static readonly HashSet<string> IgnoredDirectories = new(StringComparer.OrdinalIgnoreCase)
    {
        ".git", ".idea", ".vs", ".vscode", "bin", "build", "dist", "node_modules", "obj",
    };

    private static readonly HashSet<string> CodeExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".c", ".cpp", ".cs", ".cshtml", ".css", ".go", ".h", ".html", ".java", ".js",
        ".json", ".jsx", ".kt", ".php", ".py", ".rb", ".rs", ".sql", ".swift", ".ts",
        ".tsx", ".vue", ".xml", ".yml", ".yaml",
    };

    /// <summary>Extensões incluídas quando nenhuma lista personalizada é fornecida.</summary>
    public static IReadOnlySet<string> DefaultExtensions => CodeExtensions;

    /// <summary>
    /// Analisa os arquivos de código abaixo de <paramref name="projectPath"/>.
    /// Diretórios de dependências, controle de versão e artefatos de build são ignorados.
    /// </summary>
    /// <param name="projectPath">Caminho absoluto ou relativo para a raiz do projeto.</param>
    /// <param name="extensions">
    /// Extensões a incluir, com ou sem ponto. Quando nulo ou vazio, usa
    /// <see cref="DefaultExtensions"/>.
    /// </param>
    /// <returns>Totais do projeto, agrupamentos por extensão e métricas por arquivo.</returns>
    /// <exception cref="ArgumentException">O caminho está vazio.</exception>
    /// <exception cref="DirectoryNotFoundException">O diretório não existe.</exception>
    public static ProjectCodeMetrics Analyze(
        string projectPath,
        IEnumerable<string>? extensions = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(projectPath);

        var rootPath = Path.GetFullPath(projectPath);
        if (!Directory.Exists(rootPath))
        {
            throw new DirectoryNotFoundException($"Projeto não encontrado: {rootPath}");
        }

        var includedExtensions = NormalizeExtensions(extensions);
        var files = new List<CodeFileMetrics>();

        foreach (var path in EnumerateFiles(rootPath))
        {
            var extension = Path.GetExtension(path).ToLowerInvariant();
            if (!includedExtensions.Contains(extension))
            {
                continue;
            }

            try
            {
                long lines = 0;
                foreach (var _ in File.ReadLines(path))
                {
                    lines++;
                }

                var fileInfo = new FileInfo(path);
                files.Add(new CodeFileMetrics(
                    Path.GetRelativePath(rootPath, path),
                    extension,
                    lines,
                    fileInfo.Length));
            }
            catch (IOException)
            {
                // Arquivos removidos ou bloqueados durante a análise são ignorados.
            }
            catch (UnauthorizedAccessException)
            {
                // Um arquivo sem acesso não deve impedir a análise do restante do projeto.
            }
        }

        var languages = files
            .GroupBy(file => file.Extension, StringComparer.OrdinalIgnoreCase)
            .Select(group => new CodeLanguageMetrics(
                group.Key,
                group.Count(),
                group.Sum(file => file.LineCount),
                group.Sum(file => file.SizeBytes)))
            .OrderBy(language => language.Extension, StringComparer.OrdinalIgnoreCase)
            .ToArray();

        return new ProjectCodeMetrics(
            rootPath,
            files.Count,
            files.Sum(file => file.LineCount),
            files.Sum(file => file.SizeBytes),
            languages,
            files.OrderBy(file => file.RelativePath, StringComparer.OrdinalIgnoreCase).ToArray());
    }

    private static HashSet<string> NormalizeExtensions(IEnumerable<string>? extensions)
    {
        if (extensions is null)
        {
            return new HashSet<string>(CodeExtensions, StringComparer.OrdinalIgnoreCase);
        }

        var normalized = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var extension in extensions)
        {
            if (string.IsNullOrWhiteSpace(extension))
            {
                continue;
            }

            normalized.Add(extension.StartsWith('.') ? extension : $".{extension}");
        }

        return normalized.Count == 0
            ? new HashSet<string>(CodeExtensions, StringComparer.OrdinalIgnoreCase)
            : normalized;
    }

    private static IEnumerable<string> EnumerateFiles(string rootPath)
    {
        var directories = new Stack<string>();
        directories.Push(rootPath);

        while (directories.Count > 0)
        {
            var directory = directories.Pop();
            IEnumerable<string> childDirectories;
            IEnumerable<string> files;
            try
            {
                childDirectories = Directory.EnumerateDirectories(directory).ToArray();
                files = Directory.EnumerateFiles(directory).ToArray();
            }
            catch (IOException)
            {
                continue;
            }
            catch (UnauthorizedAccessException)
            {
                continue;
            }

            foreach (var childDirectory in childDirectories)
            {
                if (!IgnoredDirectories.Contains(Path.GetFileName(childDirectory)))
                {
                    directories.Push(childDirectory);
                }
            }

            foreach (var file in files)
            {
                yield return file;
            }
        }
    }
}

/// <summary>Resumo físico dos arquivos de código encontrados em um projeto.</summary>
/// <param name="RootPath">Caminho absoluto da raiz analisada.</param>
/// <param name="FileCount">Quantidade de arquivos de código incluídos.</param>
/// <param name="LineCount">Quantidade total de linhas, incluindo linhas vazias.</param>
/// <param name="SizeBytes">Tamanho total dos arquivos incluídos em bytes.</param>
/// <param name="Languages">Totais agrupados por extensão.</param>
/// <param name="Files">Métricas individuais de cada arquivo incluído.</param>
public sealed record ProjectCodeMetrics(
    string RootPath,
    int FileCount,
    long LineCount,
    long SizeBytes,
    IReadOnlyList<CodeLanguageMetrics> Languages,
    IReadOnlyList<CodeFileMetrics> Files);

/// <summary>Totais de arquivos de código com a mesma extensão.</summary>
/// <param name="Extension">Extensão dos arquivos, incluindo o ponto.</param>
/// <param name="FileCount">Quantidade de arquivos.</param>
/// <param name="LineCount">Quantidade total de linhas.</param>
/// <param name="SizeBytes">Tamanho total em bytes.</param>
public sealed record CodeLanguageMetrics(
    string Extension,
    int FileCount,
    long LineCount,
    long SizeBytes);

/// <summary>Métricas físicas de um arquivo de código.</summary>
/// <param name="RelativePath">Caminho do arquivo relativo à raiz analisada.</param>
/// <param name="Extension">Extensão do arquivo, incluindo o ponto.</param>
/// <param name="LineCount">Quantidade de linhas, incluindo linhas vazias.</param>
/// <param name="SizeBytes">Tamanho do arquivo em bytes.</param>
public sealed record CodeFileMetrics(
    string RelativePath,
    string Extension,
    long LineCount,
    long SizeBytes);
