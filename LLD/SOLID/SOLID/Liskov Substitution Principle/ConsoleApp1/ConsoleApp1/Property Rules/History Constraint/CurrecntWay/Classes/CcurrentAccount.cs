using ConsoleApp1.first_part.CurrecntWay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part.CurrecntWay.Classes
{
	internal class CcurrentAccount:IChild
	{
		int balance = 0;
		public CcurrentAccount(int initialBalance)
		{
			balance = initialBalance;
		}
		public void deposit(int amount)
		{
			Console.WriteLine();
			balance += amount;
			Console.WriteLine("Current Account Deposited: " + amount);
			Console.WriteLine();
		}

		public void withdraw(int amount)
		{
			Console.WriteLine();
			if (balance - amount <= 0)
			{
				Console.WriteLine("Current Account Insufficient Balance");
			}
			else
			{
				balance -= amount;
				Console.WriteLine("Current Account Withdrawn: " + amount);
				Console.WriteLine("Current Balance " + balance);
			}
			Console.WriteLine();
		}
	}
}
