﻿#pragma checksum "..\..\modifierRapportsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A8C10EC57CA21C5A4AA78865C1DB909A48C9E1DD579A6A1E8A6BEFBB78EA9FB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GsbRapports;
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


namespace GsbRapports {
    
    
    /// <summary>
    /// modifierRapportsWindow
    /// </summary>
    public partial class modifierRapportsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\modifierRapportsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbVisiteur;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\modifierRapportsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDate;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\modifierRapportsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChercher;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\modifierRapportsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\modifierRapportsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMotif;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\modifierRapportsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBilan;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\modifierRapportsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnValider;
        
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
            System.Uri resourceLocater = new System.Uri("/GsbRapports;component/modifierrapportswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\modifierRapportsWindow.xaml"
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
            this.cmbVisiteur = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\modifierRapportsWindow.xaml"
            this.cmbVisiteur.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbVisiteur_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbDate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btnChercher = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\modifierRapportsWindow.xaml"
            this.btnChercher.Click += new System.Windows.RoutedEventHandler(this.btnChercher_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dtg = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.txtMotif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtBilan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnValider = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\modifierRapportsWindow.xaml"
            this.btnValider.Click += new System.Windows.RoutedEventHandler(this.btnValider_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
