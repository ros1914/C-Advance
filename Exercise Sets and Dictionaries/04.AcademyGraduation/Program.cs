namespace _04.AcademyGraduation
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
			SortedDictionary<string, List<double>> averageScores = new SortedDictionary<string, List<double>>();

			int numberOfStudents = int.Parse(Console.ReadLine());

			for (int i = 0; i < numberOfStudents; i++)
			{
				string name = Console.ReadLine();
				var inputScore = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

				averageScores.Add(name, inputScore);
			}

			foreach (var averageScor in averageScores)
			{
				Console.WriteLine($"{averageScor.Key} is graduated with {averageScor.Value.Average()}");
			}
		}
	}
}
