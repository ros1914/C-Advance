namespace _07.LegoBlocks
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

			int n = int.Parse(Console.ReadLine());

			int[][] firstMatrix = new int[n][];
			int[][] secoundMatrix = new int[n][];
			int count = 0;
			for (int row = 0; row < 2 * n; row++)
			{
				if (row < n)
				{
					firstMatrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
					count += firstMatrix[row].Count();
				}
				else
				{
					secoundMatrix[row - n] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
					count += secoundMatrix[row - n].Count();
					Array.Reverse(secoundMatrix[row - n]);
				}
			}
			int[][] resultMatrix = new int[n][];
			int len = firstMatrix[0].Length + secoundMatrix[0].Length;
			bool equalLen = true;
			for (int i = 0; i < n; i++)
			{
				resultMatrix[i] = new int[firstMatrix[i].Length + secoundMatrix[i].Length];
				if (len != resultMatrix[i].Length)
				{
					equalLen = false;
				}
				for (int f = 0; f < firstMatrix[i].Length; f++)
				{
					resultMatrix[i][f] = firstMatrix[i][f];
				}
				int j = 0;
				for (int r = firstMatrix[i].Length; r < firstMatrix[i].Length + secoundMatrix[i].Length; r++)
				{
					resultMatrix[i][r] = secoundMatrix[i][j];
					j++;
				}
			}
			if (equalLen)
			{
				for (int row = 0; row < resultMatrix.Length; row++)
				{
					Console.Write("[");
					for (int cow = 0; cow < resultMatrix[row].Length; cow++)
					{
						Console.Write(resultMatrix[row][cow]);
						if (cow == resultMatrix[row].Length - 1)
						{
							Console.Write("]");
						}
						else
						{
							Console.Write(", ");
						}
					}
					Console.WriteLine();
				}
			}
			else
				{
				Console.WriteLine($"The total number of cells is: {count}");
			}
		}
	}
}
