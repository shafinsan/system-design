using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Property_Rules.Class_Invariant
{
	internal class Cheat:Account
	{
		public Cheat(int Balance) : base(Balance)
		{

		}
		public void AddNegativeBalance(int amount)
		{
			Balance -= amount;
			Console.WriteLine("Cheated: " + amount);
			Console.WriteLine("Current Balance " + Balance);
		}
		public override void display()
		{
			Console.WriteLine();
			Console.WriteLine("Cheat account balance is :" + Balance);
			Console.WriteLine();
		}
	}
}
