﻿#pragma checksum "..\..\..\Editors\EditorBinanceFutures.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C0E277F85C6173B7FBF88EA0FDCA279AB50CA48F49FAE066C330070DE950417A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BinanceOptionsApp.Controls;
using BinanceOptionsApp.CustomStyles;
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


namespace BinanceOptionsApp.Editors {
    
    
    /// <summary>
    /// EditorBinanceFutures
    /// </summary>
    public partial class EditorBinanceFutures : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Editors\EditorBinanceFutures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTradeType;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Editors\EditorBinanceFutures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buAccept;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Editors\EditorBinanceFutures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/BinanceOptionsApp;component/editors/editorbinancefutures.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Editors\EditorBinanceFutures.xaml"
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
            
            #line 7 "..\..\..\Editors\EditorBinanceFutures.xaml"
            ((BinanceOptionsApp.Editors.EditorBinanceFutures)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\Editors\EditorBinanceFutures.xaml"
            ((BinanceOptionsApp.Editors.EditorBinanceFutures)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbTradeType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.buAccept = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Editors\EditorBinanceFutures.xaml"
            this.buAccept.Click += new System.Windows.RoutedEventHandler(this.BuAccept_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buCancel = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Editors\EditorBinanceFutures.xaml"
            this.buCancel.Click += new System.Windows.RoutedEventHandler(this.BuCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

