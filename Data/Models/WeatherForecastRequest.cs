using System.Text.Json.Serialization;

namespace Data.Models;

public class WeatherForecastRequest
{
    [JsonPropertyName("ip")]
    public string IP { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }
}
