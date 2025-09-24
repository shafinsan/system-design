using ConsoleApp1.Folder.Simple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Simple.Classes
{
	internal class SimpleSimpleBurger:IBarger
	{
		public void prepared()
		{
			Console.WriteLine("Simple Simple Burger is prepared");
		}
	}
}
