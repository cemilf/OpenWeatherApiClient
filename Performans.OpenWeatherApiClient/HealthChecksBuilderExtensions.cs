using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient
{
    public static class HealthChecksBuilderExtensions
    {
        public static IHealthChecksBuilder AddOpenWeatherApiHealthCheck(this IHealthChecksBuilder healthChecksBuilder, string name = "Open Weather Api")
        {
            return healthChecksBuilder.AddCheck<OpenWeatherApiHealthCheck>(name);
        }
    }
}
