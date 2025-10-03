using ConsoleApp1.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Decorator.Classes
{
	internal class Miro:ICharacter
	{
		public string GetAttribute()
		{
			return "Basic Miro";
		}
	}
}
