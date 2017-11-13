namespace _05.Extract_Email
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			string input = Console.ReadLine();

			Regex regex = new Regex(@"((?<=\s)[A-Za-z0-9]+([-.]\w*)*@[a-zA-z]+?([.-][a-zA-z]*)*(\.[a-z]{2,}))");
			MatchCollection matches = regex.Matches(input);

			foreach (var item in matches)
			{
				Console.WriteLine(item);

			}
		}
	}
}
