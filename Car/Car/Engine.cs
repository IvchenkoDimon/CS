using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
	class Engine
	{
		uint power;					//мощность
		double consumption;         //расход топлива
        //double consumptionPerSecond; // не нужно обьявлять, так как используем автосвойство
		//bool started;
		public uint Power
		{
			get => power;
			set
			{
			//	if(value>=50 && value<=1000)
			//	{
			//		power = value;
			//	}
			//	else
			//	{
			//		throw new Exception("Error: Bad engine power!");
			//	}
			power = value >= 50 && value <= 1000 ? value : throw new Exception("Error: Bad engine power!");
			}
		}
		public double Consumption
		{
			get => consumption;
			private set => consumption = value;
		}
        public double ConsumptionPerSecond { get; set; }
		public bool Started { get; set; }

		public Engine(uint power)
		{
			Power = power;
			Consumption = .0002 * (Power / 15);
            ConsumptionPerSecond = Consumption / 10;
			Started = false;
		}
		public override string ToString()
		{
			return $"Power: {Power} HP, Consumption {Consumption*3600} L/100km, consumption per second: {ConsumptionPerSecond} L/sec, engine: {(Started?"started":"stopped")}";
		}
	}
}
