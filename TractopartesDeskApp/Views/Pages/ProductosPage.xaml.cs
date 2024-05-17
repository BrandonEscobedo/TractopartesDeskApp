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
    /// Lógica de interacción para ProductosPage.xaml
    /// </summary>
    public partial class ProductosPage : Page
    {
        private string filtroSeleccionado;

        public ProductosPage()
        {
            InitializeComponent();
            ProductosManagerViewModel productosManagerViewModel = new();
            this.DataContext = productosManagerViewModel;
            filtroSeleccionado = "Nombre";
            comboSelectedBuscar.SelectedIndex=0;
            MembersDataGrid.Items.Filter = OnFilter;
        }

        private void txtbuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            MembersDataGrid.Items.Filter = OnFilter;
        }
        private bool OnFilter(object obj)
        {

            var nombreProducto = (ProductoModel)obj;
            switch (filtroSeleccionado.ToString())
            {
                case "Nombre":
                    return nombreProducto.p_productonombre.Contains(txtbuscar.Text);
                case "Categoria":
                    return nombreProducto.p_categoria.categoria.Contains(txtbuscar.Text);
                case "Codigo de Pieza":
                    return nombreProducto.p_codigopieza.Contains(txtbuscar.Text);
                case "Proveedor Razon Social":
                    return nombreProducto.p_proveedor.razonsocial.Contains(txtbuscar.Text);

                default:
                    return false;

            }

        }



        private void comboSelectedBuscar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem itemseleccionado = (ComboBoxItem)comboSelectedBuscar.SelectedItem;
             filtroSeleccionado=itemseleccionado.Content.ToString();
            MembersDataGrid.Items.Filter = OnFilter;
        }
    }
}
