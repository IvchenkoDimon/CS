using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("-----------class Human-----------");
			//Human A = new Human("McCallister", "Kevin", 20 );
			//A.Info();
			//Console.WriteLine("-----------class Student-----------");
			//Student B = new Student("McCallister", "Kevin", 20, 100500 , "ITV_34v", "Home Alone");
			//B.Info();
			//Console.WriteLine("-----------class Teacher-----------");
			//Teacher C = new Teacher("Murchins", "Marv", 50, "Thief", 40);
			//C.Info();
			//Console.WriteLine("-----------class Graduate-----------");
			//Graduate D = new Graduate("Lyme", "Hary", 25, 500, "Home Alone 2", "ITV_54v", "Thief technique");
			//D.Info();

			Human[] group = new Human[] 
			{
				new Student("!McCallister", "!Kevin", 20, 100500 , "ITV_34v", "Home Alone"),
				new Teacher("Murchins", "Marv", 150, "Thief", 40),
				new Graduate("Lyme", "Hary", 25, 500, "Home Alone 2", "ITV_54v", "Thief technique"),
				new Teacher("Einstein", "Albert", 100, "Astrinimy", 70),
				new Student("Montana", "Antonio", 30, 70, "ITV_34v", "Scareface"),
				new Graduate("Vercetty", "Tom", 30, 95, "Vice City", "ITV_54v", "Making money")
			};

			foreach( Human i in group)
			{
				//Console.WriteLine(i + ":");
				//i.Info();
				//Console.WriteLine("----------------------------------------");

				Console.WriteLine(i);
			}
		}
	}
}
