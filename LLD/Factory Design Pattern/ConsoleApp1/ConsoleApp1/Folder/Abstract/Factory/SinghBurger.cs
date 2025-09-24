using ConsoleApp1.Folder.Abstract.Classes.Burger;
using ConsoleApp1.Folder.Abstract.Classes.GarlicBread;
using ConsoleApp1.Folder.Abstract.Factory.Interface;
using ConsoleApp1.Folder.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Abstract.Factory
{
	internal class SinghBurger:IAbstractInterface
	{

		public IBurger CreateBurger(string type)
		{
			if (type.Equals("BasicBurger"))
			{
				return new BasicBurger();
			}
			else if (type.Equals("PremiumBurger"))
			{
				return new PremiumBurger();
			}
			else if (type.Equals("StandardBurger"))
			{
				return new StandardBurger();
			}
			else
			{
				return null;
			}
		}
		public IGarlicBread CreateGarlicBread(string type)
		{
			if (type.Equals("BasicGarlicBread"))
			{
				return new BasicGarlicBread();
			}
			else if (type.Equals("CheeseGarlicBread"))
			{
				return new CheeseGarlicBread();
			}
			else
			{
				return null;
			}
		}
	}
}
