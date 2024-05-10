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
            txtbuscar.DataContext = this.DataContext;
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (usuarios == null || !usuarios.IsVisible)
            {
                usuarios = new();
                this.DataContext = usuarios.DataContext;
                txtbuscar.Text = "";
                usuarios.txtnombres.txttexto.Text = "";
            }
            else
            {
                usuarios.Focus();
            }
            usuarios.Show();
        }
    }
}
