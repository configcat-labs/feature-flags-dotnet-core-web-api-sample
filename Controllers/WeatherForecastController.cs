using Microsoft.AspNetCore.Mvc;
using ConfigCat.Client; // Import the package

namespace feature_flags_dotnet_core_web_api_sample.Controllers;

[ApiController]
[Route("[controller]")]
// Add the ConfigCat client to the class constructor 
// so we can use it within the class to control the API response
public class WeatherForecastController(IConfigCatClient configCatClient) : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    // Create a private instance of the ConfigCat client
    private readonly IConfigCatClient _configCatClient = configCatClient;

  [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        // Fetch the flag's value
        var isMyFeatureFlagEnabled = await _configCatClient.GetValueAsync("myFeatureFlag", false);

        if (!isMyFeatureFlagEnabled)
        {
            return []; // Return a blank list when the flag is off
        }

        // Otherwise return the default list
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
