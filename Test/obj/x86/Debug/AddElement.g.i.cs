﻿#pragma checksum "..\..\..\AddElement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6F4EB0207232E184E6D1F14F9EEA6D66"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Test {
    
    
    /// <summary>
    /// AddElement
    /// </summary>
    public partial class AddElement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tbCar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpick;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbHours;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMinuts;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPurposesOfUsingAuto;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCargo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRoute;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLastName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel hide;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNameDocument;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AddElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/addelement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddElement.xaml"
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
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbCar = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\AddElement.xaml"
            this.tbCar.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tbCar_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dtpick = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.tbHours = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbMinuts = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cbPurposesOfUsingAuto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.tbCargo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbRoute = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.hide = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.tbNameDocument = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.btnAddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\AddElement.xaml"
            this.btnAddOrder.Click += new System.Windows.RoutedEventHandler(this.btnAddOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

