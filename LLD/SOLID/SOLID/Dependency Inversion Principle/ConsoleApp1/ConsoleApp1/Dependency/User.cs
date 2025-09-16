using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dependency
{
	internal class User
	{
		public readonly IDatabase _database;
		public User(IDatabase database)
		{
			_database = database;
		}
		public void Save()
		{
			_database.Save();
		}
	}
}
