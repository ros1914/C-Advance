namespace _04.MaximalSum
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
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = input[0];
			int m = input[1];

			int[,] matrix = new int[n,m];

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				var data = Console.ReadLine().Split(' ');
				
				for (int cow = 0; cow < matrix.GetLength(1); cow++)
				{
					matrix[row, cow] = int.Parse(data[cow]);		;
				}
			}

			int totalSum = 0;
			int rows = 0;
			int cows = 0;
			for (int row = 0; row < matrix.GetLength(0)-2; row++)
			{
				for (int cow = 0; cow < matrix.GetLength(1)-2; cow++)
				{
					int total = matrix[row, cow] + matrix[row, cow + 1] + matrix[row, cow + 2] + matrix[row + 1, cow] + matrix[row + 1, cow + 1] + matrix[row + 1, cow + 2] + matrix[row + 2, cow] + matrix[row + 2, cow + 1] + matrix[row + 2, cow + 2];
					if (total>totalSum)
					{
						totalSum = total;
						rows = row;
						cows = cow;
					}
				}
			}

			Console.WriteLine($"Sum = {totalSum}");
			for (int i = rows; i < 3+rows; i++)
			{
				for (int j = cows; j < 3+cows; j++)
				{
					Console.Write(string.Join(" ",matrix[i,j])+" ");
				}
				Console.WriteLine();
			}
		}
	}
}
