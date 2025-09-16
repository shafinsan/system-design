using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Property_Rules.Class_Invariant
{
	internal class Account
	{
		public int Balance { get; set; }
		public Account(int Balance)
		{
			if (Balance <= 0)
			{
				Console.WriteLine("Balance can not be less or equal zero");
			}
			else
			{
				this.Balance = Balance;
			}
		}
		public void Deposite(int amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine("Deposit amount must be greater than zero");
			}
			else
			{
				Balance += amount;
				Console.WriteLine("Deposited: " + amount);
				Console.WriteLine("Current Balance " + Balance);
			}
		}
		public virtual void display()
		{
			Console.WriteLine();
			Console.WriteLine("Current account balance is :"+Balance);
			Console.WriteLine();
		}
	}
}
