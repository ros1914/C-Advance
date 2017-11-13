namespace _02.Students_by_First_and_Last_Name
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

			while ( (input = Console.ReadLine())!="END")
			{
				students.Add(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());

			}

			var result = students.Where(s=> s[0].CompareTo(s[1])<0);

			foreach (var item in result)
			{
				Console.WriteLine(item[0] + " " + item[1]);
			}
		}
	}
}
