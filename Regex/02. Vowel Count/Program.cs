namespace _02.Vowel_Count
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

			Regex regex = new Regex(@"[aeiouyAEIOUY]");
			MatchCollection matches = regex.Matches(input);

			Console.WriteLine($"Vowels: {matches.Count}");

		}
	}
}
