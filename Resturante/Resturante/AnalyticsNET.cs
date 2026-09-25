using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;

namespace Analytics.NET;

/// <summary>Cliente de análise de interações com métricas agregadas em memória.</summary>
public sealed class AnalyticsNET : IDisposable
{
    /// <summary>URL base padrão do serviço de interações.</summary>
    public const string DefaultBaseUrl = "https://chat.opentty.fun/v1/";

    private readonly HttpClient _httpClient;
    private readonly bool _disposeHttpClient;
    private long _requestCount;
    private long _successCount;
    private long _failureCount;
    private long _totalElapsedTicks;
    private int _lastStatusCode;

    /// <summary>Chave de acesso usada nas requisições.</summary>
    public string ApiKey { get; }

    /// <summary>Cria um cliente com uma chave de acesso e um cliente HTTP opcional.</summary>
    /// <param name="apiKey">Chave enviada no cabeçalho Authorization Bearer.</param>
    /// <param name="httpClient">
    /// Cliente HTTP a reutilizar. Sem valor, a instância cria e descarta seu próprio cliente.
    /// </param>
    public AnalyticsNET(string apiKey, HttpClient? httpClient = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);

        ApiKey = apiKey;
        _disposeHttpClient = httpClient is null;
        _httpClient = httpClient ?? new HttpClient { BaseAddress = new Uri(DefaultBaseUrl) };
    }

    /// <summary>Processa uma interação e atualiza as métricas locais.</summary>
    public async Task<AnalyticsResult> CompletionAsync(
        string message,
        string model = "lucy:latest",
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);
        ArgumentException.ThrowIfNullOrWhiteSpace(model);

        var startedAt = Stopwatch.GetTimestamp();
        try
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, "chat/completions")
            {
                Content = JsonContent.Create(new
                {
                    model,
                    messages = new[] { new { role = "user", content = message } },
                    stream = false,
                }),
            };
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ApiKey);

            using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            RecordRequest(response.IsSuccessStatusCode, response.StatusCode, startedAt);

            return new AnalyticsResult(
                response.StatusCode,
                ExtractResponse(body),
                body,
                response.IsSuccessStatusCode);
        }
        catch
        {
            RecordRequest(false, null, startedAt);
            throw;
        }
    }

    /// <summary>Retorna métricas agregadas desde a criação desta instância.</summary>
    public AnalyticsMetrics GetMetrics() => new(
        Interlocked.Read(ref _requestCount),
        Interlocked.Read(ref _successCount),
        Interlocked.Read(ref _failureCount),
        TimeSpan.FromTicks(Interlocked.Read(ref _totalElapsedTicks)),
        Volatile.Read(ref _lastStatusCode) is var status && status > 0 ? (HttpStatusCode)status : null);

    private void RecordRequest(bool success, HttpStatusCode? statusCode, long startedAt)
    {
        Interlocked.Increment(ref _requestCount);
        Interlocked.Add(ref _totalElapsedTicks, Stopwatch.GetElapsedTime(startedAt).Ticks);
        if (success)
        {
            Interlocked.Increment(ref _successCount);
        }
        else
        {
            Interlocked.Increment(ref _failureCount);
        }

        if (statusCode is not null)
        {
            Volatile.Write(ref _lastStatusCode, (int)statusCode.Value);
        }
    }

    private static string? ExtractResponse(string body)
    {
        try
        {
            var completion = JsonSerializer.Deserialize<CompletionResponse>(body);
            return completion?.Choices?.FirstOrDefault()?.Message?.Content
                ?? completion?.Error?.Message;
        }
        catch (JsonException)
        {
            return null;
        }
    }

    /// <summary>Descarta o cliente HTTP criado internamente, quando houver.</summary>
    public void Dispose()
    {
        if (_disposeHttpClient)
        {
            _httpClient.Dispose();
        }
    }

    private sealed record CompletionResponse(
        [property: JsonPropertyName("choices")] CompletionChoice[]? Choices,
        [property: JsonPropertyName("error")] CompletionError? Error);

    private sealed record CompletionChoice(
        [property: JsonPropertyName("message")] CompletionMessage? Message);

    private sealed record CompletionMessage(
        [property: JsonPropertyName("content")] string? Content);

    private sealed record CompletionError(
        [property: JsonPropertyName("message")] string? Message);
}

/// <summary>Resultado de uma interação analisada.</summary>
public sealed record AnalyticsResult(
    HttpStatusCode StatusCode,
    string? Response,
    string RawResponse,
    bool IsSuccessStatusCode);

/// <summary>Métricas locais agregadas de uma instância de <see cref="AnalyticsNET"/>.</summary>
public sealed record AnalyticsMetrics(
    long RequestCount,
    long SuccessCount,
    long FailureCount,
    TimeSpan TotalElapsed,
    HttpStatusCode? LastStatusCode)
{
    /// <summary>Duração média das requisições registradas.</summary>
    public TimeSpan AverageElapsed => RequestCount == 0
        ? TimeSpan.Zero
        : TimeSpan.FromTicks(TotalElapsed.Ticks / RequestCount);
}
