using System;

namespace HW9
{
	class Program
	{
		static void Main(string[] args)
		{
			var car = CarConstructor.Construct(Model.model1, Engine.engine1, Color.black, Taransmission.transmission1);

			Console.WriteLine(car);

			car = CarConstructor.Reconstruct(car, Engine.engine2);

			Console.WriteLine(car);

			Console.ReadKey();
		}
	}
}
