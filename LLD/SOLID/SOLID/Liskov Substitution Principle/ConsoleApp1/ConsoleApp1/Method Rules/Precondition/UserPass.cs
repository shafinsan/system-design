using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Second_Part
{
	internal class UserPass:AdminPass
	{
		public override void CreateAdmin(string st)
		{
			int l = st.Length;
			if (l > 6)
			{
				Console.WriteLine("Password must be at least 8 characters long. but i am at child so it can possible for 6 :"+l);
			}
			return;
		}
	}
}
