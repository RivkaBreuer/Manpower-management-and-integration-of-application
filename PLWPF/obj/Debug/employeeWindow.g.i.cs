﻿#pragma checksum "..\..\employeeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2D05F38CEE1C51A9262C0D462788BFD8580F12A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// employeeWindow
    /// </summary>
    public partial class employeeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\employeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\employeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\employeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\employeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/employeewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\employeeWindow.xaml"
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
            this.addEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\employeeWindow.xaml"
            this.addEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.addEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.updateEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\employeeWindow.xaml"
            this.updateEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.updateEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.removeEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\employeeWindow.xaml"
            this.removeEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.removeEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\employeeWindow.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

