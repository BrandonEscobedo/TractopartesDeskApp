﻿using System.Windows;
using System.Windows.Controls;

namespace TractopartesDeskApp.Views.UserControls
{
    public partial class MyTexBox : UserControl
    {
        public MyTexBox()
        {
            InitializeComponent();
        }
        public string Hint
        {
            get
            {
                return (string)GetValue(HintProperty);
            }
            set { SetValue(HintProperty, value); }

        }
        public static readonly DependencyProperty HintProperty =
            DependencyProperty.Register("Hint", typeof(string), typeof(MyTexBox));  
        public int HintInt
        {
            get
            {
                return (int)GetValue(HintIntProperty);
            }
            set { SetValue(HintIntProperty, value); }

        }
        public static readonly DependencyProperty HintIntProperty =
            DependencyProperty.Register("HintInt", typeof(int), typeof(MyTexBox));
        public string Caption
        {
            get
            {
                return (string)GetValue(CaptionProperty);
            }
            set { SetValue(CaptionProperty, value); }

        }
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(MyTexBox));


        public static readonly DependencyProperty DbProperty =
           DependencyProperty.Register("ValueDb", typeof(string), typeof(MyTexBox));
        public string ValueDb
        {
            get
            {
                return (string)GetValue(DbProperty);
            }
            set { SetValue(DbProperty, value); }

        }

    }
}

