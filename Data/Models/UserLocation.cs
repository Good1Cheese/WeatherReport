using System.Text.Json.Serialization;

namespace Data.Models;

public class UserLocation
{
    [JsonPropertyName("ip")]
    public string IP { get; set; } = default!;

    [JsonPropertyName("city")]
    public string City { get; set; } = default!;

    [JsonPropertyName("region")]
    public string Region { get; set; } = default!;

    [JsonPropertyName("postal")]
    public string Postal { get; set; } = default!;
}
