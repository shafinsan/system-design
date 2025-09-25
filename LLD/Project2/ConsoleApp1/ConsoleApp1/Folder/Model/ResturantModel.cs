using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Model
{
	internal class ResturantModel
	{
		public static int Id=0;
		public int resturantId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public List<MenuModel> Menu = new List<MenuModel>();
		public ResturantModel( string name, string address)
		{

			Name = name;
			Address = address;
			resturantId = ++Id;
		}
		public void AddMenu(MenuModel menu)
		{
			Menu.Add(menu);
		}
	}
}
