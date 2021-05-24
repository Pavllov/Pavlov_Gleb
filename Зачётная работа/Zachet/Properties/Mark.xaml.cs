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
	/// Логика взаимодействия для Mark.xaml
	/// </summary>
	public partial class Mark : Page
	{
		public Mark()
		{
			InitializeComponent();
			CBGroup.SelectedValuePath = "Id";
			CBGroup.DisplayMemberPath = "Name";
			CBGroup.ItemsSource = BD.bazaDannix.Group.ToList();

			CBStudent.SelectedValuePath = "Id";
			CBStudent.DisplayMemberPath = "FullName";
			CBStudent.ItemsSource = BD.bazaDannix.FIO.ToList();

			CBDis.SelectedValuePath = "Id";
			CBDis.DisplayMemberPath = "Name";
			CBDis.ItemsSource = BD.bazaDannix.Disceplina.ToList();

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				Jurnal jurnal = new Jurnal()
				{
					IdFIO = (int)CBStudent.SelectedValue,
					IdDisceplina = (int)CBDis.SelectedValue,
					Mark = Convert.ToInt32(TbMark.Text),

				};
				BD.bazaDannix.Jurnal.Add(jurnal);
				BD.bazaDannix.SaveChanges();
				MessageBox.Show("Оценка студенту поставлена","Поздравляю!",MessageBoxButton.OK);

			}
			catch (Exception )
			{

				throw;
			}
		}
	}
}
