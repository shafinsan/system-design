using ConsoleApp1.Folder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Managers.payment
{
	internal class Pay
	{
		public INagad nagad;
		public IBikash bikash;
		public Pay(INagad _nagad,IBikash _bikash)
		{
			nagad = _nagad;
			bikash = _bikash;
		}
		public bool MakeNagadPayment()
		{
			nagad.MakePayment();
			return true;
		}
		public bool MakeBikashPayment()
		{
			bikash.MakePayment();
			return true;
		}
	}
}
