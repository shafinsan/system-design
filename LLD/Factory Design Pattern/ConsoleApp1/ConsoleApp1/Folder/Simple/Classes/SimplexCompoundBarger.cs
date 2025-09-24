using ConsoleApp1.Folder.Simple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Simple.Classes
{
	internal class SimplexCompoundBarger:IBarger
	{
		public void prepared()
		{
			Console.WriteLine("Simplex Compound Barger is prepared");
		}
	}
}
