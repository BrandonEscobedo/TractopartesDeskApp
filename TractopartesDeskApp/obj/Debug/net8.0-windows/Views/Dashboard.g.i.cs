﻿#pragma checksum "..\..\..\..\Views\Dashboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F061D9CD89E50D9C836A5E01F772AAA573F435C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TractopartesDeskApp.VIewModel;
using TractopartesDeskApp.Views;
using TractopartesDeskApp.Views.UserControls;


namespace TractopartesDeskApp.Views {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 129 "..\..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlControlBAR1;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose1;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximize1;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize1;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridContainer;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl BtnContentContainer;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ContentContainer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TractopartesDeskApp;component/views/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Dashboard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 70 "..\..\..\..\Views\Dashboard.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 79 "..\..\..\..\Views\Dashboard.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_3);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 88 "..\..\..\..\Views\Dashboard.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pnlControlBAR1 = ((System.Windows.Controls.StackPanel)(target));
            
            #line 135 "..\..\..\..\Views\Dashboard.xaml"
            this.pnlControlBAR1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pnlControlBAR_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\..\Views\Dashboard.xaml"
            this.pnlControlBAR1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.pnlControlBAR_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClose1 = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\..\..\Views\Dashboard.xaml"
            this.btnClose1.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnMaximize1 = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\..\Views\Dashboard.xaml"
            this.btnMaximize1.Click += new System.Windows.RoutedEventHandler(this.btnMaximize_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMinimize1 = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\..\..\Views\Dashboard.xaml"
            this.btnMinimize1.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.gridContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.BtnContentContainer = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 10:
            this.ContentContainer = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

