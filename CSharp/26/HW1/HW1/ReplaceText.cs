using System;
using System.IO;
using System.Threading.Tasks;

namespace HW1
{
	class ReplaceText
	{
		private const int MaxDegreeOfParallelism = 5;

		private readonly string _oldText;

		private readonly string _newText;

		public ReplaceText(string t1, string t2)
		{
			_oldText = t1;

			_newText = t2;

			var fileStream = File.Create("log.txt");

			fileStream.Close();
		}

		public void ReplaceTextInFiles(string path)
		{
			var _directories = Directory.GetDirectories(path);

			var _files = Directory.GetFiles(path, "*.txt");

			string str;

			var logFile = string.Empty;

			Parallel.ForEach(_files, new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism }, x =>
			{
				Console.WriteLine(x);

				var streamReader = File.OpenText(x);

				var text = string.Empty;

				while ((str = streamReader.ReadLine()) != null)
				{
					if (str.Contains(_oldText))
					{
						logFile += $"Name of the file: {x} String: {str}";

						str = str.Replace(_oldText, _newText);

						logFile += $"Result:{str}\r\n";
					}
					text += str + "\r\n";
				}

				streamReader.Close();

				File.WriteAllText(x, text);

				lock (this)
				{
					File.AppendAllText("log.txt", logFile);
				}
			});

			Parallel.ForEach(_directories, ReplaceTextInFiles);
		}
	}
}