﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JCTBank.WebApp.HGSServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HGSServices.HGSServiceSoap")]
    public interface HGSServiceSoap {
        
        // CODEGEN: Generating message contract since element name customerTCKN from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaleHGS", ReplyAction="*")]
        JCTBank.WebApp.HGSServices.SaleHGSResponse SaleHGS(JCTBank.WebApp.HGSServices.SaleHGSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaleHGS", ReplyAction="*")]
        System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.SaleHGSResponse> SaleHGSAsync(JCTBank.WebApp.HGSServices.SaleHGSRequest request);
        
        // CODEGEN: Generating message contract since element name PlateNumber from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoadBalance", ReplyAction="*")]
        JCTBank.WebApp.HGSServices.LoadBalanceResponse LoadBalance(JCTBank.WebApp.HGSServices.LoadBalanceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoadBalance", ReplyAction="*")]
        System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.LoadBalanceResponse> LoadBalanceAsync(JCTBank.WebApp.HGSServices.LoadBalanceRequest request);
        
        // CODEGEN: Generating message contract since element name PlateNumber from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateBalance", ReplyAction="*")]
        JCTBank.WebApp.HGSServices.UpdateBalanceResponse UpdateBalance(JCTBank.WebApp.HGSServices.UpdateBalanceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateBalance", ReplyAction="*")]
        System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.UpdateBalanceResponse> UpdateBalanceAsync(JCTBank.WebApp.HGSServices.UpdateBalanceRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaleHGSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaleHGS", Namespace="http://tempuri.org/", Order=0)]
        public JCTBank.WebApp.HGSServices.SaleHGSRequestBody Body;
        
        public SaleHGSRequest() {
        }
        
        public SaleHGSRequest(JCTBank.WebApp.HGSServices.SaleHGSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaleHGSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal balance;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int customerId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string customerTCKN;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string plateNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.DateTime saleDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string webOrMobil;
        
        public SaleHGSRequestBody() {
        }
        
        public SaleHGSRequestBody(decimal balance, int customerId, string customerTCKN, string plateNumber, System.DateTime saleDate, string webOrMobil) {
            this.balance = balance;
            this.customerId = customerId;
            this.customerTCKN = customerTCKN;
            this.plateNumber = plateNumber;
            this.saleDate = saleDate;
            this.webOrMobil = webOrMobil;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaleHGSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaleHGSResponse", Namespace="http://tempuri.org/", Order=0)]
        public JCTBank.WebApp.HGSServices.SaleHGSResponseBody Body;
        
        public SaleHGSResponse() {
        }
        
        public SaleHGSResponse(JCTBank.WebApp.HGSServices.SaleHGSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaleHGSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool SaleHGSResult;
        
        public SaleHGSResponseBody() {
        }
        
        public SaleHGSResponseBody(bool SaleHGSResult) {
            this.SaleHGSResult = SaleHGSResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoadBalanceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoadBalance", Namespace="http://tempuri.org/", Order=0)]
        public JCTBank.WebApp.HGSServices.LoadBalanceRequestBody Body;
        
        public LoadBalanceRequest() {
        }
        
        public LoadBalanceRequest(JCTBank.WebApp.HGSServices.LoadBalanceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoadBalanceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PlateNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public decimal balance;
        
        public LoadBalanceRequestBody() {
        }
        
        public LoadBalanceRequestBody(string PlateNumber, decimal balance) {
            this.PlateNumber = PlateNumber;
            this.balance = balance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoadBalanceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoadBalanceResponse", Namespace="http://tempuri.org/", Order=0)]
        public JCTBank.WebApp.HGSServices.LoadBalanceResponseBody Body;
        
        public LoadBalanceResponse() {
        }
        
        public LoadBalanceResponse(JCTBank.WebApp.HGSServices.LoadBalanceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoadBalanceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LoadBalanceResult;
        
        public LoadBalanceResponseBody() {
        }
        
        public LoadBalanceResponseBody(bool LoadBalanceResult) {
            this.LoadBalanceResult = LoadBalanceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateBalanceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateBalance", Namespace="http://tempuri.org/", Order=0)]
        public JCTBank.WebApp.HGSServices.UpdateBalanceRequestBody Body;
        
        public UpdateBalanceRequest() {
        }
        
        public UpdateBalanceRequest(JCTBank.WebApp.HGSServices.UpdateBalanceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateBalanceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PlateNumber;
        
        public UpdateBalanceRequestBody() {
        }
        
        public UpdateBalanceRequestBody(string PlateNumber) {
            this.PlateNumber = PlateNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateBalanceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateBalanceResponse", Namespace="http://tempuri.org/", Order=0)]
        public JCTBank.WebApp.HGSServices.UpdateBalanceResponseBody Body;
        
        public UpdateBalanceResponse() {
        }
        
        public UpdateBalanceResponse(JCTBank.WebApp.HGSServices.UpdateBalanceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateBalanceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UpdateBalanceResult;
        
        public UpdateBalanceResponseBody() {
        }
        
        public UpdateBalanceResponseBody(bool UpdateBalanceResult) {
            this.UpdateBalanceResult = UpdateBalanceResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HGSServiceSoapChannel : JCTBank.WebApp.HGSServices.HGSServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HGSServiceSoapClient : System.ServiceModel.ClientBase<JCTBank.WebApp.HGSServices.HGSServiceSoap>, JCTBank.WebApp.HGSServices.HGSServiceSoap {
        
        public HGSServiceSoapClient() {
        }
        
        public HGSServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HGSServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HGSServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HGSServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JCTBank.WebApp.HGSServices.SaleHGSResponse JCTBank.WebApp.HGSServices.HGSServiceSoap.SaleHGS(JCTBank.WebApp.HGSServices.SaleHGSRequest request) {
            return base.Channel.SaleHGS(request);
        }
        
        public bool SaleHGS(decimal balance, int customerId, string customerTCKN, string plateNumber, System.DateTime saleDate, string webOrMobil) {
            JCTBank.WebApp.HGSServices.SaleHGSRequest inValue = new JCTBank.WebApp.HGSServices.SaleHGSRequest();
            inValue.Body = new JCTBank.WebApp.HGSServices.SaleHGSRequestBody();
            inValue.Body.balance = balance;
            inValue.Body.customerId = customerId;
            inValue.Body.customerTCKN = customerTCKN;
            inValue.Body.plateNumber = plateNumber;
            inValue.Body.saleDate = saleDate;
            inValue.Body.webOrMobil = webOrMobil;
            JCTBank.WebApp.HGSServices.SaleHGSResponse retVal = ((JCTBank.WebApp.HGSServices.HGSServiceSoap)(this)).SaleHGS(inValue);
            return retVal.Body.SaleHGSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.SaleHGSResponse> JCTBank.WebApp.HGSServices.HGSServiceSoap.SaleHGSAsync(JCTBank.WebApp.HGSServices.SaleHGSRequest request) {
            return base.Channel.SaleHGSAsync(request);
        }
        
        public System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.SaleHGSResponse> SaleHGSAsync(decimal balance, int customerId, string customerTCKN, string plateNumber, System.DateTime saleDate, string webOrMobil) {
            JCTBank.WebApp.HGSServices.SaleHGSRequest inValue = new JCTBank.WebApp.HGSServices.SaleHGSRequest();
            inValue.Body = new JCTBank.WebApp.HGSServices.SaleHGSRequestBody();
            inValue.Body.balance = balance;
            inValue.Body.customerId = customerId;
            inValue.Body.customerTCKN = customerTCKN;
            inValue.Body.plateNumber = plateNumber;
            inValue.Body.saleDate = saleDate;
            inValue.Body.webOrMobil = webOrMobil;
            return ((JCTBank.WebApp.HGSServices.HGSServiceSoap)(this)).SaleHGSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JCTBank.WebApp.HGSServices.LoadBalanceResponse JCTBank.WebApp.HGSServices.HGSServiceSoap.LoadBalance(JCTBank.WebApp.HGSServices.LoadBalanceRequest request) {
            return base.Channel.LoadBalance(request);
        }
        
        public bool LoadBalance(string PlateNumber, decimal balance) {
            JCTBank.WebApp.HGSServices.LoadBalanceRequest inValue = new JCTBank.WebApp.HGSServices.LoadBalanceRequest();
            inValue.Body = new JCTBank.WebApp.HGSServices.LoadBalanceRequestBody();
            inValue.Body.PlateNumber = PlateNumber;
            inValue.Body.balance = balance;
            JCTBank.WebApp.HGSServices.LoadBalanceResponse retVal = ((JCTBank.WebApp.HGSServices.HGSServiceSoap)(this)).LoadBalance(inValue);
            return retVal.Body.LoadBalanceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.LoadBalanceResponse> JCTBank.WebApp.HGSServices.HGSServiceSoap.LoadBalanceAsync(JCTBank.WebApp.HGSServices.LoadBalanceRequest request) {
            return base.Channel.LoadBalanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.LoadBalanceResponse> LoadBalanceAsync(string PlateNumber, decimal balance) {
            JCTBank.WebApp.HGSServices.LoadBalanceRequest inValue = new JCTBank.WebApp.HGSServices.LoadBalanceRequest();
            inValue.Body = new JCTBank.WebApp.HGSServices.LoadBalanceRequestBody();
            inValue.Body.PlateNumber = PlateNumber;
            inValue.Body.balance = balance;
            return ((JCTBank.WebApp.HGSServices.HGSServiceSoap)(this)).LoadBalanceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JCTBank.WebApp.HGSServices.UpdateBalanceResponse JCTBank.WebApp.HGSServices.HGSServiceSoap.UpdateBalance(JCTBank.WebApp.HGSServices.UpdateBalanceRequest request) {
            return base.Channel.UpdateBalance(request);
        }
        
        public bool UpdateBalance(string PlateNumber) {
            JCTBank.WebApp.HGSServices.UpdateBalanceRequest inValue = new JCTBank.WebApp.HGSServices.UpdateBalanceRequest();
            inValue.Body = new JCTBank.WebApp.HGSServices.UpdateBalanceRequestBody();
            inValue.Body.PlateNumber = PlateNumber;
            JCTBank.WebApp.HGSServices.UpdateBalanceResponse retVal = ((JCTBank.WebApp.HGSServices.HGSServiceSoap)(this)).UpdateBalance(inValue);
            return retVal.Body.UpdateBalanceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.UpdateBalanceResponse> JCTBank.WebApp.HGSServices.HGSServiceSoap.UpdateBalanceAsync(JCTBank.WebApp.HGSServices.UpdateBalanceRequest request) {
            return base.Channel.UpdateBalanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<JCTBank.WebApp.HGSServices.UpdateBalanceResponse> UpdateBalanceAsync(string PlateNumber) {
            JCTBank.WebApp.HGSServices.UpdateBalanceRequest inValue = new JCTBank.WebApp.HGSServices.UpdateBalanceRequest();
            inValue.Body = new JCTBank.WebApp.HGSServices.UpdateBalanceRequestBody();
            inValue.Body.PlateNumber = PlateNumber;
            return ((JCTBank.WebApp.HGSServices.HGSServiceSoap)(this)).UpdateBalanceAsync(inValue);
        }
    }
}