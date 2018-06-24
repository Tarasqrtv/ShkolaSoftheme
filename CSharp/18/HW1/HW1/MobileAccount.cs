using System;

namespace HW1
{
	class MobileAccount
	{
		public event EventHandler<int> CallEvent;

		public event EventHandler<SMS> MessageEvent;

		public int Number { get; }

		public MobileAccount(int number)
		{
			Number = number;
		}

		public void MakeCall(int number)
		{
			if (CallEvent != null)
			{
				CallEvent.Invoke(this, number);
			}
		}

		public void ReceiveCall(int number)
		{
			Console.WriteLine($"Call from {number} to {Number}");
		}

		public void SendMessage(int number, string message)
		{
			if (MessageEvent != null)
			{
				MessageEvent.Invoke(this, new SMS { Number = number, Message = message });
			}
		}

		public void ReceiveMessage(int number, string message)
		{
			Console.WriteLine($"Message from {number} to {Number}, {message}");
		}
	}
}
