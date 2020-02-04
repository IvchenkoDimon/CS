using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Inharitance
{
	class Student:Human
	{
		int rating;
		string groupe;
		string course;

		public int Rating
		{
			get => rating;
			set => rating = value;
		}
		public string Groupe
		{
			get => groupe;
			set
			{
				if (Regex.IsMatch(value, "[^A-Z]{2}_[A-Z]{2,3}_[0-9]", RegexOptions.IgnoreCase))///////////!!!!!!!!!!!!!!
				throw new Exception("Чувак, ГРУППА должно состоять только из букв и цифр!");
				groupe = value;
			}
		}
		public string Course
		{
			get => course;
			set => course = value;
		}
		public Student(string last, string first, uint age, int rating, string course, string groupe):base(last, first, age)
		{
			this.Rating = rating;
			this.Groupe = groupe;
			this.Course = course;
			Console.WriteLine("SConstructor\t:" + this.GetHashCode());
		}
		~Student()
		{
			Console.WriteLine("SDestructor\t:" + this.GetHashCode());
		}
		public override void Info()
		{
			//((Human)this).Info();//Вариант 1
			base.Info();//Вариант 2(запись короче)
			Console.WriteLine($"{course}, {groupe}, {rating}%");
		}

		public override string ToString()
		{
			return base.ToString() + $"{course}, {groupe}, {rating}%";
		}
	}
}
