﻿namespace HW9
{
	internal class CarConstructor
	{
		public static Car Construct(Model model, Engine engine, Color color, Taransmission transmission)
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