using ConsoleApp1.Folder.Managers.Resturant;
using ConsoleApp1.Folder.Model.MyCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Model
{
	internal class Cart
	{
		public Dictionary<ResturantModel,List<MenuModel>> data { get; set; } =new Dictionary<ResturantModel, List<MenuModel>>();
		public void AddtoCart(ResturantManager res,int res_id,int menu_id)
		{
			foreach(var item in res.resturantModels)
			{
				if (item.resturantId == res_id)
				{
					foreach (var menu in item.Menu)
					{
						if (menu.MenuId == menu_id)
						{
							if (data.ContainsKey(item))
							{
								data[item].Add(menu);
							}
							else
							{
								data.Add(item, new List<MenuModel>() { menu });
							}
						}
					}
				}
			}
			return;
		}
		public void ShowCart()
		{
			foreach (var item in data)
			{
				Console.WriteLine();
				Console.WriteLine($"************************ {item.Key.Name} ************************");
				Console.WriteLine($"Resturant Id: {item.Key.resturantId}, Name: {item.Key.Name}, Address: {item.Key.Address}");
				foreach (var c in item.Value)
				{
					Console.WriteLine($"\tMenu Id: {c.MenuId}, Name: {c.Name}, Price: {c.Price}");
				}
				Console.WriteLine("******************************** End ********************************");
				Console.WriteLine();
			}
		}
	}
}
