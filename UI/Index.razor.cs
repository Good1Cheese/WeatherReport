using Data.Models;
using Data.Services;
using Microsoft.AspNetCore.Components;

namespace UI;

public partial class Index
{
    [Inject] public IWeatherForecastService WeatherForecastService { get; set; } = default!;

    public WeatherForecast? Forecast { get; set; }
    public bool Clicked { get; set; }

    public async Task GetForecast()
    {
        Clicked = true;

        Forecast = await WeatherForecastService.Get();
    }
}
