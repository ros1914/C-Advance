namespace _01.MatrixOfPalindromes
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

			string[,] matrix = new string[n,m];
			char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int cow = 0; cow < matrix.GetLength(1); cow++)
				{
					matrix[row, cow] = alphabet[row].ToString()+alphabet[cow+row]+alphabet[row];
				}
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int r = 0; r < matrix.GetLength(1); r++)
				{
					Console.Write(matrix[i,r]+ " ");
				}
				Console.WriteLine();
			}
		}
	}
}
