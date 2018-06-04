using System;

namespace HW7
{
	class Program
	{
		static void Main(string[] args)
		{
			var car = new Car("Impala", 1967, "Black");

			Console.WriteLine(car.GetFullInfo());
			
			TuningAtelier.TuneCar(car);

			Console.WriteLine(car.GetFullInfo());

			Console.ReadKey();
		}
	}
}
