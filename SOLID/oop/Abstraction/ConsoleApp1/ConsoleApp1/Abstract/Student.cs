using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
	internal class Student:Person
	{
		public int RollNo { get; set; }
		public Student(string Name, int Age, int RollNo) : base(Name, Age)
		{
			this.RollNo = RollNo;
		}
		public override void display()
		{
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Age: " + Age);
			Console.WriteLine("Roll No: " + RollNo);
		}
	}
}
