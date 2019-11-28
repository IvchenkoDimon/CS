using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			Object obj;
			//Значащие типы - Value types: built-in types, struct, enum; (Stack)
			//Ссылочные типы - Reference type; (Heap)

			//Built-int types:
			//1) Logical: bool;
			//2) Character: char;
			//3) Numeric types:
			//		Integer: byte, sbyte, short, ushort, int, uint, long, ulong;
			//		Floating-point: float, double, decimal;
			bool bVar = false;
			Console.WriteLine(bVar.GetType());
			System.Boolean bVar2 = true;
			Console.WriteLine(bVar2.GetType());

			byte b = 123;
			Console.WriteLine(b.GetType());
			Console.WriteLine(byte.MinValue + "\t" + byte.MaxValue);
			Console.WriteLine(sbyte.MinValue + "\t" + sbyte.MaxValue);

		}
	}
}
