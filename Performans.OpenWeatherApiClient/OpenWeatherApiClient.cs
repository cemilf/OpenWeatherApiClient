using Microsoft.Extensions.Options;
using Flurl;
using Flurl.Http;
using Performans.OpenWeatherApiClient.Models;

namespace Performans.OpenWeatherApiClient
{
    public class OpenWeatherApiClient
    {
        private readonly string _apiKey;
        private readonly string _apiBaseUrl;


        public OpenWeatherApiClient(IOptions<OpenWeatherApiClientOptions> options)
        {
            _apiBaseUrl = options.Value.ApiBaseUrl;
            _apiKey = options.Value.ApiKey;
        }

        private Url? CreateRequest(string route, WeatherRequest query)
        {
            var request = _apiBaseUrl
                .AppendPathSegment(route)
                .SetQueryParam("appid", _apiKey);

            if (query.Coordinates != null)
            {
                request = request
                    .SetQueryParam("lat", query.Coordinates.Latitude)
                    .SetQueryParam("lon", query.Coordinates.Longitude);
            }

            if (!string.IsNullOrWhiteSpace(query.City))
            {
                request = request.SetQueryParam("q", query.City);
            }


            if (!string.IsNullOrWhiteSpace(query.Units))
            {
                request = request.SetQueryParam("units", query.Units);
            }

            if (!string.IsNullOrWhiteSpace(query.Mode))
            {
                request = request.SetQueryParam("mode", query.Mode);
            }


            if (!string.IsNullOrWhiteSpace(query.Exclude))
            {
                request = request.SetQueryParam("exclude", query.Exclude);
            }

            if (!string.IsNullOrWhiteSpace(query.Language))
            {
                request = request.SetQueryParam("lang", query.Language);
            }


            return request;
        }


        public async Task<CurrentWeatherResponse> GetCurrentWeatherAsync(WeatherRequest query)
        {
            return await CreateRequest("weather", query).GetJsonAsync<CurrentWeatherResponse>();
        }

        public async Task<CurrentWeatherInfo> GetCurrentWeatherOneCallAsync(WeatherRequest query)
        {
            return await CreateRequest("onecall", query).GetJsonAsync<CurrentWeatherInfo>();
        }

        public async Task<bool> HealthCheckAsync()
        {
            return await Task.FromResult(true);
        }
    }
}