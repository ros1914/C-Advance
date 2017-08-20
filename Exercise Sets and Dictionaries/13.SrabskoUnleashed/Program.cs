namespace _13.SrabskoUnleashed
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
			Dictionary<string, Dictionary<string, int>> srubsko = new Dictionary<string, Dictionary<string, int>>();
			string input = Console.ReadLine(); ;
			while (input != "End")
			{
				var data = input.Split(new[] { '@' },StringSplitOptions.RemoveEmptyEntries);
				if (!(data.Length > 1))
				{
					input = Console.ReadLine();
					continue;
				}

				var singer = data[0].Trim();
				var token = data[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				int price = 1;
				try
				{
					 price = int.Parse(token[token.Length - 2]) * int.Parse(token[token.Length - 1]);

				}
				catch (Exception e)
				{

					input = Console.ReadLine();
					continue;
				}
			


				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < token.Length - 2; i++)
				{
					sb.Append(token[i]);
					sb.Append(" ");
				}
				var venues = sb.ToString().Trim();
				if (srubsko.ContainsKey(venues))
				{
					if (srubsko[venues].ContainsKey(singer))
					{
						srubsko[venues][singer] += price;
					}
					else
					{
						srubsko[venues].Add(singer, price);
					}
				}
				else
				{
					srubsko.Add(venues, new Dictionary<string, int> { { singer, price } });
				}

				input = Console.ReadLine();
			}

			foreach (var srubete in srubsko)
			{
				Console.WriteLine($"{srubete.Key}");
				foreach (var item in srubete.Value.OrderByDescending(s => s.Value))
				{
					Console.WriteLine($"#  {item.Key} -> {item.Value}");
				}
			}
		}
	}
}
