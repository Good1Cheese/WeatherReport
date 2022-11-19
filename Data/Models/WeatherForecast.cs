using System.Text.Json.Serialization;

namespace Data.Models;

public partial class WeatherForecast
{
    public Weather Result { get; set; } = new();
    public GeoLocation Location { get; set; } = new();
}
