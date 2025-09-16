using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Second_Part
{
	internal class AdminPass
	{
		public virtual void CreateAdmin(string st)
		{
			int l = st.Length;
			if (l > 8)
			{
				Console.WriteLine("Password must be at least 8 characters long. i am at parent :"+l);
			}
			return;
		}
		
	}
}
