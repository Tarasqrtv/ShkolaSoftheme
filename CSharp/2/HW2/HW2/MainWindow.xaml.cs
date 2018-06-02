using System.Windows;
using System.Windows.Controls;

namespace HW2
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

		private void ListBoxTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var selectedItem = (ListBoxItem)type.SelectedItem;

			switch (selectedItem.Content.ToString())
			{
				case "int":
					ShowIntValue();
					break;
				case "long":
					ShowLongValue();
					break;
				case "float":
					ShowFloatValue();
					break;
				case "double":
					ShowDoubleValue();
					break;
				case "decimal":
					ShowDecimalValue();
					break;
			}
		}

		private void ShowIntValue()
		{
			maxvalue.Text = int.MaxValue.ToString();
			minvalue.Text = int.MinValue.ToString();
		}

		private void ShowLongValue()
		{
			maxvalue.Text = long.MaxValue.ToString();
			minvalue.Text = long.MinValue.ToString();
		}

		private void ShowFloatValue()
		{
			maxvalue.Text = float.MaxValue.ToString();
			minvalue.Text = float.MinValue.ToString();
		}

		private void ShowDoubleValue()
		{
			maxvalue.Text = double.MaxValue.ToString();
			minvalue.Text = double.MinValue.ToString();
		}

		private void ShowDecimalValue()
		{
			maxvalue.Text = decimal.MaxValue.ToString();
			minvalue.Text = decimal.MinValue.ToString();
		}

		private void QuitClick(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}