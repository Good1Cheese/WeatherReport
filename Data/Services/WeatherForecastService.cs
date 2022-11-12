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

    // Нужно получать позицию пользователя, затем прогноз погоды 
    // https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/CITY?unitGroup=metric&key=6PGHAX6MUKV9MGUUQ3452BDY7&contentType=json

    // Желательно делать два запроса, а не три
    // https://jsonip.com - ip
    // https://ipapi.co/api/ - город по ip
    // https://www.visualcrossing.com/- погода по координатам/городу
    public async Task<WeatherForecast> Get()
    {
        var request = await _httpClient.GetFromJsonAsync<WeatherForecastRequest>("https://jsonip.com");
        request = await _httpClient.GetFromJsonAsync<WeatherForecastRequest>($"https://ipapi.co/{request.IP}/json");
      

        return request;
    }
}
