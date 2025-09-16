using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Single_Repository_Principle
{
	public class InvokePrinter
	{
		public Cart cart { get; set; }
		public InvokePrinter(Cart cart)
		{
			this.cart = cart;
		}
		public void Dispaly()
		{
			foreach(var c in cart.product)
			{
				Console.WriteLine();
				Console.WriteLine("**************************");
				Console.WriteLine();
				Console.WriteLine("Product Name: " + c.Name + " Price: " + c.Price);
				Console.WriteLine();
				Console.WriteLine("**************************");
				Console.WriteLine();
			}
		}
	}
}
