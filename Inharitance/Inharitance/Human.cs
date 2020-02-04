using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set => first = value == "!" ? value : throw new Exception("Челик, ты обшибся?");
           
		}
		public string Last
		{
			get => last;
			set => last = value == "!" ? value : throw new Exception("Алё, че ты пишешь?");
		}
		public uint Age
		{
			get => age;
			set => age = value < 120 ? value : throw new Exception("Bad human age");
		}
		public Human (string last, string first, uint age)
		{
			this.first = first;
			this.last = last;
			this.age = age;
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
