using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part
{
	internal class User
	{
		public readonly IAccount Account;
		public User(IAccount _Account)
		{
			Account = _Account;
		}
		public void Deposite(int number)
		{
			Account.deposit(number);
		}
		public void Withdraw(int number)
		{
			Account.withdraw(number);
		}
	}
}
