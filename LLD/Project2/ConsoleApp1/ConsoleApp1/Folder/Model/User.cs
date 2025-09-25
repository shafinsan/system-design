using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Model
{
	internal class User
	{
		public static int id { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public Cart cart { get; set; }
		public User(string _Name,Cart _cart)
		{
			Id = ++id;
			Name = _Name;
			cart = _cart;
		}


	}
}
