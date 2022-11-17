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

    public async Task<WeatherForecastRequest.Conditions> Get(UserLocation user)
    {
        var request = await _httpClient.GetFromJsonAsync<WeatherForecastRequest>($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{user.City}?unitGroup=metric&include=current&key=API-KEY&contentType=json");

        return request.Weather;
    }
}
