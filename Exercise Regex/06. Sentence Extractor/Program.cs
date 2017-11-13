namespace _06.Sentence_Extractor
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			string input = Console.ReadLine();
			string text = Console.ReadLine();
		
			Regex regex = new Regex(@"(\w[^.!?]*)?\b" + input + @"\b[^.?]*[.!?]");
			MatchCollection matches = regex.Matches(text);

			foreach (var item in matches)
			{
				Console.WriteLine(item);
			}
		}
	}
}
