using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
	internal class Ractangle:I2Dinterface
	{
		public int a { get; set; }
		public int b { get; set; }
		public Ractangle(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public void Area()
		{
			Console.WriteLine("Area of ractangle: " + a * b);
		}
	}
}
