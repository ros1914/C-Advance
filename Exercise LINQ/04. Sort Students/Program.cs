namespace _04.Sort_Students
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

			var result = student.OrderBy(s => s[1]).ThenByDescending(s => s[0]);
			foreach (var item in result)
			{
				Console.WriteLine(item[0] + " "+ item[1]);
			}
		}
	}
}
