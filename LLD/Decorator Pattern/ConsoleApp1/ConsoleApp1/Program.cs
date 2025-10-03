
using ConsoleApp1.Decorator.Classes;
using ConsoleApp1.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ICharacter miro = new Miro();
			Console.WriteLine(miro.GetAttribute());
			ICharacter gunPower = new GunPower(miro);
			Console.WriteLine(gunPower.GetAttribute());
			ICharacter heightUp = new HeightUp(gunPower);
			Console.WriteLine(heightUp.GetAttribute());
			Console.WriteLine("***********************");
			ICharacter shrine = new Shrine(new GunPower(new Shrine(new Miro())));
			Console.WriteLine(shrine.GetAttribute());
		}

	}
}
