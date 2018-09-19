//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace PBA
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class AifFault : object
    {
        
        private string CustomDetailXmlField;
        
        private PBA.FaultMessageList[] FaultMessageListArrayField;
        
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
        public PBA.FaultMessageList[] FaultMessageListArray
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
        
        private PBA.FaultMessage[] FaultMessageArrayField;
        
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
        public PBA.FaultMessage[] FaultMessageArray
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="PBA.PBAWebService")]
    public interface PBAWebService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PBAWebService/test", ReplyAction="http://tempuri.org/PBAWebService/testResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PBA.AifFault), Action="http://tempuri.org/PBAWebService/testAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        System.Threading.Tasks.Task<PBA.PBAWebServiceTestResponse> testAsync(PBA.testRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class testRequest
    {
        
        public testRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PBAWebServiceTestResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class PBAWebServiceTestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string response;
        
        public PBAWebServiceTestResponse()
        {
        }
        
        public PBAWebServiceTestResponse(string response)
        {
            this.response = response;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface PBAWebServiceChannel : PBA.PBAWebService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PBAWebServiceClient : System.ServiceModel.ClientBase<PBA.PBAWebService>, PBA.PBAWebService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PBAWebServiceClient() : 
                base(PBAWebServiceClient.GetDefaultBinding(), PBAWebServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_PBAWebService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBAWebServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PBAWebServiceClient.GetBindingForEndpoint(endpointConfiguration), PBAWebServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBAWebServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PBAWebServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBAWebServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PBAWebServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PBAWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PBA.PBAWebServiceTestResponse> PBA.PBAWebService.testAsync(PBA.testRequest request)
        {
            return base.Channel.testAsync(request);
        }
        
        public System.Threading.Tasks.Task<PBA.PBAWebServiceTestResponse> testAsync()
        {
            PBA.testRequest inValue = new PBA.testRequest();
            return ((PBA.PBAWebService)(this)).testAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_PBAWebService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_PBAWebService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/MicrosoftDynamicsAXAif50/pbawebservice.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PBAWebServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_PBAWebService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PBAWebServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_PBAWebService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_PBAWebService,
        }
    }
}
