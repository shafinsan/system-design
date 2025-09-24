using ConsoleApp1.Classes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
	internal class MyController
	{
		public Iwalk walki { get; set; }
		public Italk talki { get; set; }

		public Ifly flyi { get; set; }
		public MyController(Italk talki, Ifly flyi,Iwalk walki)
		{
			this.talki = talki;
			this.flyi = flyi;
			this.walki = walki;
		}
		public void walkFunction()
		{
			walki.walk();
		}
		public void talkFunction()
		{
			talki.talk();
		}
		public void flyFunction()
		{
			flyi.fly();
		}
	}
}
