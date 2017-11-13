namespace _06.Find_and_Sum_Integers
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

			var input = Console.ReadLine().Split(' ');

			var result = input.Select(w => new { sucsses = long.TryParse(w, out var value), value }).Where(e => e.sucsses).Select(n => n.value).ToList();
			if (result.Count()!=0)
			{
				Console.WriteLine(result.Sum());

			}
			else
			{
				Console.WriteLine("No match");

			}
		}
	}
}
