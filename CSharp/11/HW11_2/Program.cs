using HW11;
using System;

namespace HW11_2
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
			Printer print = new Printer();
			string[] arr_print1 = {"I","YOU","HE","SHE" };
			print.Print(arr_print1);

			ColorPrinter colorprint = new ColorPrinter();
			ConsoleColor[] cc = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow };
			string[] arr_print2 = { "This", "Amazing", "World", "My" };
			colorprint.Print(arr_print2, cc);			

			PhotoPrinter photoPrinter = new PhotoPrinter();
			Photo[] ph = { Photo.GoodCar, Photo.GoodGirl, Photo.GoodFootballTeam };
			photoPrinter.Print(ph);
		}		
	}
}
