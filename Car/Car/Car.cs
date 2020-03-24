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
        public bool GasPedal { get; set; }
        public bool BreackPedal { get; set; }
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
            speed = 0;
        }

        public void Panel()
        {

            while (DriverInside)
            {
                Console.Clear();
                Console.WriteLine($"Engine is {(engine.Started ? "started" : "stoped")}");
                Console.WriteLine($"Fuel level: {tank.Fuel}.");
                Console.WriteLine($"Speed: {Speed} km/h");
                if (tank.Fuel < 5)
                {
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Low fuel, men!");
                    Console.ForegroundColor = defaultColor;
                }
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
        }
        public void Start()
        {
            if (tank.Fuel > 0)
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
            engine.Started = false;
            if (Control.tEngineIdleThread != null) Control.tEngineIdleThread.Join();
        }
        public void EngineIdle()
        {
            while (engine.Started && tank.Fuel > 0)
            {
                tank.Fuel -= engine.ConsumptionPerSecond;
                Thread.Sleep(1000);
            }
        }
        public void PressGas() //газ нажат
        {
            GasPedal = true;
            if (engine.Started && GasPedal && Control.tAccelerationThread == null)
            {
                Control.tAccelerationThread = new Thread(Accelleration);
                Control.tAccelerationThread.Start();
            }
        }
        public void Accelleration() //ускорение
        {
            if (engine.Started && Speed < max_speed)
            {
                if (speed < max_speed) Speed += 10;
                if (speed > max_speed) Speed = max_speed;
                Thread.Sleep(1000);
            }
        }
        public void ReleaseGas()
        {
            GasPedal = false;
            if (Speed > 0 && !GasPedal && Control.tFreeWeelingThread == null)
            {
                Control.tFreeWeelingThread = new Thread(FreeWeeling);
                Control.tFreeWeelingThread.Start();
                
            }
        }
        public void FreeWeeling()
        {
            while (Speed > 0)
            {
                if (Speed > 0) Speed -= 1;
                if (Speed < 0) Speed = 0;
                Thread.Sleep(1000);
            }
        }
        public void Break()
        {
            if (Speed > 0 && BreackPedal && Control.tBreakingThread == null)
            {
                Control.tBreakingThread = new Thread(Breaking);
                Control.tBreakingThread.Start();
            }
        }
        public void Breaking()
        {
            while (BreackPedal && Speed > 0)
            {
                if (Speed > 0) Speed -= 20;
                if (Speed < 0) Speed = 0;
                Thread.Sleep(1000);
            }
        }
        public override string ToString()
        {
            return $"Engine:{Engine.ToString()}\n{Tank.ToString()}\nMaxSpeed: {MaxSpeed}km/h";
        }
    }
}
