using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ionic.Zip;

namespace HW1
{
	internal class Zip
	{
		private const int MaxDegreeOfParallelism = 5;

		private readonly ZipFile _zipFile;

		public Zip()
		{
			_zipFile = new ZipFile(Encoding.UTF8)
			{
				UseZip64WhenSaving = Zip64Option.AsNecessary
			};
		}

		public void MakeZipFile(string path, string archiveName)
		{
			try
			{
				ZipDirectory(path);

				_zipFile.Save(archiveName + ".zip");

				Console.WriteLine("Program is finished");
			}

			catch (UnauthorizedAccessException e)
			{
				Console.WriteLine(e);
			}
		}

		private void AddItem(string file, string path)
		{
			_zipFile.AddItem(file, path);
		}

		private void ZipDirectory(string path)
		{
			var _directories = Directory.GetDirectories(path);
			var _files = Directory.GetFiles(path);

			Parallel.ForEach(_files, new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism }, x =>
			{
				AddItem(x, path);
				Console.WriteLine($"Thread - {Thread.CurrentThread.ManagedThreadId}");
			});

			Parallel.ForEach(_directories, x =>
		   {
			   ZipDirectory(x);
			   Console.WriteLine($"Thread - {Thread.CurrentThread.ManagedThreadId}");
		   });
		}
	}
}