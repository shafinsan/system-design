using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
	public class Cube:I3DInterface
	{
		public int a { get; set; }
		public Cube(int a)
		{
			this.a = a;
		}
		public void Area()
		{
			Console.WriteLine("Area of Cube: " + 6 * a * a);
		}
		public void Volume()
		{
			Console.WriteLine("Volume of Cube: " + a * a * a);
		}
	}
}
