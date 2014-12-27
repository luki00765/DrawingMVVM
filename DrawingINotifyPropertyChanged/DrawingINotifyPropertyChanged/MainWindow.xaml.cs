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

namespace DrawingINotifyPropertyChanged
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		EditingMode editingMode = new EditingMode();
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = editingMode;
		}

		private void InkBtn_Click(object sender, RoutedEventArgs e)
		{
			editingMode.EditMode = InkCanvasEditingMode.Ink;
			editingMode.Text = "Ink";
		}

		private void DrawBtn_Click(object sender, RoutedEventArgs e)
		{
			editingMode.EditMode = InkCanvasEditingMode.Select;
			editingMode.Text = "Draw";
		}
	}
}
