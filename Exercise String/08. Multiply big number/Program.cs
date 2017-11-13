
namespace _08.Multiply_big_number
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
			string inputOne = Console.ReadLine().TrimStart(new char[] { '0'});
			string inputTwo = Console.ReadLine();
			if (inputOne=="0"|| inputTwo=="0")
			{
				Console.WriteLine(0);
				
			}
			else
			{
				int result = 0;
				int index = 0;
				int total = 0;
				StringBuilder totalScore = new StringBuilder();
				for (int i = inputOne.Length - 1; i >= 0; i--)
				{
					result = (int.Parse(inputOne[i].ToString()) * int.Parse(inputTwo) )+ index;

					total = result % 10;
					totalScore.Insert(0, total);
					index = result / 10;
				}

				if (index != 0)
				{
					totalScore.Insert(0, index);

					Console.WriteLine(totalScore.ToString());

				}
				else
				{
					Console.WriteLine(totalScore.ToString());
				}
			}
			
		}
	}
}
