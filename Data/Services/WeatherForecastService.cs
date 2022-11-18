using Data.Interfaces;
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

    public async Task<WeatherRequest.Weather> Get(string city)
    {
        string APIKey = await _httpClient.GetStringAsync("https://localhost:7011/api/weatherforecast/key");

        var request = await _httpClient.GetFromJsonAsync<WeatherRequest>($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}?unitGroup=metric&include=current&key={APIKey}&contentType=json");

        return request.Result;
    }
}
