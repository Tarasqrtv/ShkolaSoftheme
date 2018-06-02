namespace ConsoleHW4_1
{
	public static class zodiac
	{
		public static string MyZodiac(int day, int month)
		{
			if ((day >= 14 && month == 3) || (month == 4 && day <= 15))
			{
				return "The Ram";
			}
			else if ((day >= 21 && month == 4) || (month == 5 && day <= 21))
			{
				return "The Bull";
			}
			else if ((day >= 22 && month == 5) || (month == 6 && day <= 21))
			{
				return "The Twins";
			}
			else if ((day >= 22 && month == 6) || (month == 7 && day <= 22))
			{
				return "The Crab";
			}
			else if ((day >= 23 && month == 7) || (month == 8 && day <= 23))
			{
				return "The Lion";
			}
			else if ((day >= 24 && month == 8) || (month == 9 && day <= 23))
			{
				return "The Maiden";
			}
			else if ((day >= 24 && month == 9) || (month == 10 && day <= 23))
			{
				return "The Scales";
			}
			else if ((day >= 24 && month == 10) || (month == 11 && day <= 22))
			{
				return "The Scorpion";
			}
			else if ((day >= 23 && month == 11) || (month == 12 && day <= 21))
			{
				return "The (Centaur) Archer";
			}
			else if ((day >= 22 && month == 12) || (month == 1 && day <= 20))
			{
				return "Goat Mountain";
			}
			else if ((day >= 21 && month == 1) || (month == 2 && day <= 19))
			{
				return "The Water-Bearer";
			}
			else if ((day >= 20 && month == 2) || (month == 3 && day <= 20))
			{
				return "The Fish";
			}
			return string.Empty;
		}
	}
}
