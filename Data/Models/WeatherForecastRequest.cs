using System.Text.Json.Serialization;

namespace Data.Models;

public class WeatherForecastRequest
{
    [JsonPropertyName("currentConditions")]
    public Forecast СurrentConditions { get; set; } = default!;

    public class Forecast
    {
        public double Temp { get; set; } = default!;
        public double Humidity { get; set; } = default!;
        public double WindSpeed { get; set; } = default!;
    }
}
