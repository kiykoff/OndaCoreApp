//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace PBACalcSrv
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class AifFault : object
    {
        
        private string CustomDetailXmlField;
        
        private PBACalcSrv.FaultMessageList[] FaultMessageListArrayField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomDetailXml
        {
            get
            {
                return this.CustomDetailXmlField;
            }
            set
            {
                this.CustomDetailXmlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PBACalcSrv.FaultMessageList[] FaultMessageListArray
        {
            get
            {
                return this.FaultMessageListArrayField;
            }
            set
            {
                this.FaultMessageListArrayField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessageList", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class FaultMessageList : object
    {
        
        private string DocumentField;
        
        private string DocumentOperationField;
        
        private PBACalcSrv.FaultMessage[] FaultMessageArrayField;
        
        private string FieldField;
        
        private string ServiceField;
        
        private string ServiceOperationField;
        
        private string ServiceOperationParameterField;
        
        private string XPathField;
        
        private string XmlLineField;
        
        private string XmlPositionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document
        {
            get
            {
                return this.DocumentField;
            }
            set
            {
                this.DocumentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentOperation
        {
            get
            {
                return this.DocumentOperationField;
            }
            set
            {
                this.DocumentOperationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PBACalcSrv.FaultMessage[] FaultMessageArray
        {
            get
            {
                return this.FaultMessageArrayField;
            }
            set
            {
                this.FaultMessageArrayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Field
        {
            get
            {
                return this.FieldField;
            }
            set
            {
                this.FieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Service
        {
            get
            {
                return this.ServiceField;
            }
            set
            {
                this.ServiceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperation
        {
            get
            {
                return this.ServiceOperationField;
            }
            set
            {
                this.ServiceOperationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperationParameter
        {
            get
            {
                return this.ServiceOperationParameterField;
            }
            set
            {
                this.ServiceOperationParameterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XPath
        {
            get
            {
                return this.XPathField;
            }
            set
            {
                this.XPathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlLine
        {
            get
            {
                return this.XmlLineField;
            }
            set
            {
                this.XmlLineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlPosition
        {
            get
            {
                return this.XmlPositionField;
            }
            set
            {
                this.XmlPositionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessage", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class FaultMessage : object
    {
        
        private string CodeField;
        
        private string MessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="PBACalcSrv.PBACalcWebService")]
    public interface PBACalcWebService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PBACalcWebService/PBACalculatePrice", ReplyAction="http://tempuri.org/PBACalcWebService/PBACalculatePriceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PBACalcSrv.AifFault), Action="http://tempuri.org/PBACalcWebService/PBACalculatePriceAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        System.Threading.Tasks.Task<PBACalcSrv.PBACalcWebServicePBACalculatePriceResponse> PBACalculatePriceAsync(PBACalcSrv.PBACalcWebServicePBACalculatePriceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PBACalcWebService/SaveCalculatedQuotation", ReplyAction="http://tempuri.org/PBACalcWebService/SaveCalculatedQuotationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PBACalcSrv.AifFault), Action="http://tempuri.org/PBACalcWebService/SaveCalculatedQuotationAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        System.Threading.Tasks.Task SaveCalculatedQuotationAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PBACalcWebServicePBACalculatePriceRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class PBACalcWebServicePBACalculatePriceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string InventTransId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=1)]
        public bool isTestMode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=2)]
        public double stdMatHight;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=3)]
        public string stdMatId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=4)]
        public double stdMatWidht;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=5)]
        public double stdStepHight;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=6)]
        public double stdStepWidht;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=7)]
        public string typeOfStep;
        
        public PBACalcWebServicePBACalculatePriceRequest()
        {
        }
        
        public PBACalcWebServicePBACalculatePriceRequest(string InventTransId, bool isTestMode, double stdMatHight, string stdMatId, double stdMatWidht, double stdStepHight, double stdStepWidht, string typeOfStep)
        {
            this.InventTransId = InventTransId;
            this.isTestMode = isTestMode;
            this.stdMatHight = stdMatHight;
            this.stdMatId = stdMatId;
            this.stdMatWidht = stdMatWidht;
            this.stdStepHight = stdStepHight;
            this.stdStepWidht = stdStepWidht;
            this.typeOfStep = typeOfStep;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PBACalcWebServicePBACalculatePriceResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class PBACalcWebServicePBACalculatePriceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public double response;
        
        public PBACalcWebServicePBACalculatePriceResponse()
        {
        }
        
        public PBACalcWebServicePBACalculatePriceResponse(double response)
        {
            this.response = response;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface PBACalcWebServiceChannel : PBACalcSrv.PBACalcWebService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PBACalcWebServiceClient : System.ServiceModel.ClientBase<PBACalcSrv.PBACalcWebService>, PBACalcSrv.PBACalcWebService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PBACalcWebServiceClient() : 
                base(PBACalcWebServiceClient.GetDefaultBinding(), PBACalcWebServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_PBACalcWebService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBACalcWebServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PBACalcWebServiceClient.GetBindingForEndpoint(endpointConfiguration), PBACalcWebServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBACalcWebServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PBACalcWebServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBACalcWebServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PBACalcWebServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBACalcWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PBACalcSrv.PBACalcWebServicePBACalculatePriceResponse> PBACalcSrv.PBACalcWebService.PBACalculatePriceAsync(PBACalcSrv.PBACalcWebServicePBACalculatePriceRequest request)
        {
            return base.Channel.PBACalculatePriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<PBACalcSrv.PBACalcWebServicePBACalculatePriceResponse> PBACalculatePriceAsync(string InventTransId, bool isTestMode, double stdMatHight, string stdMatId, double stdMatWidht, double stdStepHight, double stdStepWidht, string typeOfStep)
        {
            PBACalcSrv.PBACalcWebServicePBACalculatePriceRequest inValue = new PBACalcSrv.PBACalcWebServicePBACalculatePriceRequest();
            inValue.InventTransId = InventTransId;
            inValue.isTestMode = isTestMode;
            inValue.stdMatHight = stdMatHight;
            inValue.stdMatId = stdMatId;
            inValue.stdMatWidht = stdMatWidht;
            inValue.stdStepHight = stdStepHight;
            inValue.stdStepWidht = stdStepWidht;
            inValue.typeOfStep = typeOfStep;
            return ((PBACalcSrv.PBACalcWebService)(this)).PBACalculatePriceAsync(inValue);
        }
        
        public System.Threading.Tasks.Task SaveCalculatedQuotationAsync()
        {
            return base.Channel.SaveCalculatedQuotationAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_PBACalcWebService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.TransportCredentialOnly;
                result.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.Windows;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_PBACalcWebService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/pbacalcwebservice.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PBACalcWebServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_PBACalcWebService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PBACalcWebServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_PBACalcWebService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_PBACalcWebService,
        }
    }
}
