using System;

namespace HW16
{
	class Program
	{
		static void Main(string[] args)
		{
			DoWork();
		}
		public static void DoWork()
		{
			Console.WriteLine("Queue: ");

			var queue = new MyQueue<int>();

			for (int i = 1; i < 11; i++)
			{
				queue.Enqueue(i);
			}

			for (int i = 1; i < 12; i++)
			{
				try
				{
					Console.WriteLine(queue.Peek());
					queue.Dequeue();
				}
				catch (InvalidOperationException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			Console.WriteLine("Stack: ");

			var stack = new MyStack<int>();

			for (int i = 1; i < 11; i++)
			{
				stack.Push(i);
			}

			for (int i = 1; i < 12; i++)
			{
				try
				{
					Console.WriteLine(stack.Peek());
					stack.Pop();
				}
				catch (InvalidOperationException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			Console.WriteLine("Dictionary: ");

			var dictionary = new MyDictionary<int, string>();

			try
			{
				dictionary.Add(1, "I");
				dictionary.Add(2, "You");
				dictionary.Add(3, "We");				
				Console.WriteLine(dictionary.ToString());
				dictionary.Remove(1, "I");
				dictionary.Remove(3, "We");
				Console.WriteLine(dictionary.ToString());
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadKey();
		}
	}
}
