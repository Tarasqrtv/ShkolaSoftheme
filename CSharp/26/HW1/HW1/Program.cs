using System;
using System.Text;

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
			Console.InputEncoding = Encoding.GetEncoding(18475);

			Console.OutputEncoding = Encoding.GetEncoding(18475);

			Console.WriteLine("Input the path to the directory");

			var path = Console.ReadLine();

			var replaceText = new ReplaceText("old", "new");

			replaceText.ReplaceTextInFiles(path);

			Console.WriteLine("Program is finished");

			Console.ReadKey();
		}
	}
}
