using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient
{
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
}
