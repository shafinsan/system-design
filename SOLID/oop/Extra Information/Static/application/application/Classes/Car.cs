using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Classes
{
	public class Car
	{
		private string CarName;
		private string CarModel;
		private int CarYear;
		public static int NumberOfCars;
		static Car()
		{
			NumberOfCars = 5;
		}
		public Car(string name, string model, int year)
		{
			CarName = name;
			CarModel = model;
			CarYear = year;
			NumberOfCars++;
		}
		public string Name
		{
			set
			{
				CarName = value;
			}
			get
			{
				return CarName;
			}
		}
		public string Model
		{
			set
			{
				CarModel = value;
			}
			get
			{
				return CarModel;
			}
		}
		public int Year
		{
			set
			{
				if(value>2015)
				{
					CarYear = value;
				}
				else
				{
					CarYear = 2015;
				}
			}
			get
			{
				return CarYear;
			}
		}
		public void DisplayInfo()
		{
			Console.WriteLine("Car Name: " + CarName);
			Console.WriteLine("Car Model: " + CarModel);
			Console.WriteLine("Car Year: " + CarYear);
		}
	}
}
