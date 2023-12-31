﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesRentalClient.AccountService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Register", ReplyAction="http://tempuri.org/IAccountService/RegisterResponse")]
        bool Register(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Register", ReplyAction="http://tempuri.org/IAccountService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Login", ReplyAction="http://tempuri.org/IAccountService/LoginResponse")]
        string Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Login", ReplyAction="http://tempuri.org/IAccountService/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : MoviesRentalClient.AccountService.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<MoviesRentalClient.AccountService.IAccountService>, MoviesRentalClient.AccountService.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Register(string name, string email, string password) {
            return base.Channel.Register(name, email, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string name, string email, string password) {
            return base.Channel.RegisterAsync(name, email, password);
        }
        
        public string Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
    }
}
