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
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Models.Managers;

namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para ClientesTablaView.xaml
    /// </summary>
    public partial class ClientesTablaView : Window
    {
        public ClientesTablaView()
        {
            InitializeComponent();
            MembersDataGrid.ItemsSource = Usermanager.Users;

            MembersDataGrid.UnselectAllCells();

        }

        private void MembersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
