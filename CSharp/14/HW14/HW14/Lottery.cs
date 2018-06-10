using System;

namespace HW14
{
	class Lottery
	{
		private int[] _values;

		public int this[int index]
		{
			get { return _values[index]; }
			set { _values[index] = value; }
		}

		public Lottery(int length)
		{
			_values = new int[length];

			Random rnd = new Random();

			for (int i = 0; i < length; i++)
			{
				_values[i] = rnd.Next(1, 9);
			}
		}

		public int Length
		{
			get { return _values.Length; }
		}

		public bool СompareValues(int[] values)
		{
			if (this.Length != values.Length)
			{
				return false;
			}

			for (int i = 0; i < this.Length; i++)
			{
				if (this[i] != values[i])
				{
					return false;
				}
			}
			return true;
		}		

		public override string ToString()
		{
			var str = String.Empty;

			for (int i = 0; i < this.Length; i++)
			{
				str += " " + this[i];
			}

			return str;
		}
	}
}
