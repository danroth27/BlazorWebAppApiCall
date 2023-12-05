
using System.Net.Http.Json;

namespace BlazorAppTest2.Client;

public class WeatherService(HttpClient httpClient) : IWeatherService
{
    public Task<WeatherForecast[]> GetWeather() => 
        httpClient.GetFromJsonAsync<WeatherForecast[]>("/api/weather")!;
}
