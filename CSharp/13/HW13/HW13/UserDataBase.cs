using System;

namespace HW13
{
	class UserDataBase : IUserDataBase
	{
		User[] _accounts;

		public UserDataBase(User[] accounts)
		{
			_accounts = accounts;
		}

		public void AddUser(User user)
		{
			var usersListBuf = new User[_accounts.Length + 1];

			_accounts.CopyTo(usersListBuf, 0);

			usersListBuf[usersListBuf.Length - 1] = user;

			_accounts = usersListBuf;
		}

		public bool IsUserNameExist(string name)
		{
			foreach (var item in _accounts)
			{
				if (item.Name.Equals(name))
				{
					return true;
				}
			}
			return false;
		}

		public User[] GetUsers()
		{
			return _accounts;
		}
		
		public void Dispose()
		{
			for (int i = 0; i < _accounts.Length; i++)
			{
				Console.WriteLine($"Name: {_accounts[i].Name} \t Password: {_accounts[i].Password} \t " +
				$"Email: {_accounts[i].Email}");
			}
		}		
	}
}
