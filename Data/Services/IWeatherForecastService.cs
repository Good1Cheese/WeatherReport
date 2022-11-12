using Data.Models;

namespace Data.Services;

public interface IWeatherForecastService
{
    Task<WeatherForecast> Get();
}
