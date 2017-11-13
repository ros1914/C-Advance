namespace _06.Valid_Usernames
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

			Regex regex = new Regex(@"^[\w-]{3,16}$");

			while (input!="END")
			{

				Match matches = regex.Match(input);
				if (matches.Success)
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
