using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ElementaryLevelTasks
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			var _Dictionary = program.GetWordFrequency("C:/Users/Horko/source/repos/ElementaryLevelTasks/ElementaryLevelTasks/TextFile.txt");
			var _SortedDictionary = from entry in _Dictionary orderby entry.Value descending select entry;
			foreach (KeyValuePair<string, int> kvp in _SortedDictionary)
			{
				Console.WriteLine("{0}  -  {1}", kvp.Key, kvp.Value);
			}
			Console.ReadLine();
		}
		private  Dictionary<string, int> GetWordFrequency(string file)
		{
			return File.ReadLines(file)
				.SelectMany(x => x.Split())
				.Where(x => x != string.Empty)
				.GroupBy(x => x)
				.ToDictionary(x => x.Key, x => x.Count());
		}
	}

}
