namespace HW9
{
	struct Car
	{
		public Model Model { get; }
		public Color Color { get; }
		public Engine Engine { get; set; }
		public Transmission Transmission { get; }
		public Car(Model model,Engine engine, Color color,  Transmission transmission)
		{
			Model = model;
			Engine = engine;
			Color = color;			
			Transmission = transmission;
		}
		
		public override string ToString()
		{
			return string.Format("Model: {0}, Engine: {1}, Color: {2}, Transmission: {3}",
			Model, Engine, Color, Transmission);
		}
	}
}
