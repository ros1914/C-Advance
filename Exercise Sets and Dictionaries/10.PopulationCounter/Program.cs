namespace _10.PopulationCounter
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		public static void Main()
		{
			Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>();

			string input;
			while ((input=Console.ReadLine())!="report")
			{
				var data = input.Split('|');
				var country = data[1];
				var city = data[0];
				var population = long.Parse(data[2]);

				if (populationCounter.ContainsKey(country))
				{
					if (populationCounter[country].ContainsKey(city))
					{
						populationCounter[country][city] += population;
					}
					else
					{
						populationCounter[country].Add(city, population);

					}
				}
				else
				{
					populationCounter.Add(country, new Dictionary<string, long> { { city, population } });
				}
			}

			foreach (var item in populationCounter.OrderByDescending(p=>p.Value.Values.Sum()))
			{
				Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
				foreach (var res in item.Value.OrderByDescending(i=>i.Value))
				{
					Console.WriteLine($"=>{res.Key}: {res.Value}");
				}
			}
		}
	}
}
