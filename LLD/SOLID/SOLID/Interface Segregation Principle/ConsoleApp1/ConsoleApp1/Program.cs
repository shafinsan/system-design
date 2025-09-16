
using ConsoleApp1.Classes;
using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			I3DInterface cube = new Cube(5);
			I2Dinterface ractangle = new Ractangle(5, 10);
			cube.Area();
			cube.Volume();
			ractangle.Area();
		}

	}
}
