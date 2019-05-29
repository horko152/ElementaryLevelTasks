using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms22
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			Console.WriteLine("Введіть слово для пошуку:");
			string word = Console.ReadLine();
			Console.WriteLine("Введіть режим роботи (1 або 2)");
			int workingmode = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введіть адрес файлу:");
			string fileaddress = Console.ReadLine();
			if (File.Exists(fileaddress))
			{
				if (workingmode == 1)
				{
					var _Dictionary = program.GetWordFrequency(fileaddress);
					int count = 0;
					foreach (var item in _Dictionary)
					{
						if (item.Key.Contains(word)) count++;
					}
					Console.WriteLine("К-сть згадувань слова <{0}> - {1} раз", word,count);
				}
				else if (workingmode == 2)
				{

					var _Dictionary = program.GetWordFrequency(fileaddress);
					foreach (var item in _Dictionary)
					{
						if (item.Key == word) Console.WriteLine("К-сть згадувань слова <{0}> - {1} раз", item, item.Value);
					}
				}
				else Console.WriteLine("Неправильно введений режим роботи");
			}
			else Console.WriteLine("Файла не існує");

			Console.ReadKey();
			//C:/Users/Horko/source/repos/ElementaryLevelTasks/Algoritms22/TextFile.txt
		}
		private Dictionary<string, int> GetWordFrequency(string file)
		{
			return File.ReadLines(file)
				.SelectMany(x => x.Split())
				.Where(x => x != string.Empty)
				.GroupBy(x => x)
				.ToDictionary(x => x.Key, x => x.Count());
		}
	}
}
