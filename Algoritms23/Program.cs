using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms23
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Введіть номер рядка: ");

			int n = Convert.ToInt32(Console.ReadLine());

			Program program = new Program();

			foreach (var item in program.PascalRow(n))
			{
				Console.Write("   {0}",item);
			}

			Console.ReadKey();
		}
		private List<long> PascalRow(int row_number)
		{
			checked //Для перевірки переповненості в арифметичних виразах
			{

				List<long> results = new List<long>();
				long value = 1;
				results.Add(value);

				for (int k = 1; k <= row_number; k++)
				{
					value = (value * (row_number + 1 - k)) / k;
					results.Add(value);
				}

				return results;
			}
		}
	}
}
