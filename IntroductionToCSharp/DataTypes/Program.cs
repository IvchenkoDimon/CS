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
			#region DataTypes
			//Object obj = null;
			//Console.WriteLine(obj.ToString());
			//Значащие типы - Value types: built-in types, struct, enum; (Stack)
			//Ссылочные типы - Reference type; (Heap)

			//Built-int types:
			//1) Logical: bool;
			//2) Character: char;
			//3) Numeric types:
			//		Integer: byte, sbyte, short, ushort, int, uint, long, ulong;
			//		Floating-point: float, double, decimal;

			//Console.WriteLine(true.ToString());

			//Console.WriteLine(Convert.ToInt32(char.MinValue) + "\t" + Convert.ToInt32( char.MaxValue));
			//(UTF-16)

			//	byte:
			//byte b = Convert.ToByte(1230);
			//byte b = Convert.ToByte(-123);
			//Console.WriteLine(123.GetType());

			//Console.WriteLine("Введите число: ");
			//double num = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine($"Вы ввели число {num}"); 
			#endregion

			#region calc
			try
			{
				Console.Write("Введите выражение: ");
				string expression = Console.ReadLine();
				expression = expression.Replace('.', ',');
				Console.WriteLine(expression);
				double a = Convert.ToDouble(expression.Split("+-*/".ToCharArray())[0]);
				double b = Convert.ToDouble(expression.Split("+-*/".ToCharArray())[1]);
				//Console.WriteLine(expression + " = " + (a + b));
				#region CalcByIf
				//if (expression.Contains('+'))
				//{
				//	Console.WriteLine($"{expression} = {a + b}");
				//}
				//else if (expression.Contains('-'))
				//{
				//	Console.WriteLine($"{expression} = {a - b}");
				//}
				//else if (expression.Contains('*'))
				//{
				//	Console.WriteLine($"{expression} = {a * b}");
				//}
				//else if (expression.Contains('/'))
				//{
				//	Console.WriteLine($"{expression} = {a / b}");
				//}
				//else
				//{
				//	Console.WriteLine("Error; Net takoi jivotnij");
				//} 
				#endregion


				switch (expression[expression.IndexOfAny("+-*/".ToCharArray())])
				{
					case '+': Console.WriteLine($"{expression}={a + b}"); break;
					case '-': Console.WriteLine($"{expression}={a - b}"); break;
					case '*': Console.WriteLine($"{expression}={a * b}"); break;
					case '/': Console.WriteLine($"{expression}={a / b}"); break;
					default: Console.WriteLine("Error: Net takoi jivotnij"); break;
				}
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
				Console.WriteLine("Error: Chto za dich ti napisal V_o_O_v");
			}

			#endregion
		}
	}
}
