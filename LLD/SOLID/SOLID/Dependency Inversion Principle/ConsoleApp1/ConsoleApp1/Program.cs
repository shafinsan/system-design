

using ConsoleApp1.Classes;
using ConsoleApp1.Dependency;
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
			User user1 = new User(new MongoDb());
			User user2 = new User(new SqlDb());
			User user3 = new User(new MsSqlDb());
			user1.Save();
			user2.Save();
			user3.Save();
		}

	}
}
