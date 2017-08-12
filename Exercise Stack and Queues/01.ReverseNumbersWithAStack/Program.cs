namespace _01.ReverseNumbersWithAStack
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
			var inputNumber = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < inputNumber.Length; i++)
			{
				stack.Push(inputNumber[i]);
			}

			for (int i = 0; i < inputNumber.Length; i++)
			{
				Console.Write(stack.Pop()+ " ");
			}
		}
	}
}
