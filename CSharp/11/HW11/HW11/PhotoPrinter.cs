using System;

namespace HW11
{
	public class PhotoPrinter :Printer
	{
		public override void Print(string str)
		{
			Console.WriteLine(str);
		}
		public void Print(Photo photo)
		{
			Console.WriteLine(photo.ToString());
		}
	}
	public enum Photo
	{
		GoodGirl,
		GoodCar,
		GoodFootballTeam
	}
}
