﻿#pragma checksum "..\..\..\..\Views\Productos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9ED2C52EEBEC6A35F826ABFFEB5CC10D706135C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TractopartesDeskApp.Views;


namespace TractopartesDeskApp.Views {
    
    
    /// <summary>
    /// Productos
    /// </summary>
    public partial class Productos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 361 "..\..\..\..\Views\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncancelar;
        
        #line default
        #line hidden
        
        
        #line 362 "..\..\..\..\Views\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer PART_ContentHost;
        
        #line default
        #line hidden
        
        
        #line 394 "..\..\..\..\Views\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox;
        
        #line default
        #line hidden
        
        
        #line 399 "..\..\..\..\Views\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_Copiar;
        
        #line default
        #line hidden
        
        
        #line 407 "..\..\..\..\Views\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagenCliente;
        
        #line default
        #line hidden
        
        
        #line 410 "..\..\..\..\Views\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCargarFoto;
        
        #line default
        #line hidden
        
        
        #line 411 "..\..\..\..\Views\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGuardar;
        
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
            System.Uri resourceLocater = new System.Uri("/TractopartesDeskApp;component/views/productos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Productos.xaml"
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
            this.btncancelar = ((System.Windows.Controls.Button)(target));
            
            #line 361 "..\..\..\..\Views\Productos.xaml"
            this.btncancelar.Click += new System.Windows.RoutedEventHandler(this.btncancelar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PART_ContentHost = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.comboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.comboBox_Copiar = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.imagenCliente = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.btnCargarFoto = ((System.Windows.Controls.Button)(target));
            
            #line 410 "..\..\..\..\Views\Productos.xaml"
            this.btnCargarFoto.Click += new System.Windows.RoutedEventHandler(this.CARGARFOTO_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 411 "..\..\..\..\Views\Productos.xaml"
            this.BtnGuardar.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

