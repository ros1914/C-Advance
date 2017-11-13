namespace _07.Bounded_Numbers
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
			var boundNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).Where(n => boundNumber.Min() <= n && n <= boundNumber.Max()).ToList();

			Console.WriteLine(string.Join(" ",numbers));

			


		}
	}
}
