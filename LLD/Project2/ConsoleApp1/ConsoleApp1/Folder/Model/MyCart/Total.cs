using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Model.MyCart
{
	internal class Total
	{
		private Cart cart=new Cart();
		public Total(Cart _cart)
		{
			cart = _cart;
		}
		public double TotalPrice()
		{
		
			double total= 0;
			foreach(var item in cart.data)
			{
				var menu=item.Value;
				foreach(var list in menu)
				{
					total+= list.Price;
				}
			}
			return total;
		}
	}
}
