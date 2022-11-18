using System.Text.Json.Serialization;

namespace Data.Models;

public partial class WeatherForecast
{
    [JsonPropertyName("currentConditions")]
    public Weather Result { get; set; } = new();

    public GeoLocation Location { get; set; } = new();

    public class Weather
    {
        public double Temp { get; set; } = default!;
        public double Humidity { get; set; } = default!;
        public double WindSpeed { get; set; } = default!;
    }

    public class GeoLocation
    {
        public string IP { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Region { get; set; } = default!;
        public string Postal { get; set; } = default!;
    }
}
