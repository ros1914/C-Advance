namespace _03.CountSameValuesInArray
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		public static void Main(string[] args)
		{
			SortedDictionary<double, double> countSum = new SortedDictionary<double, double>();

			var input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

			for (int i = 0; i < input.Length; i++)
			{
				if (countSum.ContainsKey(input[i]))
				{
					countSum[input[i]] += 1;
				}
				else
				{
					countSum.Add(input[i],1);

				}
			}

			foreach (var cs in countSum)
			{
				Console.WriteLine($"{cs.Key} - {cs.Value} times");
			}

		}
	}
}
