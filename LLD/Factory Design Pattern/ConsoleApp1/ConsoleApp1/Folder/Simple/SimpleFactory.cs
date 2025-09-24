using ConsoleApp1.Folder.Interface;
using ConsoleApp1.Folder.Simple.Classes;
using ConsoleApp1.Folder.Simple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Simple
{
	internal class SimpleFactory: IFactory
	{
		public string type { get; set; }
		public SimpleFactory(){}
		public IBarger getObject(string type)
		{
			if (type == "SimpleComplexBurger")
			{
				return new SimpleComplexBurger();
			}
			else if (type == "SimpleSimpleBurger")
			{
				return new SimpleSimpleBurger();
			}
			else if (type == "SimplexCompoundBarger")
			{
				return new SimplexCompoundBarger();
			}
			else
			{
				return null;
			}
		}
	}
}
