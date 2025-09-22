using ConsoleApp1.Solution_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Solution_1.Classes.MyDoc
{
	internal class RandDocument
	{
		public Document document { get; set; }
		public List<Irander> list =new List<Irander>();
		public List<string> store = new List<string>();
		public RandDocument(Document doc)
		{
			document = doc;
			list=document.GetAllList();
		}
		public IList<string> Rander()
		{

			foreach (var element in list)
			{
				string st = element.Render();
				store.Add(st);

			}
			return store;
		}

	}
}
