using System;
using System.Net.Mail;

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

			var MA1 = new MobileAccount("Taras", "Tarik", new DateTime(1998, 10, 5), new MailAddress("i@mail.com"));

			var MA2 = new MobileAccount("Andrew", "Daubt", new DateTime(1991, 10, 31), new MailAddress("he@mail.com"));

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
		}
    }
}
