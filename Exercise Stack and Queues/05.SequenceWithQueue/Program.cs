namespace _05.SequenceWithQueue
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	class Program
	{
		public static void Main()
		{
			long n = long.Parse(Console.ReadLine());
			Queue<long> queue = new Queue<long>();
			long[] list = new long[49];

			long s1 = n;
			
			queue.Enqueue(s1);
			long s2 = 0;
			long s3 = 0;
			long s4 = 0;

			for (int i = 1; i <=50; i++)
			{
				queue.Enqueue(s2 = s1 + 1);
				queue.Enqueue(s3=2*s1+1);
				queue.Enqueue(s4 = s1 + 2);
				s1 = queue.ElementAt(i);
			}

			foreach (var queues in queue.Take(50))
			{
				Console.Write(queues + " ");
			}
		}
	}
}
