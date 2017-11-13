namespace _08.WeakStudents
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

			var result = student.Where(s => s.Skip(2).Count(o=> int.Parse(o)<=3)>=2).ToList();

			foreach (var item in result)
			{
				Console.WriteLine(item[0] + " " + item[1]);
			}
		}
	}
}
