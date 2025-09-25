
using ConsoleApp1.Folder.Interface;
using ConsoleApp1.Folder.Managers.Order;
using ConsoleApp1.Folder.Managers.payment;
using ConsoleApp1.Folder.Managers.Resturant;
using ConsoleApp1.Folder.Model;
using ConsoleApp1.Folder.Model.MyCart;
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
			//create resturant manager
			ResturantManager resturantManager = ResturantManager.Instance;
			ResturantModel r1 = new ResturantModel("KFC", "Baku");
			ResturantModel r2 = new ResturantModel("McDonalds", "Ganja");
			ResturantModel r3 = new ResturantModel("Burger King", "Sumqayit");
			MenuModel m1 = new MenuModel("Zinger", 5.0, 1);
			MenuModel m2 = new MenuModel("Big Mac", 6.0, 2);
			MenuModel m3 = new MenuModel("Whopper", 7.0, 3);
			MenuModel m4 = new MenuModel("Fries", 2.0, 1);
			MenuModel m5 = new MenuModel("Nuggets", 3.0, 2);
			MenuModel m6 = new MenuModel("Coke", 1.0, 3);
			r1.AddMenu(m1);
			r1.AddMenu(m4);
			r2.AddMenu(m2);
			r2.AddMenu(m5);
			r3.AddMenu(m3);
			r3.AddMenu(m6);
			resturantManager.Add(r1);
			resturantManager.Add(r2);
			resturantManager.Add(r3);
			resturantManager.GetAll();
			ResturantModel resturantModel = new ResturantModel("New Resturant", "New Address 123");
			MenuModel menuModel = new MenuModel("New Menu", 15.99, resturantModel.resturantId);
			resturantManager.Add(resturantModel, menuModel);
			resturantManager.GetAll();
			//user can add to cart
			Cart cart=new Cart();
			cart.AddtoCart(resturantManager,2,2);
			cart.AddtoCart(resturantManager, 2, 5);
			cart.ShowCart();
			Total total = new Total(cart);
			double taka=total.TotalPrice();
			Console.WriteLine($"Total Price: {taka}");
			Console.WriteLine();
			// payment and order
			Console.WriteLine("********** Payment and Order **********");
			Console.WriteLine();
			User user = new User("Elias",cart);
			Order order=new Order(user,cart,false);
			Pay pay = new Pay(new Nagad(),new Bikash());
			bool payment = pay.MakeNagadPayment();
			Iorderfactory factory= order.getType("current");
			factory.CreateOrder(cart, user, payment,total.TotalPrice());

		}

	}
}
