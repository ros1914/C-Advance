namespace _04.Convert_from_base_10_to_base_N
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Numerics;

	public class Program
	{
		static void Main()
		{

			string[] input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);

			long baseTo = int.Parse(input[0]);

			//BigInteger numberBaseTen = BigInteger.Parse(input[1]);
			BigInteger numberToBaseTen = BigInteger.Parse(input[1]);
			StringBuilder result = new StringBuilder();
			while (numberToBaseTen>0)
			{
				BigInteger reminder = numberToBaseTen % baseTo;
				result.Insert(0,reminder.ToString());
				numberToBaseTen /= baseTo;
				
			}

			Console.WriteLine(result);
		}
	}
}
