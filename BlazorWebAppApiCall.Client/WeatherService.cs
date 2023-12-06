
using System.Net.Http.Json;

namespace BlazorWebAppApiCall.Client;

public class WeatherService(HttpClient httpClient) : IWeatherService
{
    public Task<WeatherForecast[]> GetWeather() => 
        httpClient.GetFromJsonAsync<WeatherForecast[]>("/api/weather")!;
}
