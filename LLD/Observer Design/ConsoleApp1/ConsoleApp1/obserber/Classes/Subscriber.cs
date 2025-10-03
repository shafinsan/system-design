using ConsoleApp1.obserber.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.obserber.Classes
{
	internal class Subscriber:ISubscriber
	{
		public string Name { get; set; }
		public Subscriber(string Name)
		{
			this.Name = Name;
		}
		public void update(string st)
		{
			Console.WriteLine($"Hi {Name} our new video uploaded on our youtube chennal, title :{st}");
		}
	}
}
