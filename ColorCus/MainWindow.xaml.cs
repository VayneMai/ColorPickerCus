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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ColorCus.Cus;

namespace ColorCus
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static MainWindow instance;
		public ColorPickerCus ColorPickerCus;
		public ColorSelectionCus ColorSelectionCus;
		public MainWindow()
		{
			this.DataContext = this;
			instance = this;
			InitializeComponent();
		}

		private void btnOpen_Click(object sender, RoutedEventArgs e)
		{
			ColorPickerCus = new ColorPickerCus();
			if (ColorPickerCus.ShowDialog() == true)
			{

			}
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (ColorPickerCus!=null)
			{
				ColorPickerCus.Close();
			}
			if (ColorSelectionCus!=null)
			{
				ColorSelectionCus.Close();
			}
		}
	}
}
