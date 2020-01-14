using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Program
	{
		static void Main(string[] args)
		{
			//Вариант 1 - get / set методы
			Point A = new Point(5, 2);
			//A.setX(2);
			//A.setY(3);
			Console.WriteLine(A);
			//Вариант 2 - Свойство
			
			//A.X = 123;
			//A.Y = 456;
			//Console.WriteLine(A.ToString());

			Point B = new Point(A);
			Console.WriteLine(A);
			Console.WriteLine(B);

			Point C = new Point();
			C = A;
			Console.WriteLine(C);
			C = A + B;
			Console.WriteLine(C);
		}
	}
}
