using ConsoleApp1.Folder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Interface
{
	internal interface Iorderfactory
	{
		void CreateOrder(Cart _cart, User user, bool payment,double total);
	}
}
