﻿

#pragma checksum "C:\Users\Qiming\Documents\GitHub\dropbox-sdk-dotnet-private\dropbox-sdk-dotnet\Examples\UniversalDemo\UniversalDemo\UniversalDemo.Windows\DropboxSettings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F04E354431E3D4B338261FC84B7A0B22"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversalDemo
{
    partial class DropboxSettings : global::Windows.UI.Xaml.Controls.SettingsFlyout, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 30 "..\..\DropboxSettings.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ConnectBtn_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 31 "..\..\DropboxSettings.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.DisconnectBtn_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

