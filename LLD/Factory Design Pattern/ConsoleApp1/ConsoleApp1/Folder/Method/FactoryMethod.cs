using ConsoleApp1.Folder.Interface;
using ConsoleApp1.Folder.Method.Classes;
using ConsoleApp1.Folder.Simple.Classes;
using ConsoleApp1.Folder.Simple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Method
{
	internal class FactoryMethod:IFactory
	{
		public string type { get; set; }
		public FactoryMethod() { }
		public IBarger getObject(string type)
		{
			if (type == "MthodComplexBurger")
			{
				return new MthodComplexBurger();
			}
			else if (type == "MthodCompoundBarger")
			{
				return new MthodCompoundBarger();
			}
			else if (type == "MthodSimpleBurger")
			{
				return new MthodSimpleBurger();
			}
			else
			{
				return null;
			}
		}
	}
}
