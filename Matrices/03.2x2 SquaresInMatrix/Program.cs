namespace _03._2x2_SquaresInMatrix
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

			int rows = input[0];
			
			string[][] matrix = new string[rows][];

			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			int countSquares = 0;

			for (int row = 0; row < matrix.Length-1; row++)
			{
				for (int cow = 0; cow < matrix[row].Length-1; cow++)
				{
					if (matrix[row][cow]==matrix[row][cow+1]&& matrix[row][cow]==matrix[row+1][cow]&&matrix[row][cow]==matrix[row+1][cow+1])
					{
						countSquares++;
					}
				}
			}

			Console.WriteLine(countSquares);
		}
	}
}
