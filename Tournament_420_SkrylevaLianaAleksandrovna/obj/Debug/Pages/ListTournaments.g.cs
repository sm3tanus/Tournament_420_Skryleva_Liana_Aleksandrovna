﻿#pragma checksum "..\..\..\Pages\ListTournaments.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C5E7E9D7EE50C54565CBBB8A65DD9A742BC1502D8230E406C8AAE643185F2E7"
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
using Tournament_420_SkrylevaLianaAleksandrovna.Pages;


namespace Tournament_420_SkrylevaLianaAleksandrovna.Pages {
    
    
    /// <summary>
    /// ListTournaments
    /// </summary>
    public partial class ListTournaments : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Pages\ListTournaments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterStatus;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\ListTournaments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBt;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\ListTournaments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBt;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\ListTournaments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resetBt;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\ListTournaments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTournamentsLv;
        
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
            System.Uri resourceLocater = new System.Uri("/Tournament_420_SkrylevaLianaAleksandrovna;component/pages/listtournaments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ListTournaments.xaml"
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
            this.FilterStatus = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\Pages\ListTournaments.xaml"
            this.FilterStatus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterStatus_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddBt = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\ListTournaments.xaml"
            this.AddBt.Click += new System.Windows.RoutedEventHandler(this.AddBt_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitBt = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\ListTournaments.xaml"
            this.ExitBt.Click += new System.Windows.RoutedEventHandler(this.ExitBt_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.resetBt = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\ListTournaments.xaml"
            this.resetBt.Click += new System.Windows.RoutedEventHandler(this.resetBt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListTournamentsLv = ((System.Windows.Controls.ListView)(target));
            
            #line 61 "..\..\..\Pages\ListTournaments.xaml"
            this.ListTournamentsLv.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListTournamentsLv_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

