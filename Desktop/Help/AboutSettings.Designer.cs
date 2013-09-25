﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.Desktop.Help {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class AboutSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AboutSettings defaultInstance = ((AboutSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AboutSettings())));
        
        public static AboutSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Boolean switch to turn usage of these settings on/off.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Boolean switch to turn usage of these settings on/off.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSettings {
            get {
                return ((bool)(this["UseSettings"]));
            }
        }
        
        /// <summary>
        /// Assembly name of the background image.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Assembly name of the background image.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BackgroundImageAssemblyName {
            get {
                return ((string)(this["BackgroundImageAssemblyName"]));
            }
        }
        
        /// <summary>
        /// Name of the image resource in the background image assembly.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Name of the image resource in the background image assembly.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BackgroundImageResourceName {
            get {
                return ((string)(this["BackgroundImageResourceName"]));
            }
        }
        
        /// <summary>
        /// Location of the copyright, in the coordinates of the about window.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Location of the copyright, in the coordinates of the about window.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("375, 340")]
        public global::System.Drawing.Point CopyrightLocation {
            get {
                return ((global::System.Drawing.Point)(this["CopyrightLocation"]));
            }
        }
        
        /// <summary>
        /// Size of the copyright, in pixels.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Size of the copyright, in pixels.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("286, 13")]
        public global::System.Drawing.Size CopyrightSize {
            get {
                return ((global::System.Drawing.Size)(this["CopyrightSize"]));
            }
        }
        
        /// <summary>
        /// Specifies whether or not the copyright should be auto-sized.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether or not the copyright should be auto-sized.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CopyrightAutoSize {
            get {
                return ((bool)(this["CopyrightAutoSize"]));
            }
        }
        
        /// <summary>
        /// Forecolor of the copyright.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Forecolor of the copyright.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color CopyrightForeColor {
            get {
                return ((global::System.Drawing.Color)(this["CopyrightForeColor"]));
            }
        }
        
        /// <summary>
        /// Copyright bolded.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Copyright bolded.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CopyrightFontBold {
            get {
                return ((bool)(this["CopyrightFontBold"]));
            }
        }
        
        /// <summary>
        /// Copyright text alignment.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Copyright text alignment.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TopLeft")]
        public global::System.Drawing.ContentAlignment CopyrightTextAlign {
            get {
                return ((global::System.Drawing.ContentAlignment)(this["CopyrightTextAlign"]));
            }
        }
        
        /// <summary>
        /// Location of the version, in the coordinates of the about window.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Location of the version, in the coordinates of the about window.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("447, 292")]
        public global::System.Drawing.Point VersionLocation {
            get {
                return ((global::System.Drawing.Point)(this["VersionLocation"]));
            }
        }
        
        /// <summary>
        /// Size of the version, in pixels.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Size of the version, in pixels.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("214, 13")]
        public global::System.Drawing.Size VersionSize {
            get {
                return ((global::System.Drawing.Size)(this["VersionSize"]));
            }
        }
        
        /// <summary>
        /// Specifies whether or not the version should be auto-sized.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether or not the version should be auto-sized.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool VersionAutoSize {
            get {
                return ((bool)(this["VersionAutoSize"]));
            }
        }
        
        /// <summary>
        /// Forecolor of the version.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Forecolor of the version.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color VersionForeColor {
            get {
                return ((global::System.Drawing.Color)(this["VersionForeColor"]));
            }
        }
        
        /// <summary>
        /// Version bolded.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Version bolded.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool VersionFontBold {
            get {
                return ((bool)(this["VersionFontBold"]));
            }
        }
        
        /// <summary>
        /// Version text alignment.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Version text alignment.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TopLeft")]
        public global::System.Drawing.ContentAlignment VersionTextAlign {
            get {
                return ((global::System.Drawing.ContentAlignment)(this["VersionTextAlign"]));
            }
        }
        
        /// <summary>
        /// Format string for displaying the version.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Format string for displaying the version.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Version {0}")]
        public string VersionTextFormat {
            get {
                return ((string)(this["VersionTextFormat"]));
            }
        }
        
        /// <summary>
        /// Specifies whether or not to display the license (from ProductSettings) on the about window.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether or not to display the license (from ProductSettings) on the abo" +
            "ut window.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LicenseVisible {
            get {
                return ((bool)(this["LicenseVisible"]));
            }
        }
        
        /// <summary>
        /// Location of the license, in the coordinates of the about window.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Location of the license, in the coordinates of the about window.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("617, 33")]
        public global::System.Drawing.Point LicenseLocation {
            get {
                return ((global::System.Drawing.Point)(this["LicenseLocation"]));
            }
        }
        
        /// <summary>
        /// Size of the license, in pixels.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Size of the license, in pixels.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("44, 13")]
        public global::System.Drawing.Size LicenseSize {
            get {
                return ((global::System.Drawing.Size)(this["LicenseSize"]));
            }
        }
        
        /// <summary>
        /// Specifies whether or not the license should be auto-sized.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether or not the license should be auto-sized.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LicenseAutoSize {
            get {
                return ((bool)(this["LicenseAutoSize"]));
            }
        }
        
        /// <summary>
        /// Forecolor of the license.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Forecolor of the license.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color LicenseForeColor {
            get {
                return ((global::System.Drawing.Color)(this["LicenseForeColor"]));
            }
        }
        
        /// <summary>
        /// License bolded.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("License bolded.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LicenseFontBold {
            get {
                return ((bool)(this["LicenseFontBold"]));
            }
        }
        
        /// <summary>
        /// License text alignment.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("License text alignment.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TopLeft")]
        public global::System.Drawing.ContentAlignment LicenseTextAlign {
            get {
                return ((global::System.Drawing.ContentAlignment)(this["LicenseTextAlign"]));
            }
        }
        
        /// <summary>
        /// Color of the close button link.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Color of the close button link.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60, 150, 208")]
        public global::System.Drawing.Color CloseButtonLinkColor {
            get {
                return ((global::System.Drawing.Color)(this["CloseButtonLinkColor"]));
            }
        }
        
        /// <summary>
        /// Location of the manifest message, in the coordinates of the about window.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Location of the manifest message, in the coordinates of the about window.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("447, 331")]
        public global::System.Drawing.Point ManifestLocation {
            get {
                return ((global::System.Drawing.Point)(this["ManifestLocation"]));
            }
        }
        
        /// <summary>
        /// Size of the manifest message, in pixels.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Size of the manifest message, in pixels.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("214, 13")]
        public global::System.Drawing.Size ManifestSize {
            get {
                return ((global::System.Drawing.Size)(this["ManifestSize"]));
            }
        }
        
        /// <summary>
        /// Specifies whether or not the manifest message should be auto-sized.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether or not the manifest message should be auto-sized.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ManifestAutoSize {
            get {
                return ((bool)(this["ManifestAutoSize"]));
            }
        }
        
        /// <summary>
        /// Forecolor of the manifest message.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Forecolor of the manifest message.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Firebrick")]
        public global::System.Drawing.Color ManifestForeColor {
            get {
                return ((global::System.Drawing.Color)(this["ManifestForeColor"]));
            }
        }
        
        /// <summary>
        /// Manifest message bolded.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Manifest message bolded.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManifestFontBold {
            get {
                return ((bool)(this["ManifestFontBold"]));
            }
        }
        
        /// <summary>
        /// Manifest message text alignment.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Manifest message text alignment.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TopLeft")]
        public global::System.Drawing.ContentAlignment ManifestTextAlign {
            get {
                return ((global::System.Drawing.ContentAlignment)(this["ManifestTextAlign"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("659, 9")]
        public global::System.Drawing.Point CloseButtonLocation {
            get {
                return ((global::System.Drawing.Point)(this["CloseButtonLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TopRight")]
        public global::System.Drawing.ContentAlignment CloseButtonAnchor {
            get {
                return ((global::System.Drawing.ContentAlignment)(this["CloseButtonAnchor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EvaluationVisible {
            get {
                return ((bool)(this["EvaluationVisible"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("617, 33")]
        public global::System.Drawing.Point EvaluationLocation {
            get {
                return ((global::System.Drawing.Point)(this["EvaluationLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("214, 13")]
        public global::System.Drawing.Size EvaluationSize {
            get {
                return ((global::System.Drawing.Size)(this["EvaluationSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EvaluationAutoSize {
            get {
                return ((bool)(this["EvaluationAutoSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Firebrick")]
        public global::System.Drawing.Color EvaluationForeColor {
            get {
                return ((global::System.Drawing.Color)(this["EvaluationForeColor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EvaluationFontBold {
            get {
                return ((bool)(this["EvaluationFontBold"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TopRight")]
        public global::System.Drawing.ContentAlignment EvaluationTextAlign {
            get {
                return ((global::System.Drawing.ContentAlignment)(this["EvaluationTextAlign"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NotForDiagnosticUseVisible {
            get {
                return ((bool)(this["NotForDiagnosticUseVisible"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("617, 33")]
        public global::System.Drawing.Point NotForDiagnosticUseLocation {
            get {
                return ((global::System.Drawing.Point)(this["NotForDiagnosticUseLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("214, 13")]
        public global::System.Drawing.Size NotForDiagnosticUseSize {
            get {
                return ((global::System.Drawing.Size)(this["NotForDiagnosticUseSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Firebrick")]
        public global::System.Drawing.Color NotForDiagnosticUseForeColor {
            get {
                return ((global::System.Drawing.Color)(this["NotForDiagnosticUseForeColor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NotForDiagnosticUseAutoSize {
            get {
                return ((bool)(this["NotForDiagnosticUseAutoSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NotForDiagnosticUseFontBold {
            get {
                return ((bool)(this["NotForDiagnosticUseFontBold"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TopRight")]
        public global::System.Drawing.ContentAlignment NotForDiagnosticUseTextAlign {
            get {
                return ((global::System.Drawing.ContentAlignment)(this["NotForDiagnosticUseTextAlign"]));
            }
        }
    }
}
