using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Signature_Rules
{
	internal class MethodArgumentRule
	{
		class currentShape
		{
			public virtual void Draw(int s)
			{

			}
		};
		class currentTriangle : currentShape
		{
			//contravariant
			public override void Draw(int s)
			{
				Console.WriteLine("Drawing Triangle");
			}
		}
	}
}
