using Data.Models;

namespace Data.Interfaces;

public interface IWeatherForecastService
{
    Task<WeatherForecastRequest.Forecast> Get(string city);
}
