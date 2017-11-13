using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.Convert_from_base_N_to_base_10
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			long n = long.Parse(input[0]);

			BigInteger numberBaseN = BigInteger.Parse(input[1]);

			string strBaseNnumber = numberBaseN.ToString();

			BigInteger result = 0;

			for (int i = strBaseNnumber.Length - 1, j = 0; i >= 0; i--, j++)
			{

				int num = int.Parse(strBaseNnumber[i].ToString());
				BigInteger pow = 1;

				for (int k = 1; k <= j; k++)
				{
					pow *= n;
				}

				result += num * pow;

			}



			Console.WriteLine(result);
		}
	}
}
