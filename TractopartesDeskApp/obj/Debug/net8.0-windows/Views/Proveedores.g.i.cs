﻿#pragma checksum "..\..\..\..\Views\Proveedores.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3FF4361938B7040BBFBE9204AF10D28FD2448AD0"
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
    /// Proveedores
    /// </summary>
    public partial class Proveedores : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\..\Views\Proveedores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreEmpresa;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\Proveedores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRazonSocial;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\Proveedores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\Proveedores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\Proveedores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCorreo;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\Proveedores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\Proveedores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/TractopartesDeskApp;component/views/proveedores.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Proveedores.xaml"
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
            this.txtNombreEmpresa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtRazonSocial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Views\Proveedores.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\Views\Proveedores.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

