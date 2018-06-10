using System;

namespace HW10_1
{
	class Program
	{
		public static int[] array = new int[1002];
		static void Main(string[] args)
		{
			Init();
			Unique();
			Console.ReadLine();
			#region
			//int[] arr = (int[])array.Clone();

			//Array.Sort(arr);

			//for (int i = 0; i < array.Length; i++)
			//{
			//	Console.WriteLine((i) + ": " + array[i] + "\t" + arr[i]);
			//}
			#endregion
		}
		private static void Swap(ref int a, ref int b)
		{
			int c;
			c = a;
			a = b;
			b = c;
		}
		private static void Init()
		{
			for (int i = 0; i <= 500; i++)
			{
				array[i] = i;
				array[i + 501] = array[i];
			}

			Array.Resize(ref array, array.Length - 1);

			Random rnd = new Random();

			Swap(ref array[array.Length-1], ref array[rnd.Next(0,500)]);
		}

		private static void  Unique()
		{
			for (int i = 0; i < array.Length; ++i)
			{
				int count = 0;

				for (int j = 0; j < array.Length; ++j)
				{
					if (array[i] == array[j])
					{
						count++;
					}						
				}					
				if (count != 2)
				{
					Console.WriteLine(array[i]);
				}					
			}
		}
	}
}
