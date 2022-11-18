using Data.Interfaces;
using Data.Models;
using System.Net.Http.Json;
using static Data.Models.WeatherForecast;

namespace Data.Services;

public class UserLocationService : IUserLocationService
{
    private readonly HttpClient _httpClient;
    private readonly WeatherForecast _forecast;

    public UserLocationService(HttpClient httpClient, WeatherForecast weatherForecast)
    {
        _httpClient = httpClient;
        _forecast = weatherForecast;
    }

    public async Task Get()
    {
        var location = await _httpClient.GetFromJsonAsync<GeoLocation>("https://jsonip.com");
        location = await _httpClient.GetFromJsonAsync<GeoLocation>($"https://ipapi.co/{location.IP}/json");

        _forecast.Location = location;
    }
}
