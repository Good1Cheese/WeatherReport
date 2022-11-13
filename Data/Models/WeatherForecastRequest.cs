using System.Text.Json.Serialization;

namespace Data.Models;

public class WeatherForecastRequest
{
    [JsonPropertyName("ip")]
    public string IP { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("postal")]
    public string Postal { get; set; }

    [JsonPropertyName("currentConditions")]
    public Conditions Conditions { get; set; } = default!;
}

public class Conditions
{
    [JsonPropertyName("temp")]
    public double Temperature { get; set; } = default!;

    [JsonPropertyName("humidity")]
    public double Humidity { get; set; } = default!;

    [JsonPropertyName("windspeed")]
    public double WindSpeed { get; set; } = default!;
}