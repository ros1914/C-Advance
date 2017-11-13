namespace _01.Students_by_Group
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
			List<string[]> students = new List<string[]>();

			while ((input=Console.ReadLine())!="END")
			{
				students.Add(input.Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray());
			}

			var result = students.Where(s => s[2] == "2").OrderBy(s => s[0]).ToArray();

			foreach (var item in result)
			{
				Console.WriteLine(item[0] + " " + item[1]);
			}
		}
	}
}
