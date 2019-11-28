using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите Ваше имя: ");
			string name = Console.ReadLine();
			Console.Title = "Player - " + name;

			Console.WriteLine("Выберите цвет игрока: ");
			ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
			for (int i = 0; i < colors.Length; i++)
			{
				Console.ForegroundColor = colors[i];
				Console.WriteLine(i + "\t" + colors[i]);
			}

			//Console.ForegroundColor = colors[ Console.Read()-48];
			//Console.Read();

			Console.ForegroundColor = (ConsoleColor)(Convert.ToInt32( Console.ReadLine())%colors.Length);

			int xSize = 100;
			int ySize = 30;
			Console.SetWindowSize(xSize, ySize);
			Console.SetBufferSize(xSize, ySize);
			ConsoleKey key;

			int x = 15;
			int y = 15;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					#region Shooter
					//case ConsoleKey.W: Console.WriteLine("Вперед"); break;
					//case ConsoleKey.S: Console.WriteLine("Назад"); break;
					//case ConsoleKey.A: Console.WriteLine("Влево"); break;
					//case ConsoleKey.D: Console.WriteLine("Вправо"); break;
					//case ConsoleKey.Escape: Console.WriteLine("Выход"); break;
					//default: Console.WriteLine("Error"); break; 
					#endregion
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: if (y > 0) y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: if (y < ySize - 2) y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: if (x > 0) x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: if (x < xSize - 2) x++; break;
				}
				Console.Clear();
				Console.SetCursorPosition(0, 0);
				Console.WriteLine("x:\t" + x);
				Console.WriteLine("y:\t" + y);
				Console.SetCursorPosition(x, y);
				Console.WriteLine((char)2);
			} while (key != ConsoleKey.Escape);
		}
	}
}
