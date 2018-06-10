using System;

namespace HW10_3
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
			var array = new MyArray();

			array.Array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array.Array[i] + " ");
			}

			Console.WriteLine(": " + array.Length + " - Length array");

			Console.WriteLine();

			array.Add(19);

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array.Array[i] + " ");
			}

			Console.WriteLine(": " + array.Length + " - Length array");

			Console.WriteLine();

			Console.WriteLine(array.Contains(3));

			Console.WriteLine();

			Console.WriteLine(array.Contains(25));

			Console.WriteLine();

			Console.WriteLine(array.GetByIndex(5));
		}
	}
}
