using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
	class User
	{
		int _value;
		WrappedInt _refType;

		public int Value { get { return _value; } }
		public int RefType { get { return _refType.Number; } }

		public void SetValueType(ref int value)
		{
			_value = value;
		}

		public void SetRefType(WrappedInt refValue)
		{
			_refType = refValue;
		}

		public void ChangeValueType()
		{
			_value++;
		}

		public void ChangeRefType()
		{
			_refType.Number++;
		}
	}
	class WrappedInt
	{
		public int Number;
	}
}
