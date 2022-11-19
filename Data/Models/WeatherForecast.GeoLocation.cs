namespace Data.Models;

public partial class WeatherForecast
{
    public class GeoLocation
    {
        public string IP { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Region { get; set; } = default!;
        public string Postal { get; set; } = default!;
    }
}
