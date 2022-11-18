using Data.Interfaces;
using Data.Models;
using static Data.Models.WeatherForecastRequest;

namespace Data.Services;

public class WeatherForecastOutputService : IWeatherForecastOutputService
{
    public WeatherForecast Format(Forecast forecast, UserLocation location)
    {
        return new()
        {
            Location = string.Format($"{location.City}, {location.Region}, {location.Postal}"),
            Temperature = forecast.Temp,
            Humidity = forecast.Humidity,
            WindSpeed = forecast.WindSpeed
        };
    }
}
