namespace HW1
{
    class Login
    {
        public MobileAccount Sender { get; }

		public  MobileAccount Receiver { get; }

		public double Rate { get; }

		public Login(MobileAccount sender, MobileAccount receiver, double rate)
        {
            Sender = sender;
            Receiver = receiver;
            Rate = rate;
        }
    }
}
