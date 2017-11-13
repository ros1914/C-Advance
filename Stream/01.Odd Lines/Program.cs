namespace _00.Test
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		public static void Main()
		{

			StreamReader word = new StreamReader("../../words.txt");
			StreamReader text = new StreamReader("../../text.txt");
			StreamWriter result = new StreamWriter("../../result.txt");

			using (word)
			{
				using (result)
				{
					string readText = word.ReadLine();
					string conteinText = text.ReadLine().ToLower();
					while (readText != null)
					{
						int count = 0;

						while (conteinText != null)
						{
							if (conteinText.Contains(readText))
							{
								count++;
							}
							conteinText = text.ReadLine().ToLower();
						}
						result.WriteLine(readText);
						conteinText = text.ReadLine().ToLower();

						readText = word.ReadLine();
					}
				}
			}

			//const string snimka = "../../snimka.jpg";
			//const string picture = "../../result.jpg";
			//
			//using (FileStream op=new FileStream(snimka,FileMode.Open))
			//{
			//	using (FileStream rs = new FileStream(picture, FileMode.Create))
			//	{
			//		double fileLength = op.Length;
			//		byte[] bufer = new byte[4096];
			//		while (true)
			//		{
			//			int readByte = op.Read(bufer, 0, bufer.Length);
			//			if (readByte == 0)
			//			{
			//				break;
			//			}
			//
			//			rs.Write(bufer,0,bufer.Length);
			//			Console.WriteLine("{0:p}",Math.Min(op.Position ///fileLength, 1));
			//		}
			//	}
			//}
			//


			//string text = "кирилица";
			//FileStream ts = new FileStream("../../log.txt",FileMode.Create);
			//
			//try
			//{
			//	byte[] bytes = Encoding.UTF8.GetBytes(text);
			//	ts.Write(bytes,0,bytes.Length);
			//}
			//finally 
			//{
			//
			//	ts.Close();
			//}

			//FileStream fs = new FileStream("proba1",FileMode.Create);
			//
			//var buffer = new byte[4096];
			//fs.Read(buffer, 0, buffer.Length);



			//using (StreamWriter rs = new StreamWriter("proba1.txt"))
			//{
			//	for (int i = 0; i < 10; i++)
			//	{
			//		rs.WriteLine(i+1);
			//	}
			//	
			//}
			//const string file = "number.txt";
			//string text = File.ReadAllText(file);
			//
			//string newText = $"{text}{Environment.NewLine}9 10 11 12";
			//
			//File.WriteAllText(file, newText);
			//List<string> rs = new List<string>();
			//
			//rs.Add("blue");
			//rs.Add("yelow");
			//
			//File.WriteAllLines("lines.txt", rs);








			// File няма remove използва се move
			//File.Move("../another.txt", "rosen.txt");



			//string newPath = "../another.txt";
			//if (!File.Exists(newPath))
			//{
			//	File.Copy("number.txt", "../another.txt",true);
			//
			//}
			//string numbers = File.ReadAllText("number.txt");
			//Console.WriteLine(numbers);
			//Console.WriteLine(File.ReadAllText("somefile.txt"));

			///var buffer = new byte[2048];
			///FileStream file = new FileStream("failcheto.txt",FileMode.Create);
			///
			///file.Read(buffer, 0, buffer.Length);
			///






			//StreamReader reader = new StreamReader("somefile.txt");
			//
			//for (int i = 0; i < 10; i++)
			//{
			//	Console.WriteLine(reader.ReadLine()); 
			//}
			//
			//reader.Close();
		}
	}
}
