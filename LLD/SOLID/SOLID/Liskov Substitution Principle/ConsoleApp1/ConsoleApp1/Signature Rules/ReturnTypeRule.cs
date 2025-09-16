using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Signature_Rules
{
	internal class ReturnTypeRule
	{
		class Shape { };
		class Circle : Shape { };
		class ParentShape
		{
			public virtual Shape GetAnimal()
			{
				return new Shape();
			}
		}

		class ChildShape : ParentShape
		{
			//c# 9 allow coverient
			//public override Circle GetAnimal()
			//{
			//	return new Circle();
			//}
		}
	}
}
