namespace _01.ParkingLot
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

			SortedSet<string> set = new SortedSet<string>();

			string input = string.Empty;

			while ((input = Console.ReadLine()) != "END")
			{
				var data = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
				var comand = data[0];
				var carNumber = data[1];

				if (comand == "IN")
				{
					set.Add(carNumber);
				}
				else
				{
					set.Remove(carNumber);
				}
			}
			if (set.Count() >=1)
			{
				foreach (var sets in set)
				{
					Console.WriteLine(sets);
				}
			}
			else
			{
				Console.WriteLine("Parking Lot is Empty");
			}

		}
	}
}
