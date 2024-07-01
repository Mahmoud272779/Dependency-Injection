namespace DITest
{
	public class WeatherForecast
	{
		public DateOnly Date { get; set; }

		public int TemperatureC { get; set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? Summary { get; set; }
	}

	public class singlet 
	{
        public int r { get; set; }=new Random().Next(0,10000);
    }

	public class scopped
	{
		public int r { get; set; } = new Random().Next(0, 10000);
	}

	public class trans
	{
		public int r { get; set; } = new Random().Next(0, 10000);
	}
}
