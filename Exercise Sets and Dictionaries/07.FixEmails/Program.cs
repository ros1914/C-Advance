namespace _07.FixEmails
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	using System.Threading.Tasks;
	public class Program
	{
		public static void Main()
		{
			Dictionary<string, string> fixEmails = new Dictionary<string, string>();
			string input = string.Empty;

			while ((input = Console.ReadLine())!="stop")
			{
				var email = Console.ReadLine();
				if (email.Contains("bg"))
				{
					fixEmails.Add(input,email);
				}
			}
			foreach (var item in fixEmails)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
