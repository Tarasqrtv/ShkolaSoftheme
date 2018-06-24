namespace HW13
{
	class Authenticator : IAuthenticator
	{
		public bool NameAuthenticate;
		public bool EmailAuthenticate;
		public void AuthenticateUser(IUser user)
		{
			if (user.Name.Contains("@"))
			{
				EmailAuthenticate = true;
				NameAuthenticate = false;
			}
			else
			{
				EmailAuthenticate = false;
				NameAuthenticate = true;
			}
		}
	}
}
