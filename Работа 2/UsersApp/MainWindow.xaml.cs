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

namespace UsersApp
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string login = textBoxLogin.Text.Trim();
			string pass = passBox.Password.Trim();
			string pass2 = passBox2.Password.Trim();
			string email = textBoxEmail.Text.ToLower().Trim();

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
			if (pass != pass2)
			{
				passBox2.ToolTip = "пароли не совпадают!";
				passBox2.Background = Brushes.Red;
			}
			else
			if ( !email.Contains("@") || !email.Contains("."))
			{
				textBoxEmail.ToolTip = "Проверьте наличие @ и . ";
				textBoxEmail.Background = Brushes.Red;
			}

			else
			{
				textBoxLogin.ToolTip = "";
				textBoxLogin.Background = Brushes.Transparent;
				passBox.ToolTip = "";
				passBox.Background = Brushes.Transparent;
				passBox2.ToolTip = "";
				passBox2.Background = Brushes.Transparent;
				textBoxEmail.ToolTip = "";
				textBoxEmail.Background = Brushes.Transparent;
				MessageBox.Show("вы успешно зарегистрировались!");
			}
				
			
			
		
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			JoinIn joinIn = new JoinIn();
			joinIn.Show();
			this.Hide();
		}
	}
}
