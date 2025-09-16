using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Method_Rules.Postcondition
{
	internal class HybridCar:Car
	{
		public int Charge { get; set; }
		public HybridCar(int Speed, int charge):base(Speed)
		{
			Charge = charge;
		}
		public override void brake(int value)
		{
			Speed-=(int)value;
			Charge += value;
			Console.WriteLine();
			Console.WriteLine("**************** Hybrid Car *******************");
			Console.WriteLine("Current speed "+Speed);
			Console.WriteLine("Charge "+ Charge);
			Console.WriteLine();
		}
		
	}
}
