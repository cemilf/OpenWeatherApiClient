using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient.Models
{
    public class WeatherRequest
    {
        /// <summary>
        /// Geographical coordinates latitude, longitude
        /// </summary>
        public GeoCoordinate? Coordinates { get; set; }

        public string? City { get; set; }

        /// <summary>
        /// Units of measurement. standard, metric and imperial units are available. 
        /// If you do not use the units parameter, standard units will be applied by default.
        /// </summary>
        public string? Units { get; set; }

        /// <summary>
        /// Response format. Possible values are xml and html. If you don't use the mode parameter format is JSON by default.
        /// </summary>
        public string? Mode { get; set; }

        /// <summary>
        /// You can use this parameter to get the output in your language.
        /// 
        /// </summary>
        public string? Language { get; set; }


        public string? Exclude { get; set; }
    }
}
