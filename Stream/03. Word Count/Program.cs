namespace _03.Word_Count
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			StreamReader word = new StreamReader("../../words.txt");
			StreamReader text = new StreamReader("../../text.txt");
			StreamWriter result = new StreamWriter("../../result.txt");

			using (word)
			{
				using (result)
				{
					string readText = word.ReadLine();
					string conteinText = text.ReadLine().ToLower();
					List<string> list = new List<string>();
					Dictionary<string, int> dict = new Dictionary<string, int>();
					while (conteinText!=null)
					{
						list.Add(conteinText);
						conteinText = text.ReadLine();
					}
					 
					while (readText != null)
					{
						int count = 0;

						foreach (var item in list)
						{
							string data = item.ToLower();
							if (data.Contains(readText))
							{
								count++;
							}
						}

						dict[readText] = count;
						//result.WriteLine(readText + $" - {count}");
						
						readText = word.ReadLine();
					}

					foreach (var item in dict.OrderByDescending(d=>d.Value))
					{
						result.WriteLine($"{item.Key} - {item.Value}");
					}
					
				}
			}
		}
	}
}
