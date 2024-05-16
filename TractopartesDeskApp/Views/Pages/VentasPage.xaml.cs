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
using TractopartesDeskApp.Models.Managers;
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Views.Pages
{
   
    public partial class VentasPage : Page
    {
        VentasViewModel ventasViewModel;
        public VentasPage()
        {
            InitializeComponent();
             ventasViewModel = new VentasViewModel();
            this.DataContext=ventasViewModel;
            MembersDataGrid.ItemsSource = ventasViewModel.DetallesVentaList;  
            txtb.FilterMode = AutoCompleteFilterMode.Contains;
            txtb.ItemsSource = ProductoManager.productos;
        }
        private void txtb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductoModel selectedItem = (ProductoModel)((AutoCompleteBox)sender).SelectedItem;
            if (selectedItem != null)
            {

               ventasViewModel._productoModel = selectedItem;
            }         
        }
    }
}
