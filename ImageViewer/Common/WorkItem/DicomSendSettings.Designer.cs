﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.ImageViewer.Common.WorkItem {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class DicomSendSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DicomSendSettings defaultInstance = ((DicomSendSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DicomSendSettings())));
        
        public static DicomSendSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int RetryCount {
            get {
                return ((int)(this["RetryCount"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Seconds")]
        public global::Macro.ImageViewer.Common.WorkItem.RetryDelayTimeUnit RetryDelayUnits {
            get {
                return ((global::Macro.ImageViewer.Common.WorkItem.RetryDelayTimeUnit)(this["RetryDelayUnits"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int RetryDelay {
            get {
                return ((int)(this["RetryDelay"]));
            }
        }
    }
}