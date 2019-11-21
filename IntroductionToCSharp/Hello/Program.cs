//Подключаются пространства имен:
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//Каждое приложение должно быть в своем именном пространстве
namespace Hello
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.ForegroundColor = System.ConsoleColor.Green;
			System.Console.Title = "Hello C#";
			System.Console.WindowHeight = 10;
			System.Console.WindowWidth = 50;
			System.Console.BufferHeight = 10;
			System.Console.BufferWidth = 50;
			//System.Console.CursorVisible = false;
			System.Console.CursorSize = 50;

			#region Strings
			System.Console.Write("\t\t\t\t\tHello World!\n");
			System.Console.WriteLine("Сам привет");
			string name = "";
			string age = null;
			System.Console.Write("Введите Ваше имя: ");
			name = System.Console.ReadLine();
			System.Console.Write("Сколько Вам лет? ");
			age = System.Console.ReadLine();
			//Конкатенация строк:
			System.Console.WriteLine("Привет " + name + ", тебе " + age + " лет.");
			//Форматирование строк:
			System.Console.WriteLine("Привет {0}, тебе {1} лет.", name, age);
			//Интерполяция строк:
			System.Console.WriteLine($"Привет {name}, тебе {age} лет.");
			/////////////////
			System.Console.WriteLine("C:\\Windows\\System32\\");
			System.Console.WriteLine(@"C:\Windows\System32\");  //Veratim string - дословная строка.
																//System.Console.WriteLine("Hello"); 
			#endregion

			System.Console.Clear();
		}
	}
}
