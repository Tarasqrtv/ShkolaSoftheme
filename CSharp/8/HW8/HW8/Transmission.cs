namespace HW8
{
	public class Transmission
	{
		public string CarTransmission { get; }
		public Transmission(string transmission)
		{
			CarTransmission = transmission;
		}
		public override string ToString()
		{
			return CarTransmission;
		}
	}
}