namespace HW8
{
	public class Model
	{
		public string CarModel { get; }
		public Model(string model)
		{
			CarModel = model;
		}
		public override string ToString()
		{
			return CarModel;
		}
	}
}