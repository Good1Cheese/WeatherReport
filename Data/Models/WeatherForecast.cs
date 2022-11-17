namespace Data.Models;

public class WeatherForecast
{
    public string Location { get; set; } = default!;
    public double Temperature { get; set; } = default!;
    public double Humidity { get; set; } = default!;
    public double WindSpeed { get; set; } = default!;
}
