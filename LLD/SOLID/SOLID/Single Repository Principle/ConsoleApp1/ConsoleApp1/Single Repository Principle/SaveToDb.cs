using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Single_Repository_Principle
{
	public class SaveToDb
	{
		public Cart cart { get; set; }
		public SaveToDb(Cart cart)
		{
			this.cart = cart;
		}
		public void Save()
		{
			Console.WriteLine("Save to database...");
		}
	}
}
