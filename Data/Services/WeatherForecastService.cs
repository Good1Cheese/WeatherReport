using Data.Interfaces;
using Data.Models;
using System.Net.Http.Json;
using static Data.Models.WeatherForecast;

namespace Data.Services;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly HttpClient _httpClient;
    private readonly WeatherForecast _forecast;

    public WeatherForecastService(HttpClient httpClient, WeatherForecast forecast)
    {
        _httpClient = httpClient;
        _forecast = forecast;
    }

    public async Task Get()
    {
        string APIKey = await _httpClient.GetStringAsync("https://localhost:7011/api/weatherforecast/key");

        var request = await _httpClient.GetFromJsonAsync<WeatherContainer>($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{_forecast.Location.City}?unitGroup=metric&include=current&key={APIKey}&contentType=json");

        _forecast.Result = request.Weather;
    }
}
