using System;

namespace HW1
{
	class Program
	{
		static void Main(string[] args)
		{
			DoWork();
		}
		public static void DoWork()
		{
			var MO = new MobileOperator();

			var MA1 = new MobileAccount("Taras", "Tarik", new DateTime(1998, 10, 5), "i@mail.com");
			var MA2 = new MobileAccount("Andrew", "Doubt", new DateTime(1991, 10, 31), "he@mail.com");

			MO.AddNumber(MA1);
			MO.AddNumber(MA2);

			MA1.AddContact(MA2.Number, new SubName("Andrew"));

			MA1.MakeCall(MA2.Number);
			MA1.MakeCall(MA2.Number);
			MA1.MakeCall(MA2.Number);

			MA2.SendMessage(MA1.Number, "Hey");

			Console.WriteLine("Most Frequently Receiving Numbers");
			MO.Log.MostFrequentlyReceivingNumbers(5);

			Console.WriteLine("Most Frequently Sendering Numbers");
			MO.Log.MostFrequentlySendingNumbers(5);

			MO.PersistJson();
			MO.RestoreJson();

			Console.ReadKey();
		}
	}
}
