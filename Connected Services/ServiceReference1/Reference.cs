﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklep.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="produkt", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class produkt : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float BruttoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float IloscField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float NettoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VatField;
        
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
        public float Brutto {
            get {
                return this.BruttoField;
            }
            set {
                if ((this.BruttoField.Equals(value) != true)) {
                    this.BruttoField = value;
                    this.RaisePropertyChanged("Brutto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Ilosc {
            get {
                return this.IloscField;
            }
            set {
                if ((this.IloscField.Equals(value) != true)) {
                    this.IloscField = value;
                    this.RaisePropertyChanged("Ilosc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Kat {
            get {
                return this.KatField;
            }
            set {
                if ((object.ReferenceEquals(this.KatField, value) != true)) {
                    this.KatField = value;
                    this.RaisePropertyChanged("Kat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazwa {
            get {
                return this.NazwaField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwaField, value) != true)) {
                    this.NazwaField = value;
                    this.RaisePropertyChanged("Nazwa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Netto {
            get {
                return this.NettoField;
            }
            set {
                if ((this.NettoField.Equals(value) != true)) {
                    this.NettoField = value;
                    this.RaisePropertyChanged("Netto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Vat {
            get {
                return this.VatField;
            }
            set {
                if ((this.VatField.Equals(value) != true)) {
                    this.VatField = value;
                    this.RaisePropertyChanged("Vat");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Sklep.ServiceReference1.CompositeType GetDataUsingDataContract(Sklep.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Sklep.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Sklep.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Dodajprodukt", ReplyAction="http://tempuri.org/IService1/DodajproduktResponse")]
        int Dodajprodukt(Sklep.ServiceReference1.produkt prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Dodajprodukt", ReplyAction="http://tempuri.org/IService1/DodajproduktResponse")]
        System.Threading.Tasks.Task<int> DodajproduktAsync(Sklep.ServiceReference1.produkt prod);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Sklep.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Sklep.ServiceReference1.IService1>, Sklep.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Sklep.ServiceReference1.CompositeType GetDataUsingDataContract(Sklep.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Sklep.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Sklep.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int Dodajprodukt(Sklep.ServiceReference1.produkt prod) {
            return base.Channel.Dodajprodukt(prod);
        }
        
        public System.Threading.Tasks.Task<int> DodajproduktAsync(Sklep.ServiceReference1.produkt prod) {
            return base.Channel.DodajproduktAsync(prod);
        }
    }
}