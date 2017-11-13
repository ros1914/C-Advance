namespace _01.Match_Full_Name
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
			string input;
			
			while ((input = Console.ReadLine()) != "end")
			{
				Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
				MatchCollection matches = regex.Matches(input);
				foreach (var item in matches)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
