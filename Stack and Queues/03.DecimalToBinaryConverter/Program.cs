namespace _03.DecimalToBinaryConverter
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	class Program
	{
		static void Main()
		{
			int input = int.Parse(Console.ReadLine());

			Stack<string> stack = new Stack<string>();
			stack.Push(Convert.ToString(input,2));
			Console.WriteLine(stack.Pop());
		}
	}
}
