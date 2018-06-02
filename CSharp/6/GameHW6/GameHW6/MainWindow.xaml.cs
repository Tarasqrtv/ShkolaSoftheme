using System;
using System.Windows;

namespace GameHW6
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		int randomdigit; 
		int EnterDigit;
		int counterClick;

		public MainWindow()
		{
			InitializeComponent();
			randomdigit = RandomDigit();
		}

		public int RandomDigit()
		{
			return new Random().Next(1, 10);
		}

		private void infobtn_Click(object sender, RoutedEventArgs e)
		{
			var message = "You must enter a number from 1 to 10. You have 3 attempts. If you guess your victory.";

			var caption = "About Game";

			MessageBoxButton boxButton = MessageBoxButton.OK;

			MessageBox.Show(message, caption, boxButton);

			Startbtn.Visibility = Visibility.Visible;
		}

		private void Startbtn_Click(object sender, RoutedEventArgs e)
		{
			counterClick++;
			try
			{
				EnterDigit = int.Parse(digittbx.Text);

				if (EnterDigit < 1 || EnterDigit > 10)
				{
					throw new Exception("You must enter a number from 1 to 10");
				}
				if (EnterDigit == randomdigit)
				{
					MessageBox.Show("You guessed. Congratulations!");

					counterClick = 0;

					randomdigit = RandomDigit();
				}
				else if (counterClick != 3)
				{
					MessageBox.Show("Not lucky... But you have " + (3 - counterClick) + " more attempts");
				}
				else
				{
					MessageBox.Show("Not lucky... Guess the new number, have 3 attempts");

					randomdigit = RandomDigit();

					counterClick = 0;
				}
			}
			catch (FormatException formatexception)
			{
				MessageBox.Show(formatexception.Message);
			}
			catch (OverflowException overflowexception)
			{
				MessageBox.Show(overflowexception.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}