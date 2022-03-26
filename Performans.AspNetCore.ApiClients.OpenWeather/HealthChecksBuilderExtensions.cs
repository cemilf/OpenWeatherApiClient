using Microsoft.Extensions.DependencyInjection;

namespace Performans.AspNetCore.ApiClients.OpenWeather;

public static class HealthChecksBuilderExtensions
{
    public static IHealthChecksBuilder AddOpenWeatherApiHealthCheck(this IHealthChecksBuilder healthChecksBuilder, string name = "Open Weather Api")
    {
        return healthChecksBuilder.AddCheck<OpenWeatherApiHealthCheck>(name);
    }
}