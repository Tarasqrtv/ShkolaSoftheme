using System;
using System.Reflection;

namespace HW1
{
	class Program
	{
		static void Main(string[] args)
		{
			DoWork();

			Console.ReadKey();
		}
		public static void DoWork()
		{
			var asembly = Assembly.Load("TestConsole");

			var type = asembly.GetType("TestConsole.Program", true, true);
			Console.WriteLine("Type: {0}", type);

			var typeInfo = type.GetTypeInfo();
			Console.WriteLine("Type Info: {0}", typeInfo);

			var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Static);

			foreach (var method in methods)
			{
				Console.WriteLine("Method: {0}", method);
			}

			var methodDevided = type.GetMethod("Devided", BindingFlags.NonPublic | BindingFlags.Static);

			if (methodDevided != null)
			{
				var result = methodDevided.Invoke(null, new object[] { 8, 4 });
				Console.WriteLine("Devided: {0}", result);
			}

			var methodGetE = type.GetMethod("GetE", BindingFlags.NonPublic | BindingFlags.Static);

			if (methodGetE != null)
			{
				var result = methodGetE.Invoke(null, new object[] { });
				Console.WriteLine("GetE {0}", result);
			}
		}
	}
}
