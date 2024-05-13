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
using TractopartesDeskApp.Stores;
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Views.Pages
{
    /// <summary>
    /// Lógica de interacción para Test.xaml
    /// </summary>
        public partial class ClientesPage : Page
        {
           public UsuariosStore productosPage;
            public AddUserByViewModel addUserByViewModel;
            public UserByViewModel userByViewModel;
            public MainClientesViewModel mainClientesViewModel;
            public ClientesPage()
            {
                InitializeComponent();
                productosPage = new UsuariosStore();
                addUserByViewModel = new AddUserByViewModel(productosPage);
                userByViewModel = new UserByViewModel(productosPage);
                mainClientesViewModel = new MainClientesViewModel(addUserByViewModel, userByViewModel);
                this.DataContext = mainClientesViewModel.UserByViewModel;
            }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //UsuariosView usuarios = new()
            //{
            //    DataContext = mainClientesViewModel.CreateUserViewModel
            //};
            //usuarios.Show();
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
