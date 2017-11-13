namespace _03.Formatting_Numbers
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
			var number = Console.ReadLine().Split(new [] { ' ','\t', '\n', '\r' },StringSplitOptions.RemoveEmptyEntries).ToArray();
			int a = int.Parse(number[0]);
			string resultA = a.ToString("X");
			string binaryA = Convert.ToString(a,2);
			string resultBinaryA = binaryA.PadLeft(10,'0').Substring(0,10);
			decimal b = decimal.Parse(number[1]);
			decimal c = decimal.Parse(number[2]);

			Console.WriteLine(string.Format("|{0,-10}|{1,10}|{2,10:f2}|{3,-10:f3}|",resultA,resultBinaryA,b,c));
		}
	}
}
