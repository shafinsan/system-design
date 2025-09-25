using ConsoleApp1.Folder.Interface;
using ConsoleApp1.Folder.Managers.payment;
using ConsoleApp1.Folder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Managers.Order
{
	internal class Order:Iorder
	{
		public readonly User user = new User(null,null);
		public readonly Cart cart = new Cart();
		public bool payment=false;
		

		public Order(User _user, Cart _cart, bool pay=false)
		{
			user = _user;
			cart = _cart;
			payment = pay;

		}
		public Iorderfactory getType(string type)
		{
			if(type=="current")
			{
				return new CurrentOrder();
			}
			else if(type=="shedule")
			{
				return new SheduleOrder();
			}
			return null;
		}
		
	}
}
