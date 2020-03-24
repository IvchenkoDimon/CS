using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Car
{
    class Car
    {
        Engine engine;
        Tank tank;
        uint speed;
        uint max_speed;
        public Engine Engine { get => engine; set => engine = value; }
        public Tank Tank { get => tank; private set => tank = value; }
        public uint Speed { get => speed; set => speed = value < max_speed ? value : max_speed; }
        public uint MaxSpeed { get => max_speed; private set => max_speed = value <= 420 ? value : throw new Exception("Error: Превышена максимальная скорость, одумайся чувак!!!"); }
        public bool DriverInside { get; set; }
        public Control Control { get; set; }
        public Car(Engine engine, Tank tank)
        {
            Engine = engine;
            Tank = tank;
            if (Engine.Power >= 50 && Engine.Power <= 200)
            {
                MaxSpeed = Engine.Power * 14 / 10;
            }
            else if (Engine.Power > 200 && Engine.Power <= 300)
            {
                MaxSpeed = Engine.Power * 13 / 10;
            }
            else if (Engine.Power > 300 && Engine.Power <= 400)
            {
                MaxSpeed = Engine.Power * 8 / 10;
            }
            else
            {
                MaxSpeed = Engine.Power * 42 / 100;
            }
            Control = new Control();
            Control.tMainThread = new Thread(ControlCar);
            Control.tMainThread.Start();
        }
        ~Car()
        {
            Control.tFreeWheelingThread.Join();
            Control.tMainThread.Join();
        }
        public void Panel()
        {

            while (DriverInside)
            {
                Console.Clear();
                Console.WriteLine($"Engine is {(engine.Started ? "started" : "stoped")}");
                Console.WriteLine($"Fuel level: {tank.Fuel}.");
                if (tank.Fuel < 5)
                {
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Low fuel, men!");
                    Console.ForegroundColor = defaultColor; 
                }
                Console.WriteLine();
                Console.WriteLine($"Speed:{Speed} km/h");
                Thread.Sleep(1000);
            }
        }
        public void Fill(double amount)
        {
            tank.Fill(amount);
        }
        public void GetIn()
        {
            DriverInside = true;
            Control.tControlPanelThread = new Thread(Panel);
            Control.tControlPanelThread.Start();
        }
        public void GetOut()
        {
            DriverInside = false;
            Control.tControlPanelThread.Join();
            Console.Clear();
            Console.WriteLine("You are out of car");
        }
        public void Start()
        {
            if (DriverInside && tank.Fuel > 0)
            {
                engine.Started = true;
                Control.tEngineIdleThread = new Thread(EngineIdle);
                Control.tEngineIdleThread.Start();
            }
            else
            {
                Console.WriteLine("No fuel: .I.");
            }
        }
        public void Stop()
        {
            if (DriverInside)
            {
                engine.Started = false;
                if (Control.tEngineIdleThread != null) Control.tEngineIdleThread.Join(); 
            }
        }
        public void EngineIdle()
        {
            while (engine.Started && tank.Fuel>0)
            {
                tank.Fuel -= engine.ConsumptionPerSecond;
                Console.Write("Dr...");
                Thread.Sleep(1000);
            }
        }
        public void FreeWheeling()
        {
            while (Speed > 0)
            {
                Speed--;
                Thread.Sleep(1000);
            }
        }
		public override string ToString()
		{
			return $"Engine:{Engine.ToString()}\n{Tank.ToString()}\nMaxSpeed: {MaxSpeed}km/h";
		}

        public void ControlCar()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        if (!this.DriverInside) this.GetIn();
                        else this.GetOut();
                        break;
                    case ConsoleKey.I:
                        if (!this.Engine.Started) this.Start();
                        else this.Stop();
                        break;

                    case ConsoleKey.F:
                        if (this.Control.tControlPanelThread.IsAlive) this.Control.tControlPanelThread.Suspend();
                        Console.WriteLine("Сколько бенза надо, чувак?");
                        //double amount = Convert.ToDouble(Console.ReadLine());
                        this.Fill(Convert.ToDouble(Console.ReadLine()));
                        if (this.Control.tControlPanelThread != null) this.Control.tControlPanelThread.Resume();
                        break;
                    case ConsoleKey.W:
                        if (DriverInside && Engine.Started)
                        {
                            if (Speed < MaxSpeed) Speed += 10;
                            if (Speed > MaxSpeed) Speed = MaxSpeed;
                        }
                        break;
                    case ConsoleKey.S:
                        if (DriverInside)
                        {
                            if (Speed >= 20) Speed -= 20;
                            else Speed = 0;
                        }
                        break;
                    case ConsoleKey.Escape:
                        this.Stop();
                        this.GetOut();
                        break;
                }

                if (Speed > 0)
                {
                        Control.tFreeWheelingThread = new Thread(FreeWheeling);
                        Control.tFreeWheelingThread.Start();
                }
                if (Speed == 0 && Control.tFreeWheelingThread != null)
                {
                    Control.tFreeWheelingThread.Suspend();
                }
                //if (Speed > 0) Speed--;

                Thread.Sleep(1000);
            } while (key != ConsoleKey.Escape);
        }
	}
}
