namespace _02.SoftUniParty
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
			string input = string.Empty;
			SortedSet<string> vip = new SortedSet<string>();
			SortedSet<string> guest = new SortedSet<string>();

			while ((input = Console.ReadLine()) != "PARTY")
			{
				if (input.Take(1).All(char.IsDigit))
				{
					vip.Add(input);
				}
				else
				{
					guest.Add(input);
				}
			}
			while ((input = Console.ReadLine()) != "END")
			{
				if (vip.Contains(input))
				{
					vip.Remove(input);
				}
				else
				{
					guest.Remove(input);
				}
			}
			

			var count = vip.Count() + guest.Count();
			Console.WriteLine(count);
			foreach (var vp in vip)
			{
				Console.WriteLine(vp);
			}
			foreach (var gs in guest)
			{
				Console.WriteLine(gs);
			}
		}
	}
}
