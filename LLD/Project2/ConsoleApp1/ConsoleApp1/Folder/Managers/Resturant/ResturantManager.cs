using ConsoleApp1.Folder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Managers.Resturant
{
	internal class ResturantManager
	{
		public static ResturantManager _instance = null;
		public static object obj = new object();
		private ResturantManager() { }
		public static ResturantManager Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (obj)
					{
						if (_instance == null)
						{
							_instance = new ResturantManager();
						}
					}
				}
				return _instance;
			}
			
		}
		public List<ResturantModel> resturantModels { set; get; } = new List<ResturantModel>();
	
		public void Add(ResturantModel resturantModel,MenuModel menu=null)
		{
			if (menu!=null)
			{
				menu.ResturantId = resturantModel.resturantId;
				resturantModel.AddMenu(menu);
			}

			resturantModels.Add(resturantModel);
		}
		public void GetAll()
		{
			foreach (var item in resturantModels)
			{
				Console.WriteLine();
				Console.WriteLine($"************************ {item.Name} ************************");
				Console.WriteLine($"Resturant Id: {item.resturantId}, Name: {item.Name}, Address: {item.Address}");
				foreach(var c in item.Menu)
				{
					Console.WriteLine($"\tMenu Id: {c.MenuId}, Name: {c.Name}, Price: {c.Price}");
				}
				Console.WriteLine("******************************** End ********************************");
				Console.WriteLine();
			}
		}
		public void GetByLocation(string name)
		{
			Console.WriteLine();
			Console.WriteLine($"************************ Search Result ************************");
			foreach (var item in resturantModels)
			{

				if(item.Address.ToLower().Contains(name.ToLower()))
				{
					Console.WriteLine($"Resturant Id: {item.resturantId}, Name: {item.Name}, Address: {item.Address}");
					foreach (var c in item.Menu)
					{
						Console.WriteLine($"\tMenu Id: {c.MenuId}, Name: {c.Name}, Price: {c.Price}");
					}
				}
				
			}
			Console.WriteLine();
			Console.WriteLine($"************************* End ***************************");
		}
		
		
	}
}
