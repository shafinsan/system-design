using ConsoleApp1.Solution_1.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Solution_1.Classes.Save
{
	internal class SaveToFile:Isave
	{
		public void Save(IList<string> data)
		{
			string path= "document.txt";
			try
			{
				File.WriteAllLines(path, data);
				Console.WriteLine($"File saved successfully to {Path.GetFullPath(path)}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error saving file: {ex.Message}");
			}
		}
	}
}
