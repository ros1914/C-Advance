namespace _08.RecursiveFibonacci
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
			var n = int.Parse(Console.ReadLine());
			var getFibonachi = 1;
			//int[] list = new int[n];
			//list[0] = getFibonachi;
			//list[1]=getFibonachi;
			Queue<long> queue = new Queue<long>();
			queue.Enqueue(getFibonachi);
			queue.Enqueue(getFibonachi);
			for (int i = 2; i < n; i++)
			{
				//list[i] = list[i-1]+list[i-2];
				queue.Enqueue(queue.ElementAt(i - 1) + queue.ElementAt(i - 2));
				//queue.Enqueue(list[i]);
			}

			Console.WriteLine(queue.Last());
		}
	}
}
