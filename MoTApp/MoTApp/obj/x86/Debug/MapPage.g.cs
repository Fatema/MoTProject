﻿#pragma checksum "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\MapPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4B6B921D34575A4D732165B25CD0E965"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoTApp
{
    partial class MapPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ZoomOutBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ZoomOutBtn).Click += this.ZoomOutBtn_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.ZoomInBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ZoomInBtn).Click += this.ZoomInBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.ZoomInIcon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4:
                {
                    this.ZoomOutIcon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.RouteMapImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

