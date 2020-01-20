using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Fraction
	{
		int integer;
		int numerator;
		int denominator;

		public int Integer
		{
			get
			{
				return integer;
			}
			set
			{
				integer = value;
			}
		}
		public int Numerator
		{
			get => numerator;
			set => numerator = value;
		}
		public int Denominator
		{
			get => denominator;
			set => denominator = value == 0 ? 1 : value;
		}
		public override string ToString()
		{
			//return base.ToString();
			string fraction = "0";
			if (numerator != 0)
			{
				fraction = $"{numerator}/{denominator}";
			}
			if (Integer != 0)
			{
				fraction = fraction.Insert(0, Integer.ToString() + "(");
				fraction += ")";
			}
			return fraction;
		}
		//					Constructors:
		public Fraction()
		{
			Integer = 0;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine("DConstructor\t" + this.GetHashCode());
		}
		public Fraction(int integer)
		{
			Integer = integer;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine("Constructor\t" + this.GetHashCode());
		}
		public Fraction(int numerator, int denominator)
		{
			Integer = 0;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine("Constructor\t" + this.GetHashCode());
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			Integer = integer;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine("Constructor\t" + this.GetHashCode());
		}
		~Fraction()
		{
			Console.WriteLine("Destructor\t" + this.GetHashCode());
		}
		public Fraction ToProper()
		{
			Integer += Numerator / Denominator;
			Numerator %= Denominator;
			return this;
		}
		public void ToImproper()
		{
			Numerator += Integer * Denominator;
			Integer = 0;
		}
		public static Fraction operator *(Fraction left, Fraction right)
		{
			left.ToImproper();
			right.ToProper();
			return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator).ToProper();
		}
	}
}