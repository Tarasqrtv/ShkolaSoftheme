using System;

namespace ConsoleHW4_1
{
	class Program
	{
		static void Main(string[] args)
		{			
			do
			{
				try
				{
					Console.WriteLine("Please enter the day of your birth: ");

					int day = int.Parse(Console.ReadLine());

					Console.WriteLine("Please enter the month of your birth: ");

					int month = int.Parse(Console.ReadLine());

					Console.WriteLine("Please enter the year of your birth: ");

					int year = int.Parse(Console.ReadLine());

					if (day < 1 || day > 31)
					{
						throw new Exception("error input day");
					}
					else if (month < 1 || day > 12)
					{
						throw new Exception("error input month");
					}
					else if (year < 1900 || year > 2018)
					{
						throw new Exception("error input year");
					}
					else
					{
						string Yourzodiac = zodiac.MyZodiac(day, month);

						Console.WriteLine(Yourzodiac);

						Console.WriteLine("Press Esc to exit");
					}
				}
				catch (FormatException fex)
				{
					Console.WriteLine(fex.Message);
				}
				catch (OverflowException overex)
				{
					Console.WriteLine(overex.Message);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}