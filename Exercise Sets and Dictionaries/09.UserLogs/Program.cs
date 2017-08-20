namespace _09.UserLogs
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

			SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();


			string input;
			while ((input = Console.ReadLine())!="end")

			{
				 var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				var ip = data[0].Replace("IP=", "");
				var user = data[2].Replace("user=", "");
				if (userLogs.ContainsKey(user))
				{
					if (userLogs[user].ContainsKey(ip))
					{
						userLogs[user][ip] += 1;
					}
					else
					{
						userLogs[user].Add(ip, 1);
					}
				}
				else
				{
					userLogs.Add(user, new Dictionary<string, int> { {ip, 1 }});
				}
			}

			foreach (var item in userLogs)
			{
					var count = item.Value.Count();

				Console.WriteLine($"{item.Key}: ");
				foreach (var res in item.Value)
				{
					if (count==1)
					{
						Console.WriteLine($"{res.Key} => {res.Value}.");

					}
					else
					{
						Console.Write($"{res.Key} => {res.Value}, ");
						count--;
					}
					
				}
			}
		}
	}
}
