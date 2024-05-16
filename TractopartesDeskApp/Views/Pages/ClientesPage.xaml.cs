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
    
    public partial class ClientesPage : Page
    {
        
        public ClientesPage()
        {
            InitializeComponent();
            UserByViewModel viewModel = new UserByViewModel();  
            this.DataContext=viewModel;
           
        }

        private bool OnFilter(string search, object item)
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        }
        private void txtbuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            MembersDataGrid.Items.Filter = OnFilter;
        }


        private bool OnFilter(object obj)
        {
            var cliente = (UserModel)obj;
            return cliente.nombres.Contains(txtbuscar.Text);
        }



    }
}
