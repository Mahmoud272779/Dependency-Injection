using Microsoft.AspNetCore.Mvc;

namespace DITest.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;
		private readonly singlet sin1;
		private readonly singlet sin2;
		private readonly scopped sc1;
		private readonly scopped sc2;
		private readonly trans t1;
		private readonly trans t2;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, singlet sin1, scopped sc1, scopped sc2
			, trans t1, trans t2, singlet sin2)
		{
			_logger = logger;
			this.sin1 = sin1;
			this.sc1 = sc1;
			this.sc2 = sc2;
			this.t1 = t1;
			this.t2 = t2;
			this.sin2 = sin2;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		[HttpGet("DI_Test")]
		public IActionResult get ()
		{
			var ss = new
			{
				sin2 = sin2.r,
				sin = sin1.r,
				sc1 = sc1.r,
				sc2 = sc2.r,
				t1 = t1.r,
				t2 = t2.r

			};

			return Ok(ss);
		}


	}


}
