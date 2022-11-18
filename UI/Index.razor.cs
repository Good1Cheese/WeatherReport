using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Components;

namespace UI;

public partial class Index
{
    [Inject] public IUserLocationService UserLocation { get; set; } = default!;

    [Inject] public IWeatherForecastService WeatherForecast { get; set; } = default!;

    public WeatherForecast? Forecast { get; set; }
    public bool Clicked { get; set; }

    public async Task GetForecast()
    {
        Clicked = true;

        var location = await UserLocation.Get();
        var weather = await WeatherForecast.Get(location.City);

        Forecast = new(weather, location);
    }
}
