using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
	internal class Ractangle : IShape
	{
		public float a { get; set; }
		public float b { get; set; }
		public Ractangle(float a, float b)
		{
			this.a = a;
			this.b = b;
		}
		public void Area()
		{
			Console.WriteLine("Area of Ractangle: "+a*b);
		}
	}
}
