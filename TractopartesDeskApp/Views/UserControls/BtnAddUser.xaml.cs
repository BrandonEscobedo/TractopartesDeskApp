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

namespace TractopartesDeskApp.Views.UserControls
{
    /// <summary>
    /// Lógica de interacción para BtnAddUser.xaml
    /// </summary>
    public partial class BtnAddUser : UserControl
    {
        public BtnAddUser()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            UsuariosView usuarios = new UsuariosView();
            usuarios.DataContext = this.DataContext;
            usuarios.Show();
        }
    }
}
