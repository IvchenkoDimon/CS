using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
	class Teacher : Human
	{
		int exp;
		string subject;

		public int Exp
		{
			get => exp;
			set => exp = value;
		}
		public string Subject
		{
			get => subject;
			set => subject = value;
		}

		public Teacher(string last, string first, uint age, string subject, int exp) : base(last, first, age)
		{
			this.exp = exp;
			this.subject = subject;
			Console.WriteLine("TConstructor\t:" + this.GetHashCode());
		}
		~Teacher()
		{
			Console.WriteLine("TDestructor\t:" + this.GetHashCode());
		}
		public override void Info()
		{
			//((Human)this).Info();
			base.Info();
			Console.WriteLine($"{subject}, {exp} years");
		}
	}
}
