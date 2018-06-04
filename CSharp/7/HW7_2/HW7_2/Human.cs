using System;

namespace HW7_2
{
	class Human
	{
		private string age;

		public Human(string birthdate, string firstname, string lastname, string age)
		{
			BirthDate = birthdate;
			FirstName = firstname;
			LastName = lastname;
			Age = age;
		}
		public Human(string firstname, string lastname, string age)
		{			
			FirstName = firstname;
			LastName = lastname;
			Age = age;
		}
		public Human(string firstname, string lastname)
		{
			FirstName = firstname;
			LastName = lastname;			
		}
		public Human()
		{

		}

		public string BirthDate { get; set; }		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Age { get; }


		public void equals(Human H1, Human H2)
		{
			if (H1.Equals(H2))
			{
				Console.WriteLine("Обранi екземпляри еквiвалентнi");
			}
			else
			{
				Console.WriteLine("Обранi екземпляри не еквiвалентнi");
			}
		}


		public string GetFullInfo()
		{
			var message = string.Format("BirtDay: {0}, FirsName: {1}, LastName: {2}, Age: {3}", 
				BirthDate, FirstName, LastName, Age);
			return message;
		}
	}
}
