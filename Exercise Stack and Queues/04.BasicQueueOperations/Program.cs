namespace _04.BasicQueueOperations
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
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = input[0];
			int s = input[1];
			int x = input[2];

			int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Queue<int> queues = new Queue<int>();

			for (int i = 0; i < n; i++)
			{
				queues.Enqueue(number[i]);
			}

			for (int i = 0; i < s; i++)
			{
				queues.Dequeue();
			}

			if (queues.Contains(x))
			{
				Console.WriteLine("true");
			}
			else
			{
				if (queues.Count ==0)
				{
					Console.WriteLine("0");
				}
				else
				{
					Console.WriteLine(queues.Min());
				}
			}
		}
	}
}
