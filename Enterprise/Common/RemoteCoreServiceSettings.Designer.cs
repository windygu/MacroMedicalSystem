﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.Enterprise.Common {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class RemoteCoreServiceSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static RemoteCoreServiceSettings defaultInstance = ((RemoteCoreServiceSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new RemoteCoreServiceSettings())));
        
        public static RemoteCoreServiceSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Base URL that hosts the remote core services
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Base URL that hosts the remote core services")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("net.tcp://localhost:8000/")]
        public string BaseUrl {
            get {
                return ((string)(this["BaseUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Macro.Enterprise.Common.ServiceConfiguration.Client.NetTcpConfiguration, Macro.Enterprise.Common")]
        public string ConfigurationClass {
            get {
                return ((string)(this["ConfigurationClass"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000000")]
        public int MaxReceivedMessageSize {
            get {
                return ((int)(this["MaxReceivedMessageSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PeerOrChainTrust")]
        public global::System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode {
            get {
                return ((global::System.ServiceModel.Security.X509CertificateValidationMode)(this["CertificateValidationMode"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NoCheck")]
        public global::System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode {
            get {
                return ((global::System.Security.Cryptography.X509Certificates.X509RevocationMode)(this["RevocationMode"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserCredentialsProviderClass {
            get {
                return ((string)(this["UserCredentialsProviderClass"]));
            }
        }
        
        /// <summary>
        /// Optional failover base URL (see BaseURL property)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Optional failover base URL (see BaseURL property)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FailoverBaseUrl {
            get {
                return ((string)(this["FailoverBaseUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ConfigurationServiceResponseCachingEnabled {
            get {
                return ((bool)(this["ConfigurationServiceResponseCachingEnabled"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:01:00")]
        public global::System.TimeSpan FailedEndpointBlackoutTime {
            get {
                return ((global::System.TimeSpan)(this["FailedEndpointBlackoutTime"]));
            }
        }
    }
}
