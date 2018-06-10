namespace HW9
{
	internal class CarConstructor
	{
<<<<<<< HEAD
		public static Car Construct(Model model, Engine engine, Color color, Transmission transmission)
=======
		public static Car Construct(Model model, Engine engine, Color color, Taransmission transmission)
>>>>>>> mypull
		{
			return new Car(model, engine, color, transmission);
		}
		public static Car Reconstruct(Car car, Engine engine)
		{
			car.Engine = engine;
			return car;
		}
	}
<<<<<<< HEAD
}
=======
}
>>>>>>> mypull
