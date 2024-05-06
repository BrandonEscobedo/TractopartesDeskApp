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

namespace TractopartesDeskApp.Views.UserControls
{
    /// <summary>
    /// Lógica de interacción para BtnAddUser.xaml
    /// </summary>
    public partial class BtnAddUser : UserControl
    {
        public Type WindowType { get; set; }
        public string ad="";
        public BtnAddUser()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (WindowType != null && WindowType.IsSubclassOf(typeof(Window)))
            {
                // Crea una instancia de la ventana T
                Window windowInstance = (Window)Activator.CreateInstance(WindowType);
                // Muestra la ventana
                windowInstance.DataContext = this.DataContext;
                windowInstance.Show();
            }
            else
            {
                MessageBox.Show("Tipo de ventana no válido");
            }
       
        }
    }
}
