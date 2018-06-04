using System;

namespace HW8
{
	class Program
	{
		static void Main(string[] args)
		{
			//як без моделі? без моделі не можна!
			Model model = new Model("BMW E46 M3");

			Color color = new Color("Black");

			Transmission transmission = new Transmission("6 Speed Manual");

			Engine engine = new Engine("3.2L S54B32 I6");

			var car = CarConstructor.Construct(model, engine, color, transmission);

			Console.WriteLine(car);

			car = CarConstructor.Reconstruct(car, new Engine("4.0L P60B40 V8"));

			Console.WriteLine(car);

			Console.ReadKey();
		}
	}
}
