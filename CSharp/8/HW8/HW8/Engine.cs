namespace HW8
{
	public class Engine
	{
		public string CarEngine { get; set; }
		public Engine(string engine)
		{
			CarEngine = engine;
		}
		public override string ToString()
		{
			return CarEngine;
		}
	}
}