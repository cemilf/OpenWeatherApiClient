using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Performans.AspNetCore.ApiClients.OpenWeather;

public class OpenWeatherApiHealthCheck : IHealthCheck
{
    private readonly OpenWeatherApiClient _apiClient;

    public OpenWeatherApiHealthCheck(OpenWeatherApiClient apiClient)
    {
        _apiClient = apiClient;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        return await _apiClient.HealthCheckAsync()
            ? HealthCheckResult.Healthy()
            : HealthCheckResult.Unhealthy();
    }
}

