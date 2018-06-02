using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW3
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Submitbtn_Click(object sender, RoutedEventArgs e)
		{
			RegistHuman();
			string info = registration.FirstName + Environment.NewLine +
				registration.LastName + Environment.NewLine +
				registration.Birthday + Environment.NewLine +				
				registration.Gender + Environment.NewLine +
				registration.Email + Environment.NewLine +
				registration.PhoneNumber + Environment.NewLine +
				registration.AdditionalInfo + Environment.NewLine;
			MessageBox.Show("Result:"+Environment.NewLine+info);
		}

		Registration registration = new Registration();

		public void RegistHuman()
		{
			string FirstName = FirstNametbx.Text,
				LastName = LastNametbx.Text,
				PhoneNumber = PhoneNumberTBX.Text,
				Email = Emailtbx.Text,
				AdditionalInfo = Addinfotbx.Text;

			long longresphone;

			int day, month, year;

			bool isday = int.TryParse(daytbx.Text, out day);
			bool ismonth = int.TryParse(monthtbx.Text, out month);
			bool isyear = int.TryParse(yeartbx.Text, out year);

			if (!registration.CheckInfo(FirstName))
			{
				MessageBox.Show("Error entering field FirstName!");
				registration.FirstName = "";
			}
			else
			{
				registration.FirstName = FirstName;
			}

			if (!registration.CheckInfo(LastName))
			{
				MessageBox.Show("Error entering field LastName!");
				registration.LastName = "";
			}
			else
			{
				registration.LastName = LastName;
			}

			if (!Email.Contains('@') || Email.Length > 255)
			{
				MessageBox.Show("Error entering field Email!");
				registration.Email = "";
			}
			else
			{
				registration.Email = Email;
			}

			if (!long.TryParse(PhoneNumber, out longresphone) || PhoneNumber.Length != 12)
			{
				MessageBox.Show("Error entering field Phone Number!");
				registration.PhoneNumber = "";
			}
			else
			{
				registration.PhoneNumber = PhoneNumber;
			}

			if (AdditionalInfo.Length > 2000 || AdditionalInfo.Length < 5)
			{
				MessageBox.Show("Error entering field Additional Info!");
				registration.AdditionalInfo = "";
			}
			else
			{
				registration.AdditionalInfo = AdditionalInfo;
			}

			if (!isday || !ismonth || !isyear)
			{
				MessageBox.Show("Error entering field BirthDay!");
				registration.Birthday = "";
			}
			else
			{
				registration.Birthday = BirthDay(day, month, year);
			}
		}

		public string BirthDay(int day, int month, int year)
		{
			string _res = "";

			if (day > 0 && day < 32 && month > 0 && month < 13 && year > 1900 && year < 2018)
			{
				_res = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
			}
			else
			{
				MessageBox.Show("Error entering field BirthDay!");
			}
			return _res;
		}
		
		private void Male_or_Femalecmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (Male_or_Femalecmbx.SelectedIndex == 0)
			{
				registration.Gender = "Male";
			}
			else
			{
				registration.Gender = "Female";
			}
		}
	}
}