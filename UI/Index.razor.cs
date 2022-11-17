using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Components;

namespace UI;

public partial class Index
{
    [Inject] public IWeatherForecastService WeatherForecastService { get; set; } = default!;
    [Inject] public IUserLocationService UserLocationService { get; set; } = default!;
    [Inject] public IWeatherPrintService WeatherPrintService { get; set; } = default!;

    public WeatherForecast? Forecast { get; set; }
    public bool Clicked { get; set; }

    public async Task GetForecast()
    {
        Clicked = true;

        var user = await UserLocationService.Get();
        var weather  = await WeatherForecastService.Get(user);

        Forecast = WeatherPrintService.Get(weather, user);
    }
}
