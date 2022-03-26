namespace Performans.AspNetCore.ApiClients.OpenWeather.Models;

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