using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public WeatherForecastController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("key")]
    public string GetAPIKey()
    {
        return _configuration["API-Key:VisualCrossing"];
    }
}
