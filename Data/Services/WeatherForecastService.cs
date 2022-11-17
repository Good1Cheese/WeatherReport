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

    public async Task<WeatherForecastRequest.Forecast> Get(string city)
    {
        var request = await _httpClient.GetFromJsonAsync<WeatherForecastRequest>($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}?unitGroup=metric&include=current&key=API-KEY&contentType=json");

        return request.Weather;
    }
}
