namespace Performans.AspNetCore.ApiClients.OpenWeather.Models;

public class WeatherCondition
{
    /// <summary>
    /// Weather condition id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Group of weather parameters (Rain, Snow, Extreme etc.)
    /// </summary>
    public string? Main { get; set; }

    /// <summary>
    /// Weather condition within the group. You can get the output in your language
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Weather icon id
    /// </summary>
    public string? Icon { get; set; }
}