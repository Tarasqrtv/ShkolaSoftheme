using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
	public class Registration
	{
		public string FirstName;
		public string LastName;
		public string PhoneNumber;
		public string Email;
		public string AdditionalInfo;
		public string Birthday;
		public string Gender;

		public bool CheckInfo(string text)
		{
			if (text.Length > 255 || text.Length < 3)
			{
				return false;
			}
			foreach (char ch in text)
			{
				if (char.IsDigit(ch))
				{
					return false;
				}
			}
			return true;
		}
	}
}
