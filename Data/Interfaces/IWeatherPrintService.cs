using Data.Models;
using static Data.Models.WeatherForecastRequest;

namespace Data.Interfaces;

public interface IWeatherPrintService
{
    WeatherForecast Get(Conditions weather, UserLocation user);
}
