using Data.Models;
using System.Net.Http.Json;

namespace Data.Services;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly HttpClient _httpClient;

    public WeatherForecastService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherForecast> Get()
    {
        var request = await _httpClient.GetFromJsonAsync<WeatherForecastRequest>("https://jsonip.com");
        request = await _httpClient.GetFromJsonAsync<WeatherForecastRequest>($"https://ipapi.co/{request?.IP}/json");

        WeatherForecast forecast = new();

        forecast.Location = string.Format($"{request.City}, {request.Region}, {request.Postal}");

        request = await _httpClient.GetFromJsonAsync<WeatherForecastRequest>($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{request.City}?unitGroup=metric&include=current&key=API_KEY&contentType=json");
       
        forecast.Temperature = request.Conditions.Temperature;
        forecast.Humidity = request.Conditions.Humidity;
        forecast.WindSpeed = request.Conditions.WindSpeed;

        return forecast;
    }
}
    