namespace _05.Min_Even_Number
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
			try
			{
				var input = Console.ReadLine().Split(' ').Select(double.Parse);
				var result = input.Where(w => w % 2 == 0).Min();
				
					Console.WriteLine($"{result:f2}");
				
			}
			catch (Exception )
			{

				Console.WriteLine("No match");

			}

		}
	}
}
