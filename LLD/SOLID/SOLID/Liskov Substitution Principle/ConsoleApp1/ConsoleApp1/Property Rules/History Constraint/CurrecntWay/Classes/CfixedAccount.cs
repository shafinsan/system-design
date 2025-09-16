using ConsoleApp1.first_part.CurrecntWay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part.CurrecntWay.Classes
{
	internal class CfixedAccount:IParent
	{
		int balance = 0;
		public CfixedAccount(int initialBalance)
		{
			balance = initialBalance;
		}
		public void deposit(int amount)
		{
			balance += amount;
			Console.WriteLine();
			Console.WriteLine("Fixed Account Deposited: " + amount);
			Console.WriteLine("Current Balance " + balance);
			Console.WriteLine();
		}

	}
}
