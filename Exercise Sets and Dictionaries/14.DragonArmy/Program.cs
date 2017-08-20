using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DragonArmy
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, SortedDictionary<string, List<int>>> dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);
				

				AddDataForDragon(dragons,input);

			}

			foreach (var dragon in dragons)
			{
				double avDamage = dragon.Value.Select(d=>d.Value[0]).Average();
				double avHealth = dragon.Value.Select(d=>d.Value[1]).Average();
				double avArmor = dragon.Value.Select(d => d.Value[2]).Average();

				Console.WriteLine($"{dragon.Key}::({avDamage:f2}/{avHealth:f2}/{avArmor:f2})");
				foreach (var item in dragon.Value.OrderBy(d=>d.Key))
				{
					Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}" );
				}
			}
			

		}

		private static void AddDataForDragon(Dictionary<string, SortedDictionary<string, List<int>>> dragons, string[] input)
		{
			var typeDragon = input[0];
			var nameDragon = input[1];
			int damage = 0;
			int health = 0;
			int armor = 0;

			damage = 45;
			if (input[2] != "null")
			{
				damage = int.Parse(input[2]);
			}

			health = 250;
			if (input[3] != "null")
			{
				health = int.Parse(input[3]);
			}

			armor = 10;
			if (input[4] != "null")
			{
				armor = int.Parse(input[4]);
			}

			if (dragons.ContainsKey(typeDragon))
			{
				if (dragons[typeDragon].ContainsKey(nameDragon))
				{
					dragons[typeDragon][nameDragon] = new List<int>{ damage,health,armor};
				}
				else
				{
					dragons[typeDragon].Add(nameDragon, new List<int> { damage, health, armor });
				}
			}
			else
			{
				dragons.Add(typeDragon, new SortedDictionary<string, List<int>> { {nameDragon,new List<int> { damage, health, armor } } });
			}
		}
	}
}
