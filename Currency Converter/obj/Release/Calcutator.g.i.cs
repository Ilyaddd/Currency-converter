﻿#pragma checksum "..\..\Calcutator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97E87E19EC7FA8A258E2B24E1BA4A20E1A1B45E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Currency_Converter;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Currency_Converter {
    
    
    /// <summary>
    /// Calcutator
    /// </summary>
    public partial class Calcutator : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BYN_Field;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox USD_Field;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RUB_Field;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EUR_Field;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UAH_Field;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cur_Input;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cur_Output;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Output;
        
        #line default
        #line hidden
        
        /// <summary>
        /// Date Name Field
        /// </summary>
        
        #line 231 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Label Date;
        
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
            System.Uri resourceLocater = new System.Uri("/Currency Converter;component/calcutator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Calcutator.xaml"
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
            
            #line 12 "..\..\Calcutator.xaml"
            ((Currency_Converter.Calcutator)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BYN_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\Calcutator.xaml"
            this.BYN_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BYN_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 68 "..\..\Calcutator.xaml"
            this.BYN_Field.GotFocus += new System.Windows.RoutedEventHandler(this.BYN_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 68 "..\..\Calcutator.xaml"
            this.BYN_Field.LostFocus += new System.Windows.RoutedEventHandler(this.BYN_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.USD_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 82 "..\..\Calcutator.xaml"
            this.USD_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.USD_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 83 "..\..\Calcutator.xaml"
            this.USD_Field.GotFocus += new System.Windows.RoutedEventHandler(this.USD_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 83 "..\..\Calcutator.xaml"
            this.USD_Field.LostFocus += new System.Windows.RoutedEventHandler(this.USD_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RUB_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 97 "..\..\Calcutator.xaml"
            this.RUB_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RUB_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 98 "..\..\Calcutator.xaml"
            this.RUB_Field.GotFocus += new System.Windows.RoutedEventHandler(this.RUB_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 98 "..\..\Calcutator.xaml"
            this.RUB_Field.LostFocus += new System.Windows.RoutedEventHandler(this.RUB_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EUR_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 112 "..\..\Calcutator.xaml"
            this.EUR_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EUR_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 113 "..\..\Calcutator.xaml"
            this.EUR_Field.GotFocus += new System.Windows.RoutedEventHandler(this.EUR_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 113 "..\..\Calcutator.xaml"
            this.EUR_Field.LostFocus += new System.Windows.RoutedEventHandler(this.EUR_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UAH_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 127 "..\..\Calcutator.xaml"
            this.UAH_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.UAH_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 128 "..\..\Calcutator.xaml"
            this.UAH_Field.GotFocus += new System.Windows.RoutedEventHandler(this.UAH_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 128 "..\..\Calcutator.xaml"
            this.UAH_Field.LostFocus += new System.Windows.RoutedEventHandler(this.UAH_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Cur_Input = ((System.Windows.Controls.ComboBox)(target));
            
            #line 152 "..\..\Calcutator.xaml"
            this.Cur_Input.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.Cur_Input_TextChanged));
            
            #line default
            #line hidden
            return;
            case 8:
            this.Input = ((System.Windows.Controls.TextBox)(target));
            
            #line 178 "..\..\Calcutator.xaml"
            this.Input.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Input_TextChanged);
            
            #line default
            #line hidden
            
            #line 179 "..\..\Calcutator.xaml"
            this.Input.GotFocus += new System.Windows.RoutedEventHandler(this.Input_GotFocus);
            
            #line default
            #line hidden
            
            #line 179 "..\..\Calcutator.xaml"
            this.Input.LostFocus += new System.Windows.RoutedEventHandler(this.Input_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Cur_Output = ((System.Windows.Controls.ComboBox)(target));
            
            #line 194 "..\..\Calcutator.xaml"
            this.Cur_Output.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.Cur_Output_TextChanged));
            
            #line default
            #line hidden
            return;
            case 10:
            this.Output = ((System.Windows.Controls.TextBox)(target));
            
            #line 220 "..\..\Calcutator.xaml"
            this.Output.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Output_TextChanged);
            
            #line default
            #line hidden
            
            #line 221 "..\..\Calcutator.xaml"
            this.Output.GotFocus += new System.Windows.RoutedEventHandler(this.Output_GotFocus);
            
            #line default
            #line hidden
            
            #line 221 "..\..\Calcutator.xaml"
            this.Output.LostFocus += new System.Windows.RoutedEventHandler(this.Output_LostFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Date = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            
            #line 238 "..\..\Calcutator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 239 "..\..\Calcutator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Buton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

