
namespace Performans.AspNetCore.ApiClients.OpenWeather;

public class OpenWeatherApiClientOptions
{
    public string ApiBaseUrl { get; set; } = "https://api.openweathermap.org/data/2.5/";

    public string ApiKey { get; set; } = string.Empty;
}