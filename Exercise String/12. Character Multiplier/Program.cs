namespace _12.Character_Multiplier
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
			string[] input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);

			char[] dataOne = input[0].ToCharArray();
			char[] dataTwo = input[1].ToCharArray();
			int len = 0;
			int sum = 0;
			int lenOne = 0;
			int lenTwo = 0;
			if (dataOne.Length>dataTwo.Length)
			{
				len = dataTwo.Length;
				lenOne = dataOne.Length - dataTwo.Length;

			}
			else
			{
				len = dataOne.Length;
				lenTwo = dataTwo.Length - dataOne.Length;
			}

			for (int i = len-1; i >=0; i--)
			{
				int result = dataOne[i] * dataTwo[i];
				sum += result;
			}

			if (lenOne!=0)
			{
				for (int i = dataOne.Length-1; i >= dataOne.Length - lenOne; i--)
				{
					sum += dataOne[i];
				}
				Console.WriteLine(sum);
			}
			else if (lenTwo!=0)
			{
				for (int i = dataTwo.Length-1; i >= dataTwo.Length-lenTwo; i--)
				{
					sum += dataTwo[i];
				}
				Console.WriteLine(sum);
			}
			else
			{
				Console.WriteLine(sum);
			}
		}
	}
}
