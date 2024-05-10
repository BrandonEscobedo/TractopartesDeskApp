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

namespace TractopartesDeskApp.Views.Pages
{
    /// <summary>
    /// Lógica de interacción para Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        UsuariosView usuarios;
        public Test()
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
