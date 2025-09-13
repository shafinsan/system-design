using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
	internal class Triangle : IShape
	{
		public float a { get; set; }
		public float b { get; set; }
		public float c { get; set; }
		public Triangle(float a, float b, float c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
		public void Area()
		{
			Console.WriteLine("Triangle :"+a*b*c);	
		}
	}
}
