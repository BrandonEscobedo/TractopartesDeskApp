using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Views.UserControls
{
    /// <summary>
    /// Lógica de interacción para TablaUsuarios.xaml
    /// </summary>
    public partial class TablaUsuarios : UserControl
    {
        UsuariosView usuarios;
        public TablaUsuarios()
        {
            InitializeComponent();
            Loaded += MembersDataGrid_Loaded;

        }

        private void MembersDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            usuarios = new UsuariosView();
            usuarios.DataContext = this.DataContext;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (usuarios == null || !usuarios.IsVisible)
            {
                usuarios = new();

                usuarios.DataContext = this.DataContext;
            }
            else
            {
                usuarios.Focus();
            }
            usuarios.Show();
        }
    }
}
