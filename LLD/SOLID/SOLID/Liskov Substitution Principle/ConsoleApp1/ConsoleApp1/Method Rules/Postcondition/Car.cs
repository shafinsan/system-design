using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Method_Rules.Postcondition
{
	internal class Car
	{
		public int Speed { get; set; }
		public Car(int Speed) 
		{
			this.Speed = Speed;
		}
		public virtual void brake(int value)
		{
			Speed-=value;
			if(Speed<=0)Speed=0;
			Console.WriteLine();
			Console.WriteLine("**************** Car ******************");
			Console.WriteLine("Speed decresing");
			Console.WriteLine($"Current speed {Speed}");
			Console.WriteLine();
		}
	}
}
