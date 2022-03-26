using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient.Models
{
    public class CurrentWeatherInfo
    {
        /// <summary>
        /// Geographical coordinates of the location (latitude)
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// Geographical coordinates of the location (longitude)
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        /// <summary>
        /// Timezone name for the requested location
        /// </summary>
        public string? Timezone { get; set; }

        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        [JsonProperty("timezone_offset")]
        public long TimezoneOffset { get; set; }

        public CurrentWeatherData? Current { get; set; }

        public List<CurrentWeatherData>? Hourly { get; set; }
    }
}
