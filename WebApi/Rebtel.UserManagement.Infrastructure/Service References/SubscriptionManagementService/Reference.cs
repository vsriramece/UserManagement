﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rebtel.UserManagement.Infrastructure.SubscriptionManagementService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateSubcription", Namespace="http://schemas.datacontract.org/2004/07/Rebtel.UserManagement.Infrastructure.DTO")]
    [System.SerializableAttribute()]
    public partial class CreateSubcription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CallminutesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceIncVatAmountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Callminutes {
            get {
                return this.CallminutesField;
            }
            set {
                if ((this.CallminutesField.Equals(value) != true)) {
                    this.CallminutesField = value;
                    this.RaisePropertyChanged("Callminutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PriceIncVatAmount {
            get {
                return this.PriceIncVatAmountField;
            }
            set {
                if ((this.PriceIncVatAmountField.Equals(value) != true)) {
                    this.PriceIncVatAmountField = value;
                    this.RaisePropertyChanged("PriceIncVatAmount");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateSubscriptionResponse", Namespace="http://schemas.datacontract.org/2004/07/Rebtel.UserManagement.Infrastructure.DTO." +
        "Response")]
    [System.SerializableAttribute()]
    public partial class CreateSubscriptionResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateSubscription", Namespace="http://schemas.datacontract.org/2004/07/Rebtel.UserManagement.Infrastructure.DTO")]
    [System.SerializableAttribute()]
    public partial class UpdateSubscription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CallminutesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceIncVatAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid SubcriptionIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Callminutes {
            get {
                return this.CallminutesField;
            }
            set {
                if ((this.CallminutesField.Equals(value) != true)) {
                    this.CallminutesField = value;
                    this.RaisePropertyChanged("Callminutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PriceIncVatAmount {
            get {
                return this.PriceIncVatAmountField;
            }
            set {
                if ((this.PriceIncVatAmountField.Equals(value) != true)) {
                    this.PriceIncVatAmountField = value;
                    this.RaisePropertyChanged("PriceIncVatAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SubcriptionId {
            get {
                return this.SubcriptionIdField;
            }
            set {
                if ((this.SubcriptionIdField.Equals(value) != true)) {
                    this.SubcriptionIdField = value;
                    this.RaisePropertyChanged("SubcriptionId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SubscriptionData", Namespace="http://schemas.datacontract.org/2004/07/Rebtel.UserManagement.Infrastructure.DTO." +
        "Response")]
    [System.SerializableAttribute()]
    public partial class SubscriptionData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CallminutesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceIncVatAmountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Callminutes {
            get {
                return this.CallminutesField;
            }
            set {
                if ((this.CallminutesField.Equals(value) != true)) {
                    this.CallminutesField = value;
                    this.RaisePropertyChanged("Callminutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PriceIncVatAmount {
            get {
                return this.PriceIncVatAmountField;
            }
            set {
                if ((this.PriceIncVatAmountField.Equals(value) != true)) {
                    this.PriceIncVatAmountField = value;
                    this.RaisePropertyChanged("PriceIncVatAmount");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SubscriptionManagementService.ISubscriptionManagement")]
    public interface ISubscriptionManagement {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/CreateSubscription", ReplyAction="http://tempuri.org/ISubscriptionManagement/CreateSubscriptionResponse")]
        Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubscriptionResponse CreateSubscription([System.ServiceModel.MessageParameterAttribute(Name="createSubscription")] Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubcription createSubscription1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/CreateSubscription", ReplyAction="http://tempuri.org/ISubscriptionManagement/CreateSubscriptionResponse")]
        System.Threading.Tasks.Task<Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubscriptionResponse> CreateSubscriptionAsync(Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubcription createSubscription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/UpdateSubscription", ReplyAction="http://tempuri.org/ISubscriptionManagement/UpdateSubscriptionResponse")]
        void UpdateSubscription([System.ServiceModel.MessageParameterAttribute(Name="updateSubscription")] Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.UpdateSubscription updateSubscription1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/UpdateSubscription", ReplyAction="http://tempuri.org/ISubscriptionManagement/UpdateSubscriptionResponse")]
        System.Threading.Tasks.Task UpdateSubscriptionAsync(Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.UpdateSubscription updateSubscription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/DeleteSubscription", ReplyAction="http://tempuri.org/ISubscriptionManagement/DeleteSubscriptionResponse")]
        void DeleteSubscription(System.Guid subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/DeleteSubscription", ReplyAction="http://tempuri.org/ISubscriptionManagement/DeleteSubscriptionResponse")]
        System.Threading.Tasks.Task DeleteSubscriptionAsync(System.Guid subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/GetSubscriptionById", ReplyAction="http://tempuri.org/ISubscriptionManagement/GetSubscriptionByIdResponse")]
        Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData GetSubscriptionById(System.Guid subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/GetSubscriptionById", ReplyAction="http://tempuri.org/ISubscriptionManagement/GetSubscriptionByIdResponse")]
        System.Threading.Tasks.Task<Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData> GetSubscriptionByIdAsync(System.Guid subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/GetSubscriptions", ReplyAction="http://tempuri.org/ISubscriptionManagement/GetSubscriptionsResponse")]
        Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData[] GetSubscriptions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionManagement/GetSubscriptions", ReplyAction="http://tempuri.org/ISubscriptionManagement/GetSubscriptionsResponse")]
        System.Threading.Tasks.Task<Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData[]> GetSubscriptionsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubscriptionManagementChannel : Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.ISubscriptionManagement, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubscriptionManagementClient : System.ServiceModel.ClientBase<Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.ISubscriptionManagement>, Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.ISubscriptionManagement {
        
        public SubscriptionManagementClient() {
        }
        
        public SubscriptionManagementClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubscriptionManagementClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubscriptionManagementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubscriptionManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubscriptionResponse CreateSubscription(Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubcription createSubscription1) {
            return base.Channel.CreateSubscription(createSubscription1);
        }
        
        public System.Threading.Tasks.Task<Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubscriptionResponse> CreateSubscriptionAsync(Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.CreateSubcription createSubscription) {
            return base.Channel.CreateSubscriptionAsync(createSubscription);
        }
        
        public void UpdateSubscription(Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.UpdateSubscription updateSubscription1) {
            base.Channel.UpdateSubscription(updateSubscription1);
        }
        
        public System.Threading.Tasks.Task UpdateSubscriptionAsync(Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.UpdateSubscription updateSubscription) {
            return base.Channel.UpdateSubscriptionAsync(updateSubscription);
        }
        
        public void DeleteSubscription(System.Guid subscriptionId) {
            base.Channel.DeleteSubscription(subscriptionId);
        }
        
        public System.Threading.Tasks.Task DeleteSubscriptionAsync(System.Guid subscriptionId) {
            return base.Channel.DeleteSubscriptionAsync(subscriptionId);
        }
        
        public Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData GetSubscriptionById(System.Guid subscriptionId) {
            return base.Channel.GetSubscriptionById(subscriptionId);
        }
        
        public System.Threading.Tasks.Task<Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData> GetSubscriptionByIdAsync(System.Guid subscriptionId) {
            return base.Channel.GetSubscriptionByIdAsync(subscriptionId);
        }
        
        public Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData[] GetSubscriptions() {
            return base.Channel.GetSubscriptions();
        }
        
        public System.Threading.Tasks.Task<Rebtel.UserManagement.Infrastructure.SubscriptionManagementService.SubscriptionData[]> GetSubscriptionsAsync() {
            return base.Channel.GetSubscriptionsAsync();
        }
    }
}