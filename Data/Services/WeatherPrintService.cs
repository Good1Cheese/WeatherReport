using Data.Interfaces;
using Data.Models;
using static Data.Models.WeatherForecastRequest;

namespace Data.Services;

public class WeatherPrintService : IForecastOutputService
{
    public WeatherForecast Get(Conditions weather, UserLocation user)
    {
        WeatherForecast forecast = new();

        forecast.Location = string.Format($"{user.City}, {user.Region}, {user.Postal}");
        forecast.Temperature = weather.Temperature;
        forecast.Humidity = weather.Humidity;
        forecast.WindSpeed = weather.WindSpeed;

        return forecast;
    }
}
