using System;

namespace HW7_2
{
	class Program
	{
		static void Main(string[] args)
		{
			var me = new Human("05/10/1998","Taras", "Fedorenko", "19");
			var myexgirlfriend = new Human("08/03/1998", "Yaroslava", "Gorbunenko", "20");
			var myfriend = new Human("Vlad","Kovdrya");

			Console.WriteLine(me.GetFullInfo());

			//Console.WriteLine(myfriend.GetFullInfo());

			Console.WriteLine(myexgirlfriend.GetFullInfo());

			var eq = new Human();

			eq.equals(myexgirlfriend, myfriend);

			//eq.equals(myexgirlfriend, me);

			eq.equals(me, me);

			Console.ReadKey();
		}
	}
}
