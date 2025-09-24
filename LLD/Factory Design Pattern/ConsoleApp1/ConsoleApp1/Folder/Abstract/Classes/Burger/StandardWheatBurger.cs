using ConsoleApp1.Folder.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Abstract.Classes.Burger
{
	internal class StandardWheatBurger: IBurger
	{
		public void prepaired()
		{
			Console.WriteLine("Standard Wheat Burger is Prepaired");
		}
	}
	
}
