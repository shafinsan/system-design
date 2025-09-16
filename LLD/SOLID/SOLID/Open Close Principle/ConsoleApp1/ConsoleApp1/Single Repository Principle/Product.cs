using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Single_Repository_Principle
{
	public class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public Product(string name, double price)
		{
			Name = name;
			Price = price;
		}
	}
}
