using ConsoleApp1.Solution_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Solution_1.Classes.Rander
{
	internal class ImageRander:Irander
	{
		public string text { get; set; }
		public ImageRander (string text)
		{
			this.text = text;
		}
		public string Render()
		{
			return "[Image: " + text + "]";
		}
	}
}
