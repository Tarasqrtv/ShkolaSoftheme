using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
	class Program
	{
		static void DoWork()
		{
			int value = 5;

			User user = new User();

			int refvalue = user.RefSetValue(ref value);

			user.GetFullInfo(value, refvalue);

			value++;

			user.GetFullInfo(value, refvalue);

			value = user.SetValue(value);

			int clonevalue = user.GetClone(value);

			int refclonevalue = user.RefGetClone(ref value);






			//User user = new User();

			//var number = 0;

			//user.SetValueType(ref number);
			//Console.WriteLine("Value Type: " + user.Value);
			//number++;
			//Console.WriteLine("After Changing: " + user.Value);

			//user.SetRefType(new WrappedInt() { Number = 0 });
			//Console.WriteLine("Reference Type: " + user.RefType);
			//user.ChangeRefType();
			//Console.WriteLine("After Changing: " + user.RefType);
		}

		static void Main(string[] args)
		{
			try
			{
				DoWork();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadKey();
		}
	}
}
