using ConsoleApp1.Folder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Managers.payment
{
	internal class Bikash:IBikash
	{
		public void MakePayment()
		{
			Console.WriteLine("Payment made through Bikash.");
		}
	}
}
