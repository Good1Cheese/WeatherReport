using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Components;

namespace UI;

public partial class Index
{
    [Inject] public IUserLocationService UserLocation { get; init; } = default!;
    [Inject] public IWeatherForecastService WeatherForecast { get; init; } = default!;

    [Inject] public WeatherForecast? Forecast { get; init; }

    public bool Clicked { get; private set; }
    public bool Done { get; private set; }

    public async Task GetForecast()
    {
        Clicked = true;

        await UserLocation.Get();
        await WeatherForecast.Get();

        Done = true;
    }
}
