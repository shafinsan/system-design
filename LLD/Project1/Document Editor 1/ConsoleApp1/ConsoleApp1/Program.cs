
using ConsoleApp1.Solution_1.Classes;
using ConsoleApp1.Solution_1.Classes.MyDoc;
using ConsoleApp1.Solution_1.Classes.Save;
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
			DocumentEditor doc = new DocumentEditor(new Document(),new SaveToFile());
			doc.Addtext("this is text4");
			doc.AddImage("this is image1");
			doc.Addtext("this is text2");
			doc.AddImage("this is image2");
			doc.rander();
			doc.Save();
			Console.WriteLine();
			Console.WriteLine("****************************************************");
			Console.WriteLine();
		}

	}
}
