using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
    /// Lógica de interacción para PassWordControl.xaml
    /// </summary>
    public partial class PassWordControl : UserControl
    {
        public PassWordControl()
        {
            InitializeComponent();
            txtPass.PasswordChanged += OnpasswordChanged;
        }

        private void OnpasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = txtPass.SecurePassword;
        }

        public static readonly DependencyProperty passwordproperty =
            DependencyProperty.Register("Password", typeof(SecureString),typeof(PassWordControl));
        public SecureString Password
        {
            get { return (SecureString)GetValue(passwordproperty); }
            set { SetValue(passwordproperty, value); }
        }

    }
}
