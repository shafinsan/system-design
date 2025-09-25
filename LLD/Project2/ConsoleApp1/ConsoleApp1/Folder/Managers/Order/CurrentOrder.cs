using ConsoleApp1.Folder.Interface;
using ConsoleApp1.Folder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Managers.Order
{
	internal class CurrentOrder:Iorderfactory
	{
		
		public bool payment = false;
		public CurrentOrder()
		{
			
		}
		public void CreateOrder(Cart _cart,User user, bool payment, double total)
		{
			Console.WriteLine();
			Console.WriteLine("===================================");
			Console.WriteLine("Order type is current");
			Console.WriteLine("===================================");
			Console.WriteLine();

			foreach (var item in _cart.data)
			{
				var value = item.Value;
				Console.WriteLine($"User Name: {user.Name}");
				Console.WriteLine("Resturant name :", item.Key.Name);
				foreach (var list in value)
				{
					Console.WriteLine($"Product Name: {list.Name} | Price: {list.Price} | Quantity: {list.MenuId}");
				}
			}
			if (payment) 
			{
				
				Console.WriteLine("Payment successfull");
				Console.WriteLine($"Total Amount: {total}");
			}
			else
			{
				Console.WriteLine("Payment Pending");
			}
		}
	}
}
