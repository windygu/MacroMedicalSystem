﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.Desktop {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class ToolStripSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ToolStripSettings defaultInstance = ((ToolStripSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ToolStripSettings())));
        
        public static ToolStripSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Controls if tool strips longer than the window size should be wrapped.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls if tool strips longer than the window size should be wrapped.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WrapLongToolstrips {
            get {
                return ((bool)(this["WrapLongToolstrips"]));
            }
            set {
                this["WrapLongToolstrips"] = value;
            }
        }
        
        /// <summary>
        /// Controls the size of toolstrip buttons.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls the size of toolstrip buttons.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Large")]
        public global::Macro.Desktop.IconSize IconSize {
            get {
                return ((global::Macro.Desktop.IconSize)(this["IconSize"]));
            }
            set {
                this["IconSize"] = value;
            }
        }
        
        /// <summary>
        /// User&apos;s preference as to where the main toolbar should be docked.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("User\'s preference as to where the main toolbar should be docked.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Top")]
        public global::Macro.Desktop.ToolStripDock ToolStripDock {
            get {
                return ((global::Macro.Desktop.ToolStripDock)(this["ToolStripDock"]));
            }
            set {
                this["ToolStripDock"] = value;
            }
        }
    }
}
