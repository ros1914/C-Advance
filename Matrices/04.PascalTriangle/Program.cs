namespace _04.PascalTriangle
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
			int input = int.Parse(Console.ReadLine());

			ulong[][] matrix = new ulong[input][];
				
			for (int row = 0; row <matrix.Length; row++)
			{
				matrix[row] = new ulong[row+1];
				for (int cow = 0; cow < matrix[row].Length; cow++)
				{
					if (cow > 0)
					{
						if (cow == 0 || cow == matrix[row].Length-1)
						{
							matrix[row][cow] = 1;
						}
						else
						{
							matrix[row][cow] = matrix[row - 1][cow-1] + matrix[row - 1][cow];
						}
					}
					else
					{
						matrix[row][cow] = 1;

					}
				}
			}

			foreach (var item in matrix)
			{
				Console.WriteLine(string.Join(" ",item));
			}
		}
	}
}
