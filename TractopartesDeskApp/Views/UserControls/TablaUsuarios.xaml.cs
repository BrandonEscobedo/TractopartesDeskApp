using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
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
          
        }

        public void UpdateUsers(ObservableCollection<UserModel> users) // New function
        {
            MembersDataGrid.ItemsSource = users;
        }
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
           
        }

  
  
    }
}
