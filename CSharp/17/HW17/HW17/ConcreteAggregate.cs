using System.Collections;

namespace Iterator
{
	class ConcreteAggregate<T> : Aggregate<T>
	{
		private T[] _items = new T[0];

		public override Iterator<T> CreateIterator()
		{
			return new ConcreteIterator<T>(this);
		}

		public int Count
		{
			get { return _items.Length; }
		}

		public T this[int index]
		{
			get { return _items[index]; }
			set { Insert(index, value); }
		}

		public bool Insert(int index, T value)
		{
			if (index >= _items.Length + 1)
			{
				return false;
			}

			var _itemsBuffer = new T[_items.Length + 1];

			for (int i = 0, j = 0; i < _itemsBuffer.Length; i++, j++)
			{
				if (i == index)
				{
					_itemsBuffer[index] = value;
					j++;
					continue;
				}
				_itemsBuffer[j] = _items[i];
			}

			_items = _itemsBuffer;

			return true;
		}
	}
}