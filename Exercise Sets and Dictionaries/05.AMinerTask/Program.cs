namespace _05.AMinerTask
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
			Dictionary<string, int> miner = new Dictionary<string, int>();
			string input = string.Empty;
			while ((input = Console.ReadLine())!="stop")
			{
				var data = int.Parse(Console.ReadLine());
				if (miner.ContainsKey(input))
				{
					miner[input] += data;
				}
				else
				{
					miner.Add(input, data);
				}
				

			}

			foreach (var item in miner)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
