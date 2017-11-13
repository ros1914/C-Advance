namespace _07.Valid_Time
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
			

			while (input!="END")
			{
				Regex regex = new Regex("^([01][0-9]):([0-5][0-9]):([0-5][0-9]) ([AP])M$");

				Match match = regex.Match(input);
				if (match.Success)
				{
					Console.WriteLine("valid");
				}
				else
				{
					Console.WriteLine("invalid");
				}
				input = Console.ReadLine();
			}
		}
	}
}
