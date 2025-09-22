using ConsoleApp1.Solution_1.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Solution_1.Classes.Save
{
	internal class SaveToDB:Isave
	{
		public void Save(IList<string> data)
		{
			Console.WriteLine("Data saved to database successfully.");
		}
	}
}
