using System;

namespace HW19
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
			var MO = new MobileOperator();

			var MA1 = new MobileAccount(09846573, "Andrew");
			var MA2 = new MobileAccount(09477756, "Taras");

			MO.AddNumber(MA1);
			MO.AddNumber(MA2);
			MA1.AddContact(09477756, "Taras");

			MA2.MakeCall(09846573);
			MA2.MakeCall(09846573);
			MA2.MakeCall(09846573);
			MA2.MakeCall(09846573);
			MA1.MakeCall(09477756);
			MA1.MakeCall(09477756);
			MA1.MakeCall(09477756);
			MA2.MakeCall(09846573);
			MA2.MakeCall(09846573);
			MA2.MakeCall(09846573);
			MA2.MakeCall(09846573);
			MA1.MakeCall(09477756);
			MA1.MakeCall(09477756);
			MA1.MakeCall(09477756);

			MA2.SendMessage(09846573, "Hey");

			Console.WriteLine("Most Frequently Receiving Numbers");
			MO.MostFrequentlyReceivingNumbers(5);

			Console.WriteLine("Most Frequently Sendering Numbers");
			MO.MostFrequentlySendingNumbers(5);
		}
	}
}
