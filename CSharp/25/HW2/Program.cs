using System;
using System.IO;
using System.Text;

namespace HW2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.GetEncoding(1234);

			Console.OutputEncoding = Encoding.GetEncoding(1234);

			Console.WriteLine("Input the path to the directory");

			var path = Console.ReadLine();

			if (!Directory.Exists(path))
			{
				return;
			}

			var zipUnpack = new ZipUnpack();

			zipUnpack.ExtractAllZip(path);
		}
	}
}
