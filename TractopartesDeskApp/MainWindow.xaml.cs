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
        private readonly ISqlDataAccess SqlDataAccess;
        public MainWindow(ISqlDataAccess sqlDataAccess)
        {
            InitializeComponent();
            SqlDataAccess = sqlDataAccess;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            UserModel model = new UserModel();
            model.p_nombres = txtNombre.Text;
            model.p_apellidomaterno = txtApMaterno.Text;
            model.p_apellidopaterno = txtApPaterno.Text;
            model.p_genero = txtGenero.Text;
            model.telefono1 = Convert.ToInt32(txtTelefono1.Text);
            model.telefono2 = Convert.ToInt32(txtTelefono2.Text);
            model.email = txtCorreo.Text;
           bool response= await SqlDataAccess.SaveData("public.crearusuariosdatospersonales", model) ;
            if (response) CleanTxt();
        }
        private void CleanTxt()
        {
            txtNombre.Clear();
            txtGenero.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}