using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms21
{
	class Program
	{
		private static readonly Random getRandom = new Random();
		static void Main(string[] args)
		{ 
			int[] _array1 = new int[GetRandomNumber(1, 10)];

			int[] _array2 = new int[GetRandomNumber(1, 10)];

			//int[] _combinearray = new int[_array1.Length + _array2.Length];

			for (int i = 0; i < _array1.Length; i++)
			{
				_array1[i] = GetRandomNumber(0, 30);
			}

			for (int i = 0; i < _array2.Length; i++)
			{
				_array2[i] = GetRandomNumber(-30, 0);
			}

			int[] _combinearray = _array1.Concat(_array2).ToArray();

			//for (int i = 0; i < _combinearray.Length; i++)
			//{
			//	Console.Write("  {0}  ", _combinearray[i]);
			//}

			Console.WriteLine();

			_combinearray = Array.FindAll(_combinearray, IsNotModFive).ToArray();

			Array.Sort(_combinearray);

			for (int i = 0; i < _combinearray.Length; i++)
			{
				Console.Write("  {0}  ", _combinearray[i]);
			}
			
			

			Console.ReadKey();
		}
		public static int GetRandomNumber(int min, int max)
		{
			lock (getRandom)
			{
				return getRandom.Next(min, max);
			}
		}
		public static bool IsNotModFive(int n)
			{
				return (n % 5) != 0 ;
			}
	}
}
