namespace _04.MatchingBrackets
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

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < input.Count(); i++)
			{
				char ch = input[i];
				if (ch == '(')
				{
					stack.Push(i);
					
				}
				else if (ch == ')')
				{
					var startIndex = stack.Pop();
					var contein = input.Substring(startIndex,i-startIndex+1);
					Console.WriteLine(contein);
				}

			}
				
			
		}
	}
}
