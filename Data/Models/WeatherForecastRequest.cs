using System.Text.Json.Serialization;

namespace Data.Models;

public class WeatherForecastRequest
{
    [JsonPropertyName("currentConditions")]
    public Conditions Weather { get; set; }

    public class Conditions
    {
        [JsonPropertyName("temp")]
        public double Temperature { get; set; } = default!;

        [JsonPropertyName("humidity")]
        public double Humidity { get; set; } = default!;

        [JsonPropertyName("windspeed")]
        public double WindSpeed { get; set; } = default!;
    }
}
