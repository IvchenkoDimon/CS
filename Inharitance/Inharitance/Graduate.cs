using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Inharitance
{
	class Graduate:Student
	{
		string diploma_theme;
        string email;
        
        public string Email
        {
            get => email;
            set
            {
                if(Regex.IsMatch(value, @"^([a-z0-9]{3,20})@([a-z]{2,6}).([a-z]{2,3})$", RegexOptions.IgnoreCase))//Я, без понятия почему оно всё пропускает(((( 
                    throw new Exception("Чувак,  EMAIL должен выглядеть так : sabaka@gmail.com!");
                email = value;
            }
        }
		public string DiplomaTheme
		{
			get => diploma_theme;
			set => diploma_theme = value;
		}
		public Graduate(string last, string first, uint age, int rating, string course, string groupe, string diploma_theme, string email):base(last, first, age, rating,course, groupe)
		{
			this.DiplomaTheme = diploma_theme;
            this.Email = email;
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
			Console.WriteLine($"{diploma_theme}, {email}");
		}
        

		public override string ToString()
		{
			return base.ToString() + $"{diploma_theme}, {email} ";
		}
	}
}
