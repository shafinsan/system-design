
using ConsoleApp1.Classes;
using ConsoleApp1.Classes.strategy;
using ConsoleApp1.Classes.strategy.fly;
using ConsoleApp1.Classes.strategy.walk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyController myController=new MyController(new Human(),new dolpin(),new Fish());
			myController.flyFunction();
			myController.talkFunction();
			myController.walkFunction();
		}

	}
}
