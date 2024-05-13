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
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Views.RemoveViews
{
    /// <summary>
    /// Lógica de interacción para RemoveClienteViews.xaml
    /// </summary>
    public partial class RemoveClienteView : Window
    {
        public RemoveClienteView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
