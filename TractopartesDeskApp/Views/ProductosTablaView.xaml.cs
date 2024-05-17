using System;
using System.Collections.Generic;
using System.Globalization;
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
using TractopartesDeskApp.Models.Managers;

namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para ProductosTablaView.xaml
    /// </summary>
    public partial class ProductosTablaView : Window
    {
        public ProductosTablaView()
        {
            InitializeComponent();
            MembersDataGrid.ItemsSource = ProductoManager.productos;
            MembersDataGrid.SelectedItem = null;
            MembersDataGrid.UnselectAllCells();
            
        }
        
        private void MembersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Close();  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
