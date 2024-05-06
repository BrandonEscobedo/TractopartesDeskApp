using System.Windows;
using System.Windows.Input;

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

        private void CheckBox_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }
    }


}
