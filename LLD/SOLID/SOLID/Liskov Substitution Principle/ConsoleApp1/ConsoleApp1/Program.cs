

using ConsoleApp1.first_part;
using ConsoleApp1.first_part.CurrecntWay;
using ConsoleApp1.first_part.CurrecntWay.Classes;
using ConsoleApp1.Method_Rules.Postcondition;
using ConsoleApp1.Property_Rules.Class_Invariant;
using ConsoleApp1.Second_Part;
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
			Console.WriteLine("******************* Wrong Way ********************");
			Console.WriteLine();
			User user1 = new User(new FixedAccount(800));
			user1.Deposite(1000);
			user1.Withdraw(500);
			Console.WriteLine();
			Console.WriteLine("******************* Currect Way ********************");
			Console.WriteLine();

			CurrentUser user2 = new CurrentUser(new CcurrentAccount(4000));
			CurrentUser user3 = new CurrentUser(new CdepositeAccount(1000));
			FixedUser user4 = new FixedUser(new CfixedAccount(2000));
			user2.Deposite(2000);
			user3.Deposite(3000);
			user4.Deposite(4000);
			user2.Withdraw(1000);
			user3.Withdraw(2000);
			Console.WriteLine();
			Console.WriteLine("******************* Precondition ********************");
			AdminPass admin = new AdminPass();
			admin.CreateAdmin("eliasjabershafin");
			AdminPass client = new UserPass();
			client.CreateAdmin("eliasja");
			Console.WriteLine();
			Console.WriteLine("****************** Postcondition *********************");
			Car c1 = new Car(30);
			Car c2	= new HybridCar(40,20);
			c1.brake(10);
			c2.brake(20);

			Console.WriteLine();
			Console.WriteLine("****************** Class invarient *********************");
			Account account = new Account(500);
			Cheat account1 = new Cheat(0);
			account.display();
			account1.AddNegativeBalance(-100);
			account1.display();
		}

	}
}
