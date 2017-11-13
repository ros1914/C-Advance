namespace _02.Upper_Strings
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
			var input = Console.ReadLine();

			input.Split(' ').Select(n => n.ToUpper()).ToList().ForEach(w => Console.Write(w + " "));
		}
	}
}
