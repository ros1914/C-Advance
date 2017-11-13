namespace _03.Parse_Tags
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
			string openTag = "<upcase>";
			string clousTag = "</upcase>";
			int firstIndex = input.IndexOf(openTag);

			while (firstIndex!=-1)
			{
				int secondIndex = input.IndexOf(clousTag);
				if (secondIndex==-1)
				{
					break;
				}
				string upercase = input.Substring(firstIndex, secondIndex - firstIndex+clousTag.Length);
				string replaceUpercase = upercase.Replace(openTag,"").Replace(clousTag,"").ToUpper();

				 input = input.Replace(upercase,replaceUpercase);

				firstIndex = input.IndexOf(openTag);
			}

			Console.WriteLine(input);

		}
	}
}
 