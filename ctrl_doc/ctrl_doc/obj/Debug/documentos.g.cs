﻿#pragma checksum "..\..\documentos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67CFF983253186F5AC9BF783808980784AE370DC"
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
using ctrl_doc;


namespace ctrl_doc {
    
    
    /// <summary>
    /// documentos
    /// </summary>
    public partial class documentos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\documentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitulo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\documentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgDocumentos;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\documentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_editar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\documentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_historial;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\documentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_cancelar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\documentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_habilitar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ctrl_doc;component/documentos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\documentos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.dgDocumentos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.menu_editar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\documentos.xaml"
            this.menu_editar.Click += new System.Windows.RoutedEventHandler(this.Menu_editar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.menu_historial = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\documentos.xaml"
            this.menu_historial.Click += new System.Windows.RoutedEventHandler(this.Menu_historial_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.menu_cancelar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\documentos.xaml"
            this.menu_cancelar.Click += new System.Windows.RoutedEventHandler(this.Menu_cancelar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menu_habilitar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\documentos.xaml"
            this.menu_habilitar.Click += new System.Windows.RoutedEventHandler(this.Menu_habilitar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

