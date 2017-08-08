
namespace _02.SimpleCalculator
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
			var input = Console.ReadLine().Split(' ');

			Stack<string> stack = new Stack<string>(input.Reverse());
			//for (int i = 0; i < input.Length; i++)
			//{
			//	stack.Push(input[i]);
			//}

			while (stack.Count > 1)
			{
				var firstNum = int.Parse(stack.Pop());
				string op = stack.Pop();
				var second = int.Parse(stack.Pop());
				if (op=="+")
				{
					stack.Push((firstNum+second).ToString());
				}
				else
				{
					stack.Push((firstNum - second).ToString());
				}
			}
			Console.WriteLine(stack.Pop());
		}
	}
}
