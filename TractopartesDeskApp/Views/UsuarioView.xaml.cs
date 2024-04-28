using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp
{
    
    public partial class MainWindow : Window
    {
     
        public MainWindow( )
        {
            InitializeComponent();
           
        }
  
       

       
        private void CleanTxt()
        {
            txtNombre.Clear();
            txtGenero.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtTelefono1.Clear();
            txtTelefono2.Clear();
            txtCorreo.Clear();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}