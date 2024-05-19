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
            this.DataContext = ventasViewModel;
            MembersDataGrid.ItemsSource = ventasViewModel.DetallesVentaList;
            MembersDataGrid.DataContext = ventasViewModel.DetallesVentaList;
            txtb.FilterMode = AutoCompleteFilterMode.Contains;
            txtb.ItemsSource = ventasViewModel.Productos;
            txtb.DataContext = ventasViewModel;
        }
        private void txtb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductoModel selectedItem = (ProductoModel)((AutoCompleteBox)sender).SelectedItem;
            if (selectedItem != null)
            {

                ventasViewModel._productoModel = selectedItem;
            }
        }

        private void MembersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MembersDataGrid.SelectedItems.Count > 0)
            {
                foreach (var item in MembersDataGrid.SelectedItems)
                {
                    var obj = (DetalleVentaModel)item;
                    if (obj != null)
                    {
                        
                      
                    }
                }
            }


        }
    }
}
