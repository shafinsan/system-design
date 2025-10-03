using ConsoleApp1.obserber.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.obserber.Classes
{
	internal class Chennal:IChennal
	{
		private List<Subscriber> subscribers = new List<Subscriber>();
		public string Name { get; set; }
		public string Title { get; set; }
		public Chennal(string Name)
		{
			this.Name = Name;
		}
		public void Subscribe(Subscriber subscriber)
		{
			string name= subscriber.Name;
			foreach (var item in subscribers)
			{
				if (item.Name.ToLower().Contains(name.ToLower()))
				{
					Console.WriteLine("You are already subscribed");
					return;
				}
			}
			subscribers.Add(subscriber);
		}
		public void Unsubscribe(Subscriber subscriber)
		{
			string name = subscriber.Name;
			foreach (var item in subscribers)
			{
				if (item.Name.ToLower().Contains(name.ToLower()))
				{
					subscribers.Remove(item);
					return;
				}
			}
			Console.WriteLine("user not found");
		}
		public void notify(string st)
		{
			foreach (var item in subscribers)
			{
				item.update(st);
			}
		}
		public void uploadVideo(string title)
		{
			this.Title = title;
			notify(Title);
		}
	}
}
