namespace _05.Extract_Tags
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
			Regex regex = new Regex(@"<.+?>");
			MatchCollection matches;

			while (input!="END")
			{
				matches = regex.Matches(input);
				foreach (var item in matches)
				{
					Console.WriteLine(item);
				}
				input = Console.ReadLine();
			}
		}
	}
}
