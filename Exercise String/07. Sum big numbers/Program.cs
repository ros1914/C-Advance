namespace _07.Sum_big_numbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{

			var inputOne = Console.ReadLine().TrimStart(new char[] { '0' });
			var inputTwo = Console.ReadLine().TrimStart(new char[] { '0' });
			
			int lenOne = inputOne.Length;
			int lenTwo = inputTwo.Length;
			
			if (lenOne > lenTwo)
			{
				inputTwo = inputTwo.PadLeft(lenOne, '0');
			}
			else
			{
				inputOne = inputOne.PadLeft(lenTwo, '0');
			}
			
			StringBuilder totalScore = new StringBuilder();

			int total = 0;
			int totalResult = 0;

			for (int i = inputTwo.Length - 1; i >= 0; i--)
			{
				int result = (int.Parse(inputOne[i].ToString()) + int.Parse(inputTwo[i].ToString()) + totalResult);

				total = result % 10;
				totalResult = result / 10;
				totalScore.Insert(0, total);
			}

			if (totalResult != 0)
			{
				
				totalScore.Insert(0, totalResult);
				Console.WriteLine(totalScore.ToString());

			}
			else
			{
				Console.WriteLine(totalScore.ToString());
			}

		}
	}
}
