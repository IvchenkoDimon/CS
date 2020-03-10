using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
	class Tank
	{
		uint volume;				//Атрибут (характеристика объекта) 
		double fuel;				//Состояние объекта
		
		public uint Volume
		{
			get => volume;
			private set => volume = value >= 40 && value <= 120 ? value : throw new Exception("Bad tank volume!");
		}
		public double Fuel
		{
			get => fuel;
			set
			{
				fuel = value;
				if (fuel < 0) fuel = 0;
				if (fuel > volume) fuel = volume;
			}
		}

		public void Fill(double fuel)
		{
			Fuel += fuel;
		}

		public Tank(uint volume)
		{
			Volume = volume;
			Fuel = fuel;
		}
        public double GiveFuel(double amount)
        {
            Fuel -= amount;
            //if (Fuel < 0) Fuel = 0;
            return Fuel;
        }
		public override string ToString()
		{
			return $"Tank volume: {Volume};\nFuel level: {Fuel}";
		}
	}
}
