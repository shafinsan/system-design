using ConsoleApp1.Folder.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Abstract.Classes.Burger
{
	internal class PremiumWheatBurger:IBurger
	{
		public void prepaired()
		{
			Console.WriteLine("Premium Wheat Burger is Prepaired");
		}
	}
}
