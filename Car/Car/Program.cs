using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
	class Program
	{
		static void Main(string[] args)
		{
			//	Tank tank = new Tank(40);
			//	tank.Fill(10);
			//	tank.Fill(20);


			//	Console.WriteLine(tank);
			//	Engine engine = new Engine(200);
			//	Console.WriteLine(engine);
			
			Car myCar = new Car(new Engine(250), new Tank(40));
			Console.WriteLine(myCar);

            Console.WriteLine("Youre car is ready, press Enter to get in");
            //Console.ReadKey();
            //myCar.GetIn();

            //ConsoleKey key;
            //do
            //{
            //    key = Console.ReadKey(true).Key;
            //    switch (key)
            //    {
            //        case ConsoleKey.Enter:
            //            if (!myCar.Engine.Started) myCar.Start();
            //            else myCar.Stop();
            //            break;
            //        case ConsoleKey.Escape:
            //            myCar.Stop();
            //            myCar.GetOut();
            //            break;
            //        case ConsoleKey.F:
            //            myCar.Control.tControlPanelThread.Suspend();
            //            Console.WriteLine("Сколько бенза надо, чувак?");
            //            myCar.Fill(Convert.ToDouble(Console.ReadLine()));
            //            myCar.Control.tControlPanelThread.Resume();
            //            break;
            //    }
            //} while (key != ConsoleKey.Escape);
		}
	}
}
