namespace _08.Extract_Quotations
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

			Regex regex = new Regex("('|\")(.+?)\\1");
			MatchCollection matches = regex.Matches(input);

			foreach (Match item in matches)
			{
				Console.WriteLine(item.Groups[2].Value);
			}
			
		}
	}
}
