﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Windows_Hotel.ProxyRegistroReserva {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRegistro", Namespace="http://schemas.datacontract.org/2004/07/WCF_Hotel")]
    [System.SerializableAttribute()]
    public partial class DataRegistro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClieDniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdHabi1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdHabi2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdHabi3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReserFechaIngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReserFechaSalidaField;
        
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
        public string ClieDni {
            get {
                return this.ClieDniField;
            }
            set {
                if ((object.ReferenceEquals(this.ClieDniField, value) != true)) {
                    this.ClieDniField = value;
                    this.RaisePropertyChanged("ClieDni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHabi1 {
            get {
                return this.IdHabi1Field;
            }
            set {
                if ((object.ReferenceEquals(this.IdHabi1Field, value) != true)) {
                    this.IdHabi1Field = value;
                    this.RaisePropertyChanged("IdHabi1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHabi2 {
            get {
                return this.IdHabi2Field;
            }
            set {
                if ((object.ReferenceEquals(this.IdHabi2Field, value) != true)) {
                    this.IdHabi2Field = value;
                    this.RaisePropertyChanged("IdHabi2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHabi3 {
            get {
                return this.IdHabi3Field;
            }
            set {
                if ((object.ReferenceEquals(this.IdHabi3Field, value) != true)) {
                    this.IdHabi3Field = value;
                    this.RaisePropertyChanged("IdHabi3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReserFechaIngreso {
            get {
                return this.ReserFechaIngresoField;
            }
            set {
                if ((this.ReserFechaIngresoField.Equals(value) != true)) {
                    this.ReserFechaIngresoField = value;
                    this.RaisePropertyChanged("ReserFechaIngreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReserFechaSalida {
            get {
                return this.ReserFechaSalidaField;
            }
            set {
                if ((this.ReserFechaSalidaField.Equals(value) != true)) {
                    this.ReserFechaSalidaField = value;
                    this.RaisePropertyChanged("ReserFechaSalida");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyRegistroReserva.IServicioRegistroReserva")]
    public interface IServicioRegistroReserva {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioRegistroReserva/RegistroReserva", ReplyAction="http://tempuri.org/IServicioRegistroReserva/RegistroReservaResponse")]
        bool RegistroReserva(Windows_Hotel.ProxyRegistroReserva.DataRegistro data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioRegistroReserva/RegistroReserva", ReplyAction="http://tempuri.org/IServicioRegistroReserva/RegistroReservaResponse")]
        System.Threading.Tasks.Task<bool> RegistroReservaAsync(Windows_Hotel.ProxyRegistroReserva.DataRegistro data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioRegistroReservaChannel : Windows_Hotel.ProxyRegistroReserva.IServicioRegistroReserva, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioRegistroReservaClient : System.ServiceModel.ClientBase<Windows_Hotel.ProxyRegistroReserva.IServicioRegistroReserva>, Windows_Hotel.ProxyRegistroReserva.IServicioRegistroReserva {
        
        public ServicioRegistroReservaClient() {
        }
        
        public ServicioRegistroReservaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioRegistroReservaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioRegistroReservaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioRegistroReservaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegistroReserva(Windows_Hotel.ProxyRegistroReserva.DataRegistro data) {
            return base.Channel.RegistroReserva(data);
        }
        
        public System.Threading.Tasks.Task<bool> RegistroReservaAsync(Windows_Hotel.ProxyRegistroReserva.DataRegistro data) {
            return base.Channel.RegistroReservaAsync(data);
        }
    }
}