using Data.Models;

namespace Data.Interfaces;

public interface IWeatherForecastService
{
    Task<WeatherForecastRequest.Conditions> Get(UserLocation user);
}
