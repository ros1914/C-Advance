namespace _08.Map_Districts
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			var population = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
			long miniPopulation = long.Parse(Console.ReadLine());

			Dictionary<string, List<long>> cityPopulation = new Dictionary<string, List<long>>();

			//var rt = population[0];

			for (int i = 0; i <population.Count(); i++)
			{
				var data = population[i].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
				string city = data[0];
				long districtPopulation = long.Parse(data[1]);
				if (cityPopulation.ContainsKey(city))
				{
					cityPopulation[city].Add(districtPopulation);
				}
				else
				{
					cityPopulation.Add(city, new List<long>() { districtPopulation});
				}
			}

			cityPopulation = cityPopulation.Where(c => c.Value.Sum() > miniPopulation).OrderByDescending(r => r.Value.Sum()).ToDictionary(x => x.Key, x => x.Value);
			foreach (var item in cityPopulation)
			{
				var result = item.Value.OrderByDescending(r => r).Take(5);
				Console.WriteLine(string.Format("{0}: {1}" , item.Key , string.Join(" ",result)));
			}
		}
	}
}
