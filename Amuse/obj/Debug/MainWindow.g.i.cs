// Updated by XamlIntelliSenseFileGenerator 2023. 03. 06. 21:58:33
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BCC3A9FC74EA167D5275EE9ADA3DE5ACFEFEDE41AA87CC251507E15848EB494A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Amuse;
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


namespace Amuse
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;

#line default
#line hidden


#line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button restoreBt;

#line default
#line hidden


#line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizeBt;

#line default
#line hidden


#line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MenuGrid;

#line default
#line hidden


#line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel nowHot;

#line default
#line hidden


#line 151 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel myLibary;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Amuse;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.home = ((Amuse.MainWindow)(target));

#line 14 "..\..\MainWindow.xaml"
                    this.home.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.home_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.CloseButton = ((System.Windows.Controls.Button)(target));

#line 28 "..\..\MainWindow.xaml"
                    this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.closeBt_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.restoreBt = ((System.Windows.Controls.Button)(target));

#line 35 "..\..\MainWindow.xaml"
                    this.restoreBt.Click += new System.Windows.RoutedEventHandler(this.restoreBt_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.minimizeBt = ((System.Windows.Controls.Button)(target));

#line 53 "..\..\MainWindow.xaml"
                    this.minimizeBt.Click += new System.Windows.RoutedEventHandler(this.minimizeBt_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.MenuGrid = ((System.Windows.Controls.Grid)(target));
                    return;
                case 6:
                    this.nowHot = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 7:
                    this.myLibary = ((System.Windows.Controls.StackPanel)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window home;
    }
}

