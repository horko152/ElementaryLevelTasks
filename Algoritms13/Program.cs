using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms13
{
	class Program
	{
		const double Degrees = 180.0 / Math.PI;

		static void Main(string[] args)
		{
			Program program = new Program();
			Console.WriteLine("Введіть координати першого відрізка OA:");
			Console.Write("x1 = ");
			double x1 = Double.Parse(Console.ReadLine());
			Console.Write("y1 = ");
			double y1 = Double.Parse(Console.ReadLine());
			//Console.WriteLine("Кут першого відрізку: {0} ",program.Angle(x1, y1));
			Console.WriteLine("Введіть координати другого відрізка OB:");
			Console.Write("x2 = ");
			double x2 = Double.Parse(Console.ReadLine());
			Console.Write("y2 = ");
			double y2 = Double.Parse(Console.ReadLine());
			//Console.WriteLine("Кут другого відрізку: {0} ", program.Angle(x2, y2));
			if (program.Angle(x1, y1) > program.Angle(x2, y2)) Console.WriteLine("Кут відрізка OA більший");
			else Console.WriteLine("Кут відрізка OB більший");
			Console.ReadKey();
		}
		private double Angle(double x, double y)
		{
			return Math.Atan2(y,x) * Degrees;
		}
	}
}
