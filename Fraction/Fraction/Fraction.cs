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
			Console.WriteLine("DefConstructor\t" + this.GetHashCode());
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
		public Fraction(Fraction other)
		{
			integer = other.integer;
			numerator = other.numerator;
			denominator = other.denominator;
			Console.WriteLine("CopyConstructor:" + this.GetHashCode());
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

		public Fraction Reduce()
		{
			int more;
			int less;
			int reminder;
			if (numerator > denominator)
			{
				more = numerator;
				less = denominator;
			}
			else
			{
				less = numerator;
				more = denominator;
			}
			do
			{
				reminder = more % less;
				more = less;
				less = reminder;
			} while (reminder > 0);
			int GCD = more; //Greatest Common Divisor
			numerator /= GCD;
			denominator /= GCD;
			return this;
		}

		//							Operators:
		public static Fraction operator *(Fraction left, Fraction right)
		{
			left.ToImproper();
			right.ToImproper();
			return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator).ToProper();
		}
		public static Fraction operator /(Fraction left, Fraction right)
		{
			left.ToImproper();
			right.ToImproper();
			return new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator).ToProper().Reduce();
		}
		public static Fraction operator +(Fraction left, Fraction right)
		{
			left.ToProper();
			right.ToProper();
			return new Fraction
			(
				left.Integer + right.Integer,
				left.Numerator * right.Denominator + right.Numerator * left.Denominator,
				left.Denominator * right.Denominator
			).ToProper().Reduce();
		}
		public static Fraction operator -(Fraction left, Fraction right)
		{
			left.ToProper();
			right.ToProper();
			return new Fraction
			(
				left.Integer - right.Integer,
				left.Numerator * right.Denominator - right.Numerator * left.Denominator,
				left.Denominator * right.Denominator
			).ToProper().Reduce();
		}

		public static explicit operator bool(Fraction obj)
		{
			//Вариант 1
			//if (obj.integer == 0 && obj.numerator == 0)
			//{
			//	return false;
			//}
			//else
			//{
			//	return true;
			//}
			//Вариант 2
			return obj.integer == 0 && obj.numerator == 0;
		}
		public static explicit operator int(Fraction obj)
		{
			return obj.integer;
		}

		public static bool operator ==(Fraction left, Fraction right)
		{
			left.Reduce().ToImproper();
			right.Reduce().ToImproper();
			return left.Numerator == right.Numerator && left.Denominator == right.Denominator;
		}

		public static bool operator !=(Fraction left, Fraction right)
		{
			return !(left == right);
		}
	}
}