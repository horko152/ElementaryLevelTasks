using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms12
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введіть індекс числа Фібоначчі:");
			int index = Int32.Parse(Console.ReadLine());
			Console.WriteLine(GetNthFibonacci_Ite(index));
			Console.ReadKey();
		}
		private static int GetNthFibonacci_Ite(int n)
		{
			int number = n - 1;  
			int[] Fib = new int[number + 1];
			Fib[0] = 0;
			Fib[1] = 1;
			for (int i = 2; i <= number; i++)
			{
				Fib[i] = Fib[i - 2] + Fib[i - 1];
			}
			return Fib[number];
		}
	}
}
