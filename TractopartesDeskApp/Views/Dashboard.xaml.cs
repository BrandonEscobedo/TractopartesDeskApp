using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using TractopartesDeskApp.Views.UserControls;
using TractopartesDeskApp.VIewModel;
using System.Windows.Navigation;
using TractopartesDeskApp.Views.Pages;
namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }


        public string DataSource
        {
            get
            {
                return (string)GetValue(DataProperty);
            }
            set { SetValue(DataProperty, value); }

        }
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("DataSource", typeof(string), typeof(MyTexBox));

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void pnlControlBAR_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);

        }

        private void pnlControlBAR_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }

 

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {



        }
        private void ProveedorChecked(object sender, RoutedEventArgs e)
        {
          txtitulo.Text = "Proveedores";
         MainContainerPage.NavigationService.Navigate(new ProveedoresPage()); 
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            txtitulo.Text = "Clientes";
            MainContainerPage.NavigationService.Navigate(new ClientesPage());
            
        }
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnEnviar_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void ProveedoresPanel_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MainContainerPage.NavigationService.Navigate(new CategoriasPage());
        }

        private void rbproductos_Checked(object sender, RoutedEventArgs e)
        {
            MainContainerPage.NavigationService.Navigate(new ProductosPage());
        }

        private void rbGenerarVenta_Checked(object sender, RoutedEventArgs e)
        {
            MainContainerPage.NavigationService.Navigate(new VentasPage());
        }
    }
}
