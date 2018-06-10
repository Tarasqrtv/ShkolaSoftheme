using HW11;
using System;

namespace HW11_2
{
	static class ExtentionMethods
	{
		public static void Print(this PhotoPrinter photoPrinter, Photo[] photos)
		{
			for (int i = 0; i < photos.Length; i++)
			{
				photoPrinter.Print(photos[i].ToString());
			}
		}

		public static void Print(this ColorPrinter colourPrinter, string[] text, ConsoleColor[] colors)
		{
			if (text.Length == colors.Length)
			{
				for (int i = 0; i < text.Length; i++)
				{
					colourPrinter.Print(text[i], colors[i]);
				}
			}
			else
			{
				Console.WriteLine(new Exception("The dimensions of the input arrays must be the same"));
			}			
		}

		public static void Print(this Printer printer, string[] str)
		{
			for (int i = 0; i < str.Length; i++)
			{
				printer.Print(str[i]);
			}
		}
	}
}
