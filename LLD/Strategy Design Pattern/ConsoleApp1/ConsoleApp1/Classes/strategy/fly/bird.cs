using ConsoleApp1.Classes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes.strategy.fly
{
	internal class bird: Ifly
	{
		public void fly()
		{
			Console.WriteLine("bird can fly");
		}
	}

}
