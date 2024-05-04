using System.Windows;
using TractopartesDeskApp.Views.UserControls;

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