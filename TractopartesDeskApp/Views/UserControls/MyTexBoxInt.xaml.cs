using System.Windows;
using System.Windows.Controls;

namespace TractopartesDeskApp.Views.UserControls
{
    public partial class MyTexBoxInt : UserControl
    {
        public MyTexBoxInt()
        {
            InitializeComponent();
            txttexto.Text= string.Empty;
        }
        public int Hint
        {
            get
            {
                return (int)GetValue(HintProperty);
            }
            set { SetValue(HintProperty, value); }

        }
        public static readonly DependencyProperty HintProperty =
            DependencyProperty.Register("Hint", typeof(int), typeof(MyTexBoxInt));  
    
        public string Caption
        {
            get
            {
                return (string)GetValue(CaptionProperty);
            }
            set { SetValue(CaptionProperty, value); }

        }
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(MyTexBoxInt));

        public static readonly DependencyProperty DbProperty =
           DependencyProperty.Register("ValueDb", typeof(int), typeof(MyTexBoxInt));
        public int ValueDb
        {
            get
            {
                return (int)GetValue(DbProperty);
            }
            set { SetValue(DbProperty, value); }

        }

    }
}

