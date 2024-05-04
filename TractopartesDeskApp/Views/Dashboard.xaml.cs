﻿using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace TractopartesDeskApp.Views
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            dglist.Focusable = true;



        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void pnlControlBAR_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);

        }

        private void pnlControlBAR_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            UsuariosView usuariosView= new UsuariosView();
            usuariosView.Show();
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            
            
                dglist.Visibility = Visibility.Visible;
            btnEnviar.Visibility=Visibility.Visible;

            
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            dglist.Visibility = Visibility.Collapsed;
            dglist.Focus();
            btnEnviar.Visibility = Visibility.Hidden;
        }
    }
}
