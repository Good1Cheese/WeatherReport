using System.Text.Json.Serialization;

namespace Data.Models;

public class WeatherForecastRequest
{
    [JsonPropertyName("currentConditions")]
    public Forecast Weather { get; set; } = default!;

    public class Forecast
    {
        [JsonPropertyName("temp")]
        public double Temperature { get; set; } = default!;

        [JsonPropertyName("humidity")]
        public double Humidity { get; set; } = default!;

        [JsonPropertyName("windspeed")]
        public double WindSpeed { get; set; } = default!;
    }
}
