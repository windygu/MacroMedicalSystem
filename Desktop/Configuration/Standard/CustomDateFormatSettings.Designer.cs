﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.Desktop.Configuration.Standard {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class CustomDateFormatSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static CustomDateFormatSettings defaultInstance = ((CustomDateFormatSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CustomDateFormatSettings())));
        
        public static CustomDateFormatSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// A list of custom date formats the user can select from to set their own preferred date format.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("A list of custom date formats the user can select from to set their own preferred" +
            " date format.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>M/d/yyyy</string>
  <string>M/d/yy</string>
  <string>MM/dd/yyyy</string>
  <string>MM/dd/yy</string>
  <string>yyyy-MM-dd</string>
  <string>yy-MM-dd</string>
  <string>yyyy/MM/dd</string>
  <string>yy/MM/dd</string>
  <string>dd-MMM-yy</string>
  <string>dd-MMM-yyyy</string>
  <string>dd-MM-yy</string>
  <string>dd-MM-yyyy</string>
  <string>yyyyMMdd</string>
  <string>dddd, MMMM dd, yyyy</string>
  <string>MMMM dd, yyyy</string>
  <string>dddd, dd MMMM, yyyy</string>
  <string>dd MMMM, yyyy</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AvailableCustomFormats {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AvailableCustomFormats"]));
            }
        }
    }
}
