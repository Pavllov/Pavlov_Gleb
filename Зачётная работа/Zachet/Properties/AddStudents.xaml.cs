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

namespace Zachet.Properties
{
	/// <summary>
	/// Логика взаимодействия для AddStudents.xaml
	/// </summary>
	public partial class AddStudents : Page
	{
		public AddStudents()
		{
			InitializeComponent();
			CBSPECI.SelectedValuePath = "Id";
			CBSPECI.DisplayMemberPath = "Name";
			CBSPECI.ItemsSource = BD.bazaDannix.Curs.ToList();
			CBFormTeach.SelectedValuePath = "Id";
			CBFormTeach.DisplayMemberPath = "Name";
			CBFormTeach.ItemsSource = BD.bazaDannix.FormaTeaching.ToList();
			CBNameGroup.SelectedValuePath = "Id";
			CBNameGroup.DisplayMemberPath = "Name";
			CBNameGroup.ItemsSource = BD.bazaDannix.Group.ToList();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				FIO fIO = new FIO()
				{
					FullName = TBFIO.Text,
					IdGroup = (int)CBNameGroup.SelectedValue,
					IdFormaTeaching = (int)CBFormTeach.SelectedValue,
					GodPostuplenia = Convert.ToInt32 (TbData.Text),
					IdCurs = (int)CBSPECI.SelectedValue,
				};
				BD.bazaDannix.FIO.Add(fIO);
				BD.bazaDannix.SaveChanges();
				MessageBox.Show("Студент добавлен","Поздравляю!",MessageBoxButton.OK);

			}
			catch (Exception )
			{

				throw;
			}

		}
	}
}
