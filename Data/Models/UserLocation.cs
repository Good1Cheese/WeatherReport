using System.Text.Json.Serialization;

namespace Data.Models;

public class UserLocation
{
    [JsonPropertyName("ip")]
    public string IP { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("postal")]
    public string Postal { get; set; }
}
