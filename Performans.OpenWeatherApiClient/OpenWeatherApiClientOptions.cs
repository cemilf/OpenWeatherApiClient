using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient
{
    public class OpenWeatherApiClientOptions
    {
        public string ApiBaseUrl { get; set; } = "https://api.openweathermap.org/data/2.5/";

        public string ApiKey { get; set; } = string.Empty;
    }
}
