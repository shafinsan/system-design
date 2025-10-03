using ConsoleApp1.obserber.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.obserber.Interface
{
	internal interface IChennal
	{
		void Subscribe(Subscriber subscriber);
		void Unsubscribe(Subscriber subscriber);
		void notify(string st);
	}
}
