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
using System.Windows.Shapes;

namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para UsuariosView.xaml
    /// </summary>
    public partial class UsuariosView : Window
    {
        public List<string> YourCollection { get; set; }

        public UsuariosView()
        {
            InitializeComponent();
            YourCollection = ["Elemento 1", "Elemento 2", "Elemento 3"];
            DataContext = this;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ClickCount == 2)
            //{
            //    this.WindowState = WindowState.Normal;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }


}
