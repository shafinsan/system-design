using application.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Car>list= new List<Car>()
			{
				new Car("Toyota", "Camry", 2018),
				new Car("Honda", "Civic", 2020),
				new Car("Ford", "Mustang", 2016)
			};
			foreach(var car in list)
			{
				Console.WriteLine("---------------"+car.Name+"--------------------------");
				car.DisplayInfo();
				Console.WriteLine("-----------------"+"End"+"---------------------------");
				Console.WriteLine();
			}

			Console.WriteLine("Total number of cars: " + Car.NumberOfCars);
			Console.WriteLine();
			Console.WriteLine();
			DisplayClass.displayData();

		}
	}
}
