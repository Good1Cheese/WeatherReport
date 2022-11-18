using static Data.Models.WeatherRequest;

namespace Data.Models;

public class WeatherForecast
{
    public WeatherForecast(Weather weather, UserLocation location)
    {
        Location = string.Format($"{location.City}, {location.Region}, {location.Postal}");
        Temperature = weather.Temp;
        Humidity = weather.Humidity;
        WindSpeed = weather.WindSpeed;
    }

    public string Location { get; set; } = default!;
    public double Temperature { get; set; } = default!;
    public double Humidity { get; set; } = default!;
    public double WindSpeed { get; set; } = default!;
}
