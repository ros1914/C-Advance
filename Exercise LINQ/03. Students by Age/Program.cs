namespace _03.Students_by_Age
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
			while ((input = Console.ReadLine())!="END")
			{
				student.Add(input.Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray());
			}

			var result = student.Where(s => int.Parse(s[2]) >= 18 && int.Parse(s[2]) <= 24);
			foreach (var item in result)
			{
				Console.WriteLine(item[0] + " " + item[1] + " " +item[2]);
			}
		}
	}
}
