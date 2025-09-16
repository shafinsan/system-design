using ConsoleApp1.first_part.CurrecntWay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.first_part.CurrecntWay
{
	internal class FixedUser
	{
		public readonly IParent Account;
		public FixedUser(IParent _Account)
		{
			Account = _Account;
		}
		public void Deposite(int number)
		{
			Account.deposit(number);
		}
		

	}
}
