namespace BlazorWebAppApiCall.Client;

public interface IWeatherService
{
    Task<WeatherForecast[]> GetWeather();
}
