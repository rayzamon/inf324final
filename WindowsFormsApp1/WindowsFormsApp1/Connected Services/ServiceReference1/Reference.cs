﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tblAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet tblAlumno();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tblAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> tblAlumnoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agrega", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string agrega(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agrega", ReplyAction="*")]
        System.Threading.Tasks.Task<string> agregaAsync(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificaralumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string modificaralumno(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificaralumno", ReplyAction="*")]
        System.Threading.Tasks.Task<string> modificaralumnoAsync(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/borralumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string borralumno(string ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/borralumno", ReplyAction="*")]
        System.Threading.Tasks.Task<string> borralumnoAsync(string ci);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WindowsFormsApp1.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.WebServiceSoap>, WindowsFormsApp1.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet tblAlumno() {
            return base.Channel.tblAlumno();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> tblAlumnoAsync() {
            return base.Channel.tblAlumnoAsync();
        }
        
        public string agrega(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final) {
            return base.Channel.agrega(ci, nombre, apellido_pat, apellido_mat, nota_final);
        }
        
        public System.Threading.Tasks.Task<string> agregaAsync(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final) {
            return base.Channel.agregaAsync(ci, nombre, apellido_pat, apellido_mat, nota_final);
        }
        
        public string modificaralumno(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final) {
            return base.Channel.modificaralumno(ci, nombre, apellido_pat, apellido_mat, nota_final);
        }
        
        public System.Threading.Tasks.Task<string> modificaralumnoAsync(string ci, string nombre, string apellido_pat, string apellido_mat, string nota_final) {
            return base.Channel.modificaralumnoAsync(ci, nombre, apellido_pat, apellido_mat, nota_final);
        }
        
        public string borralumno(string ci) {
            return base.Channel.borralumno(ci);
        }
        
        public System.Threading.Tasks.Task<string> borralumnoAsync(string ci) {
            return base.Channel.borralumnoAsync(ci);
        }
    }
}
