using System;
using System.Collections.Generic;

namespace HW19
{
	class MobileAccount
	{
		public event EventHandler<int> CallEvent;

		public event EventHandler<SMS> MessageEvent;

		public int Number { get; }

		public string Name { get; }

		private readonly List<MobileAccount> _contacts;

		public MobileAccount(int number, string name)
		{
			Number = number;

			Name = name;

			_contacts = new List<MobileAccount>();
		}

		public void AddContact(int number, string name)
		{
			if (!_contacts.Exists(e => e.Number == number))
			{
				_contacts.Add(new MobileAccount(number, name));
			}
		}

		public void MakeCall(int number)
		{
			if (CallEvent != null)
			{
				CallEvent.Invoke(this, number);
			}
		}

		public void SendMessage(int number, string message)
		{
			if (MessageEvent != null)
			{
				MessageEvent.Invoke(this, new SMS { Number = number, Message = message });
			}
		}

		public void ReceiveCall(int number)
		{
			if (_contacts.Exists(e => e.Number == number))
			{
				var tmp = _contacts.Find(e => e.Number == number);
				Console.WriteLine($"Call from {tmp.Name} to {Number}");
			}
			else
			{
				Console.WriteLine($"Call from {number} to {Number}");
			}
		}

		public void ReceiveMessage(int number, string message)
		{
			if (_contacts.Exists(e => e.Number == number))
			{
				var tmp = _contacts.Find(e => e.Number == number);
				Console.WriteLine($"Message from {tmp.Name} to {Number}, {message}");
			}
			else
			{
				Console.WriteLine($"Message from {number} to {Number}, {message}");
			}
		}
	}
}
