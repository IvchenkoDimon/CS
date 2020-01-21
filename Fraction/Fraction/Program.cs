//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
#if CONSTRUCTORS_CHECK
			Fraction A = new Fraction(1, 2, 3);
			Console.WriteLine(A);
			A.ToImproper();
			Console.WriteLine(A);
			A.ToProper();
			Console.WriteLine(A); 
#endif

			Fraction A = new Fraction(3, 4, 5);
			Fraction B = new Fraction(4, 5, 6);
			/*
			Console.WriteLine(A);
			Console.WriteLine(B);
			Console.WriteLine(A*B);
			*/
			Console.WriteLine(A);
			Console.WriteLine(B);
			Console.WriteLine(A+B);
			Console.WriteLine(A);
			Console.WriteLine(B);

		}
		
    }
	
}
