﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

		}
		public override string ToString()
		{
			return $"Engine:{Engine.ToString()}\n{Tank.ToString()}\nMaxSpeed: {MaxSpeed}km/h";
		}
	}
}
