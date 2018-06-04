using System;

namespace ConsolePaintingHW5
{
	public static class Figure
	{
		public static void Square(int n)
		{
			Console.Clear();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.SetCursorPosition(i, j);
					Console.Write('*');
				}
			}
		}

		public static void Triangle(int n)
		{
			Console.Clear();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (j >= i)
					{
						Console.SetCursorPosition(i, j);
						Console.Write('*');
					}
				}
			}
		}
		
		//нечитаємий код, сам не знаю як вийшло, але ж працює, то хай так і буде
		public static void Romb(int n)
		{
			Console.Clear();

			for (int i = 0; i < n; i++)
			{
				for (int j = n - i; j <= n + i; j++)
				{
					Console.SetCursorPosition(j, i);
					Console.Write('*');
				}
			}
			int _counter = n;
			for (int i = n * 2; i > n + 1; i--)
			{
				_counter++;
				for (int j = i - n; j < _counter; j++)
				{
					Console.SetCursorPosition(j, i - 2);
					Console.Write('*');
				}
			}
		}
	}
}
