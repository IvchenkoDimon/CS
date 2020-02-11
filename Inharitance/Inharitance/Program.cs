using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Inharitance
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("-----------class Human-----------");
				Human A = new Human("McCallister", "Kevin", 20);
				A.Info();
				Console.WriteLine("-----------class Student-----------");
				Student B = new Student("McCallister", "Kevin", 20, 100500, "Home Alone", "ST_ITV_34v");
				B.Info();
				Console.WriteLine("-----------class Teacher-----------");
				Teacher C = new Teacher("Murchins", "Marv", 50, "Thief", 40);
				C.Info();
				Console.WriteLine("-----------class Graduate-----------");
				Graduate D = new Graduate("Lyme", "Hary", 25, 500, "Home Alone 2", "ST_ITV_54v", "Thief technique", "kroshka@gmail.com");
				D.Info();

				//Teacher t = new Teacher("Murchins", "Marv", 150, "Thief", 40);
				//Console.WriteLine(t);

				//Вариант 1
				//-------------------------------------------------------------------------
				//string str = "Hello World!";
				//for (int i = 0; i < str.Length; i++)
				//{
				//	if (!Char.IsLetter(str[i]))
				//	{
				//		Console.WriteLine("Popados");
				//	}
				//}
				//Вариант 2
				//--------------------------------------------------------------------------------
				//if(str.IndexOfAny)
				//char[] arr = str.ToCharArray();

				//Regex.IsMatch(str, @"^[A-Za-z]+$");
				//Char.IsLetter

				//Вариант 3
				//-----------------------------------------------------------------------------------
				//for (int i = 0; i < arr.Length; i++)
				//{
				//	if ((int)arr[i] < 65 || (int)arr[i] > 90 && (int)arr[i] < 97 || (int)arr[i] > 122)
				//	{
				//		Console.WriteLine("Not a word");
				//	}
				//}

				//Console.WriteLine(str.IndexOfAny);

				//Human[] group = new Human[]
				//{
				//new Student("McCallister", "Kevin", 20, 100500 , "ITV_34v", "Home Alone"),
				//new Teacher("Murchins", "Marv", 50, "Thief", 40),
				//new Graduate("Lyme", "Hary", 25, 500, "Home Alone 2", "ITV_54v", "Thief technique"),
				//new Teacher("Einstein", "Albert", 100, "Astrinimy", 70),
				//new Student("Montana", "Antonio", 30, 70, "ITV_34v", "Scareface"),
				//new Graduate("Vercetty", "Tom", 30, 95, "Vice City", "ITV_54v", "Making money")
				//};

				//foreach (Human i in group)
				//{
				//	//Console.WriteLine(i + ":");
				//	//i.Info();
				//	//Console.WriteLine("----------------------------------------");

				//	Console.WriteLine(i);
				//}

				/////////////////////////////////////////////////////////////////////////

				//for (int i = 0; i < 200; i++)
				//{
				//	Console.WriteLine(i + "\t" + (char)i);
				//	if (i % 50 == 0) Console.ReadKey();
				//}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
		}
	}
}
