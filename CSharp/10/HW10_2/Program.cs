using System;

namespace HW10_2
{
	class Program
	{
		static void Main(string[] args)
		{
			DoWork();
			Console.ReadLine();
		}

		public static void DoWork()
		{
			var array = new[] { 1, 4, 2, 9, 6, 8, 2, 4, 3, 7, 5, 6, 4, 1, 8, 0, 3, 6, };

			var arrclone = (int[])array.Clone();

			InsertSort(arrclone);

			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine((i + 1) + "\t" + array[i] + "\t" + arrclone[i]);
			}
		}

		public static void InsertSort(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				int temp = array[i];
				int j = i;
				while (j > 0 && temp < array[j - 1])
				{
					array[j] = array[j - 1];
					j--;
				}
				array[j] = temp;
			}
		}
	}
}