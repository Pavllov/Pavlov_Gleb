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
using Zachet.Properties;

namespace Zachet
{
	/// <summary>
	/// Логика взаимодействия для MainMain.xaml
	/// </summary>
	public partial class MainMain : Page
	{
		public MainMain()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ClassButton.Sanya.Navigate(new AddStudents());
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			ClassButton.Sanya.Navigate(new Mark());
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			ClassButton.Sanya.Navigate(new ListStudents());
		}
	}
}
