using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Inharitance
{
	class Human
	{

		string first;
		string last;
		uint age;

		public string First
		{
			get => first;
            //set => first = value == "!" ? value : throw new Exception("Челик, ты обшибся?");
			set
			{
				Console.WriteLine(Regex.IsMatch(value, "![^a-z]"));
				//Console.ReadKey();
				//if (System.Text.RegularExpressions.Regex.IsMatch(value, "![^a-z]", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
				//{
				//	throw new Exception("Чувак, ИМЯ должно состоять только из букв!");
				//}
				first = value;
			}
           
		}
		public string Last
		{
			get => last;
			set
			{
				if (Regex.IsMatch(value.ToLower(), "[^a-z]", RegexOptions.IgnoreCase))
				{
					throw new Exception("Чувак, ФАМИЛИЯ должно состоять только из букв!");
				}
				last= value;
			}
		}
		public uint Age
		{
			get => age;
			set => age = value < 120  ? value : throw new Exception("Bad human age");
		}
		public Human (string last, string first, uint age)
		{
			this.First = first;
			this.Last = last;
			this.Age = age;
			Console.WriteLine("HConstructor\t:" + this.GetHashCode());
		}
		~Human()
		{
			Console.WriteLine("HDestructor\t:" + this.GetHashCode());
		}
		public virtual void Info()
		{
			Console.WriteLine($"{last} {first}, {age} y.o.");
		}

		public override string ToString()
		{
			return $"{last} {first}, {age} y.o.";
		}
	}
}
