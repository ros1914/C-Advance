namespace _05.Concatenate_Strings
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

			//string text="";
			StringBuilder text = new StringBuilder();
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				//text = string.Concat(text ,input," ");
				text.Append(input).Append(" ");
			}

			Console.WriteLine(text);
		}
	}
}
