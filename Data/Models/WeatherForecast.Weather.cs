using System.Text.Json.Serialization;

namespace Data.Models;

public partial class WeatherForecast
{
    public class WeatherContainer
    {
        [JsonPropertyName("currentConditions")]
        public Weather Weather { get; set; } = new();
    }

    public class Weather
    {
        public double Temp { get; set; } = default!;
        public double Humidity { get; set; } = default!;
        public double WindSpeed { get; set; } = default!;
    }
}
