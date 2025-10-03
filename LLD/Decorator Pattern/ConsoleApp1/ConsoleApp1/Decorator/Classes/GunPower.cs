using ConsoleApp1.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Decorator.Classes
{
	internal class GunPower:IDecorator
	{
		public ICharacter miro = new Miro();
		public GunPower(ICharacter miro)
		{
			this.miro = miro;
		}
		public string GetAttribute()
		{
			return $"{miro.GetAttribute()} Gun Power Added";
		}
	}
}
