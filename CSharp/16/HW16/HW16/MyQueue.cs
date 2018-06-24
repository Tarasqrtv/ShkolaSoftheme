using System;

namespace HW16
{
	class MyQueue<T>
	{
		private T[] _array;
		private int _length;

		public MyQueue()
		{

		}

		public void Enqueue(T value)
		{
			if (_length != 0)
			{
				T[] tmpArr = _array;
				_array = new T[_length + 1];
				Array.Copy(tmpArr, 0, _array, 1, tmpArr.Length);
			}
			else
			{
				_array = new T[1];
			}
			_array[0] = value;
			_length++;
		}

		public T Dequeue()
		{
			if (_length != 0)
			{
				T[] tmpArr = _array;
				_array = new T[_length - 1];
				Array.Copy(tmpArr, 0, _array, 0, _array.Length);
				_length--;
				if (_length == 0)
				{
					return default(T);
				}
				return _array[_length - 1];
			}
			else
			{
				throw new InvalidOperationException("Could not delete item how non-existing.", null);
			}
		}

		public T Peek()
		{
			if (_length == 0)
			{
				throw new InvalidOperationException("Queue is empty.", null);
			}
			return _array[_length - 1];
		}
	}
}
