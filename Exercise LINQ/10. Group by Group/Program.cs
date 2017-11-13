namespace _10.Group_by_Group
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
			string input;
			List<Persone> students = new List<Persone>();
			while ((input = Console.ReadLine())!="END")
			{
				string[] data = input.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
				string name = data[0] + " " + data[1];
				int group = int.Parse(data[2]);
				students.Add(new Persone(name,group));
			}

			var result = students.GroupBy(s => s.Group,s=>s.Name).OrderBy(p=>p.Key).ToList();
			foreach (var item in result)
			{
				Console.WriteLine(item.Key + " - " + string.Join(", ",item));
			}
		}

		class Persone
		{
			public Persone(string name,int group)
			{
				this.Name = name;
				this.Group = group;
			}
			public string Name { get; set; }
			public int Group { get; set; }
		}

	}

	 
}
