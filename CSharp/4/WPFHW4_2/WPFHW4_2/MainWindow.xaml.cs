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

namespace WPFHW4_2
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
			try
			{
				int day = int.Parse(daytbx.Text);
				int month = int.Parse(monthtbx.Text);
				int year = int.Parse(yeartbx.Text);

				if (day < 1 || day > 31)
				{
					throw new Exception("error input day");
				}
				else if (month < 1 || month > 12)
				{
					throw new Exception("error input month");
				}
				else if (year < 1900 || year > 2018)
				{
					throw new Exception("error input year");
				}
				else
				{
					string Yourzodiac = zodiac.MyZodiac(day, month, imglbl);

					MessageBox.Show(Yourzodiac);					
				}
			}
			catch (FormatException fex)
			{
				MessageBox.Show(fex.Message);
			}
			catch (OverflowException overex)
			{
				MessageBox.Show(overex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
