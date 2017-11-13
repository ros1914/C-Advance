namespace _03.Series_Of_Letters
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

			Regex regex = new Regex(@"(.)\1+");

			Console.WriteLine(regex.Replace(input,"$1"));
			
		}
	}
}

