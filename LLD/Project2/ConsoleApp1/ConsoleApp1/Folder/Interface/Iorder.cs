using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Folder.Interface
{
	internal interface Iorder
	{
		Iorderfactory getType(string st);
	}
}
