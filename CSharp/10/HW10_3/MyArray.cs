using System;

namespace HW10_3
{
	class MyArray
	{
		public int[] Array { get; set; }

		public int Length => Array.Length;

		public void Add(int insertelement)
		{
			var newArray = new int[Array.Length + 1];

			for (var i = 0; i < Array.Length; i++)
			{
				newArray[i] = Array[i];
			}

			newArray[Array.Length] = insertelement;

			Array = newArray;
		}

		public bool Contains(int insertelement)
		{
			var result = false;
			for (int i = 0; i < Array.Length; i++)
			{
				if (Array[i] == insertelement)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		public int GetByIndex(int index)
		{
			if (index >= 0 && index < Array.Length)
			{
				return Array[index];
			}
			throw new IndexOutOfRangeException("Incorrect input index");
		}
	}
}