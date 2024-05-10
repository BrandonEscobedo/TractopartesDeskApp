using System.Windows;
using System.Windows.Input;
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para UsuariosView.xaml
    /// </summary>
    public partial class ProveedoresView : Window
    {

        public ProveedoresView()
        {
            InitializeComponent();
            DataContext = this;
            ProveedorByViewModel proveedorByViewModel = new ProveedorByViewModel();
            this.DataContext= proveedorByViewModel;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }


}
