namespace _09.Students_Enrolled_in_2014_or_2015
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
			string input;
			List<string[]> student = new List<string[]>();
			while ((input = Console.ReadLine()) != "END")
			{
				student.Add(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());
			}

			var result = student.Where(s=>s[0].EndsWith("14") ||s[0].EndsWith("15"));

			foreach (var item in result)
			{
				
				Console.WriteLine(string.Join(" ", item.Skip(1)));

			}
		}
	}
}
