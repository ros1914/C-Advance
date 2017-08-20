namespace _08.HandsOfCards
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
			Dictionary<string, HashSet<string>> totalScor = new Dictionary<string, HashSet<string>>();

			var cardScor = 0;
			string input = string.Empty;
			while ((input = Console.ReadLine()) != "JOKER")
			{
				var data = input.Split(':');
				var name = data[0];
				var card = data[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


				if (!totalScor.ContainsKey(name))
				{
					totalScor[name] = new HashSet<string>(card);

				}
				else
				{
					totalScor[name].UnionWith(card);
				}

			}
			foreach (var item in totalScor)
			{
				var scor = TotalScorCard(item.Value);

				Console.WriteLine($"{item.Key}: {scor}");
			}
		}

		private static int TotalScorCard(HashSet<string> cards)
		{
			var totalScors = 0;

			foreach (var card in cards)
			{

				var cardsScore = 0;
				var cardTypeNumber = 0;
				var cardType = card.Substring(0, card.Length-1).ToString();
				var type = card.Last();

				var convert = int.TryParse(cardType, out cardTypeNumber);

				if (convert == true)
				{
					cardsScore += cardTypeNumber;
				}
				else if (convert == false)
				{
					switch (cardType)
					{
						case "J": cardsScore += 11; break;
						case "Q": cardsScore += 12; break;
						case "K": cardsScore += 13; break;
						case "A": cardsScore += 14; break;
						default:
							break;
					}
				}

				switch (type)
				{
					case 'S': cardsScore *= 4; break;
					case 'H': cardsScore *= 3; break;
					case 'D': cardsScore *= 2; break;
					case 'C': cardsScore *= 1; break;
					default:
						break;
				}
				totalScors += cardsScore;
			}

			return totalScors;
		}
	}
}
