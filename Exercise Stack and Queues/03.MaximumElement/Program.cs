namespace _03.MaximumElement
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
			Stack<int> stack = new Stack<int>();

			var n = int.Parse(Console.ReadLine());
			var max = int.MinValue;
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				if (input.Length > 1)
				{
					int number = input[1];
					stack.Push(number);
					if (number > max)
					{
						max = number;
					}
				}
				else
				{
					if (input[0] == 2)
					{
					    var element = stack.Pop();

						if (element == max && stack.Count> 0)
						{
							max = stack.Max();
						}
						else if (element == max && stack.Count == 0)
						{
							max = int.MaxValue;
						}
					}
					else
					{
						Console.WriteLine(max);
					}
				}
			    
			}
		}
	}
}
