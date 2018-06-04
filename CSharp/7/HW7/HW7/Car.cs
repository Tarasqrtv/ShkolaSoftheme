namespace HW7
{
	class Car
	{
		public Car(string model, int year, string color)
		{
			Model = model;
			Year = year;
			Color = color;
		}

		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public string GetFullInfo()
		{
			var message = string.Format("Model: {0}, Year: {1}, Color: {2}", Model, Year, Color);
			return message;
		}
	}	
}
