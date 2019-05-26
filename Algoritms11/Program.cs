using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms11
{
	class Program
	{
		static void Main(string[] args)
		{
			string _readfile = "C:/Users/Horko/source/repos/ElementaryLevelTasks/Algoritms11/ReadFile.txt";
			Console.Write("Введіть адрес файла-отримувача:");
			string _wriitenfile = Console.ReadLine();
			using (StreamWriter writetext = new StreamWriter(_wriitenfile))
			{
				foreach (var line in File.ReadAllLines(_readfile).Reverse())
				{
					var reversedLines = string.Join(" ",
						line.Split(' ')
							.Select(x => new String(x.Reverse().ToArray())));
					writetext.WriteLine(reversedLines);
				}
				
			}
			Console.WriteLine(File.ReadAllText(_wriitenfile));
			Console.ReadLine();
		}
		//C:/Users/Horko/source/repos/ElementaryLevelTasks/Algoritms11/WrittenFile.txt
	}
}
