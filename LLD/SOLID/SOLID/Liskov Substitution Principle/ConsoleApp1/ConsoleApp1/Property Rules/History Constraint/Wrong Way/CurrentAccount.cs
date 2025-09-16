using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part
{
	internal class CurrentAccount : IAccount
	{
		int balance = 0;
		public CurrentAccount(int initialBalance)
		{
			balance = initialBalance;
		}
		public void deposit(int amount)
		{
			balance+=amount;
			Console.WriteLine("Current Account Deposited: " + amount);
		}

		public void withdraw(int amount)
		{
			if (balance - amount <= 0)
			{
				Console.WriteLine("Current Account Insufficient Balance");
			}
			else
			{
				balance -= amount;
				Console.WriteLine("Current Account Withdrawn: " + amount);
				Console.WriteLine("Current Balance "+balance);
			}
		}
	}
}
