using ConsoleApp1.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Decorator.Classes
{
	internal class Shrine:IDecorator
	{
		public ICharacter miro = new Miro();
		public Shrine(ICharacter miro){
			this.miro = miro;
		}
		public string GetAttribute()
		{
			return $"{miro.GetAttribute()} Shrine Power Added";
		}
	}
}
