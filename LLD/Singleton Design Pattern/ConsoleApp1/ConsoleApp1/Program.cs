
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Singleton
	{
		public static Singleton instence;
		public static readonly object locker = new object();
		private Singleton(){}

		public static Singleton Initalization
		{
			get
			{
				if (instence == null)
				{
					lock (locker)
					{
						if (instence == null)
						{
							instence = new Singleton();
						}
					}

				}
				return instence;

			}
		}
	}
	class egerSingleton
	{
		public static egerSingleton instence=new egerSingleton();
		public static readonly object locker = new object();
		private egerSingleton() { }

		public static egerSingleton Initalization
		{
			get
			{
				return instence;
			}
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Thread thred1 = new Thread(() =>
			{
				Singleton t1 = Singleton.Initalization;
				Console.WriteLine("Thread 1 instance: " + t1.GetHashCode());
			});
			Thread thred2 = new Thread(() =>
			{
				Singleton t2 = Singleton.Initalization;
				Console.WriteLine("Thread 2 instance: " + t2.GetHashCode());
			});
			thred1.Start();
			thred2.Start();
			thred1.Join();
			thred1.Join();
				
			Console.WriteLine("Test complete.");
			egerSingleton t3 = egerSingleton.Initalization;
			egerSingleton t4 = egerSingleton.Initalization;
			Console.WriteLine(t3 == t4);
			
			

		}

	}
}
