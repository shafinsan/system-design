
using ConsoleApp1.Solution_1.Classes;
using ConsoleApp1.Solution_1.Classes.MyDoc;
using ConsoleApp1.Solution_1.Classes.Save;
using ConsoleApp1.Solution_1.Interface;
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
			Document d = new Document();
			DocumentEditor doc = new DocumentEditor(d);
			doc.Addtext("this is text4");
			doc.AddImage("this is image1");
			doc.Addtext("this is text2");
			doc.AddImage("this is image2");

			doc.Addtext("this is text5");
			doc.AddImage("this is image7");
			doc.AddImage("this is image8");
			doc.Addtext("this is text2");
			RandDocument r = new RandDocument(d);
			IList<string>st= r.Rander();
			Isave isave = new SaveToFile();
			Isave isave1 = new SaveToDB();
			isave.Save(st);
			isave1.Save(st);


		}

	}
}
