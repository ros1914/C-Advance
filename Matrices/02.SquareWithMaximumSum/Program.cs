namespace _02.SquareWithMaximumSum
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new[] { ',',' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			int rows = input[0];
			int cows = input[1];

			int maxSum = 0;
			int[,] matrix = new int[rows,cows];
			int[] resultMatrics = new int[4];

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				var data = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				for (int cow = 0; cow < matrix.GetLength(1); cow++)
				{
					matrix[row, cow] = data[cow];
																	 
				}
			}

			for (int row = 0; row < matrix.GetLength(0)-1; row++)
			{
				for (int cow = 0; cow < matrix.GetLength(1)-1; cow++)
				{
					var total = matrix[row, cow] + matrix[row, cow + 1] + matrix[row + 1, cow] + matrix[row + 1, cow + 1];
					if (maxSum<total)
					{
						maxSum = total;
						resultMatrics[0] = matrix[row, cow];
						resultMatrics[1] = matrix[row, cow + 1];
						resultMatrics[2]= matrix[row + 1, cow];
						resultMatrics[3]= matrix[row + 1, cow + 1];
					}
				}
			}
			for (int i = 0; i < resultMatrics.Length; i++)
			{
				Console.Write(resultMatrics[i]+" ");
				if (i==1)
				{
					Console.WriteLine();
				}

			}

			Console.WriteLine();
			Console.WriteLine(maxSum);
		}
	}
}
