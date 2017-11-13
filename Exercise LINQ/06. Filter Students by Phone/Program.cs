namespace _06.Filter_Students_by_Phone
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
			while ((input= Console.ReadLine())!="END")
			{
				student.Add(input.Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray());
			}

			var result = student.Where(s => s[2].StartsWith("02") || s[2].StartsWith("+3592"));
			foreach (var item in result)
			{
				Console.WriteLine(item[0] + " " + item[1]);
			}
		}
	}
}
