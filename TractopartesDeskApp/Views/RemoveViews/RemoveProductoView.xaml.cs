using QuestPDF.Fluent;
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

namespace TractopartesDeskApp.Views.RemoveViews
{
    /// <summary>
    /// Lógica de interacción para RemoveProductoView.xaml
    /// </summary>
    public partial class RemoveProductoView : Window
    {
        public RemoveProductoView()
        {
            InitializeComponent();
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
