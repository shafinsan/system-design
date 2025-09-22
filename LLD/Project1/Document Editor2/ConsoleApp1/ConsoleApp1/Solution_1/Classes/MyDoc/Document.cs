using ConsoleApp1.Solution_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Solution_1.Classes.MyDoc
{
	internal class Document
	{
		public List<Irander> list { get; set; } = new List<Irander>();
		


		public void Add(Irander element)
		{
			list.Add(element);
		}
		public List<Irander> GetAllList()
		{

			return list;
		}
		
	}
}
