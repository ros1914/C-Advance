namespace _04.Average_of_Doubles
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
			Console.WriteLine($"{Console.ReadLine().Split(' ').Select(double.Parse).Average():f2}");
		}
	}
}
