﻿#pragma checksum "..\..\..\..\View\AppWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E830A39F6A0EA088A2F3122405AECE5ABF6D0989"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using InformatorMVVM.View;
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


namespace InformatorMVVM.View {
    
    
    /// <summary>
    /// AppWindow
    /// </summary>
    public partial class AppWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\View\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl contentControl;
        
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
            System.Uri resourceLocater = new System.Uri("/InformatorMVVM;component/view/appwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AppWindow.xaml"
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
            
            #line 12 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowWydarzenie);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowOrganizatorzy);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowKategorie);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 15 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowUzytkownicy);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 16 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowRezerwacje);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 17 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowOcenyUzytkownikow);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 18 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowTabelaKont);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 21 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowWydarzenieAdd);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 24 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowOrganizatorAdd);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 27 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowKategoriaAdd);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 30 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowUzytkownikAdd);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 33 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowRezerwacjaAdd);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 36 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowOcenyUzytkownikowAdd);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 39 "..\..\..\..\View\AppWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowTabelaKontAdd);
            
            #line default
            #line hidden
            return;
            case 15:
            this.contentControl = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

