using System;

namespace HW14
{
	class Program
	{
		static void Main(string[] args)
		{
			DoWork();
		}
		static void DoWork()
		{
			var lottery = new Lottery(6);

			var values = new int[6];

			var value = 0;

			do
			{
				Console.WriteLine("Input 6 values(whith enter): ");

				for (int i = 0; i < values.Length; i++)
				{
					if (!int.TryParse(Console.ReadLine(), out value))
					{
						Console.WriteLine("Input Error! Restart...");

						break;
					}
					values[i] = value;
				}
				
				if (lottery.СompareValues(values))
				{
					Console.WriteLine("You win!");
				}
				else
				{
					Console.WriteLine("You lose!");
				}
				Console.WriteLine(lottery.ToString() + " - is a bonus combination");
			}
			while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
