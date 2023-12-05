namespace BlazorAppTest2.Client;

public interface IWeatherService
{
    Task<WeatherForecast[]> GetWeather();
}
