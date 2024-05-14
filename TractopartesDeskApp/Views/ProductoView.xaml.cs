using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para ProductoView.xaml
    /// </summary>
    public partial class ProductoView : Window
    {
        public ProductoView()
        {
            InitializeComponent();
            this.DataContext = new ProductosViewModel();
            CategoriaViewModel categoriaViewModel = new CategoriaViewModel();
            combocategorias.ItemsSource = categoriaViewModel.CategoriasList;
            WindowProveedorViewModel proveedorByView = new WindowProveedorViewModel();
            comboProveedor.ItemsSource = proveedorByView.Proveedores;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog()==true)
            {
                try
                {
                    BitmapImage imagen = new BitmapImage(new Uri(openFileDialog.FileName));
                    imgProducto.Source = imagen;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void texBosx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
             
        }
    }
}
