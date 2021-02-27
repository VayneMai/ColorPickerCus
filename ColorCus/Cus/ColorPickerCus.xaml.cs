using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using ColorCus.Cus;

namespace ColorCus.Cus
{
	/// <summary>
	/// Interaction logic for ColorPickerCus.xaml
	/// </summary>
	public partial class ColorPickerCus : Window
	{
		string[] nameColor = new string[] { "Red", "Yellow", "Maroon", "OrangeRed", "DarkCyan", "DarkOrange", "Magenta", "DeepPink", "RoyalBlue" };
		List<PropertyInfo> inforProperties = new List<PropertyInfo>();
		public ColorPickerCus()
		{
			InitializeComponent();
			this.DataContext = this;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (var item in typeof(Brushes).GetProperties())
			{
				if (nameColor.Contains(item.Name)) { inforProperties.Add(item); }
			}
			this.colorList.ItemsSource = null;
			this.colorList.ItemsSource = inforProperties;
		}
		private void colorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Brush selectedColor = (Brush)(e.AddedItems[0] as PropertyInfo).GetValue(null, null);
			MainWindow.instance.btnOpen.Background = selectedColor;


			this.Close();
		}
		//ColorSelectionCus colorSelectionCus;
		private void btnColorSelection_Click(object sender, RoutedEventArgs e)
		{
			if (MainWindow.instance.ColorPickerCus != null)
			{
				MainWindow.instance.ColorPickerCus.Close();
			}
			MainWindow.instance.ColorSelectionCus = new ColorSelectionCus();
			if (MainWindow.instance.ColorSelectionCus.ShowDialog() == true)
			{

			}
		}
	}
}
