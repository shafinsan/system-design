using ConsoleApp1.Folder.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Abstract.Factory.Interface
{
	internal interface IAbstractInterface
	{
		IBurger CreateBurger(string type);
		IGarlicBread CreateGarlicBread(string type);
	}
}
