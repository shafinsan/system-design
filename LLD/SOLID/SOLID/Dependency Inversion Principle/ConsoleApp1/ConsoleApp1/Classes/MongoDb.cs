using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
	internal class MongoDb:IDatabase
	{
		public void Save()
		{
			Console.WriteLine("Saved to MongoDB Database");
		}
	}
}
