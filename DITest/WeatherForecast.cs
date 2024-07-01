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
		public static int myint  = 0;
	}

	public class scopped
	{
		public int r { get; set; } = new Random().Next(0, 10000);
		public static int myint  = 0;
	}

	public class trans
	{
		public int r { get; set; } = new Random().Next(0, 10000);
	}

	public static class DI 
	{
		public static void addDI(IServiceCollection s)
		{
			s.AddScoped<scopped>();
			s.AddSingleton<singlet>();
			s.AddTransient<trans>();
		}

		public delegate int funcDelegte(int n,int m);

	public static	int  sum(int n,int m,funcDelegte f) 
		{
			int res = f(n, m);
			Console.WriteLine(res);
			return res;
		}

		
	}
}
