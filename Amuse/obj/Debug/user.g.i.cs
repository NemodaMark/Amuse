// Updated by XamlIntelliSenseFileGenerator 2023. 03. 20. 19:49:14
#pragma checksum "..\..\user.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A1FD26EE96A6FDBD475D99F1F217ED8E10E9BE3D958CA2D694AB26EB31BDEB2"
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
    /// user
    /// </summary>
    public partial class user : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\user.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserPics;

#line default
#line hidden


#line 22 "..\..\user.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Username;

#line default
#line hidden


#line 23 "..\..\user.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userEmail;

#line default
#line hidden


#line 24 "..\..\user.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userRole;

#line default
#line hidden


#line 25 "..\..\user.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout;

#line default
#line hidden


#line 32 "..\..\user.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label wallet;

#line default
#line hidden


#line 33 "..\..\user.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userBalance;

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
            System.Uri resourceLocater = new System.Uri("/Amuse;component/user.xaml", System.UriKind.Relative);

#line 1 "..\..\user.xaml"
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
                    this.UserPics = ((System.Windows.Controls.Image)(target));
                    return;
                case 2:
                    this.Username = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.userEmail = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.userRole = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.Logout = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\user.xaml"
                    this.Logout.Click += new System.Windows.RoutedEventHandler(this.userBt_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.wallet = ((System.Windows.Controls.Label)(target));
                    return;
                case 7:
                    this.userBalance = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.Logout_Copy = ((System.Windows.Controls.Button)(target));

#line 34 "..\..\user.xaml"
                    this.Logout_Copy.Click += new System.Windows.RoutedEventHandler(this.userBt_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button deposit;
    }
}

