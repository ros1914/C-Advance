namespace _11.Palindromes
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
			var input = Console.ReadLine().Split(new[] { ' ', ',','!','?','.'},StringSplitOptions.RemoveEmptyEntries);
			List<string> result = new List<string>();
			foreach (var item in input)
			{
				var revursWord = new string(item.Reverse().ToArray());
				//string revurs = revursWord.ToString();

				if (item.Equals(revursWord))
				{
					if (!result.Contains(item))
					{
						result.Add(item);

					}
				}

			}

			 result.Sort();
			int count = result.Count();
			Console.Write("[");
			foreach (var rs in result)
			{
				Console.Write(rs);
				if (count>1)
				{
					Console.Write(", ");
					count--;
				}
			}
			Console.Write("]");
		}
	}
}
