using Newtonsoft.Json.Converters;

namespace Performans.AspNetCore.ApiClients.OpenWeather.Models;

public class CurrentWeatherData
{
    /// <summary>
    /// Current time, UTC
    /// </summary>
    [JsonProperty("dt")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Sunrise time, UTC
    /// </summary>
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? Sunrise { get; set; }

    /// <summary>
    /// Sunset time, UTC
    /// </summary>
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? Sunset { get; set; }

    /// <summary>
    /// Temperature. Units - default: kelvin, metric: Celsius, imperial: Fahrenheit.
    /// </summary>
    [JsonProperty("temp")]
    public double Temperature { get; set; }

    /// <summary>
    /// Temperature. This temperature parameter accounts for the human perception of weather. 
    /// Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
    /// </summary>
    [JsonProperty("feels_like")]
    public double FeelsLike { get; set; }

    /// <summary>
    /// Atmospheric pressure on the sea level, hPa
    /// </summary>
    public double Pressure { get; set; }

    /// <summary>
    /// Humidity, %
    /// </summary>
    public double Humidity { get; set; }

    /// <summary>
    /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense 
    /// and dew can form. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
    /// </summary>
    [JsonProperty("dew_point")]
    public double DewPoint { get; set; }

    /// <summary>
    /// Current UV index
    /// </summary>
    public double Uvi { get; set; }

    /// <summary>
    /// Cloudiness, %
    /// </summary>
    public double Clouds { get; set; }

    /// <summary>
    /// Average visibility, metres. The maximum value of the visibility is 10km
    /// </summary>
    public double Visibility { get; set; }

    /// <summary>
    /// Wind speed. Wind speed. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour
    /// </summary>
    [JsonProperty("wind_speed")]
    public double WindSpeed { get; set; }

    /// <summary>
    /// Wind direction, degrees (meteorological)
    /// </summary>
    [JsonProperty("wind_deg")]
    public long WindDirection { get; set; }

    /// <summary>
    /// (where available) Wind gust. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
    /// </summary>
    [JsonProperty("wind_gust")]
    public double WindGust { get; set; }

    public RainCondition? Rain { get; set; }

    public RainCondition? Snow { get; set; }


    public List<WeatherCondition>? Weather { get; set; }

    /// <summary>
    /// Probability of precipitation. The values of the parameter vary between 0 and 1, where 0 is equal to 0%, 1 is equal to 100%
    /// </summary>
    [JsonProperty("pop")]
    public double? ProbabilityOfPrecipitation { get; set; }
}