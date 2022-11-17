using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Components;

namespace UI;

public partial class Index
{
    [Inject]
    public IUserLocationService UserLocationService { get; set; } = default!;

    [Inject]
    public IWeatherForecastService WeatherForecastService { get; set; } = default!;

    [Inject]
    public IWeatherForecastOutputService ForecastOutputService { get; set; } = default!;

    public WeatherForecast? Forecast { get; set; }
    public bool Clicked { get; set; }

    public async Task GetForecast()
    {
        Clicked = true;

        var location = await UserLocationService.Get();
        var forecast = await WeatherForecastService.Get(location.City);

        Forecast = ForecastOutputService.Format(forecast, location);
    }
}
