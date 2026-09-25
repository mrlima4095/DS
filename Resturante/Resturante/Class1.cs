using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public sealed class LucyClient : IDisposable
{
    public const string DefaultBaseUrl = "https://opentty.fun";
    public const string DefaultModel = "lucy:latest";

    private readonly HttpClient _http;
    private readonly bool _ownsHttpClient;
    private readonly string _apiKey;
    private readonly string _model;

    public LucyClient(string apiKey)
        : this(apiKey, DefaultModel, DefaultBaseUrl, null)
    {
    }

    public LucyClient(
        string apiKey,
        string model,
        string baseUrl,
        HttpClient httpClient = null)
    {
        if (apiKey == null)
            throw new ArgumentNullException(nameof(apiKey));

        if (model == null)
            throw new ArgumentNullException(nameof(model));

        if (baseUrl == null)
            throw new ArgumentNullException(nameof(baseUrl));

        _apiKey = apiKey;
        _model = model;

        _ownsHttpClient = httpClient == null;
        _http = httpClient ?? new HttpClient();

        if (_ownsHttpClient)
        {
            _http.BaseAddress = new Uri(
                NormalizeBaseUrl(baseUrl),
                UriKind.Absolute);
        }
    }

    public async Task<string> GenerateResponseAsync(
        string message,
        CancellationToken ct = default(CancellationToken))
    {
        if (string.IsNullOrWhiteSpace(message))
            throw new ArgumentException(
                "Mensagem vazia.",
                nameof(message));

        // Escapa aspas e quebras de linha para evitar quebrar o JSON manual
        string escapedMessage = message
            .Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\n", "\\n")
            .Replace("\r", "\\r");

        // Cria a string JSON na unha de forma exata
        string json = "{\"model\":\"" + _model + "\",\"messages\":[{\"role\":\"user\",\"content\":\"" + escapedMessage + "\"}],\"stream\":false}";

        using (var request = new HttpRequestMessage(
            HttpMethod.Post,
            "chat/completions"))
        {
            request.Content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json");

            request.Headers.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    _apiKey);

            using (HttpResponseMessage response =
                   await _http.SendAsync(request, ct)
                              .ConfigureAwait(false))
            {
                string body =
                    await response.Content.ReadAsStringAsync()
                        .ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(
                        "Lucy retornou " +
                        (int)response.StatusCode +
                        ": " +
                        ExtractError(body));
                }

                // Extração manual da propriedade "content" do JSON de sucesso
                string searchKey = "\"content\":\"";
                int index = body.IndexOf(searchKey, StringComparison.Ordinal);

                if (index != -1)
                {
                    int start = index + searchKey.Length;
                    int end = body.IndexOf("\"", start, StringComparison.Ordinal);

                    if (end != -1)
                    {
                        string content = body.Substring(start, end - start);

                        // Desfaz os caracteres escapados vindo da resposta da API
                        return content
                            .Replace("\\\"", "\"")
                            .Replace("\\n", "\n")
                            .Replace("\\r", "\r")
                            .Replace("\\\\", "\\");
                    }
                }

                throw new InvalidOperationException("Resposta da Lucy sem content.");
            }
        }
    }

    private static string ExtractError(string body)
    {
        if (string.IsNullOrWhiteSpace(body))
            return "Resposta vazia.";

        // Extração manual da propriedade "message" dentro do bloco "error"
        string searchKey = "\"message\":\"";
        int index = body.IndexOf(searchKey, StringComparison.Ordinal);

        if (index != -1)
        {
            int start = index + searchKey.Length;
            int end = body.IndexOf("\"", start, StringComparison.Ordinal);

            if (end != -1)
            {
                return body.Substring(start, end - start);
            }
        }

        return body;
    }

    private static string NormalizeBaseUrl(string url)
    {
        return url.EndsWith("/", StringComparison.Ordinal)
            ? url
            : url + "/";
    }

    public void Dispose()
    {
        if (_ownsHttpClient)
            _http.Dispose();
    }
}
