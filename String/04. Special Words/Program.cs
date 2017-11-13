namespace _04.Special_Words
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
			string[] input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);

			string[] text = Console.ReadLine().Split(new[] { ' ',},StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < input.Length; i++)
			{
				int count = 0;
				for (int j = 0; j < text.Length; j++)
				{
					if (input[i].Equals(text[j]))
					{
						count++;
					}
				}
				Console.WriteLine($"{input[i]} - {count}");
			}
		}
	}
}

