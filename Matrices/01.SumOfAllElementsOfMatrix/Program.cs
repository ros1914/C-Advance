namespace _01.SumOfAllElementsOfMatrix
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
			var input = Console.ReadLine().Split(new[] { ' ', ','},StringSplitOptions.RemoveEmptyEntries);

			int rowsInput = int.Parse(input[0]);
			int cowsInput = int.Parse(input[1]);

			int[][] matrix = new int[rowsInput][];

			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = Console.ReadLine().Split(new[] { ' ', ','},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			}
			int maxSum = 0;
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow= 0; cow < matrix[row].Length; cow++)
				{
					maxSum += matrix[row][cow];

				}
			}

			Console.WriteLine(matrix.Length);
			Console.WriteLine(matrix[0].Length);
			Console.WriteLine(maxSum);
		}
	}
}
