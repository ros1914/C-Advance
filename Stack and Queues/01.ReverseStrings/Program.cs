namespace _01.ReverseStrings
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
			var input = Console.ReadLine();

			Stack<char> stack = new Stack<char>();
			foreach (var item in input)
			{
				stack.Push(item);
			}
			//stack.Reverse();
			while (stack.Count !=0)
			{
				Console.Write(stack.Pop());
			}
			Console.WriteLine();
			
		}
	}
}
