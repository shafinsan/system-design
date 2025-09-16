using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
	internal class Teacher: Person
	{
		public int EmpId { get; set; }
		public Teacher(string Name, int Age, int EmpId) : base(Name, Age)
		{
			this.EmpId = EmpId;
		}
		public override void display()
		{
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Age: " + Age);
			Console.WriteLine("Emp Id: " + EmpId);
		}
	}
	
}
