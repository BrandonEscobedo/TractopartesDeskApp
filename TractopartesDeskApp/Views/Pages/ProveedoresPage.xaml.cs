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
using TractopartesDeskApp.Models;
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Views.Pages
{
    /// <summary>
    /// Lógica de interacción para ProveedoresPage.xaml
    /// </summary>
    public partial class ProveedoresPage : Page
    {
        public ProveedoresPage()
        {
            InitializeComponent();
            WindowProveedorViewModel windowProveedor = new WindowProveedorViewModel();
            this.DataContext=windowProveedor;
        }
        private void txtbuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            MembersDataGrid.Items.Filter = OnFilter;
        }

        private bool OnFilter(object obj)
        {
            var proveedor = (ProveedorModel)obj;
            return proveedor.nombreempresa.Contains(txtbuscar.Text);



        }
    }
}
