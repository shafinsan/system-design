using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Model
{
	internal class MenuModel
	{
		public static int Id = 0;
		public int MenuId { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public int ResturantId { get; set; }
		public MenuModel(string name, double price, int resturantId)
		{
			Id++;
			MenuId = Id;
			Name = name;
			Price = price;
			ResturantId = resturantId;
		}
	}
}
