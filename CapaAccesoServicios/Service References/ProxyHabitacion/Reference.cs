﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaAccesoServicios.ProxyHabitacion {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="dataHabitacion", Namespace="http://schemas.datacontract.org/2004/07/WCF_Hotel")]
    [System.SerializableAttribute()]
    public partial class dataHabitacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HabiNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HabiPisoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdHabitaconField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdHotelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdTipoHabiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoNombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoNumCamasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TipoPrecioField;
        
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
        public string HabiNum {
            get {
                return this.HabiNumField;
            }
            set {
                if ((object.ReferenceEquals(this.HabiNumField, value) != true)) {
                    this.HabiNumField = value;
                    this.RaisePropertyChanged("HabiNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HabiPiso {
            get {
                return this.HabiPisoField;
            }
            set {
                if ((object.ReferenceEquals(this.HabiPisoField, value) != true)) {
                    this.HabiPisoField = value;
                    this.RaisePropertyChanged("HabiPiso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHabitacon {
            get {
                return this.IdHabitaconField;
            }
            set {
                if ((object.ReferenceEquals(this.IdHabitaconField, value) != true)) {
                    this.IdHabitaconField = value;
                    this.RaisePropertyChanged("IdHabitacon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHotel {
            get {
                return this.IdHotelField;
            }
            set {
                if ((object.ReferenceEquals(this.IdHotelField, value) != true)) {
                    this.IdHotelField = value;
                    this.RaisePropertyChanged("IdHotel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdTipoHabi {
            get {
                return this.IdTipoHabiField;
            }
            set {
                if ((object.ReferenceEquals(this.IdTipoHabiField, value) != true)) {
                    this.IdTipoHabiField = value;
                    this.RaisePropertyChanged("IdTipoHabi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDescripcion {
            get {
                return this.TipoDescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDescripcionField, value) != true)) {
                    this.TipoDescripcionField = value;
                    this.RaisePropertyChanged("TipoDescripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoNombre {
            get {
                return this.TipoNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoNombreField, value) != true)) {
                    this.TipoNombreField = value;
                    this.RaisePropertyChanged("TipoNombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoNumCamas {
            get {
                return this.TipoNumCamasField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoNumCamasField, value) != true)) {
                    this.TipoNumCamasField = value;
                    this.RaisePropertyChanged("TipoNumCamas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float TipoPrecio {
            get {
                return this.TipoPrecioField;
            }
            set {
                if ((this.TipoPrecioField.Equals(value) != true)) {
                    this.TipoPrecioField = value;
                    this.RaisePropertyChanged("TipoPrecio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyHabitacion.IServicioHabitacion")]
    public interface IServicioHabitacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHabitacion/ListarHabitacionesDisponibles", ReplyAction="http://tempuri.org/IServicioHabitacion/ListarHabitacionesDisponiblesResponse")]
        System.Collections.Generic.List<CapaAccesoServicios.ProxyHabitacion.dataHabitacion> ListarHabitacionesDisponibles(System.DateTime fecIngreso, System.DateTime fecSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHabitacion/ListarHabitacionesDisponibles", ReplyAction="http://tempuri.org/IServicioHabitacion/ListarHabitacionesDisponiblesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyHabitacion.dataHabitacion>> ListarHabitacionesDisponiblesAsync(System.DateTime fecIngreso, System.DateTime fecSalida);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioHabitacionChannel : CapaAccesoServicios.ProxyHabitacion.IServicioHabitacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioHabitacionClient : System.ServiceModel.ClientBase<CapaAccesoServicios.ProxyHabitacion.IServicioHabitacion>, CapaAccesoServicios.ProxyHabitacion.IServicioHabitacion {
        
        public ServicioHabitacionClient() {
        }
        
        public ServicioHabitacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioHabitacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioHabitacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioHabitacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<CapaAccesoServicios.ProxyHabitacion.dataHabitacion> ListarHabitacionesDisponibles(System.DateTime fecIngreso, System.DateTime fecSalida) {
            return base.Channel.ListarHabitacionesDisponibles(fecIngreso, fecSalida);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyHabitacion.dataHabitacion>> ListarHabitacionesDisponiblesAsync(System.DateTime fecIngreso, System.DateTime fecSalida) {
            return base.Channel.ListarHabitacionesDisponiblesAsync(fecIngreso, fecSalida);
        }
    }
}
