using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Performans.OpenWeatherApiClient.Models
{
    public class SysParams
    {
        /// <summary>
        /// Internal parameter
        /// </summary>
        public double Type { get; set; }

        /// <summary>
        /// Internal parameter
        /// </summary>
        public double Id { get; set; }

        /// <summary>
        /// Internal parameter
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Country code (GB, JP etc.)
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Sunrise time,  UTC
        /// </summary>
        public long Sunrise { get; set; }

        /// <summary>
        /// Sunset time,  UTC
        /// </summary>
        public long Sunset { get; set; }
    }
}
