
using ConsoleApp1.Folder.Abstract;
using ConsoleApp1.Folder.Abstract.Factory;
using ConsoleApp1.Folder.Abstract.Factory.Interface;
using ConsoleApp1.Folder.Abstract.Interface;
using ConsoleApp1.Folder.Interface;
using ConsoleApp1.Folder.Method;
using ConsoleApp1.Folder.Simple;
using ConsoleApp1.Folder.Simple.Interface;
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
			IFactory fc = new SimpleFactory();
			IBarger bg = fc.getObject("SimpleSimpleBurger");
			if (bg == null)
			{
				Console.WriteLine("No Burger");
			}
			else
			{
				bg.prepared();
			}
			Console.WriteLine();
			Console.WriteLine("************* Method Factory *************");
			Console.WriteLine();

			IFactory fc1 = new FactoryMethod();
			IBarger bg1 = fc1.getObject("MthodComplexBurger");
			if (bg1 == null)
			{
				Console.WriteLine("No Burger");
			}
			else
			{
				bg1.prepared();
			}



			Console.WriteLine();
			Console.WriteLine("************* Abstract Factory *************");
			Console.WriteLine();

			IAbstractInterface abs1 = new GarlicBread();
			IAbstractInterface abs2 = new SinghBurger();
			IBurger bar1= abs2.CreateBurger("BasicBurger");
			IGarlicBread gali1= abs2.CreateGarlicBread("CheeseGarlicBread");
			IBurger bar2=abs1.CreateBurger("StandardWheatBurger");
			IGarlicBread gali2=abs1.CreateGarlicBread("BasicWheatGarlicBread");

			if (bar1 == null)
			{
				Console.WriteLine("No Burger");
			}
			else
			{

				bar1.prepaired();
			}

			gali1.prepaired();
			bar2.prepaired();
			gali2.prepaired();
		}

	}
}
