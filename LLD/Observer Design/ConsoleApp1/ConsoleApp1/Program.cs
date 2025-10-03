
using ConsoleApp1.obserber.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Subscriber s1 = new Subscriber("Elias");
			Subscriber s2 = new Subscriber("Kebede");
			Chennal c1 = new Chennal("Tech with Elias");
			Chennal c2 = new Chennal("Tech with Halal IT");
			Subscriber s3 = new Subscriber("Halal vai");
			c2.Subscribe(s3);
			c2.uploadVideo("Singleton Design Pattern in C#");
			c1.Subscribe(s1);
			c1.Subscribe(s2);
			c1.uploadVideo("Observer Design Pattern in C#");
			Console.WriteLine("---------------------------------------------------");
			c1.Unsubscribe(s1);
			c1.uploadVideo("Factory Design Pattern in C#");
			c2.uploadVideo("Decorator Design Pattern in C#");
		}

	}
}
