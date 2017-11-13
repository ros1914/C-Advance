namespace _10.Unicode_Characters
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
			string input = Console.ReadLine();
			StringBuilder result = new StringBuilder();
			foreach (var item in input)
			{
				result.Append("\\u");
				result.Append(String.Format("{0:x4}",(int)item));
			}
			Console.WriteLine(result.ToString());
		}

		
	}
}
