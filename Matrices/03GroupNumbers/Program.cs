namespace _03GroupNumbers
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
			var input = Console.ReadLine().Split(new[] { ' ',','},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

			int[][] matrix = new int[3][];

			for (int row = 0; row < matrix.Length; row++)
			{
				List<int> res = new List<int>();

				for (int cow = 0; cow < input.Count; cow++)
				{
					if (Math.Abs(input[cow])%3==row)
					{
						res.Add(input[cow]);
						input.Remove(input[cow]);
						cow--;
					}
				}
				matrix[row] = res.ToArray();
			}

			foreach (var item in matrix)
			{
				Console.WriteLine(string.Join(" ",item));
			}
		}
	}
}
