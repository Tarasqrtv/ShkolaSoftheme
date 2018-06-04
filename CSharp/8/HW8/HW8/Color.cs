namespace HW8
{
	public class Color
	{
		public string CarColor { get; }
		public Color(string color)
		{
			CarColor = color;
		}
		public override string ToString()
		{
			return CarColor;
		}
	}
}