using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddOpenWeatherApiClient(this IServiceCollection services, IConfigurationSection config)
        {
            services.Configure<OpenWeatherApiClientOptions>(config).AddSingleton<OpenWeatherApiClient>();

            return services;
        }

    }
}
