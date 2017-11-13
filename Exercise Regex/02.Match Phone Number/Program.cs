using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			while ((input = Console.ReadLine())!="end")
			{
				Regex regex = new Regex(@"^\+359( |-)[2]\1([0-9]{3})\1([0-9]{4})$");
				MatchCollection matches = regex.Matches(input);
				foreach (var item in matches)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
