namespace HW13
{
	interface IUser
	{
		string Name { get; set; }
		string Password { get; set; }
		string Email { get; set; }

		void GetFullInfo();
	}
}
