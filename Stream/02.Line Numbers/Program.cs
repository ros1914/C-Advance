namespace _02.Line_Numbers
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
			StreamReader reads = new StreamReader("../../someFile.txt");
			StreamWriter result = new StreamWriter("../../result.txt");

			using (reads)
			{
				using (result)
				{
					int lineNumber = 0;
					string lineReads = reads.ReadLine();
					while (lineReads!=null)
					{
						result.WriteLine($"line {lineNumber} " + lineReads);
						 lineReads = reads.ReadLine();
						lineNumber++;
					}
				}
			}
		}
	}
}
