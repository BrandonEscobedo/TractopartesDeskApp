using System.Windows;
using System.Windows.Input;

namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para ProductosView.xaml
    /// </summary>
    public partial class ProductosView : Window
    {
        public ProductosView()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton==MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
