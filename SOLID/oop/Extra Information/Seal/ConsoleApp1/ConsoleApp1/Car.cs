using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public sealed class Car
	{
		public string Name { get;  }
		public string Model { get; }
		public int Year { get; }
		public Car(string Name,string Model,int Year)
		{
			this.Name = Name;
			this.Model = Model;
			this.Year = Year;
		}
		public void DisplayInfo()
		{
			Console.WriteLine($"Car Name: {Name}, Model: {Model}, Year: {Year}");
		}

	}
}
