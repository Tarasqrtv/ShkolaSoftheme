namespace HW15
{
	class DoublyList<T>
	{
		public DoublyList(T value)
		{
			Value = value;
		}

		public DoublyList<T> Next { get; set; }

		public DoublyList<T> Previous { get; set; }

		public T Value { get; set; }
	}
}
