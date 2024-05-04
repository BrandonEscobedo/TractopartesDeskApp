using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Views.UserControls
{
    /// <summary>
    /// Lógica de interacción para TablaUsuarios.xaml
    /// </summary>
    public partial class TablaUsuarios : UserControl
    {
        public TablaUsuarios()
        {
            InitializeComponent();
            DataContext = this;
        }
        public static readonly DependencyProperty PathSource =
            DependencyProperty.Register("SourceList", typeof(ObservableCollection<UserModel>), typeof(TablaUsuarios));
        public ObservableCollection<UserModel> SourceList
        {
            get { return (ObservableCollection<UserModel>)GetValue(PathSource); }
            set { SetValue(PathSource, value);}
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            UsuariosView  usuarios = new UsuariosView();
            this.DataContext = usuarios.DataContext;
            usuarios.Show();
        }
    }
}
