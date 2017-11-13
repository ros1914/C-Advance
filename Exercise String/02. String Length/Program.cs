namespace _02.String_Length
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;


	public class Program
	{
		static void Main()
		{
			string input = Console.ReadLine();
			string result = input.PadRight(20, '*');
			Console.WriteLine(result);
		}
	}
}
