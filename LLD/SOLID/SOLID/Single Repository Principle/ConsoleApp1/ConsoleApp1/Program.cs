using ConsoleApp1.Single_Repository_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Product p1=new Product("Laptop", 45000);
			Product p3 = new Product("New Product", 49000);
			Product p2 = new Product("Mobile", 25000);
			List<Product> products = new List<Product>()
			{
				p1,p2
			};
			Cart cart = new Cart(products);
			InvokePrinter invokePrinter = new InvokePrinter(cart);
			SaveToDb saveToDb = new SaveToDb(cart);
			cart.PrintTotal();
			invokePrinter.Dispaly();
			saveToDb.Save();
		}	

	}
}
