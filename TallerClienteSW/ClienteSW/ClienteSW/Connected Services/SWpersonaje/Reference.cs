﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSW.SWpersonaje {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", ConfigurationName="SWpersonaje.PersonajeWebService")]
    public interface PersonajeWebService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/insertarPersonajeReques" +
            "t", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/insertarPersonajeRespon" +
            "se")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSW.SWpersonaje.insertarPersonajeResponse insertarPersonaje(ClienteSW.SWpersonaje.insertarPersonajeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/insertarPersonajeReques" +
            "t", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/insertarPersonajeRespon" +
            "se")]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.insertarPersonajeResponse> insertarPersonajeAsync(ClienteSW.SWpersonaje.insertarPersonajeRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/actualizarPersonajeRequ" +
            "est", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/actualizarPersonajeResp" +
            "onse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSW.SWpersonaje.actualizarPersonajeResponse actualizarPersonaje(ClienteSW.SWpersonaje.actualizarPersonajeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/actualizarPersonajeRequ" +
            "est", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/actualizarPersonajeResp" +
            "onse")]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.actualizarPersonajeResponse> actualizarPersonajeAsync(ClienteSW.SWpersonaje.actualizarPersonajeRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/eliminarPersonajeReques" +
            "t", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/eliminarPersonajeRespon" +
            "se")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSW.SWpersonaje.eliminarPersonajeResponse eliminarPersonaje(ClienteSW.SWpersonaje.eliminarPersonajeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/eliminarPersonajeReques" +
            "t", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/eliminarPersonajeRespon" +
            "se")]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.eliminarPersonajeResponse> eliminarPersonajeAsync(ClienteSW.SWpersonaje.eliminarPersonajeRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/listarPersonajeRequest", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/listarPersonajeResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSW.SWpersonaje.listarPersonajeResponse listarPersonaje(ClienteSW.SWpersonaje.listarPersonajeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/listarPersonajeRequest", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/listarPersonajeResponse" +
            "")]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.listarPersonajeResponse> listarPersonajeAsync(ClienteSW.SWpersonaje.listarPersonajeRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/buscarporIdPersonajeReq" +
            "uest", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/buscarporIdPersonajeRes" +
            "ponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSW.SWpersonaje.buscarporIdPersonajeResponse buscarporIdPersonaje(ClienteSW.SWpersonaje.buscarporIdPersonajeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/buscarporIdPersonajeReq" +
            "uest", ReplyAction="http://ws.servidor_taller2.grupo1.com/PersonajeWebService/buscarporIdPersonajeRes" +
            "ponse")]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.buscarporIdPersonajeResponse> buscarporIdPersonajeAsync(ClienteSW.SWpersonaje.buscarporIdPersonajeRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/")]
    public partial class personajeVO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double energiaField;
        
        private double estadoRegistroField;
        
        private System.DateTime fechaModificacionField;
        
        private bool fechaModificacionFieldSpecified;
        
        private double fuerzaField;
        
        private string idField;
        
        private string id_especieField;
        
        private string id_jugadorField;
        
        private double manaField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double energia {
            get {
                return this.energiaField;
            }
            set {
                this.energiaField = value;
                this.RaisePropertyChanged("energia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double estadoRegistro {
            get {
                return this.estadoRegistroField;
            }
            set {
                this.estadoRegistroField = value;
                this.RaisePropertyChanged("estadoRegistro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime fechaModificacion {
            get {
                return this.fechaModificacionField;
            }
            set {
                this.fechaModificacionField = value;
                this.RaisePropertyChanged("fechaModificacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaModificacionSpecified {
            get {
                return this.fechaModificacionFieldSpecified;
            }
            set {
                this.fechaModificacionFieldSpecified = value;
                this.RaisePropertyChanged("fechaModificacionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double fuerza {
            get {
                return this.fuerzaField;
            }
            set {
                this.fuerzaField = value;
                this.RaisePropertyChanged("fuerza");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string id_especie {
            get {
                return this.id_especieField;
            }
            set {
                this.id_especieField = value;
                this.RaisePropertyChanged("id_especie");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string id_jugador {
            get {
                return this.id_jugadorField;
            }
            set {
                this.id_jugadorField = value;
                this.RaisePropertyChanged("id_jugador");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public double mana {
            get {
                return this.manaField;
            }
            set {
                this.manaField = value;
                this.RaisePropertyChanged("mana");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarPersonaje", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class insertarPersonajeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSW.SWpersonaje.personajeVO PersonajeVO;
        
        public insertarPersonajeRequest() {
        }
        
        public insertarPersonajeRequest(ClienteSW.SWpersonaje.personajeVO PersonajeVO) {
            this.PersonajeVO = PersonajeVO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarPersonajeResponse", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class insertarPersonajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public insertarPersonajeResponse() {
        }
        
        public insertarPersonajeResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarPersonaje", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class actualizarPersonajeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSW.SWpersonaje.personajeVO PersonajeVO;
        
        public actualizarPersonajeRequest() {
        }
        
        public actualizarPersonajeRequest(ClienteSW.SWpersonaje.personajeVO PersonajeVO) {
            this.PersonajeVO = PersonajeVO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarPersonajeResponse", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class actualizarPersonajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public actualizarPersonajeResponse() {
        }
        
        public actualizarPersonajeResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPersonaje", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class eliminarPersonajeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PersonajeVO;
        
        public eliminarPersonajeRequest() {
        }
        
        public eliminarPersonajeRequest(string PersonajeVO) {
            this.PersonajeVO = PersonajeVO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPersonajeResponse", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class eliminarPersonajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public eliminarPersonajeResponse() {
        }
        
        public eliminarPersonajeResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarPersonaje", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class listarPersonajeRequest {
        
        public listarPersonajeRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarPersonajeResponse", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class listarPersonajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSW.SWpersonaje.personajeVO[] @return;
        
        public listarPersonajeResponse() {
        }
        
        public listarPersonajeResponse(ClienteSW.SWpersonaje.personajeVO[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarporIdPersonaje", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class buscarporIdPersonajeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PersonajeVO;
        
        public buscarporIdPersonajeRequest() {
        }
        
        public buscarporIdPersonajeRequest(string PersonajeVO) {
            this.PersonajeVO = PersonajeVO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarporIdPersonajeResponse", WrapperNamespace="http://ws.servidor_taller2.grupo1.com/", IsWrapped=true)]
    public partial class buscarporIdPersonajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.servidor_taller2.grupo1.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSW.SWpersonaje.personajeVO @return;
        
        public buscarporIdPersonajeResponse() {
        }
        
        public buscarporIdPersonajeResponse(ClienteSW.SWpersonaje.personajeVO @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PersonajeWebServiceChannel : ClienteSW.SWpersonaje.PersonajeWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonajeWebServiceClient : System.ServiceModel.ClientBase<ClienteSW.SWpersonaje.PersonajeWebService>, ClienteSW.SWpersonaje.PersonajeWebService {
        
        public PersonajeWebServiceClient() {
        }
        
        public PersonajeWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonajeWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonajeWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonajeWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSW.SWpersonaje.insertarPersonajeResponse ClienteSW.SWpersonaje.PersonajeWebService.insertarPersonaje(ClienteSW.SWpersonaje.insertarPersonajeRequest request) {
            return base.Channel.insertarPersonaje(request);
        }
        
        public bool insertarPersonaje(ClienteSW.SWpersonaje.personajeVO PersonajeVO) {
            ClienteSW.SWpersonaje.insertarPersonajeRequest inValue = new ClienteSW.SWpersonaje.insertarPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            ClienteSW.SWpersonaje.insertarPersonajeResponse retVal = ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).insertarPersonaje(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.insertarPersonajeResponse> ClienteSW.SWpersonaje.PersonajeWebService.insertarPersonajeAsync(ClienteSW.SWpersonaje.insertarPersonajeRequest request) {
            return base.Channel.insertarPersonajeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSW.SWpersonaje.insertarPersonajeResponse> insertarPersonajeAsync(ClienteSW.SWpersonaje.personajeVO PersonajeVO) {
            ClienteSW.SWpersonaje.insertarPersonajeRequest inValue = new ClienteSW.SWpersonaje.insertarPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            return ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).insertarPersonajeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSW.SWpersonaje.actualizarPersonajeResponse ClienteSW.SWpersonaje.PersonajeWebService.actualizarPersonaje(ClienteSW.SWpersonaje.actualizarPersonajeRequest request) {
            return base.Channel.actualizarPersonaje(request);
        }
        
        public bool actualizarPersonaje(ClienteSW.SWpersonaje.personajeVO PersonajeVO) {
            ClienteSW.SWpersonaje.actualizarPersonajeRequest inValue = new ClienteSW.SWpersonaje.actualizarPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            ClienteSW.SWpersonaje.actualizarPersonajeResponse retVal = ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).actualizarPersonaje(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.actualizarPersonajeResponse> ClienteSW.SWpersonaje.PersonajeWebService.actualizarPersonajeAsync(ClienteSW.SWpersonaje.actualizarPersonajeRequest request) {
            return base.Channel.actualizarPersonajeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSW.SWpersonaje.actualizarPersonajeResponse> actualizarPersonajeAsync(ClienteSW.SWpersonaje.personajeVO PersonajeVO) {
            ClienteSW.SWpersonaje.actualizarPersonajeRequest inValue = new ClienteSW.SWpersonaje.actualizarPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            return ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).actualizarPersonajeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSW.SWpersonaje.eliminarPersonajeResponse ClienteSW.SWpersonaje.PersonajeWebService.eliminarPersonaje(ClienteSW.SWpersonaje.eliminarPersonajeRequest request) {
            return base.Channel.eliminarPersonaje(request);
        }
        
        public bool eliminarPersonaje(string PersonajeVO) {
            ClienteSW.SWpersonaje.eliminarPersonajeRequest inValue = new ClienteSW.SWpersonaje.eliminarPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            ClienteSW.SWpersonaje.eliminarPersonajeResponse retVal = ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).eliminarPersonaje(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.eliminarPersonajeResponse> ClienteSW.SWpersonaje.PersonajeWebService.eliminarPersonajeAsync(ClienteSW.SWpersonaje.eliminarPersonajeRequest request) {
            return base.Channel.eliminarPersonajeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSW.SWpersonaje.eliminarPersonajeResponse> eliminarPersonajeAsync(string PersonajeVO) {
            ClienteSW.SWpersonaje.eliminarPersonajeRequest inValue = new ClienteSW.SWpersonaje.eliminarPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            return ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).eliminarPersonajeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSW.SWpersonaje.listarPersonajeResponse ClienteSW.SWpersonaje.PersonajeWebService.listarPersonaje(ClienteSW.SWpersonaje.listarPersonajeRequest request) {
            return base.Channel.listarPersonaje(request);
        }
        
        public ClienteSW.SWpersonaje.personajeVO[] listarPersonaje() {
            ClienteSW.SWpersonaje.listarPersonajeRequest inValue = new ClienteSW.SWpersonaje.listarPersonajeRequest();
            ClienteSW.SWpersonaje.listarPersonajeResponse retVal = ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).listarPersonaje(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.listarPersonajeResponse> ClienteSW.SWpersonaje.PersonajeWebService.listarPersonajeAsync(ClienteSW.SWpersonaje.listarPersonajeRequest request) {
            return base.Channel.listarPersonajeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSW.SWpersonaje.listarPersonajeResponse> listarPersonajeAsync() {
            ClienteSW.SWpersonaje.listarPersonajeRequest inValue = new ClienteSW.SWpersonaje.listarPersonajeRequest();
            return ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).listarPersonajeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSW.SWpersonaje.buscarporIdPersonajeResponse ClienteSW.SWpersonaje.PersonajeWebService.buscarporIdPersonaje(ClienteSW.SWpersonaje.buscarporIdPersonajeRequest request) {
            return base.Channel.buscarporIdPersonaje(request);
        }
        
        public ClienteSW.SWpersonaje.personajeVO buscarporIdPersonaje(string PersonajeVO) {
            ClienteSW.SWpersonaje.buscarporIdPersonajeRequest inValue = new ClienteSW.SWpersonaje.buscarporIdPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            ClienteSW.SWpersonaje.buscarporIdPersonajeResponse retVal = ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).buscarporIdPersonaje(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSW.SWpersonaje.buscarporIdPersonajeResponse> ClienteSW.SWpersonaje.PersonajeWebService.buscarporIdPersonajeAsync(ClienteSW.SWpersonaje.buscarporIdPersonajeRequest request) {
            return base.Channel.buscarporIdPersonajeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSW.SWpersonaje.buscarporIdPersonajeResponse> buscarporIdPersonajeAsync(string PersonajeVO) {
            ClienteSW.SWpersonaje.buscarporIdPersonajeRequest inValue = new ClienteSW.SWpersonaje.buscarporIdPersonajeRequest();
            inValue.PersonajeVO = PersonajeVO;
            return ((ClienteSW.SWpersonaje.PersonajeWebService)(this)).buscarporIdPersonajeAsync(inValue);
        }
    }
}
