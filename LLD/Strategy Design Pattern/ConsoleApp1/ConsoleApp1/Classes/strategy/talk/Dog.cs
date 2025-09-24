using ConsoleApp1.Classes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes.strategy
{
	internal class Dog:Italk
	{
		public void talk()
		{
			Console.WriteLine("Dog can't talk");
		}
	}
}
