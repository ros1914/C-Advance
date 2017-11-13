namespace _01.Take_Two
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
			//var number = Console.ReadLine().Split(' ').Select//(int.Parse).Where(n=> n>=10 && n<=20).Distinct().Take(2);
			//
			//
			//foreach (var item in number)
			//{
			//	Console.Write(item+ " ");
			//}

			var elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			Dictionary<string, List<long>> towns = new Dictionary<string, List<long>>();

			foreach (var ele in elements)
			{
				var info = ele.Split(':');
				var town = info[0];
				var population = long.Parse(info[1]);
				if (!towns.ContainsKey(town))
				{
					towns.Add(town, new List<long>());
				}

				towns[town].Add(population);
			}

			long num = long.Parse(Console.ReadLine());

			towns = towns.Where(t => t.Value.Sum() > num).OrderByDescending(x => x.Value.Sum()).ToDictionary(x => x.Key, x => x.Value);

			foreach (var tow in towns)
			{
				var result = tow.Value.OrderByDescending(x => x).Take(5);

				Console.WriteLine(string.Format("{0}: {1}", tow.Key, string.Join(" ", result)));
			}

		}

	
	}
}
