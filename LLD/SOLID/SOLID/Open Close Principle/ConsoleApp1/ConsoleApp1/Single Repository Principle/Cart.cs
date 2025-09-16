using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Single_Repository_Principle
{
	public class Cart
	{
		public List<Product> product { get; set; }
		public Cart(List<Product>product)
		{
			this.product = product;
		}
		public void PrintTotal()
		{
			double total = 0;
			foreach (var item in product)
			{
				total += item.Price;
			}
			Console.WriteLine("Total Price: " + total);
		}
	}
}
