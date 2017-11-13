namespace _05.RubiksMatrix
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
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

			int[][] matrix = new int[n][];
			int num = 1;
			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = new int[m];
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{
					matrix[row][cow] = num;
					num++;
				}
			}

			int countMuves = int.Parse(Console.ReadLine());

			for (int i = 0; i < countMuves; i++)
			{
				string[] comand = Console.ReadLine().Split(' ');
				MoveMatrix(matrix, comand);
			}

			int element = 1;
			
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{
					if (matrix[row][cow]==element)
					{
						Console.WriteLine("No swap required");
					}
					else
					{
						for (int r = 0; r < matrix.Length; r++)
						{
							for (int c = 0; c < matrix[r].Length; c++)
							{
								if (matrix[r][c]==element)
								{
									var currentElement = matrix[row][cow];
									matrix[row][cow] = element;
									matrix[r][c] = currentElement;
									Console.WriteLine($"Swap ({row}, {cow}) with ({r}, {c})");
									break;
								}
							}
						}
					}
					element++;
				}
			}
			
		}

		private static void MoveMatrix(int[][] matrix, string[] comand)
		{
			var positon = int.Parse(comand[0]);
				var moves = comand[1];
			var countMoves = int.Parse(comand[2]);
			if (moves =="up")
			{
				
				for (int i = 0; i < countMoves ; i++)
				{
					int firstNum = matrix[0][positon];
					for (int row = 0; row < matrix.Length-1; row++)
					{
						matrix[row][positon] = matrix[row+1][positon];
					}
					matrix[matrix.Length - 1][positon] = firstNum;
				}
				

			}
			else if (moves =="down")
			{
				for (int i = 0; i < countMoves; i++)
				{
					int LastNum = matrix[matrix.Length - 1][positon];
					for (int row = 0; row < matrix.Length-1; row++)
					{
						 matrix[matrix.Length - 1-row][positon]=matrix[matrix.Length-2-row][positon];
					}
					matrix[0][positon] = LastNum;

				}
			}
			else if (moves == "left")
			{
				for (int i = 0; i < countMoves; i++)
				{
					int firstNum = matrix[positon][0];
					for (int cow = 0; cow < matrix[positon].Length - 1; cow++)
					{
						matrix[positon][cow] = matrix[positon][cow+1];
					}
					matrix[positon][matrix[positon].Length - 1] = firstNum;
				}
			}
			else if (moves == "right")
			{
				for (int i = 0; i < countMoves; i++)
				{
					int lastNum = matrix[positon][matrix[positon].Length - 1];
					for (int cow = 0; cow < matrix[positon].Length-1; cow++)
					{
						matrix[positon][matrix[positon].Length - 1 - cow] =
						matrix[positon][matrix[positon].Length - 2 - cow];
					}
					matrix[positon][0] = lastNum;
				}
			}
		}
	}
}
