namespace HW8
{
	internal class CarConstructor
	{
		public static Car Construct(Model model, Engine engine, Color color, Transmission transmission)
		{
			return new Car(model, engine, color, transmission);
		}
		public static Car Reconstruct(Car car, Engine engine)
		{
			car.Engine = engine;
			return car;
		}
	}
}