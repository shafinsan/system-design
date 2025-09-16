using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Virtaul
{
	internal class Car:vehicle
	{
		public string Model { get; set; }
		public Car(string Name, int Speed,string Model):base(Name,Speed)
		{
			this.Model = Model;
		}
		public override void Start()
		{
			Console.WriteLine("Car is starting...also it is a overridden method");
		}
		public override void dispaly()
		{
			base.dispaly();
			Console.WriteLine("Model: " + Model);
		}

	}
}
