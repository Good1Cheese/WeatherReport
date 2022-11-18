using System.Text.Json.Serialization;

namespace Data.Models;

public class WeatherRequest
{
    [JsonPropertyName("currentConditions")]
    public Weather Result { get; set; } = default!;

    public class Weather
    {
        public double Temp { get; set; } = default!;
        public double Humidity { get; set; } = default!;
        public double WindSpeed { get; set; } = default!;
    }
}
