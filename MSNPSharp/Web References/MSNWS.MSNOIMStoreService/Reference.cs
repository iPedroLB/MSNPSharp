﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace MSNPSharp.MSNWS.MSNOIMStoreService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="OIMBinding", Namespace="http://messenger.msn.com/ws/2004/09/oim/")]
    public partial class OIMStoreService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private From fromValueField;
        
        private To toValueField;
        
        private Ticket ticketValueField;
        
        private SequenceType sequenceField;
        
        private SequenceAcknowledgment sequenceAcknowledgmentValueField;
        
        private System.Threading.SendOrPostCallback StoreOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public OIMStoreService() {
            this.Url = "https://msnmsgr.escargot.chat/OimWS/oim.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public From FromValue {
            get {
                return this.fromValueField;
            }
            set {
                this.fromValueField = value;
            }
        }
        
        public To ToValue {
            get {
                return this.toValueField;
            }
            set {
                this.toValueField = value;
            }
        }
        
        public Ticket TicketValue {
            get {
                return this.ticketValueField;
            }
            set {
                this.ticketValueField = value;
            }
        }
        
        public SequenceType Sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        
        public SequenceAcknowledgment SequenceAcknowledgmentValue {
            get {
                return this.sequenceAcknowledgmentValueField;
            }
            set {
                this.sequenceAcknowledgmentValueField = value;
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
        public event StoreCompletedEventHandler StoreCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("Sequence")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TicketValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("SequenceAcknowledgmentValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("FromValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ToValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://messenger.live.com/ws/2006/09/oim/Store2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("StoreResponse", Namespace="http://messenger.msn.com/ws/2004/09/oim/")]
        public StoreResultType Store([System.Xml.Serialization.XmlElementAttribute(Namespace="http://messenger.msn.com/ws/2004/09/oim/")] MessageType MessageType, [System.Xml.Serialization.XmlElementAttribute(Namespace="http://messenger.msn.com/ws/2004/09/oim/")] string Content) {
            object[] results = this.Invoke("Store", new object[] {
                        MessageType,
                        Content});
            return ((StoreResultType)(results[0]));
        }
        
        /// <remarks/>
        public void StoreAsync(MessageType MessageType, string Content) {
            this.StoreAsync(MessageType, Content, null);
        }
        
        /// <remarks/>
        public void StoreAsync(MessageType MessageType, string Content, object userState) {
            if ((this.StoreOperationCompleted == null)) {
                this.StoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStoreOperationCompleted);
            }
            this.InvokeAsync("Store", new object[] {
                        MessageType,
                        Content}, this.StoreOperationCompleted, userState);
        }
        
        private void OnStoreOperationCompleted(object arg) {
            if ((this.StoreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StoreCompleted(this, new StoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/ws/2003/03/rm")]
    [System.Xml.Serialization.XmlRootAttribute("Sequence", Namespace="http://schemas.xmlsoap.org/ws/2003/03/rm", IsNullable=false)]
    public partial class SequenceType : System.Web.Services.Protocols.SoapHeader {
        
        private AttributedURI identifierField;
        
        private ulong messageNumberField;
        
        private string lastMessageField;
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.xmlsoap.org/ws/2002/07/utility")]
        public AttributedURI Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        public ulong MessageNumber {
            get {
                return this.messageNumberField;
            }
            set {
                this.messageNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="ENTITY")]
        public string LastMessage {
            get {
                return this.lastMessageField;
            }
            set {
                this.lastMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/ws/2002/07/utility")]
    public partial class AttributedURI {
        
        private string idField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://messenger.msn.com/ws/2004/09/oim/")]
    public partial class StoreResultType {
        
        private string pointsConsumedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string PointsConsumed {
            get {
                return this.pointsConsumedField;
            }
            set {
                this.pointsConsumedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://messenger.msn.com/ws/2004/09/oim/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://messenger.msn.com/ws/2004/09/oim/", IsNullable=false)]
    public partial class Ticket : System.Web.Services.Protocols.SoapHeader {
        
        private string passportField;
        
        private string appidField;
        
        private string lockkeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string passport {
            get {
                return this.passportField;
            }
            set {
                this.passportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string appid {
            get {
                return this.appidField;
            }
            set {
                this.appidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockkey {
            get {
                return this.lockkeyField;
            }
            set {
                this.lockkeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.xmlsoap.org/ws/2003/03/rm")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.xmlsoap.org/ws/2003/03/rm", IsNullable=false)]
    public partial class SequenceAcknowledgment : System.Web.Services.Protocols.SoapHeader {
        
        private AttributedURI identifierField;
        
        private SequenceAcknowledgmentAcknowledgmentRange[] acknowledgmentRangeField;
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.xmlsoap.org/ws/2002/07/utility")]
        public AttributedURI Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcknowledgmentRange")]
        public SequenceAcknowledgmentAcknowledgmentRange[] AcknowledgmentRange {
            get {
                return this.acknowledgmentRangeField;
            }
            set {
                this.acknowledgmentRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.xmlsoap.org/ws/2003/03/rm")]
    public partial class SequenceAcknowledgmentAcknowledgmentRange {
        
        private ulong upperField;
        
        private ulong lowerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong Upper {
            get {
                return this.upperField;
            }
            set {
                this.upperField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong Lower {
            get {
                return this.lowerField;
            }
            set {
                this.lowerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://messenger.msn.com/ws/2004/09/oim/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://messenger.msn.com/ws/2004/09/oim/", IsNullable=false)]
    public partial class From : System.Web.Services.Protocols.SoapHeader {
        
        private string memberNameField;
        
        private string friendlyNameField;
        
        private string langField;
        
        private string proxyField;
        
        private string msnpVerField;
        
        private string buildVerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string memberName {
            get {
                return this.memberNameField;
            }
            set {
                this.memberNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string friendlyName {
            get {
                return this.friendlyNameField;
            }
            set {
                this.friendlyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string proxy {
            get {
                return this.proxyField;
            }
            set {
                this.proxyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string msnpVer {
            get {
                return this.msnpVerField;
            }
            set {
                this.msnpVerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buildVer {
            get {
                return this.buildVerField;
            }
            set {
                this.buildVerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://messenger.msn.com/ws/2004/09/oim/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://messenger.msn.com/ws/2004/09/oim/", IsNullable=false)]
    public partial class To : System.Web.Services.Protocols.SoapHeader {
        
        private string memberNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string memberName {
            get {
                return this.memberNameField;
            }
            set {
                this.memberNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://messenger.msn.com/ws/2004/09/oim/")]
    public enum MessageType {
        
        /// <remarks/>
        text,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void StoreCompletedEventHandler(object sender, StoreCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal StoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StoreResultType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StoreResultType)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591