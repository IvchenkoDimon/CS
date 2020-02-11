//#define NAME_CHECK
//#define 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



namespace Regexp
{
	class Program
	{
		static void Main(string[] args)
		{
#if NAME_CHECK
			Console.Write("Input name: ");
			string name = "Vasya";
			//string name = Console.ReadLine();
			if (Regex.IsMatch(name, "[A-Z][a-z]{1,20}$"))
			{
				Console.WriteLine(name);
			}
			else
			{
				Console.WriteLine("Error: Bad name!");
			}
#endif
			Console.Write("Input group: ");
			string delim = "(_|\\s|-)";
			string group = "PS_VS_PV_34v";
			if(Regex.IsMatch(group, $"^(ST|PS{delim}(SB|VS)){delim}(PU|PV|ITU|ITV){delim}\\d{{2}}[abv]?$"))
			{
				Console.WriteLine(group);
			}
			else
			{
				Console.WriteLine("Error: Bad group");
			}
		}
	}
}
