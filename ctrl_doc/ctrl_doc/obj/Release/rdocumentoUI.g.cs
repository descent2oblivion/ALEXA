﻿#pragma checksum "..\..\rdocumentoUI.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E51821CA1A6B5091B3B3762444D7189C3D45FBA7BAA1EC8FA3598FA2CCF4A40"
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
    /// rdocumentoUI
    /// </summary>
    public partial class rdocumentoUI : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitulo;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodigo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreDoc;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxResponsable;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtComentarios;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAut;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxRama;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxCarpeta;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\rdocumentoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReg;
        
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
            System.Uri resourceLocater = new System.Uri("/ctrl_doc;component/rdocumentoui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\rdocumentoUI.xaml"
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
            this.txtCodigo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNombreDoc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbxResponsable = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\rdocumentoUI.xaml"
            this.cbxResponsable.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CbxResponsable_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtComentarios = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtAut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbxRama = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.cbxCarpeta = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.btnReg = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

