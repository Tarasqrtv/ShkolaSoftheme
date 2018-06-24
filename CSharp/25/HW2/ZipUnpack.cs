using System;
using System.IO;
using System.Threading.Tasks;
using Ionic.Zip;

namespace HW2
{
	class ZipUnpack
	{
		private const int MaxDegreeOfParallelism = 5;

		public void ExtractAllZip(string path)
		{
			var _directories = Directory.GetDirectories(path);

			var _files = Directory.GetFiles(path, "*.zip");

			Parallel.ForEach(_files, new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism }, x =>
			{
				Console.WriteLine(x);

				var zipFile = ZipFile.Read(x);

				zipFile.ExtractAll(path, ExtractExistingFileAction.OverwriteSilently);
			});

			Parallel.ForEach(_directories, ExtractAllZip);
		}
	}
}