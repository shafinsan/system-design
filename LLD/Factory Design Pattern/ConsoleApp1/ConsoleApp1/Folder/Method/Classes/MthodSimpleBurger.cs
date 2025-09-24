using ConsoleApp1.Folder.Simple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Method.Classes
{
	internal class MthodSimpleBurger:IBarger
	{
		public void prepared()
		{
			Console.WriteLine("Method Simple Burger is prepared");
		}
	}
}
