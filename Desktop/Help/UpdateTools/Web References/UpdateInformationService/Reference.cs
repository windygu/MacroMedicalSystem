﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.296 版自动生成。
// 
#pragma warning disable 1591

namespace Macro.Desktop.Help.UpdateTools.UpdateInformationService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UpdateInformationServiceSoap", Namespace="http://www.ClearCanvas.ca/services/update")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Component))]
    public partial class UpdateInformationService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetUpdateInformationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UpdateInformationService() {
            this.Url = "http://localhost/Macro.Distribution.UpdateService/UpdateInformationService." +
                "asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetUpdateInformationCompletedEventHandler GetUpdateInformationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ClearCanvas.ca/services/update/GetUpdateInformation", RequestNamespace="http://www.ClearCanvas.ca/services/update", ResponseNamespace="http://www.ClearCanvas.ca/services/update", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UpdateInformationResult GetUpdateInformation(UpdateInformationRequest request) {
            object[] results = this.Invoke("GetUpdateInformation", new object[] {
                        request});
            return ((UpdateInformationResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetUpdateInformationAsync(UpdateInformationRequest request) {
            this.GetUpdateInformationAsync(request, null);
        }
        
        /// <remarks/>
        public void GetUpdateInformationAsync(UpdateInformationRequest request, object userState) {
            if ((this.GetUpdateInformationOperationCompleted == null)) {
                this.GetUpdateInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUpdateInformationOperationCompleted);
            }
            this.InvokeAsync("GetUpdateInformation", new object[] {
                        request}, this.GetUpdateInformationOperationCompleted, userState);
        }
        
        private void OnGetUpdateInformationOperationCompleted(object arg) {
            if ((this.GetUpdateInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUpdateInformationCompleted(this, new GetUpdateInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ClearCanvas.ca/services/update")]
    public partial class UpdateInformationRequest {
        
        private Product installedProductField;
        
        /// <remarks/>
        public Product InstalledProduct {
            get {
                return this.installedProductField;
            }
            set {
                this.installedProductField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ClearCanvas.ca/services/update")]
    public partial class Product : Component {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ClearCanvas.ca/services/update")]
    public partial class Component {
        
        private string nameField;
        
        private string editionField;
        
        private string versionField;
        
        private string versionSuffixField;
        
        private string releaseField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Edition {
            get {
                return this.editionField;
            }
            set {
                this.editionField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string VersionSuffix {
            get {
                return this.versionSuffixField;
            }
            set {
                this.versionSuffixField = value;
            }
        }
        
        /// <remarks/>
        public string Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ClearCanvas.ca/services/update")]
    public partial class UpdateInformationResult {
        
        private string downloadUrlField;
        
        private Product installedProductField;
        
        /// <remarks/>
        public string DownloadUrl {
            get {
                return this.downloadUrlField;
            }
            set {
                this.downloadUrlField = value;
            }
        }
        
        /// <remarks/>
        public Product InstalledProduct {
            get {
                return this.installedProductField;
            }
            set {
                this.installedProductField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetUpdateInformationCompletedEventHandler(object sender, GetUpdateInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUpdateInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUpdateInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UpdateInformationResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UpdateInformationResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591