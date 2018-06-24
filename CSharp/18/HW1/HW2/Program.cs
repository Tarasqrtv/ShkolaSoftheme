using System;

namespace HW1
{
	class Program
	{
		static void Main(string[] args)
		{
			DoWork();
			Console.ReadKey();
		}
		public static void DoWork()
		{
			var mO = new MobileOperator();

			var MA1 = new MobileAccount(097485837, "Andrew");
			var MA2 = new MobileAccount(092765625, "Taras");

			mO.AddNumber(MA1);
			mO.AddNumber(MA2);
			MA1.AddContact(092765625, "Taras");

			MA2.MakeCall(097485837);
			MA2.SendMessage(097485837, "Hey");
		}
	}
}
