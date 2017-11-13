namespace _01.Match_Count
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
			string pattern = Console.ReadLine();
			string input = Console.ReadLine();

			Regex regex = new Regex(pattern);
			MatchCollection match = regex.Matches(input);

			Console.WriteLine($"{match.Count}");
		}
	}
}
