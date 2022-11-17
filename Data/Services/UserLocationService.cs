using Data.Interfaces;
using Data.Models;
using System.Net.Http.Json;

namespace Data.Services;

public class UserLocationService : IUserLocationService
{
    private readonly HttpClient _httpClient;

    public UserLocationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<UserLocation> Get()
    {
        var location = await _httpClient.GetFromJsonAsync<UserLocation>("https://jsonip.com");
        location = await _httpClient.GetFromJsonAsync<UserLocation>($"https://ipapi.co/{location?.IP}/json");

        return location;
    }
}
