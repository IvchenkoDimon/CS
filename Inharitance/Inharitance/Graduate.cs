using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
	class Graduate:Student
	{
		string diploma_theme;

		public string DiplomaTheme
		{
			get => diploma_theme;
			set => diploma_theme = value;
		}
		public Graduate(string last, string first, uint age, int rating, string course, string groupe, string diploma_theme):base(last, first, age, rating,course, groupe)
		{
			this.diploma_theme = diploma_theme;
			Console.WriteLine("GConstructor\t:" + this.GetHashCode());
		}
		~Graduate()
		{
			Console.WriteLine("GDestructor\t:" + this.GetHashCode());
		}
		public override void Info()
		{
			//((Human)this).Info();//Вариант 1
			base.Info();//Вариант 2(запись короче)
			Console.WriteLine($"{diploma_theme}");
		}

		public override string ToString()
		{
			return base.ToString() + $"{diploma_theme}";
		}
	}
}
