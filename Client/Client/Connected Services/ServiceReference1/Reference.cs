﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Контракт генерации сообщений с именем s из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Client.ServiceReference1.HelloWorldResponse HelloWorld(Client.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.ServiceReference1.HelloWorldResponse> HelloWorldAsync(Client.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем MoreTwoResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MoreTwo", ReplyAction="*")]
        Client.ServiceReference1.MoreTwoResponse MoreTwo(Client.ServiceReference1.MoreTwoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MoreTwo", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.ServiceReference1.MoreTwoResponse> MoreTwoAsync(Client.ServiceReference1.MoreTwoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Client.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string s;
        
        public HelloWorldRequestBody() {
        }
        
        public HelloWorldRequestBody(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Client.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoreTwoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoreTwo", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.MoreTwoRequestBody Body;
        
        public MoreTwoRequest() {
        }
        
        public MoreTwoRequest(Client.ServiceReference1.MoreTwoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MoreTwoRequestBody {
        
        public MoreTwoRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoreTwoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoreTwoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.MoreTwoResponseBody Body;
        
        public MoreTwoResponse() {
        }
        
        public MoreTwoResponse(Client.ServiceReference1.MoreTwoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MoreTwoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MoreTwoResult;
        
        public MoreTwoResponseBody() {
        }
        
        public MoreTwoResponseBody(string MoreTwoResult) {
            this.MoreTwoResult = MoreTwoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Client.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Client.ServiceReference1.WebService1Soap>, Client.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference1.HelloWorldResponse Client.ServiceReference1.WebService1Soap.HelloWorld(Client.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld(string s) {
            Client.ServiceReference1.HelloWorldRequest inValue = new Client.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Client.ServiceReference1.HelloWorldRequestBody();
            inValue.Body.s = s;
            Client.ServiceReference1.HelloWorldResponse retVal = ((Client.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.ServiceReference1.HelloWorldResponse> Client.ServiceReference1.WebService1Soap.HelloWorldAsync(Client.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.HelloWorldResponse> HelloWorldAsync(string s) {
            Client.ServiceReference1.HelloWorldRequest inValue = new Client.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Client.ServiceReference1.HelloWorldRequestBody();
            inValue.Body.s = s;
            return ((Client.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference1.MoreTwoResponse Client.ServiceReference1.WebService1Soap.MoreTwo(Client.ServiceReference1.MoreTwoRequest request) {
            return base.Channel.MoreTwo(request);
        }
        
        public string MoreTwo() {
            Client.ServiceReference1.MoreTwoRequest inValue = new Client.ServiceReference1.MoreTwoRequest();
            inValue.Body = new Client.ServiceReference1.MoreTwoRequestBody();
            Client.ServiceReference1.MoreTwoResponse retVal = ((Client.ServiceReference1.WebService1Soap)(this)).MoreTwo(inValue);
            return retVal.Body.MoreTwoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.ServiceReference1.MoreTwoResponse> Client.ServiceReference1.WebService1Soap.MoreTwoAsync(Client.ServiceReference1.MoreTwoRequest request) {
            return base.Channel.MoreTwoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.MoreTwoResponse> MoreTwoAsync() {
            Client.ServiceReference1.MoreTwoRequest inValue = new Client.ServiceReference1.MoreTwoRequest();
            inValue.Body = new Client.ServiceReference1.MoreTwoRequestBody();
            return ((Client.ServiceReference1.WebService1Soap)(this)).MoreTwoAsync(inValue);
        }
    }
}