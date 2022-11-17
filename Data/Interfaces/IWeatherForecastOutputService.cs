using Data.Models;
using static Data.Models.WeatherForecastRequest;

namespace Data.Interfaces;

public interface IWeatherForecastOutputService
{
    WeatherForecast Format(Forecast weather, UserLocation user);
}
