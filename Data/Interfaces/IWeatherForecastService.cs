using Data.Models;

namespace Data.Interfaces;

public interface IWeatherForecastService
{
    Task<WeatherRequest.Weather> Get(string city);
}
