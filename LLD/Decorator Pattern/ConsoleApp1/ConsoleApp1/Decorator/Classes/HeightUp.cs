using ConsoleApp1.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Decorator.Classes
{
	internal class HeightUp:IDecorator
	{
		public ICharacter miro= new Miro();
		public HeightUp(ICharacter miro)
		{
			this.miro = miro;
		}
		public string GetAttribute()
		{
			return $"{miro.GetAttribute()} Height Up Added";
		}
	}
}
