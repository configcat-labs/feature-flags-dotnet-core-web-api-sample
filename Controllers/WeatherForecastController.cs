using ConfigCat.Client; // Import types from the ConfigCat SDK's main namespace

using feature_flags_dotnet_core_web_api_sample.Models;

using Microsoft.AspNetCore.Mvc;

namespace feature_flags_dotnet_core_web_api_sample.Controllers;

[ApiController]
[Route("[controller]")]
// Inject the ConfigCat client via a constructor parameter
// so we can use it within the class to control the API response
public class WeatherForecastController(IConfigCatClient configCatClient) : ControllerBase
{
	private static readonly string[] Summaries =
	[
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	];

	[HttpGet(Name = "GetWeatherForecast")]
	public async Task<IEnumerable<WeatherForecast>> Get()
	{
		// A unique user id is required when creating a ConfigCat User Object
		var configCatUser = new User("user-id-123")
		{
			Email = "john@example.com",
			Country = "United Kingdom",
			Custom =
			{
				// The dictionary keys you use here should match the custom comparison attributes
				// you added to your flag's targeting rule on the ConfigCat Dashboard
				["accountType"] = "premium",
			}
		};

		// Get the flag's latest value
		var isMyFeatureFlagEnabled = await configCatClient.GetValueAsync("myFeatureFlag", false, configCatUser);

		// When the flag is off, return only a limited number of items
		var numDays = isMyFeatureFlagEnabled ? 5 : 2;

		return Enumerable.Range(1, numDays).Select(index => new WeatherForecast
		{
			Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
			TemperatureC = Random.Shared.Next(-20, 55),
			Summary = Summaries[Random.Shared.Next(Summaries.Length)]
		})
		.ToArray();
	}
}