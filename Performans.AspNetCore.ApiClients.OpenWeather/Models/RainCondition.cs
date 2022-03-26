namespace Performans.AspNetCore.ApiClients.OpenWeather.Models;

public class RainCondition
{
    /// <summary>
    /// Rain volume for the last 1 hour, mm
    /// </summary>
    [JsonProperty("1h")]
    public double Last1Hour { get; set; }

    /// <summary>
    /// Rain volume for the last 3 hours, mm
    /// </summary>
    [JsonProperty("3h")]
    public double Last3Hours { get; set; }
}
