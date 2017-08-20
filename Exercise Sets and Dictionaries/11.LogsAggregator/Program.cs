namespace _11.LogsAggregator
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
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);
				var user = input[1];
				var ip = input[0];
				var duration = int.Parse(input[2]);

				if (logs.ContainsKey(user))
				{
					if (logs[user].ContainsKey(ip))
					{
						logs[user][ip] += duration;
					}
					else
					{
						logs[user].Add(ip, duration);
					}
				}
				else
				{
					logs.Add(user,new Dictionary<string, int> { {ip,duration} });
				}
			}

			foreach (var log in logs.OrderBy(l=>l.Key))
			{
				var count = log.Value.Keys.Count();
				var scor = log.Value.Values.Sum();
				Console.Write($"{log.Key}: {scor} [");
				foreach (var item in log.Value.OrderBy(l=>l.Key))
				{
					if (count==1)
					{
						Console.Write($"{item.Key}");

					}
					else
					{
						Console.Write($"{item.Key}, ");

					}
					count--;
				}
				Console.WriteLine("]");
			}
		}
	}
}
