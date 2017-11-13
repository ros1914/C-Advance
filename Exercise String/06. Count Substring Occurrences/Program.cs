namespace _06.Count_Substring_Occurrences
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
			string text = Console.ReadLine().ToLower();

			string word = Console.ReadLine().ToLower();
			int lenWord = word.Length;
			int count = 0;

			for (int i = 0; i < text.Length - lenWord; i++)
			{

				string checkWord = text.Substring(i, lenWord);
				if (checkWord.Contains(word))
				{
					count++;
				}

			}

			Console.WriteLine(count);

			
		}
	}
}
