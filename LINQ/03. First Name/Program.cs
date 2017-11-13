namespace _03.First_Name
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
			var input = Console.ReadLine().Split(' ');

			var pattern = Console.ReadLine()
							.Split(' ')
							.OrderBy(w => w)
							.ToList();

			foreach (var item in pattern)
			{
				var result = input.Where(w => w.ToLower().StartsWith(item.ToLower()))
					.FirstOrDefault();
				if (result!=null)
				{
					Console.WriteLine(result);
					return;
				}
			}

			Console.WriteLine("No match");


		}
	}
}
