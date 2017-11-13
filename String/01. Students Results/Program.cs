namespace _01.Students_Results
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
			int n = int.Parse(Console.ReadLine());
			List<string> student = new List<string>();
			Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
				string name = input[0];
				double[] data = input[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
				double cadv = data[0];
				double coop = data[1];
				double advOOP = data[2];
				
				double average = data.Average();
				
				Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",input[0],cadv,coop,advOOP,average));
			}
		}
	}
}
