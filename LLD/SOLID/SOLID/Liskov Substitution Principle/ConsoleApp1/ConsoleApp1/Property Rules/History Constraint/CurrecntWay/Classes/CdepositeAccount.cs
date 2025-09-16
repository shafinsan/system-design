using ConsoleApp1.first_part.CurrecntWay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part.CurrecntWay.Classes
{
	internal class CdepositeAccount:IChild
	{
		int balance = 0;
		public CdepositeAccount(int initialBalance)
		{
			balance = initialBalance;
		}
		public void deposit(int amount)
		{
			Console.WriteLine();
			balance += amount;
			Console.WriteLine("Deposite Account Deposited: " + amount);
			Console.WriteLine();
		}

		public void withdraw(int amount)
		{
			if (balance - amount <= 0)
			{
				Console.WriteLine();
				Console.WriteLine("Deposite Account Insufficient Balance");
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine();
				balance -= amount;
				Console.WriteLine("Deposite Account Withdrawn: " + amount);
				Console.WriteLine("Current Balance " + balance);
				Console.WriteLine();
			}
		}
	}
}
