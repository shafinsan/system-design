using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part
{
	internal class DepositeAccount : IAccount
	{
		int balance = 0;
		public DepositeAccount(int initialBalance)
		{
			balance = initialBalance;
		}
		public void deposit(int amount)
		{
			balance += amount;
			Console.WriteLine("Deposited Account Deposited: " + amount);
		}

		public void withdraw(int amount)
		{
			if (balance - amount <= 0)
			{
				Console.WriteLine("Deposited Account Insufficient Balance");
			}
			else
			{
				balance -= amount;
				Console.WriteLine("Deposited Account Withdrawn: " + amount);
				Console.WriteLine("Current Balance " + balance);
			}
		}
	}
}
