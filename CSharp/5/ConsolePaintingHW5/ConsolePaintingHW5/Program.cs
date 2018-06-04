using System;

namespace ConsolePaintingHW5
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberfigure, n;
			do
			{
				try
				{
					Console.Clear();

					Console.WriteLine("Press Esc to exit after drawing");

					Console.WriteLine("Please enter the number name figure(1 - Triangle; 2 - Square; 3 - Romb)");

					numberfigure = int.Parse(Console.ReadLine());

					Console.WriteLine("Please enter the dimension figure: ");

					n = int.Parse(Console.ReadLine());
					
					if (numberfigure == 2)
					{
						Figure.Square(n);
					}
					else if (numberfigure == 1)
					{
						Figure.Triangle(n);
					}
					else if (numberfigure == 3)
					{
						Figure.Romb(n);

					}
					else if (numberfigure < 1 || numberfigure > 3)
					{
						throw new Exception("Input error! (1 - Triangle; 2 - Square; 3 - Romb)");
					}
					else
					{
						throw new Exception("FATAL ERROR!!!!!!!!");//код який ніколи не виконається))) а може.....
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
