﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace FrmPIE.WebReference100 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTable_nOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSetTableOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTableOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSQLTableOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::FrmPIE.Properties.Settings.Default.FrmOCRDM_WebReference100_Service;
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
        public event GetTable_nCompletedEventHandler GetTable_nCompleted;
        
        /// <remarks/>
        public event GetSetTableCompletedEventHandler GetSetTableCompleted;
        
        /// <remarks/>
        public event GetTableCompletedEventHandler GetTableCompleted;
        
        /// <remarks/>
        public event GetSQLTableCompletedEventHandler GetSQLTableCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTable_n", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetTable_n(string inSystem, string inTable, string inWhere) {
            object[] results = this.Invoke("GetTable_n", new object[] {
                        inSystem,
                        inTable,
                        inWhere});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetTable_nAsync(string inSystem, string inTable, string inWhere) {
            this.GetTable_nAsync(inSystem, inTable, inWhere, null);
        }
        
        /// <remarks/>
        public void GetTable_nAsync(string inSystem, string inTable, string inWhere, object userState) {
            if ((this.GetTable_nOperationCompleted == null)) {
                this.GetTable_nOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTable_nOperationCompleted);
            }
            this.InvokeAsync("GetTable_n", new object[] {
                        inSystem,
                        inTable,
                        inWhere}, this.GetTable_nOperationCompleted, userState);
        }
        
        private void OnGetTable_nOperationCompleted(object arg) {
            if ((this.GetTable_nCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTable_nCompleted(this, new GetTable_nCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSetTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object GetSetTable(string inSystem, string inTable, string inWhere, string inXML) {
            object[] results = this.Invoke("GetSetTable", new object[] {
                        inSystem,
                        inTable,
                        inWhere,
                        inXML});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public void GetSetTableAsync(string inSystem, string inTable, string inWhere, string inXML) {
            this.GetSetTableAsync(inSystem, inTable, inWhere, inXML, null);
        }
        
        /// <remarks/>
        public void GetSetTableAsync(string inSystem, string inTable, string inWhere, string inXML, object userState) {
            if ((this.GetSetTableOperationCompleted == null)) {
                this.GetSetTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSetTableOperationCompleted);
            }
            this.InvokeAsync("GetSetTable", new object[] {
                        inSystem,
                        inTable,
                        inWhere,
                        inXML}, this.GetSetTableOperationCompleted, userState);
        }
        
        private void OnGetSetTableOperationCompleted(object arg) {
            if ((this.GetSetTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSetTableCompleted(this, new GetSetTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTable(string inSystem, string inTable, string inWhere) {
            object[] results = this.Invoke("GetTable", new object[] {
                        inSystem,
                        inTable,
                        inWhere});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTableAsync(string inSystem, string inTable, string inWhere) {
            this.GetTableAsync(inSystem, inTable, inWhere, null);
        }
        
        /// <remarks/>
        public void GetTableAsync(string inSystem, string inTable, string inWhere, object userState) {
            if ((this.GetTableOperationCompleted == null)) {
                this.GetTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTableOperationCompleted);
            }
            this.InvokeAsync("GetTable", new object[] {
                        inSystem,
                        inTable,
                        inWhere}, this.GetTableOperationCompleted, userState);
        }
        
        private void OnGetTableOperationCompleted(object arg) {
            if ((this.GetTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTableCompleted(this, new GetTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSQLTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetSQLTable(string inSystem, string inDB, string inUser, string inTable, string inWhere) {
            object[] results = this.Invoke("GetSQLTable", new object[] {
                        inSystem,
                        inDB,
                        inUser,
                        inTable,
                        inWhere});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetSQLTableAsync(string inSystem, string inDB, string inUser, string inTable, string inWhere) {
            this.GetSQLTableAsync(inSystem, inDB, inUser, inTable, inWhere, null);
        }
        
        /// <remarks/>
        public void GetSQLTableAsync(string inSystem, string inDB, string inUser, string inTable, string inWhere, object userState) {
            if ((this.GetSQLTableOperationCompleted == null)) {
                this.GetSQLTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSQLTableOperationCompleted);
            }
            this.InvokeAsync("GetSQLTable", new object[] {
                        inSystem,
                        inDB,
                        inUser,
                        inTable,
                        inWhere}, this.GetSQLTableOperationCompleted, userState);
        }
        
        private void OnGetSQLTableOperationCompleted(object arg) {
            if ((this.GetSQLTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSQLTableCompleted(this, new GetSQLTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetTable_nCompletedEventHandler(object sender, GetTable_nCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTable_nCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTable_nCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetSetTableCompletedEventHandler(object sender, GetSetTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSetTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSetTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetTableCompletedEventHandler(object sender, GetTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetSQLTableCompletedEventHandler(object sender, GetSQLTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSQLTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSQLTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591