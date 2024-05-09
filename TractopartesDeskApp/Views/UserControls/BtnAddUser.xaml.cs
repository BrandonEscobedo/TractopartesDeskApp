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
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Views.UserControls
{
    /// <summary>
    /// Lógica de interacción para BtnAddUser.xaml
    /// </summary>
    public partial class BtnAddUser : UserControl
    {
        public Type WindowType { get; set; }
        public UserByViewModel viewModel;
        public BtnAddUser()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (WindowType != null && WindowType.IsSubclassOf(typeof(Window)))
            {
                // Crea una instancia de la ventana T
                Window windowInstance = (Window)Activator.CreateInstance(WindowType);
                // Muestra la ventana
                windowInstance.DataContext = viewModel;
                windowInstance.Show();
            }
            else
            {
                MessageBox.Show("Tipo de ventana no válido");
            }
       
        }
    }
}
