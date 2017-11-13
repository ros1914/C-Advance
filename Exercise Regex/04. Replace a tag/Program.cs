namespace _04.Replace_a_tag
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
			while ((input = Console.ReadLine())!="end")
			{
				Regex regex = new Regex(@"<a.*?href.*?=(.*)>(.*?)<\/a>");
				string replacement = "[URL href=$1]$2[/URL]";
				string result = regex.Replace(input,replacement);

				Console.WriteLine(result);
			}
		}
	}
}
