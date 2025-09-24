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
	internal class GarlicBread:IAbstractInterface
	{
	
		public IBurger CreateBurger(string type)
		{
			if (type.Equals("BasicWheatBurger"))
			{
				return new BasicWheatBurger();
			}
			else if (type.Equals("PremiumWheatBurger"))
			{
				return new PremiumWheatBurger();
			}
			else if (type.Equals("StandardWheatBurger"))
			{
				return new StandardWheatBurger();
			}
			else
			{
				return null;
			}
		}
		public IGarlicBread CreateGarlicBread(string type)
		{
			if (type.Equals("BasicWheatGarlicBread"))
			{
				return new BasicWheatGarlicBread();
			}
			else if (type.Equals("CheeseWheatGarlicBread"))
			{
				return new CheeseWheatGarlicBread();
			}
			else
			{
				return null;
			}
		}
	}
}
