

using ConsoleApp1.Solution_1.Classes.MyDoc;
using ConsoleApp1.Solution_1.Classes.Rander;
using ConsoleApp1.Solution_1.Classes.Save;
using ConsoleApp1.Solution_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Solution_1.Classes
{
	internal class DocumentEditor
	{
		public Document doc { get; set; }
		public Isave saveInterface { get; set; }
		public IList<string> st;
		public DocumentEditor(Document document)
		{
			doc = document;
		}
		public void Addtext(string data)
		{
			doc.Add(new TextRander(data));
		}
		public void AddImage(string data)
		{
			doc.Add(new ImageRander(data));
		}
	
		
	}
}
