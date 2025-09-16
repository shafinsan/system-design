using ConsoleApp1.first_part.CurrecntWay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part.CurrecntWay
{
	internal class CurrentUser
	{
		public readonly IChild Account;
		public CurrentUser(IChild _Account)
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
