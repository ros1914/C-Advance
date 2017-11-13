namespace _09.Text_Filter
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

			string[] input = Console.ReadLine().Split(new[] { ' ',','},StringSplitOptions.RemoveEmptyEntries);
			string text = Console.ReadLine();
			

			for (int i = 0; i < input.Length; i++)
			{
				string index = input[i];

				StringBuilder newIndex = new StringBuilder();

				for (int j = 0; j < input[i].Length; j++)
				{
					newIndex.Insert(j, "*");
				}
				string rs = newIndex.ToString();

				text = text.Replace(index, rs);
			}
			Console.WriteLine(text);

			//string[] bannedWords = Console.ReadLine().Split(new char[] /{ ' /', ',' }, StringSplitOptions.RemoveEmptyEntries);
			//string text = Console.ReadLine();
			//
			//foreach (var bannedWord in bannedWords)
			//{
			//	if (text.Contains(bannedWord))
			//	{
			//		text = text.Replace(bannedWord, new string('*', //bannedWord.Length));
			//	}
			//}
			//Console.WriteLine(text);
		}
	}
}
