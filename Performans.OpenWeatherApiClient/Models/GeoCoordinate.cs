using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient.Models
{
    public class GeoCoordinate
    {

        /// <summary>
        /// City geo  latitude
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// City geo longitude
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }

    }
}
