using System;

namespace HW15
{
	class Program
	{
		static void Main(string[] args)
		{
			DoWork();
		}

		public static void DoWork()
		{
			var list = new List1<int>();

			for (int i = 0; i < 10; i++)
			{
				list.Add(i);
			}

			list.Remove(4);

			//var array = list.ToArray();

			//foreach (var item in array)
			//{
			//	Console.WriteLine(item);
			//}

			var cont = list.Contains(5);

			Console.WriteLine(cont.ToString());

			var length = list.GetLength();

			Console.WriteLine(length + " -Length");

			Console.ReadLine();
		}
	}
}
