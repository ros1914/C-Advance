namespace _02.Parse_URLs
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
			string[] input = Console.ReadLine().Split(new[] { "://"},StringSplitOptions.RemoveEmptyEntries);

			if (input.Length==2)
			{
				string protocol = input[0];
				int serverEndIndex = input[1].IndexOf('/');
				string server = input[1].Substring(0, serverEndIndex);
				string resources = input[1].Substring(serverEndIndex + 1);

				Console.WriteLine($"Protocol = {protocol}");
				Console.WriteLine($"Server = {server}");
				Console.WriteLine($"Resources = {resources}");
			}
			else
			{
				Console.WriteLine("Invalid URL");
			}

		}
	}
}
