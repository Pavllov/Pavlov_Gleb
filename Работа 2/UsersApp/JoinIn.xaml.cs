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
using System.Windows.Shapes;

namespace UsersApp
{
	/// <summary>
	/// Логика взаимодействия для JoinIn.xaml
	/// </summary>
	public partial class JoinIn : Window
	{
		public JoinIn()
		{
			InitializeComponent();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			string login = textBoxLogin.Text.Trim();
			string pass = passBox.Password.Trim();

			if (login.Length < 4)
			{
				textBoxLogin.ToolTip = "Ваш логин меньше 4 символов";
				textBoxLogin.Background = Brushes.Red;
			}
			else
			if (pass.Length < 4)
			{
				passBox.ToolTip = "Ваш пароль меньше 4 символов";
				passBox.Background = Brushes.Red;
			}
			else
			{
				textBoxLogin.ToolTip = "";
				textBoxLogin.Background = Brushes.Transparent;
				passBox.ToolTip = "";
				passBox.Background = Brushes.Transparent;

				MessageBox.Show("Вы вошли");
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Hide();
		}
	}
}
