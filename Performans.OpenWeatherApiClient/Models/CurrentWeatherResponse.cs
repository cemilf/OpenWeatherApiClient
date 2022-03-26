using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient.Models
{
    public class CurrentWeatherResponse
    {
        /// <summary>
        /// City geo location, longitude
        /// </summary>
        public GeoCoordinate? Coord { get; set; }

        /// <summary>
        /// Weather condition
        /// </summary>
        public List<WeatherCondition> Weather { get; set; } = new List<WeatherCondition>();

        /// <summary>
        /// Internal parameter
        /// </summary>
        public string? Base { get; set; }

        /// <summary>
        /// Current Weather Condition
        /// </summary>
        [JsonProperty("main")]
        public CurrentWeatherData? CurrentWeater { get; set; }

        /// <summary>
        /// Visibility, meter. The maximum value of the visibility is 10km
        /// </summary>
        public double Visibility { get; set; }

        /// <summary>
        /// Wind Information
        /// </summary>
        public WindCondition? Wind { get; set; }

        /// <summary>
        /// Rain history
        /// </summary>
        public RainCondition? Rain { get; set; }

        /// <summary>
        /// Snow history
        /// </summary>
        public RainCondition? Snow { get; set; }

        /// <summary>
        /// Cloud conditions
        /// </summary>
        public CloudCondition? Clouds { get; set; }

        /// <summary>
        /// Time of data calculation, unix, UTC
        /// </summary>
        [JsonProperty("dt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        //public SysParams? Sys { get; set; }

        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        public long Timezone { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Internal parameter
        /// </summary>
        public long Cod { get; set; }
    }
}
