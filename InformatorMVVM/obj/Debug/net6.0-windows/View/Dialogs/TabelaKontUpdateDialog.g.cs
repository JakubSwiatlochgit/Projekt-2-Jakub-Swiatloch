﻿#pragma checksum "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A032AAEEBBF5A6A5B97CF62986929E4B11BF7439"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using InformatorMVVM.View.Dialogs;
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


namespace InformatorMVVM.View.Dialogs {
    
    
    /// <summary>
    /// TabelaKontUpdateDialog
    /// </summary>
    public partial class TabelaKontUpdateDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tabelaKontEmail;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tabelaKontHaslo;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tabelaKontAdres;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InformatorMVVM;component/view/dialogs/tabelakontupdatedialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tabelaKontEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tabelaKontHaslo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tabelaKontAdres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\View\Dialogs\TabelaKontUpdateDialog.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.EditTabelaKont);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

