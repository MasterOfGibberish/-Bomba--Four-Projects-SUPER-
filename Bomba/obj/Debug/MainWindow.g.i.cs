// Updated by XamlIntelliSenseFileGenerator 7/15/2023 6:25:55 PM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7B65E3C4EA5BB3CBD3FC864DF1E9F83EFBF6FCFDC51E2F888F25DE6F51089688"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bomba;
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


namespace Bomba
{


    /// <summary>
    /// LoginScreen
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Passwordas;

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
            System.Uri resourceLocater = new System.Uri("/Bomba;component/mainwindow.xaml", System.UriKind.Relative);

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
                    this.Usernameas = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.Passwordas = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 3:
                    this.SubmitButton = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\MainWindow.xaml"
                    this.SubmitButton.Click += new System.Windows.RoutedEventHandler(this.SubmitButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.SignUP = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\MainWindow.xaml"
                    this.SignUP.Click += new System.Windows.RoutedEventHandler(this.SignUP_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label Animacija;
        internal System.Windows.Controls.Button Submit;
        internal System.Windows.Controls.Label Trys;
        internal System.Windows.Controls.Label Trys1;
        internal System.Windows.Controls.Label Trys2;
        internal System.Windows.Controls.Label Trys4;
        internal System.Windows.Controls.Label Trys5;
        internal System.Windows.Controls.Label Du;
        internal System.Windows.Controls.Label Du1;
        internal System.Windows.Controls.Label Du2;
        internal System.Windows.Controls.Label Du3;
        internal System.Windows.Controls.Label Du4;
        internal System.Windows.Controls.Label Du5;
        internal System.Windows.Controls.Label Vienas;
        internal System.Windows.Controls.Label Vienas1;
        internal System.Windows.Controls.Label Vienas2;
        internal System.Windows.Controls.Label Vienas3;
        internal System.Windows.Controls.Label Vienas4;
        internal System.Windows.Controls.Label Vienas5;
        internal System.Windows.Controls.Label Vienas6;
    }
}
