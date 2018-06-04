using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFHW4_2
{
	public static class zodiac
	{
		public static string MyZodiac(int day, int month, Label imgLabel)
		{
			if ((day >= 14 && month == 3) || (month == 4 && day <= 15))
			{	
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Овен.jpg",UriKind.Relative)));
				return "The Ram";
			}
			else if ((day >= 21 && month == 4) || (month == 5 && day <= 21))
			{
				imgLabel.Background = 
					new ImageBrush(new BitmapImage(new Uri("Resources/Телець.jpg", UriKind.Relative)));
				return "The Bull";
			}
			else if ((day >= 22 && month == 5) || (month == 6 && day <= 21))
			{
				imgLabel.Background = 
					new ImageBrush(new BitmapImage(new Uri("Resources/Близнюки.jpg", UriKind.Relative)));
				return "The Twins";
			}
			else if ((day >= 22 && month == 6) || (month == 7 && day <= 22))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Рак.jpg", UriKind.Relative)));
				return "The Crab";
			}
			else if ((day >= 23 && month == 7) || (month == 8 && day <= 23))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Лев.jpg", UriKind.Relative)));
				return "The Lion";
			}
			else if ((day >= 24 && month == 8) || (month == 9 && day <= 23))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Діва.jpg", UriKind.Relative)));
				return "The Maiden";
			}
			else if ((day >= 24 && month == 9) || (month == 10 && day <= 23))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Терези.jpg", UriKind.Relative)));
				return "The Scales";
			}
			else if ((day >= 24 && month == 10) || (month == 11 && day <= 22))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Скорпіон.jpg", UriKind.Relative)));
				return "The Scorpion";
			}
			else if ((day >= 23 && month == 11) || (month == 12 && day <= 21))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Стрілець.jpg", UriKind.Relative)));
				return "The (Centaur) Archer";
			}
			else if ((day >= 22 && month == 12) || (month == 1 && day <= 20))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Козеріг.jpg", UriKind.Relative)));
				return "Goat Mountain";
			}
			else if ((day >= 21 && month == 1) || (month == 2 && day <= 19))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Водолій.jpg", UriKind.Relative)));
				return "The Water-Bearer";
			}
			else if ((day >= 20 && month == 2) || (month == 3 && day <= 20))
			{
				imgLabel.Background =
					new ImageBrush(new BitmapImage(new Uri("Resources/Риби.jpg", UriKind.Relative)));
				return "The Fish";
			}
			return string.Empty;
		}
	}
}
