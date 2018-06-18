﻿using System;

namespace HW12
{
	class UserJob
	{
		User[] ListUser = new User[1];
		Authenticator authenticator = new Authenticator();
		User user = new User();

		public void UserJob1()
		{
			ListUser[0] = new User("Admin", "admin", "@admin");
			int counter = 1;
			do
			{
				Console.WriteLine("Hello my friend. Authentefication please.");

				Console.WriteLine("Enter your name or email: ");

				user.Name = Console.ReadLine();

				Console.WriteLine("Enter your password: ");

				user.Password = Console.ReadLine();

				authenticator.AuthenticateUser(user);

				if (authenticator.EmailAuthenticate)
				{
					foreach (var i in ListUser)
					{
						if (i.Email == user.Name && i.Password == user.Password)
						{
							Console.WriteLine("User already registered");
							break;
						}
						else
						{
							Array.Resize(ref ListUser, counter + 1);
							ListUser[counter] = new User("Unknown", user.Password, user.Name);
							ListUser[counter].GetFullInfo();
							counter++;
							break;
						}
					}
				}
				else if (authenticator.NameAuthenticate)
				{
					foreach (var i in ListUser)
					{
						if (i.Name == user.Name && i.Password == user.Password)
						{
							Console.WriteLine("User already registered");
							break;
						}
						else
						{
							Array.Resize(ref ListUser, counter + 1);
							ListUser[counter] = new User(user.Name, user.Password, "Unknown");
							ListUser[counter].GetFullInfo();
							counter++;
							break;
						}
					}
				}
				if (user.Name == "exit" && user.Password == "exit")
				{
					Environment.Exit(0);
				}
			} while (true);
		}		
	}
}
