using System;

namespace HW11
{
	public class Program
	{
		static void Main(string[] args)
		{
			DoWork();
			Console.ReadKey();
		}
		public static void DoWork()
		{
			Printer print = new Printer();
			print.Print("Hey everyone");

			ColorPrinter colorprint = new ColorPrinter();
			colorprint.Print("Hello",ConsoleColor.DarkRed);
			colorprint.Print("Bue Bue");			

			PhotoPrinter photoPrinter = new PhotoPrinter();
			photoPrinter.Print("Best storage");			
			photoPrinter.Print(Photo.GoodGirl);			
		}
	}
}
