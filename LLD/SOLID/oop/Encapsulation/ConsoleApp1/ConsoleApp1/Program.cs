using ConsoleApp1.Abstract;
using ConsoleApp1.Interface;
using ConsoleApp1.Virtaul;
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
			Console.WriteLine();
			Console.WriteLine("*********** Virtual ************");
			Console.WriteLine();
			vehicle v = new vehicle("Bike", 60);
			v.dispaly();
			v.Start();
			Console.WriteLine();
			Console.WriteLine("***********************");
			Console.WriteLine();
			vehicle car=new Car("Audi", 200, "Q7");
			car.dispaly();
			car.Start();

			Console.WriteLine();
			Console.WriteLine("*********** Abstract ************");
			Console.WriteLine();
			Person s = new Student("Elias",25,1);
			Person t = new Teacher("John", 35, 101);
			Console.WriteLine();
			Console.WriteLine("*********** Student Information ************");
			Console.WriteLine();
			s.display();
			Console.WriteLine();
			Console.WriteLine("***********************");
			Console.WriteLine();

			Console.WriteLine();
			Console.WriteLine("*********** Teacher Information ************");
			Console.WriteLine();
			t.display();
			Console.WriteLine();
			Console.WriteLine("***********************");
			Console.WriteLine();


			Console.WriteLine();
			Console.WriteLine("********** Interface *************");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("********** Triangle *************");
			Console.WriteLine();
			Console.WriteLine();
			IShape triangle = new Triangle(5, 10,5);
			IShape ractangle = new Ractangle(5, 10);
			triangle.Area();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("********** Ractangle *************");
			Console.WriteLine();
			Console.WriteLine();
			ractangle.Area();
			Console.WriteLine();
			Console.WriteLine();



		}

	}
}
