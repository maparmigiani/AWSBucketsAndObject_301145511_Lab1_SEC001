#pragma checksum "..\..\..\CreateBucket.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12251DCE454D0674132AC11500AF9578A873BB4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using _301145511_ParmigianiDeAlmeida__Lab01;


namespace _301145511_ParmigianiDeAlmeida__Lab01 {
    
    
    /// <summary>
    /// CreateBucket
    /// </summary>
    public partial class CreateBucket : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxNewBucket;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblBucketName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreateBucket;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DtGridBuckets;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBackToMain;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblMessage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/301145511(ParmigianiDeAlmeida)_Lab01;component/createbucket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreateBucket.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\CreateBucket.xaml"
            ((_301145511_ParmigianiDeAlmeida__Lab01.CreateBucket)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtBoxNewBucket = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LblBucketName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BtnCreateBucket = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\CreateBucket.xaml"
            this.BtnCreateBucket.Click += new System.Windows.RoutedEventHandler(this.BtnCreateBucket_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DtGridBuckets = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.BtnBackToMain = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\CreateBucket.xaml"
            this.BtnBackToMain.Click += new System.Windows.RoutedEventHandler(this.BtnBackToMain_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LblMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

