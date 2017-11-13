namespace _08.RadioactiveMutantVampireBunnies
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
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int n = input[0];
			char[][] matrix = new char[n][];

			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = Console.ReadLine().ToCharArray();
			}

			char[] comand = Console.ReadLine().ToCharArray();
			bool win = false;
			bool dead = false;
			int[] cordinates = new int[2];

			for (int i = 0; i < comand.Length; i++)
			{
				switch (comand[i])
				{
					case 'U':
						cordinates = GetCordinates(matrix);
						win = MoveUPPlayer(matrix, win);
						
						break;
					case 'L':
						cordinates = GetCordinates(matrix);
						win = MouveLeftPlayer(matrix, win); break;
					case 'D':
						cordinates = GetCordinates(matrix);
						win = MoveDownPlayer(matrix, win);break;
					case 'R':
						cordinates = GetCordinates(matrix);
						win = MouveRightPlayer(matrix, win); break;
					default:
						break;
				}
				if (win)
				{
					break;
				}
				dead = BunyKillPlayer(matrix, dead);

			}
			if (win)
			{
				Print(matrix);
				Console.WriteLine($"won: {cordinates[0]} {cordinates[1]}");
			}
			else if (dead)
			{
				Print(matrix);
				Console.WriteLine($"dead: {cordinates[0]} {cordinates[1]}");
			}
			Console.WriteLine(win);
		}

		private static bool MouveRightPlayer(char[][] matrix, bool win)
		{
			bool result = false;
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{

					if (matrix[row][cow] == 'P')
					{
						if (cow + 1 == matrix[row].Length)
						{
							win = true;
							matrix[row][cow] = '.';
							break;
						}
						else
						{
							if (matrix[row][cow+1]=='.')
							{

							}
							matrix[row][cow + 1] = 'P';
							matrix[row][cow] = '.';
							row = matrix.Length - 1;
							cow = matrix[0].Length;
						}
					}
				}
			}
			return win;
		}

		private static bool MoveDownPlayer(char[][] matrix, bool win)
		{
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{
					if (matrix[row][cow] == 'P')
					{
						if (row + 1 == matrix.Length)
						{
							win = true;
							matrix[row][cow] = '.';
						}
						else
						{
							matrix[row + 1][cow] = 'P';
							matrix[row][cow] = '.';
							row = matrix.Length - 1;
							cow = matrix[0].Length;
						}

					}
				}
			}
			return win;
		}

		private static void Print(char[][] matrix)
		{
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{
					Console.Write(matrix[row][cow] + " ");
				}
				Console.WriteLine();
			}
		}

		private static bool BunyKillPlayer(char[][] matrix, bool dead)
		{
			for (int row = 0; row < matrix.Length; row++)
			{
				int lenColone = matrix[row].Length;
				int len = matrix.Length;
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{

					if (matrix[row][cow] == 'B')
					{
						//Change right position.
						if (cow + 1 < lenColone && matrix[row][cow + 1] == '.')
						{
							matrix[row][cow + 1] = 'R';
						}
						// Change left position.
						if (cow - 1 >= 0 && matrix[row][cow - 1] == '.')
						{
							matrix[row][cow - 1] = 'R';
						}
						//Change up position
						if (row - 1 >= 0 && matrix[row - 1][cow] == '.')
						{
							matrix[row - 1][cow] = 'R';
						}
						//Change down position.
						if (row + 1 < len && matrix[row + 1][cow] == '.')
						{
							matrix[row + 1][cow] = 'R';
						}
						if (cow + 1 < lenColone && cow - 1 >= 0 && row - 1 >= 0 && row + 1 < len && (matrix[row + 1][cow] == 'P' || matrix[row - 1][cow] == 'P'|| matrix[row][cow+1] == 'P'|| matrix[row][cow -1] == 'P'))
						{
							dead = true;
							break;
						}
					}
				}
			}
			return dead;
		}

		private static int[] GetCordinates(char[][] matrix)
		{
			int[] result = new int[2];
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{
					if (matrix[row][cow] == 'P')
					{
						result[0] = row;
						result[1] = cow;
					}
				}
			}
			return result;
		}

		private static bool MouveLeftPlayer(char[][] matrix, bool win)
		{

			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{

					if (matrix[row][cow] == 'P')
					{
						if (cow - 1 < 0)
						{
							win = true;
							matrix[row][cow] = '.';
							break;

						}
						else
						{
							matrix[row][cow - 1] = 'P';
							matrix[row][cow] = '.';
							row = matrix.Length - 1;
							cow = matrix[0].Length;
						}



					}
				}
			}
			return win;

		}

		private static bool MoveUPPlayer(char[][] matrix, bool win)
		{
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{
					if (matrix[row][cow] == 'P')
					{
						if (row - 1 < 0)
						{
							win = true;
							matrix[row][cow] = '.';
						}
						else
						{
							matrix[row - 1][cow] = 'P';
							matrix[row][cow] = '.';
							row = matrix.Length - 1;
							cow = matrix[0].Length;
						}

					}
				}
			}
			return win;

		}
	}
}
