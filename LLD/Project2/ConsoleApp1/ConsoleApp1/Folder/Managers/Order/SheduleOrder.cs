using ConsoleApp1.Folder.Interface;
using ConsoleApp1.Folder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Managers.Order
{
	internal class SheduleOrder:Iorderfactory
	{
		DateTime time=new DateTime();
		public SheduleOrder()
		{
			time= time = DateTime.Now;
		}
		public SheduleOrder(DateTime _time)
		{
			time = _time;
		}
		public void CreateOrder(Cart _cart, User user, bool payment,double total)
		{
			Console.WriteLine();
			Console.WriteLine("Order type is shedule");
			Console.WriteLine("===================================");
			Console.WriteLine("Your order is sheduled");
			Console.WriteLine($"Shedule at {time.ToString("hh:mm:ss tt")}");
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
				
			}
			else
			{
				Console.WriteLine("Payment Pending");
				Console.WriteLine($"Total Amount: {total}");
			}
		}
	}
}
