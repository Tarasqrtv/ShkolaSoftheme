﻿namespace HW15
{
	class List1<T>
	{
		int _count;

		public DoublyList<T> Head { get; set; }

		public DoublyList<T> Tail { get; set; }

		public List1()
		{
			Head = null;
			Tail = null;
		}

		public void Add(T data)
		{
			var DoublyList = new DoublyList<T>(data);

			if (Head == null)
			{
				Head = DoublyList;
			}
			else
			{
				Tail.Next = DoublyList;
				DoublyList.Previous = Tail;
			}

			Tail = DoublyList;

			_count++;
		}

		public bool Remove(T data)
		{
			var current = Head;

			while (current != null)
			{
				if (current.Value.Equals(data))
				{
					break;
				}
				current = current.Next;
			}

			if (current != null)
			{
				if (current.Next != null)
				{
					current.Next.Previous = current.Previous;
				}
				else
				{
					Tail = current.Previous;
				}

				if (current.Previous != null)
				{
					current.Previous.Next = current.Next;
				}
				else
				{
					Head = current.Next;
				}

				_count--;

				return true;
			}
			return false;
		}
		
		public bool Contains(T value)
		{
			DoublyList<T> current = Head;

			while (current != null)
			{
				if (current.Value.Equals(value))
				{
					return true;
				}
				current = current.Next;
			}
			return false;
		}

		public T[] ToArray()
		{
			var current = Head;

			var array = new T[_count];

			for (int i = 0; i < _count; i++)
			{
				array[i] = current.Value;
				current = current.Next;
			}
			return array;
		}

		public int GetLength()
		{
			return _count;
		}
	}
}
