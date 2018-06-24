using System;

namespace HW13
{
	class User : IUser
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }

		private DateTime _datenow;

		public User(string name, string password, string email)
		{
			Name = name;
			Password = password;
			Email = email;
			_datenow = DateTime.Now;
		}		


		public User()
		{
			_datenow = DateTime.Now;
		}

		public void GetFullInfo()
		{
			Console.WriteLine($"Name: {Name} \t Password: {Password} \t " +
				$"Email: {Email} \t DeteNow: {_datenow}");
		}
	}
}
