namespace _09.StackFibonacci
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	using System.Threading.Tasks;
	public class Program
	{
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Stack<long> stack = new Stack<long>();
			int getFibonachi = 0;
			stack.Push(getFibonachi);
			stack.Push(getFibonachi + 1);
			stack.Push(getFibonachi + 1);
			int r = 2;
			for (int i = 3; i <= n; i++)
			{
				stack.Push(stack.Peek()+stack.ElementAt(i-r));
				r++;
			}

			Console.WriteLine(stack.Pop());
		}
	}
}
