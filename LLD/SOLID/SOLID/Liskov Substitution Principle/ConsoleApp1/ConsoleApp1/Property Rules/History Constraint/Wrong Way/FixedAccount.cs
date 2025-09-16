using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part
{
	internal class FixedAccount : IAccount
	{
		int balance = 0;	
		public FixedAccount(int initialBalance)
		{
			balance = initialBalance;
		}
		public void deposit(int amount)
		{
			balance += amount;
			Console.WriteLine("Deposited Account Deposited: " + amount);
			Console.WriteLine("Current Balance " + balance);
		}

		public void withdraw(int amount)
		{
			try
			{
				throw new Exception("Can't withdraw from fixed account");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
	}
}
