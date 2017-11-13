namespace _01.OddLine
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
			
			using (StreamReader reads = new StreamReader("../../text.txt"))
			{

				int lineNumber = 0;
				string readsLine = reads.ReadLine();
				while (readsLine!=null)
				{
					if (lineNumber%2!=0)
					{
						readsLine = reads.ReadLine();
						Console.WriteLine($"Line: {lineNumber} -> {readsLine}");
					}
					else if (lineNumber!=0)
					{
						readsLine = reads.ReadLine();
					}
					lineNumber++;
				}
			}
		}
	}
}
