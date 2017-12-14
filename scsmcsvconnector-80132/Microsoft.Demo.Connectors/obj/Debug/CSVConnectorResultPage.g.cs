﻿#pragma checksum "..\..\CSVConnectorResultPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3DD124593B2101350DBA5C4316D0B1C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Demo.Connectors.CSV;
using Microsoft.EnterpriseManagement.UI.WpfWizardFramework;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Microsoft.Demo.Connectors.CSV {
    
    
    /// <summary>
    /// CSVConnectorResultPage
    /// </summary>
    public partial class CSVConnectorResultPage : Microsoft.EnterpriseManagement.UI.WpfWizardFramework.WizardResultPageBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.Grid controlGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.Image completionImage;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.TextBlock titleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.TextBox errorTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.StackPanel stackPanel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.Label displaynameLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.TextBox displaynameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.Label datafilepathLabel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.TextBox datafilepathTextBlock;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.Label mappingfilepathLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.TextBox mappingfilepathTextBlock;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.Label scheduleLabel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.TextBox numberminutesTextBlock;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\CSVConnectorResultPage.xaml"
        internal System.Windows.Controls.Label completionLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Microsoft.Demo.Connectors;component/csvconnectorresultpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CSVConnectorResultPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.controlGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.completionImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.titleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.errorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 6:
            this.stackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.displaynameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.displaynameTextBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.datafilepathLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.datafilepathTextBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.mappingfilepathLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.mappingfilepathTextBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.scheduleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.numberminutesTextBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.completionLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}