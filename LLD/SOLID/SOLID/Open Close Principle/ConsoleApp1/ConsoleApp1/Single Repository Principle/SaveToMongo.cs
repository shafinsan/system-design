using ConsoleApp1.Single_Repository_Principle;
using ConsoleApp1.Single_Repository_Principle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class SaveToMongo:IDbSave
	{
		public Cart cart { get; set; }
		public string Name { get; set; }
		public SaveToMongo(string Name, Cart cart)
		{
			this.Name = Name;
			this.cart = cart;
		}
		public void Save()
		{
			Console.WriteLine($"Save to database {Name}");
		}
	}
}
