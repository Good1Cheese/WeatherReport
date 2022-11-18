using static Data.Models.WeatherForecastRequest;

namespace Data.Models;

public class WeatherForecast
{
    public WeatherForecast(Forecast forecast, UserLocation location)
    {
        Location = string.Format($"{location.City}, {location.Region}, {location.Postal}");
        Temperature = forecast.Temp;
        Humidity = forecast.Humidity;
        WindSpeed = forecast.WindSpeed;
    }

    public string Location { get; set; } = default!;
    public double Temperature { get; set; } = default!;
    public double Humidity { get; set; } = default!;
    public double WindSpeed { get; set; } = default!;
}
