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

			var MA1 = new MobileAccount(046836574);
			var MA2 = new MobileAccount(083747563);

			mO.AddNumber(MA2);
			mO.AddNumber(MA1);

			MA1.MakeCall(046836574);
			MA2.SendMessage(083747563, "Hey");
		}
	}
}
