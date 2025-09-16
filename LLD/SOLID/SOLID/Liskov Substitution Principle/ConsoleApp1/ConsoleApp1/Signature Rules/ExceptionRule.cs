using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Signature_Rules
{
	internal class ExceptionRule
	{
		class Parent
		{
			public virtual void DoWork()
			{
				// Parent method may throw Exception
				throw new Exception("Parent general exception");
			}
		}

		class Child : Parent
		{
			public override void DoWork()
			{
				// ✅ Child can throw a more specific exception
				throw new InvalidOperationException("Child specific exception");
			}
		}
	}
}
