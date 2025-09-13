using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Virtaul
{
	public class vehicle
	{
		public string Name { get; set; }
		public int Speed { get; set; }
		public vehicle(string Name,int Speed)
		{
			this.Name = Name;
			this.Speed = Speed;
		}
		public virtual void Start()
		{
			Console.WriteLine("Vehicle is starting...also it is a virtual method");
		}
		public virtual void dispaly()
		{
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Speed: " + Speed);
		}
	}
}
