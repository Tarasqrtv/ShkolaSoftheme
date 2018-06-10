using System;

namespace HW11
{
	public class ColorPrinter:Printer
	{
		public override void Print(string str)
		{
			Console.WriteLine(str);
		}
		public void Print(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;			
			Console.WriteLine(txt);
			Console.ResetColor();
		}
	}
}
