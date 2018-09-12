//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace SalesSalesOrderService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class AifFault
    {
        
        private string customDetailXmlField;
        
        private FaultMessageList[] faultMessageListArrayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string CustomDetailXml
        {
            get
            {
                return this.customDetailXmlField;
            }
            set
            {
                this.customDetailXmlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=1)]
        public FaultMessageList[] FaultMessageListArray
        {
            get
            {
                return this.faultMessageListArrayField;
            }
            set
            {
                this.faultMessageListArrayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class FaultMessageList
    {
        
        private string documentField;
        
        private string documentOperationField;
        
        private FaultMessage[] faultMessageArrayField;
        
        private string fieldField;
        
        private string serviceField;
        
        private string serviceOperationField;
        
        private string serviceOperationParameterField;
        
        private string xPathField;
        
        private string xmlLineField;
        
        private string xmlPositionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string DocumentOperation
        {
            get
            {
                return this.documentOperationField;
            }
            set
            {
                this.documentOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=2)]
        public FaultMessage[] FaultMessageArray
        {
            get
            {
                return this.faultMessageArrayField;
            }
            set
            {
                this.faultMessageArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string ServiceOperation
        {
            get
            {
                return this.serviceOperationField;
            }
            set
            {
                this.serviceOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string ServiceOperationParameter
        {
            get
            {
                return this.serviceOperationParameterField;
            }
            set
            {
                this.serviceOperationParameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public string XmlLine
        {
            get
            {
                return this.xmlLineField;
            }
            set
            {
                this.xmlLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string XmlPosition
        {
            get
            {
                return this.xmlPositionField;
            }
            set
            {
                this.xmlPositionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class FaultMessage
    {
        
        private string codeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey")]
    public partial class KeyField
    {
        
        private string fieldField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey")]
    public partial class EntityKey
    {
        
        private KeyField[] keyDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public KeyField[] KeyData
        {
            get
            {
                return this.keyDataField;
            }
            set
            {
                this.keyDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
    public partial class CriteriaElement
    {
        
        private string dataSourceNameField;
        
        private string fieldNameField;
        
        private Operator operatorField;
        
        private string value1Field;
        
        private string value2Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DataSourceName
        {
            get
            {
                return this.dataSourceNameField;
            }
            set
            {
                this.dataSourceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Operator Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Value1
        {
            get
            {
                return this.value1Field;
            }
            set
            {
                this.value1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Value2
        {
            get
            {
                return this.value2Field;
            }
            set
            {
                this.value2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
    public enum Operator
    {
        
        /// <remarks/>
        Equal,
        
        /// <remarks/>
        NotEqual,
        
        /// <remarks/>
        Greater,
        
        /// <remarks/>
        GreaterOrEqual,
        
        /// <remarks/>
        Less,
        
        /// <remarks/>
        LessOrEqual,
        
        /// <remarks/>
        Range,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
    public partial class QueryCriteria
    {
        
        private CriteriaElement[] criteriaElementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CriteriaElement", Order=0)]
        public CriteriaElement[] CriteriaElement
        {
            get
            {
                return this.criteriaElementField;
            }
            set
            {
                this.criteriaElementField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/services", ConfigurationName="SalesSalesOrderService.SalesOrderService")]
    public interface SalesOrderService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/findKeys" +
            "", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/findKeys" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesSalesOrderService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/findKeys" +
            "AifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceFindKeysResponse> findKeysAsync(SalesSalesOrderService.SalesOrderServiceFindKeysRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/delete", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/deleteRe" +
            "sponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesSalesOrderService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/deleteAi" +
            "fFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesSalesOrderService.deleteResponse> deleteAsync(SalesSalesOrderService.SalesOrderServiceDeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/find", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/findResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesSalesOrderService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/findAifF" +
            "aultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceFindResponse> findAsync(SalesSalesOrderService.SalesOrderServiceFindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/create", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/createRe" +
            "sponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesSalesOrderService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/createAi" +
            "fFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceCreateResponse> createAsync(SalesSalesOrderService.SalesOrderServiceCreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/read", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/readResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesSalesOrderService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/readAifF" +
            "aultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceReadResponse> readAsync(SalesSalesOrderService.SalesOrderServiceReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/update", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/updateRe" +
            "sponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesSalesOrderService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/SalesOrderService/updateAi" +
            "fFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesSalesOrderService.updateResponse> updateAsync(SalesSalesOrderService.SalesOrderServiceUpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceFindKeysRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceFindKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public SalesSalesOrderService.QueryCriteria QueryCriteria;
        
        public SalesOrderServiceFindKeysRequest()
        {
        }
        
        public SalesOrderServiceFindKeysRequest(SalesSalesOrderService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceFindKeysResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceFindKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesSalesOrderService.EntityKey[] EntityKeyList;
        
        public SalesOrderServiceFindKeysResponse()
        {
        }
        
        public SalesOrderServiceFindKeysResponse(SalesSalesOrderService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceDeleteRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceDeleteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesSalesOrderService.EntityKey[] EntityKeyList;
        
        public SalesOrderServiceDeleteRequest()
        {
        }
        
        public SalesOrderServiceDeleteRequest(SalesSalesOrderService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteResponse
    {
        
        public deleteResponse()
        {
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdSalesOrder
    {
        
        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;
        
        private bool docPurposeFieldSpecified;
        
        private string senderIdField;
        
        private AxdEntity_SalesTable[] salesTableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdEnum_XMLDocPurpose> DocPurpose
        {
            get
            {
                return this.docPurposeField;
            }
            set
            {
                this.docPurposeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocPurposeSpecified
        {
            get
            {
                return this.docPurposeFieldSpecified;
            }
            set
            {
                this.docPurposeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string SenderId
        {
            get
            {
                return this.senderIdField;
            }
            set
            {
                this.senderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesTable", Order=2)]
        public AxdEntity_SalesTable[] SalesTable
        {
            get
            {
                return this.salesTableField;
            }
            set
            {
                this.salesTableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_XMLDocPurpose
    {
        
        /// <remarks/>
        Original,
        
        /// <remarks/>
        Duplicate,
        
        /// <remarks/>
        Proforma,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_SalesTable
    {
        
        private string _DocumentHashField;
        
        private string bankAccount_LVField;
        
        private string bankCentralBankPurposeCodeField;
        
        private string bankCentralBankPurposeTextField;
        
        private string carrierCode_WField;
        
        private System.Nullable<AxdEnum_CarrierType_W> carrierType_WField;
        
        private bool carrierType_WFieldSpecified;
        
        private System.Nullable<AxdExtType_RFIDCaseTagging> caseTaggingField;
        
        private bool caseTaggingFieldSpecified;
        
        private string cashDiscField;
        
        private System.Nullable<System.DateTime> cashDiscBaseDateField;
        
        private bool cashDiscBaseDateFieldSpecified;
        
        private System.Nullable<decimal> cashDiscPercentField;
        
        private bool cashDiscPercentFieldSpecified;
        
        private string commissionGroupField;
        
        private string consigneeAccount_RUField;
        
        private string consignorAccount_RUField;
        
        private string contactPersonIdField;
        
        private System.Nullable<int> covStatusField;
        
        private bool covStatusFieldSpecified;
        
        private System.Nullable<decimal> creditCardApprovalAmountField;
        
        private bool creditCardApprovalAmountFieldSpecified;
        
        private string creditCardAuthorizationField;
        
        private System.Nullable<AxdEnum_NoYes> creditCardAuthorizationErrorField;
        
        private bool creditCardAuthorizationErrorFieldSpecified;
        
        private System.Nullable<long> creditCardCustRefIdField;
        
        private bool creditCardCustRefIdFieldSpecified;
        
        private string creditCardProcessorTransactionIdField;
        
        private string curBankAccount_LVField;
        
        private string currencyCodeField;
        
        private string custAccountField;
        
        private string custGroupField;
        
        private string custInvoiceIdField;
        
        private string customerRefField;
        
        private System.Nullable<System.DateTime> deadlineField;
        
        private bool deadlineFieldSpecified;
        
        private string deliveryAddressField;
        
        private string deliveryBuilding_RUField;
        
        private string deliveryCityField;
        
        private string deliveryCountryRegionIdField;
        
        private string deliveryCountyField;
        
        private System.DateTime deliveryDateField;
        
        private System.Nullable<AxdEnum_SalesDeliveryDateControlType> deliveryDateControlTypeField;
        
        private bool deliveryDateControlTypeFieldSpecified;
        
        private string deliveryEstate_RUField;
        
        private string deliveryFlat_RUField;
        
        private string deliveryNameField;
        
        private string deliverySettlementId_RUField;
        
        private string deliveryStateField;
        
        private string deliveryStreetField;
        
        private string deliveryStreetId_RUField;
        
        private string deliveryTownId_RUField;
        
        private string deliveryZipCodeField;
        
        private string[] dimensionField;
        
        private System.Nullable<decimal> discPercentField;
        
        private bool discPercentFieldSpecified;
        
        private string dlvModeField;
        
        private string dlvReasonField;
        
        private string dlvTermField;
        
        private System.Nullable<AxdEnum_DocumentStatus> documentStatusField;
        
        private bool documentStatusFieldSpecified;
        
        private string driver_WField;
        
        private string driverName_WField;
        
        private string eInvoiceAccountCodeField;
        
        private System.Nullable<AxdExtType_EInvoiceLineSpecific> eInvoiceLineSpecField;
        
        private bool eInvoiceLineSpecFieldSpecified;
        
        private string emailField;
        
        private string endDiscField;
        
        private string enterpriseNumberField;
        
        private System.Nullable<decimal> estimateField;
        
        private bool estimateFieldSpecified;
        
        private string exportReasonField;
        
        private System.Nullable<System.DateTime> fixedDueDateField;
        
        private bool fixedDueDateFieldSpecified;
        
        private System.Nullable<decimal> fixedExchRateField;
        
        private bool fixedExchRateFieldSpecified;
        
        private System.Nullable<AxdExtType_CustFreightSlipType> freightSlipTypeField;
        
        private bool freightSlipTypeFieldSpecified;
        
        private string freightZoneField;
        
        private System.Nullable<AxdExtType_PaymentStubInvoiceId> giroTypeField;
        
        private bool giroTypeFieldSpecified;
        
        private System.Nullable<AxdExtType_InclTax> inclTaxField;
        
        private bool inclTaxFieldSpecified;
        
        private System.Nullable<AxdExtType_InterCompanyAllowIndirectCreation> interCompanyAllowIndirectCreationField;
        
        private bool interCompanyAllowIndirectCreationFieldSpecified;
        
        private System.Nullable<AxdExtType_InterCompanyAutoCreateOrders> interCompanyAutoCreateOrdersField;
        
        private bool interCompanyAutoCreateOrdersFieldSpecified;
        
        private string interCompanyCompanyIdField;
        
        private System.Nullable<AxdExtType_InterCompanyDirectDelivery> interCompanyDirectDeliveryField;
        
        private bool interCompanyDirectDeliveryFieldSpecified;
        
        private System.Nullable<AxdExtType_InterCompanyDirectDelivery> interCompanyDirectDeliveryOrigField;
        
        private bool interCompanyDirectDeliveryOrigFieldSpecified;
        
        private System.Nullable<AxdExtType_InterCompanyCustomer> interCompanyOrderField;
        
        private bool interCompanyOrderFieldSpecified;
        
        private string interCompanyOriginalCustAccountField;
        
        private string interCompanyOriginalSalesIdField;
        
        private string interCompanyPurchIdField;
        
        private string inventLocationIdField;
        
        private string inventProfileId_RUField;
        
        private System.Nullable<AxdEnum_InventProfileType_RU> inventProfileType_RUField;
        
        private bool inventProfileType_RUFieldSpecified;
        
        private System.Nullable<AxdExtType_InventProfileUseRelated_RU> inventProfileUseRelated_RUField;
        
        private bool inventProfileUseRelated_RUFieldSpecified;
        
        private string inventSiteIdField;
        
        private string invoiceAccountField;
        
        private System.Nullable<AxdEnum_SalesInvoicePostingType_RU> invoicePostingType_RUField;
        
        private bool invoicePostingType_RUFieldSpecified;
        
        private System.Nullable<AxdExtType_LtDocRegister> invoiceRegister_LTField;
        
        private bool invoiceRegister_LTFieldSpecified;
        
        private System.Nullable<AxdExtType_RFIDItemTagging> itemTaggingField;
        
        private bool itemTaggingFieldSpecified;
        
        private string languageIdField;
        
        private string lineDiscField;
        
        private System.Nullable<AxdExtType_ListcodeId> listcodeField;
        
        private bool listcodeFieldSpecified;
        
        private string markupGroupField;
        
        private string multiLineDiscField;
        
        private string numberSequenceGroupField;
        
        private System.Nullable<AxdExtType_OneTimeCustomer> oneTimeCustomerField;
        
        private bool oneTimeCustomerFieldSpecified;
        
        private System.Nullable<AxdExtType_LtDocRegister> packingSlipRegister_LTField;
        
        private bool packingSlipRegister_LTFieldSpecified;
        
        private System.Nullable<AxdExtType_RFIDPalletTagging> palletTaggingField;
        
        private bool palletTaggingFieldSpecified;
        
        private string paymentField;
        
        private string paymentSchedField;
        
        private string paymModeField;
        
        private string paymSpecField;
        
        private string portField;
        
        private string postingProfileField;
        
        private System.Nullable<System.DateTime> priceAgreementDate_RUField;
        
        private bool priceAgreementDate_RUFieldSpecified;
        
        private string priceGroupIdField;
        
        private string projIdField;
        
        private string purchIdField;
        
        private string purchOrderFormNumField;
        
        private string quotationIdField;
        
        private string rContractAccountField;
        
        private string rContractCodeField;
        
        private System.Nullable<System.DateTime> receiptDateConfirmedField;
        
        private bool receiptDateConfirmedFieldSpecified;
        
        private System.Nullable<System.DateTime> receiptDateRequestedField;
        
        private bool receiptDateRequestedFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<AxdEnum_ItemReservation> reservationField;
        
        private bool reservationFieldSpecified;
        
        private System.Nullable<System.DateTime> returnDeadlineField;
        
        private bool returnDeadlineFieldSpecified;
        
        private string returnItemNumField;
        
        private string returnReasonCodeIdField;
        
        private System.Nullable<AxdExtType_ReturnReplacementCreated> returnReplacementCreatedField;
        
        private bool returnReplacementCreatedFieldSpecified;
        
        private string returnReplacementIdField;
        
        private System.Nullable<AxdEnum_ReturnStatusHeader> returnStatusField;
        
        private bool returnStatusFieldSpecified;
        
        private string salesGroupField;
        
        private string salesIdField;
        
        private string salesNameField;
        
        private string salesOriginIdField;
        
        private string salesPoolIdField;
        
        private string salesResponsibleField;
        
        private System.Nullable<AxdEnum_SalesStatus> salesStatusField;
        
        private bool salesStatusFieldSpecified;
        
        private string salesTakerField;
        
        private System.Nullable<AxdEnum_SalesType> salesTypeField;
        
        private bool salesTypeFieldSpecified;
        
        private string salesUnitIdField;
        
        private System.Nullable<AxdExtType_SalesSettlementType> settleVoucherField;
        
        private bool settleVoucherFieldSpecified;
        
        private string shipCarrierAccountField;
        
        private string shipCarrierAccountCodeField;
        
        private System.Nullable<AxdExtType_ShipCarrierBlindShipment> shipCarrierBlindShipmentField;
        
        private bool shipCarrierBlindShipmentFieldSpecified;
        
        private string shipCarrierDeliveryContactField;
        
        private System.Nullable<AxdEnum_ShipCarrierDlvType> shipCarrierDlvTypeField;
        
        private bool shipCarrierDlvTypeFieldSpecified;
        
        private System.Nullable<AxdExtType_ShipCarrierExpeditedShipment> shipCarrierExpeditedShipmentField;
        
        private bool shipCarrierExpeditedShipmentFieldSpecified;
        
        private System.Nullable<AxdExtType_ShipCarrierFuelSurcharge> shipCarrierFuelSurchargeField;
        
        private bool shipCarrierFuelSurchargeFieldSpecified;
        
        private string shipCarrierIDField;
        
        private System.Nullable<AxdExtType_ShipCarrierResidentialDest> shipCarrierResidentialField;
        
        private bool shipCarrierResidentialFieldSpecified;
        
        private System.Nullable<System.DateTime> shippingDateConfirmedField;
        
        private bool shippingDateConfirmedFieldSpecified;
        
        private System.Nullable<System.DateTime> shippingDateRequestedField;
        
        private bool shippingDateRequestedFieldSpecified;
        
        private string smmCampaignIdField;
        
        private System.Nullable<decimal> smmSalesAmountTotalField;
        
        private bool smmSalesAmountTotalFieldSpecified;
        
        private string statProcIdField;
        
        private string taxGroupField;
        
        private System.Nullable<decimal> totalBalanceField;
        
        private bool totalBalanceFieldSpecified;
        
        private System.Nullable<decimal> totalCashDiscountField;
        
        private bool totalCashDiscountFieldSpecified;
        
        private System.Nullable<decimal> totalInvoiceField;
        
        private bool totalInvoiceFieldSpecified;
        
        private System.Nullable<decimal> totalMiscChargesField;
        
        private bool totalMiscChargesFieldSpecified;
        
        private System.Nullable<decimal> totalSalesTaxField;
        
        private bool totalSalesTaxFieldSpecified;
        
        private string transactionCodeField;
        
        private string transportField;
        
        private string truckModel_WField;
        
        private string truckPlateNum_WField;
        
        private string truckTrailerNum_LTField;
        
        private string uRLField;
        
        private string vATNumField;
        
        private AxdEntity_SalesLine[] salesLineField;
        
        private AxdEntity_DocuRefHeader[] docuRefHeaderField;
        
        private AxdEntity_MarkupTransHeader[] markupTransHeaderField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_SalesTable()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string _DocumentHash
        {
            get
            {
                return this._DocumentHashField;
            }
            set
            {
                this._DocumentHashField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string BankAccount_LV
        {
            get
            {
                return this.bankAccount_LVField;
            }
            set
            {
                this.bankAccount_LVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string BankCentralBankPurposeCode
        {
            get
            {
                return this.bankCentralBankPurposeCodeField;
            }
            set
            {
                this.bankCentralBankPurposeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string BankCentralBankPurposeText
        {
            get
            {
                return this.bankCentralBankPurposeTextField;
            }
            set
            {
                this.bankCentralBankPurposeTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string CarrierCode_W
        {
            get
            {
                return this.carrierCode_WField;
            }
            set
            {
                this.carrierCode_WField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<AxdEnum_CarrierType_W> CarrierType_W
        {
            get
            {
                return this.carrierType_WField;
            }
            set
            {
                this.carrierType_WField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CarrierType_WSpecified
        {
            get
            {
                return this.carrierType_WFieldSpecified;
            }
            set
            {
                this.carrierType_WFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<AxdExtType_RFIDCaseTagging> CaseTagging
        {
            get
            {
                return this.caseTaggingField;
            }
            set
            {
                this.caseTaggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CaseTaggingSpecified
        {
            get
            {
                return this.caseTaggingFieldSpecified;
            }
            set
            {
                this.caseTaggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string CashDisc
        {
            get
            {
                return this.cashDiscField;
            }
            set
            {
                this.cashDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=8)]
        public System.Nullable<System.DateTime> CashDiscBaseDate
        {
            get
            {
                return this.cashDiscBaseDateField;
            }
            set
            {
                this.cashDiscBaseDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CashDiscBaseDateSpecified
        {
            get
            {
                return this.cashDiscBaseDateFieldSpecified;
            }
            set
            {
                this.cashDiscBaseDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<decimal> CashDiscPercent
        {
            get
            {
                return this.cashDiscPercentField;
            }
            set
            {
                this.cashDiscPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CashDiscPercentSpecified
        {
            get
            {
                return this.cashDiscPercentFieldSpecified;
            }
            set
            {
                this.cashDiscPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public string CommissionGroup
        {
            get
            {
                return this.commissionGroupField;
            }
            set
            {
                this.commissionGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string ConsigneeAccount_RU
        {
            get
            {
                return this.consigneeAccount_RUField;
            }
            set
            {
                this.consigneeAccount_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string ConsignorAccount_RU
        {
            get
            {
                return this.consignorAccount_RUField;
            }
            set
            {
                this.consignorAccount_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string ContactPersonId
        {
            get
            {
                return this.contactPersonIdField;
            }
            set
            {
                this.contactPersonIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<int> CovStatus
        {
            get
            {
                return this.covStatusField;
            }
            set
            {
                this.covStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CovStatusSpecified
        {
            get
            {
                return this.covStatusFieldSpecified;
            }
            set
            {
                this.covStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<decimal> CreditCardApprovalAmount
        {
            get
            {
                return this.creditCardApprovalAmountField;
            }
            set
            {
                this.creditCardApprovalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditCardApprovalAmountSpecified
        {
            get
            {
                return this.creditCardApprovalAmountFieldSpecified;
            }
            set
            {
                this.creditCardApprovalAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public string CreditCardAuthorization
        {
            get
            {
                return this.creditCardAuthorizationField;
            }
            set
            {
                this.creditCardAuthorizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public System.Nullable<AxdEnum_NoYes> CreditCardAuthorizationError
        {
            get
            {
                return this.creditCardAuthorizationErrorField;
            }
            set
            {
                this.creditCardAuthorizationErrorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditCardAuthorizationErrorSpecified
        {
            get
            {
                return this.creditCardAuthorizationErrorFieldSpecified;
            }
            set
            {
                this.creditCardAuthorizationErrorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public System.Nullable<long> CreditCardCustRefId
        {
            get
            {
                return this.creditCardCustRefIdField;
            }
            set
            {
                this.creditCardCustRefIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditCardCustRefIdSpecified
        {
            get
            {
                return this.creditCardCustRefIdFieldSpecified;
            }
            set
            {
                this.creditCardCustRefIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public string CreditCardProcessorTransactionId
        {
            get
            {
                return this.creditCardProcessorTransactionIdField;
            }
            set
            {
                this.creditCardProcessorTransactionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public string CurBankAccount_LV
        {
            get
            {
                return this.curBankAccount_LVField;
            }
            set
            {
                this.curBankAccount_LVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public string CustAccount
        {
            get
            {
                return this.custAccountField;
            }
            set
            {
                this.custAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public string CustGroup
        {
            get
            {
                return this.custGroupField;
            }
            set
            {
                this.custGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
        public string CustInvoiceId
        {
            get
            {
                return this.custInvoiceIdField;
            }
            set
            {
                this.custInvoiceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public string CustomerRef
        {
            get
            {
                return this.customerRefField;
            }
            set
            {
                this.customerRefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=26)]
        public System.Nullable<System.DateTime> Deadline
        {
            get
            {
                return this.deadlineField;
            }
            set
            {
                this.deadlineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeadlineSpecified
        {
            get
            {
                return this.deadlineFieldSpecified;
            }
            set
            {
                this.deadlineFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public string DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
        public string DeliveryBuilding_RU
        {
            get
            {
                return this.deliveryBuilding_RUField;
            }
            set
            {
                this.deliveryBuilding_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public string DeliveryCity
        {
            get
            {
                return this.deliveryCityField;
            }
            set
            {
                this.deliveryCityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public string DeliveryCountryRegionId
        {
            get
            {
                return this.deliveryCountryRegionIdField;
            }
            set
            {
                this.deliveryCountryRegionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public string DeliveryCounty
        {
            get
            {
                return this.deliveryCountyField;
            }
            set
            {
                this.deliveryCountyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=32)]
        public System.DateTime DeliveryDate
        {
            get
            {
                return this.deliveryDateField;
            }
            set
            {
                this.deliveryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public System.Nullable<AxdEnum_SalesDeliveryDateControlType> DeliveryDateControlType
        {
            get
            {
                return this.deliveryDateControlTypeField;
            }
            set
            {
                this.deliveryDateControlTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryDateControlTypeSpecified
        {
            get
            {
                return this.deliveryDateControlTypeFieldSpecified;
            }
            set
            {
                this.deliveryDateControlTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public string DeliveryEstate_RU
        {
            get
            {
                return this.deliveryEstate_RUField;
            }
            set
            {
                this.deliveryEstate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
        public string DeliveryFlat_RU
        {
            get
            {
                return this.deliveryFlat_RUField;
            }
            set
            {
                this.deliveryFlat_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=36)]
        public string DeliveryName
        {
            get
            {
                return this.deliveryNameField;
            }
            set
            {
                this.deliveryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
        public string DeliverySettlementId_RU
        {
            get
            {
                return this.deliverySettlementId_RUField;
            }
            set
            {
                this.deliverySettlementId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=38)]
        public string DeliveryState
        {
            get
            {
                return this.deliveryStateField;
            }
            set
            {
                this.deliveryStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=39)]
        public string DeliveryStreet
        {
            get
            {
                return this.deliveryStreetField;
            }
            set
            {
                this.deliveryStreetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=40)]
        public string DeliveryStreetId_RU
        {
            get
            {
                return this.deliveryStreetId_RUField;
            }
            set
            {
                this.deliveryStreetId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=41)]
        public string DeliveryTownId_RU
        {
            get
            {
                return this.deliveryTownId_RUField;
            }
            set
            {
                this.deliveryTownId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=42)]
        public string DeliveryZipCode
        {
            get
            {
                return this.deliveryZipCodeField;
            }
            set
            {
                this.deliveryZipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=43)]
        [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable=false)]
        public string[] Dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=44)]
        public System.Nullable<decimal> DiscPercent
        {
            get
            {
                return this.discPercentField;
            }
            set
            {
                this.discPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscPercentSpecified
        {
            get
            {
                return this.discPercentFieldSpecified;
            }
            set
            {
                this.discPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=45)]
        public string DlvMode
        {
            get
            {
                return this.dlvModeField;
            }
            set
            {
                this.dlvModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=46)]
        public string DlvReason
        {
            get
            {
                return this.dlvReasonField;
            }
            set
            {
                this.dlvReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=47)]
        public string DlvTerm
        {
            get
            {
                return this.dlvTermField;
            }
            set
            {
                this.dlvTermField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=48)]
        public System.Nullable<AxdEnum_DocumentStatus> DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentStatusSpecified
        {
            get
            {
                return this.documentStatusFieldSpecified;
            }
            set
            {
                this.documentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=49)]
        public string Driver_W
        {
            get
            {
                return this.driver_WField;
            }
            set
            {
                this.driver_WField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=50)]
        public string DriverName_W
        {
            get
            {
                return this.driverName_WField;
            }
            set
            {
                this.driverName_WField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=51)]
        public string EInvoiceAccountCode
        {
            get
            {
                return this.eInvoiceAccountCodeField;
            }
            set
            {
                this.eInvoiceAccountCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=52)]
        public System.Nullable<AxdExtType_EInvoiceLineSpecific> EInvoiceLineSpec
        {
            get
            {
                return this.eInvoiceLineSpecField;
            }
            set
            {
                this.eInvoiceLineSpecField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EInvoiceLineSpecSpecified
        {
            get
            {
                return this.eInvoiceLineSpecFieldSpecified;
            }
            set
            {
                this.eInvoiceLineSpecFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=53)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=54)]
        public string EndDisc
        {
            get
            {
                return this.endDiscField;
            }
            set
            {
                this.endDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=55)]
        public string EnterpriseNumber
        {
            get
            {
                return this.enterpriseNumberField;
            }
            set
            {
                this.enterpriseNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=56)]
        public System.Nullable<decimal> Estimate
        {
            get
            {
                return this.estimateField;
            }
            set
            {
                this.estimateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstimateSpecified
        {
            get
            {
                return this.estimateFieldSpecified;
            }
            set
            {
                this.estimateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=57)]
        public string ExportReason
        {
            get
            {
                return this.exportReasonField;
            }
            set
            {
                this.exportReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=58)]
        public System.Nullable<System.DateTime> FixedDueDate
        {
            get
            {
                return this.fixedDueDateField;
            }
            set
            {
                this.fixedDueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedDueDateSpecified
        {
            get
            {
                return this.fixedDueDateFieldSpecified;
            }
            set
            {
                this.fixedDueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=59)]
        public System.Nullable<decimal> FixedExchRate
        {
            get
            {
                return this.fixedExchRateField;
            }
            set
            {
                this.fixedExchRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedExchRateSpecified
        {
            get
            {
                return this.fixedExchRateFieldSpecified;
            }
            set
            {
                this.fixedExchRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=60)]
        public System.Nullable<AxdExtType_CustFreightSlipType> FreightSlipType
        {
            get
            {
                return this.freightSlipTypeField;
            }
            set
            {
                this.freightSlipTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightSlipTypeSpecified
        {
            get
            {
                return this.freightSlipTypeFieldSpecified;
            }
            set
            {
                this.freightSlipTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=61)]
        public string FreightZone
        {
            get
            {
                return this.freightZoneField;
            }
            set
            {
                this.freightZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=62)]
        public System.Nullable<AxdExtType_PaymentStubInvoiceId> GiroType
        {
            get
            {
                return this.giroTypeField;
            }
            set
            {
                this.giroTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GiroTypeSpecified
        {
            get
            {
                return this.giroTypeFieldSpecified;
            }
            set
            {
                this.giroTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=63)]
        public System.Nullable<AxdExtType_InclTax> InclTax
        {
            get
            {
                return this.inclTaxField;
            }
            set
            {
                this.inclTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InclTaxSpecified
        {
            get
            {
                return this.inclTaxFieldSpecified;
            }
            set
            {
                this.inclTaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=64)]
        public System.Nullable<AxdExtType_InterCompanyAllowIndirectCreation> InterCompanyAllowIndirectCreation
        {
            get
            {
                return this.interCompanyAllowIndirectCreationField;
            }
            set
            {
                this.interCompanyAllowIndirectCreationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyAllowIndirectCreationSpecified
        {
            get
            {
                return this.interCompanyAllowIndirectCreationFieldSpecified;
            }
            set
            {
                this.interCompanyAllowIndirectCreationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=65)]
        public System.Nullable<AxdExtType_InterCompanyAutoCreateOrders> InterCompanyAutoCreateOrders
        {
            get
            {
                return this.interCompanyAutoCreateOrdersField;
            }
            set
            {
                this.interCompanyAutoCreateOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyAutoCreateOrdersSpecified
        {
            get
            {
                return this.interCompanyAutoCreateOrdersFieldSpecified;
            }
            set
            {
                this.interCompanyAutoCreateOrdersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=66)]
        public string InterCompanyCompanyId
        {
            get
            {
                return this.interCompanyCompanyIdField;
            }
            set
            {
                this.interCompanyCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=67)]
        public System.Nullable<AxdExtType_InterCompanyDirectDelivery> InterCompanyDirectDelivery
        {
            get
            {
                return this.interCompanyDirectDeliveryField;
            }
            set
            {
                this.interCompanyDirectDeliveryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyDirectDeliverySpecified
        {
            get
            {
                return this.interCompanyDirectDeliveryFieldSpecified;
            }
            set
            {
                this.interCompanyDirectDeliveryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=68)]
        public System.Nullable<AxdExtType_InterCompanyDirectDelivery> InterCompanyDirectDeliveryOrig
        {
            get
            {
                return this.interCompanyDirectDeliveryOrigField;
            }
            set
            {
                this.interCompanyDirectDeliveryOrigField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyDirectDeliveryOrigSpecified
        {
            get
            {
                return this.interCompanyDirectDeliveryOrigFieldSpecified;
            }
            set
            {
                this.interCompanyDirectDeliveryOrigFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=69)]
        public System.Nullable<AxdExtType_InterCompanyCustomer> InterCompanyOrder
        {
            get
            {
                return this.interCompanyOrderField;
            }
            set
            {
                this.interCompanyOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyOrderSpecified
        {
            get
            {
                return this.interCompanyOrderFieldSpecified;
            }
            set
            {
                this.interCompanyOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=70)]
        public string InterCompanyOriginalCustAccount
        {
            get
            {
                return this.interCompanyOriginalCustAccountField;
            }
            set
            {
                this.interCompanyOriginalCustAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=71)]
        public string InterCompanyOriginalSalesId
        {
            get
            {
                return this.interCompanyOriginalSalesIdField;
            }
            set
            {
                this.interCompanyOriginalSalesIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=72)]
        public string InterCompanyPurchId
        {
            get
            {
                return this.interCompanyPurchIdField;
            }
            set
            {
                this.interCompanyPurchIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=73)]
        public string InventLocationId
        {
            get
            {
                return this.inventLocationIdField;
            }
            set
            {
                this.inventLocationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=74)]
        public string InventProfileId_RU
        {
            get
            {
                return this.inventProfileId_RUField;
            }
            set
            {
                this.inventProfileId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=75)]
        public System.Nullable<AxdEnum_InventProfileType_RU> InventProfileType_RU
        {
            get
            {
                return this.inventProfileType_RUField;
            }
            set
            {
                this.inventProfileType_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InventProfileType_RUSpecified
        {
            get
            {
                return this.inventProfileType_RUFieldSpecified;
            }
            set
            {
                this.inventProfileType_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=76)]
        public System.Nullable<AxdExtType_InventProfileUseRelated_RU> InventProfileUseRelated_RU
        {
            get
            {
                return this.inventProfileUseRelated_RUField;
            }
            set
            {
                this.inventProfileUseRelated_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InventProfileUseRelated_RUSpecified
        {
            get
            {
                return this.inventProfileUseRelated_RUFieldSpecified;
            }
            set
            {
                this.inventProfileUseRelated_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=77)]
        public string InventSiteId
        {
            get
            {
                return this.inventSiteIdField;
            }
            set
            {
                this.inventSiteIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=78)]
        public string InvoiceAccount
        {
            get
            {
                return this.invoiceAccountField;
            }
            set
            {
                this.invoiceAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=79)]
        public System.Nullable<AxdEnum_SalesInvoicePostingType_RU> InvoicePostingType_RU
        {
            get
            {
                return this.invoicePostingType_RUField;
            }
            set
            {
                this.invoicePostingType_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoicePostingType_RUSpecified
        {
            get
            {
                return this.invoicePostingType_RUFieldSpecified;
            }
            set
            {
                this.invoicePostingType_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=80)]
        public System.Nullable<AxdExtType_LtDocRegister> InvoiceRegister_LT
        {
            get
            {
                return this.invoiceRegister_LTField;
            }
            set
            {
                this.invoiceRegister_LTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceRegister_LTSpecified
        {
            get
            {
                return this.invoiceRegister_LTFieldSpecified;
            }
            set
            {
                this.invoiceRegister_LTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=81)]
        public System.Nullable<AxdExtType_RFIDItemTagging> ItemTagging
        {
            get
            {
                return this.itemTaggingField;
            }
            set
            {
                this.itemTaggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemTaggingSpecified
        {
            get
            {
                return this.itemTaggingFieldSpecified;
            }
            set
            {
                this.itemTaggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=82)]
        public string LanguageId
        {
            get
            {
                return this.languageIdField;
            }
            set
            {
                this.languageIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=83)]
        public string LineDisc
        {
            get
            {
                return this.lineDiscField;
            }
            set
            {
                this.lineDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=84)]
        public System.Nullable<AxdExtType_ListcodeId> Listcode
        {
            get
            {
                return this.listcodeField;
            }
            set
            {
                this.listcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListcodeSpecified
        {
            get
            {
                return this.listcodeFieldSpecified;
            }
            set
            {
                this.listcodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=85)]
        public string MarkupGroup
        {
            get
            {
                return this.markupGroupField;
            }
            set
            {
                this.markupGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=86)]
        public string MultiLineDisc
        {
            get
            {
                return this.multiLineDiscField;
            }
            set
            {
                this.multiLineDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=87)]
        public string NumberSequenceGroup
        {
            get
            {
                return this.numberSequenceGroupField;
            }
            set
            {
                this.numberSequenceGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=88)]
        public System.Nullable<AxdExtType_OneTimeCustomer> OneTimeCustomer
        {
            get
            {
                return this.oneTimeCustomerField;
            }
            set
            {
                this.oneTimeCustomerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OneTimeCustomerSpecified
        {
            get
            {
                return this.oneTimeCustomerFieldSpecified;
            }
            set
            {
                this.oneTimeCustomerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=89)]
        public System.Nullable<AxdExtType_LtDocRegister> PackingSlipRegister_LT
        {
            get
            {
                return this.packingSlipRegister_LTField;
            }
            set
            {
                this.packingSlipRegister_LTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingSlipRegister_LTSpecified
        {
            get
            {
                return this.packingSlipRegister_LTFieldSpecified;
            }
            set
            {
                this.packingSlipRegister_LTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=90)]
        public System.Nullable<AxdExtType_RFIDPalletTagging> PalletTagging
        {
            get
            {
                return this.palletTaggingField;
            }
            set
            {
                this.palletTaggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PalletTaggingSpecified
        {
            get
            {
                return this.palletTaggingFieldSpecified;
            }
            set
            {
                this.palletTaggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=91)]
        public string Payment
        {
            get
            {
                return this.paymentField;
            }
            set
            {
                this.paymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=92)]
        public string PaymentSched
        {
            get
            {
                return this.paymentSchedField;
            }
            set
            {
                this.paymentSchedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=93)]
        public string PaymMode
        {
            get
            {
                return this.paymModeField;
            }
            set
            {
                this.paymModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=94)]
        public string PaymSpec
        {
            get
            {
                return this.paymSpecField;
            }
            set
            {
                this.paymSpecField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=95)]
        public string Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=96)]
        public string PostingProfile
        {
            get
            {
                return this.postingProfileField;
            }
            set
            {
                this.postingProfileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=97)]
        public System.Nullable<System.DateTime> PriceAgreementDate_RU
        {
            get
            {
                return this.priceAgreementDate_RUField;
            }
            set
            {
                this.priceAgreementDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceAgreementDate_RUSpecified
        {
            get
            {
                return this.priceAgreementDate_RUFieldSpecified;
            }
            set
            {
                this.priceAgreementDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=98)]
        public string PriceGroupId
        {
            get
            {
                return this.priceGroupIdField;
            }
            set
            {
                this.priceGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=99)]
        public string ProjId
        {
            get
            {
                return this.projIdField;
            }
            set
            {
                this.projIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=100)]
        public string PurchId
        {
            get
            {
                return this.purchIdField;
            }
            set
            {
                this.purchIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=101)]
        public string PurchOrderFormNum
        {
            get
            {
                return this.purchOrderFormNumField;
            }
            set
            {
                this.purchOrderFormNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=102)]
        public string QuotationId
        {
            get
            {
                return this.quotationIdField;
            }
            set
            {
                this.quotationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=103)]
        public string RContractAccount
        {
            get
            {
                return this.rContractAccountField;
            }
            set
            {
                this.rContractAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=104)]
        public string RContractCode
        {
            get
            {
                return this.rContractCodeField;
            }
            set
            {
                this.rContractCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=105)]
        public System.Nullable<System.DateTime> ReceiptDateConfirmed
        {
            get
            {
                return this.receiptDateConfirmedField;
            }
            set
            {
                this.receiptDateConfirmedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptDateConfirmedSpecified
        {
            get
            {
                return this.receiptDateConfirmedFieldSpecified;
            }
            set
            {
                this.receiptDateConfirmedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=106)]
        public System.Nullable<System.DateTime> ReceiptDateRequested
        {
            get
            {
                return this.receiptDateRequestedField;
            }
            set
            {
                this.receiptDateRequestedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptDateRequestedSpecified
        {
            get
            {
                return this.receiptDateRequestedFieldSpecified;
            }
            set
            {
                this.receiptDateRequestedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=107)]
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=108)]
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=109)]
        public System.Nullable<AxdEnum_ItemReservation> Reservation
        {
            get
            {
                return this.reservationField;
            }
            set
            {
                this.reservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReservationSpecified
        {
            get
            {
                return this.reservationFieldSpecified;
            }
            set
            {
                this.reservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=110)]
        public System.Nullable<System.DateTime> ReturnDeadline
        {
            get
            {
                return this.returnDeadlineField;
            }
            set
            {
                this.returnDeadlineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnDeadlineSpecified
        {
            get
            {
                return this.returnDeadlineFieldSpecified;
            }
            set
            {
                this.returnDeadlineFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=111)]
        public string ReturnItemNum
        {
            get
            {
                return this.returnItemNumField;
            }
            set
            {
                this.returnItemNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=112)]
        public string ReturnReasonCodeId
        {
            get
            {
                return this.returnReasonCodeIdField;
            }
            set
            {
                this.returnReasonCodeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=113)]
        public System.Nullable<AxdExtType_ReturnReplacementCreated> ReturnReplacementCreated
        {
            get
            {
                return this.returnReplacementCreatedField;
            }
            set
            {
                this.returnReplacementCreatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnReplacementCreatedSpecified
        {
            get
            {
                return this.returnReplacementCreatedFieldSpecified;
            }
            set
            {
                this.returnReplacementCreatedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=114)]
        public string ReturnReplacementId
        {
            get
            {
                return this.returnReplacementIdField;
            }
            set
            {
                this.returnReplacementIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=115)]
        public System.Nullable<AxdEnum_ReturnStatusHeader> ReturnStatus
        {
            get
            {
                return this.returnStatusField;
            }
            set
            {
                this.returnStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnStatusSpecified
        {
            get
            {
                return this.returnStatusFieldSpecified;
            }
            set
            {
                this.returnStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=116)]
        public string SalesGroup
        {
            get
            {
                return this.salesGroupField;
            }
            set
            {
                this.salesGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=117)]
        public string SalesId
        {
            get
            {
                return this.salesIdField;
            }
            set
            {
                this.salesIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=118)]
        public string SalesName
        {
            get
            {
                return this.salesNameField;
            }
            set
            {
                this.salesNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=119)]
        public string SalesOriginId
        {
            get
            {
                return this.salesOriginIdField;
            }
            set
            {
                this.salesOriginIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=120)]
        public string SalesPoolId
        {
            get
            {
                return this.salesPoolIdField;
            }
            set
            {
                this.salesPoolIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=121)]
        public string SalesResponsible
        {
            get
            {
                return this.salesResponsibleField;
            }
            set
            {
                this.salesResponsibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=122)]
        public System.Nullable<AxdEnum_SalesStatus> SalesStatus
        {
            get
            {
                return this.salesStatusField;
            }
            set
            {
                this.salesStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesStatusSpecified
        {
            get
            {
                return this.salesStatusFieldSpecified;
            }
            set
            {
                this.salesStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=123)]
        public string SalesTaker
        {
            get
            {
                return this.salesTakerField;
            }
            set
            {
                this.salesTakerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=124)]
        public System.Nullable<AxdEnum_SalesType> SalesType
        {
            get
            {
                return this.salesTypeField;
            }
            set
            {
                this.salesTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesTypeSpecified
        {
            get
            {
                return this.salesTypeFieldSpecified;
            }
            set
            {
                this.salesTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=125)]
        public string SalesUnitId
        {
            get
            {
                return this.salesUnitIdField;
            }
            set
            {
                this.salesUnitIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=126)]
        public System.Nullable<AxdExtType_SalesSettlementType> SettleVoucher
        {
            get
            {
                return this.settleVoucherField;
            }
            set
            {
                this.settleVoucherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SettleVoucherSpecified
        {
            get
            {
                return this.settleVoucherFieldSpecified;
            }
            set
            {
                this.settleVoucherFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=127)]
        public string ShipCarrierAccount
        {
            get
            {
                return this.shipCarrierAccountField;
            }
            set
            {
                this.shipCarrierAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=128)]
        public string ShipCarrierAccountCode
        {
            get
            {
                return this.shipCarrierAccountCodeField;
            }
            set
            {
                this.shipCarrierAccountCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=129)]
        public System.Nullable<AxdExtType_ShipCarrierBlindShipment> ShipCarrierBlindShipment
        {
            get
            {
                return this.shipCarrierBlindShipmentField;
            }
            set
            {
                this.shipCarrierBlindShipmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipCarrierBlindShipmentSpecified
        {
            get
            {
                return this.shipCarrierBlindShipmentFieldSpecified;
            }
            set
            {
                this.shipCarrierBlindShipmentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=130)]
        public string ShipCarrierDeliveryContact
        {
            get
            {
                return this.shipCarrierDeliveryContactField;
            }
            set
            {
                this.shipCarrierDeliveryContactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=131)]
        public System.Nullable<AxdEnum_ShipCarrierDlvType> ShipCarrierDlvType
        {
            get
            {
                return this.shipCarrierDlvTypeField;
            }
            set
            {
                this.shipCarrierDlvTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipCarrierDlvTypeSpecified
        {
            get
            {
                return this.shipCarrierDlvTypeFieldSpecified;
            }
            set
            {
                this.shipCarrierDlvTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=132)]
        public System.Nullable<AxdExtType_ShipCarrierExpeditedShipment> ShipCarrierExpeditedShipment
        {
            get
            {
                return this.shipCarrierExpeditedShipmentField;
            }
            set
            {
                this.shipCarrierExpeditedShipmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipCarrierExpeditedShipmentSpecified
        {
            get
            {
                return this.shipCarrierExpeditedShipmentFieldSpecified;
            }
            set
            {
                this.shipCarrierExpeditedShipmentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=133)]
        public System.Nullable<AxdExtType_ShipCarrierFuelSurcharge> ShipCarrierFuelSurcharge
        {
            get
            {
                return this.shipCarrierFuelSurchargeField;
            }
            set
            {
                this.shipCarrierFuelSurchargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipCarrierFuelSurchargeSpecified
        {
            get
            {
                return this.shipCarrierFuelSurchargeFieldSpecified;
            }
            set
            {
                this.shipCarrierFuelSurchargeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=134)]
        public string ShipCarrierID
        {
            get
            {
                return this.shipCarrierIDField;
            }
            set
            {
                this.shipCarrierIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=135)]
        public System.Nullable<AxdExtType_ShipCarrierResidentialDest> ShipCarrierResidential
        {
            get
            {
                return this.shipCarrierResidentialField;
            }
            set
            {
                this.shipCarrierResidentialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipCarrierResidentialSpecified
        {
            get
            {
                return this.shipCarrierResidentialFieldSpecified;
            }
            set
            {
                this.shipCarrierResidentialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=136)]
        public System.Nullable<System.DateTime> ShippingDateConfirmed
        {
            get
            {
                return this.shippingDateConfirmedField;
            }
            set
            {
                this.shippingDateConfirmedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateConfirmedSpecified
        {
            get
            {
                return this.shippingDateConfirmedFieldSpecified;
            }
            set
            {
                this.shippingDateConfirmedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=137)]
        public System.Nullable<System.DateTime> ShippingDateRequested
        {
            get
            {
                return this.shippingDateRequestedField;
            }
            set
            {
                this.shippingDateRequestedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateRequestedSpecified
        {
            get
            {
                return this.shippingDateRequestedFieldSpecified;
            }
            set
            {
                this.shippingDateRequestedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=138)]
        public string smmCampaignId
        {
            get
            {
                return this.smmCampaignIdField;
            }
            set
            {
                this.smmCampaignIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=139)]
        public System.Nullable<decimal> smmSalesAmountTotal
        {
            get
            {
                return this.smmSalesAmountTotalField;
            }
            set
            {
                this.smmSalesAmountTotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool smmSalesAmountTotalSpecified
        {
            get
            {
                return this.smmSalesAmountTotalFieldSpecified;
            }
            set
            {
                this.smmSalesAmountTotalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=140)]
        public string StatProcId
        {
            get
            {
                return this.statProcIdField;
            }
            set
            {
                this.statProcIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=141)]
        public string TaxGroup
        {
            get
            {
                return this.taxGroupField;
            }
            set
            {
                this.taxGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=142)]
        public System.Nullable<decimal> totalBalance
        {
            get
            {
                return this.totalBalanceField;
            }
            set
            {
                this.totalBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalBalanceSpecified
        {
            get
            {
                return this.totalBalanceFieldSpecified;
            }
            set
            {
                this.totalBalanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=143)]
        public System.Nullable<decimal> TotalCashDiscount
        {
            get
            {
                return this.totalCashDiscountField;
            }
            set
            {
                this.totalCashDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalCashDiscountSpecified
        {
            get
            {
                return this.totalCashDiscountFieldSpecified;
            }
            set
            {
                this.totalCashDiscountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=144)]
        public System.Nullable<decimal> TotalInvoice
        {
            get
            {
                return this.totalInvoiceField;
            }
            set
            {
                this.totalInvoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalInvoiceSpecified
        {
            get
            {
                return this.totalInvoiceFieldSpecified;
            }
            set
            {
                this.totalInvoiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=145)]
        public System.Nullable<decimal> TotalMiscCharges
        {
            get
            {
                return this.totalMiscChargesField;
            }
            set
            {
                this.totalMiscChargesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalMiscChargesSpecified
        {
            get
            {
                return this.totalMiscChargesFieldSpecified;
            }
            set
            {
                this.totalMiscChargesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=146)]
        public System.Nullable<decimal> TotalSalesTax
        {
            get
            {
                return this.totalSalesTaxField;
            }
            set
            {
                this.totalSalesTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalSalesTaxSpecified
        {
            get
            {
                return this.totalSalesTaxFieldSpecified;
            }
            set
            {
                this.totalSalesTaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=147)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=148)]
        public string Transport
        {
            get
            {
                return this.transportField;
            }
            set
            {
                this.transportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=149)]
        public string TruckModel_W
        {
            get
            {
                return this.truckModel_WField;
            }
            set
            {
                this.truckModel_WField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=150)]
        public string TruckPlateNum_W
        {
            get
            {
                return this.truckPlateNum_WField;
            }
            set
            {
                this.truckPlateNum_WField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=151)]
        public string TruckTrailerNum_LT
        {
            get
            {
                return this.truckTrailerNum_LTField;
            }
            set
            {
                this.truckTrailerNum_LTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=152)]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=153)]
        public string VATNum
        {
            get
            {
                return this.vATNumField;
            }
            set
            {
                this.vATNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesLine", Order=154)]
        public AxdEntity_SalesLine[] SalesLine
        {
            get
            {
                return this.salesLineField;
            }
            set
            {
                this.salesLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocuRefHeader", Order=155)]
        public AxdEntity_DocuRefHeader[] DocuRefHeader
        {
            get
            {
                return this.docuRefHeaderField;
            }
            set
            {
                this.docuRefHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarkupTransHeader", Order=156)]
        public AxdEntity_MarkupTransHeader[] MarkupTransHeader
        {
            get
            {
                return this.markupTransHeaderField;
            }
            set
            {
                this.markupTransHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_CarrierType_W
    {
        
        /// <remarks/>
        InvoiceAccount,
        
        /// <remarks/>
        Customer,
        
        /// <remarks/>
        Vendor,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_RFIDCaseTagging
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_NoYes
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_SalesDeliveryDateControlType
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        SalesLeadTime,
        
        /// <remarks/>
        ATP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_DocumentStatus
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Quotation,
        
        /// <remarks/>
        PurchaseOrder,
        
        /// <remarks/>
        Confirmation,
        
        /// <remarks/>
        PickingList,
        
        /// <remarks/>
        PackingSlip,
        
        /// <remarks/>
        ReceiptsList,
        
        /// <remarks/>
        Invoice,
        
        /// <remarks/>
        ApproveJournal,
        
        /// <remarks/>
        ProjectInvoice,
        
        /// <remarks/>
        ProjectPackingSlip,
        
        /// <remarks/>
        CRMQuotation,
        
        /// <remarks/>
        Lost,
        
        /// <remarks/>
        Cancelled,
        
        /// <remarks/>
        FreeTextInvoice,
        
        /// <remarks/>
        RFQ,
        
        /// <remarks/>
        RFQAccept,
        
        /// <remarks/>
        RFQReject,
        
        /// <remarks/>
        PurchReq,
        
        /// <remarks/>
        Invoice4Paym_RU,
        
        /// <remarks/>
        Facture_RU,
        
        /// <remarks/>
        PlSAD,
        
        /// <remarks/>
        TaxReimbursementSlip_HU,
        
        /// <remarks/>
        FreeTextInvoice4Paym_RU,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_EInvoiceLineSpecific
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_CustFreightSlipType
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        UPS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_PaymentStubInvoiceId
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        FIK,
        
        /// <remarks/>
        BBS,
        
        /// <remarks/>
        ESR_blue_PTT,
        
        /// <remarks/>
        ESR_red_bank,
        
        /// <remarks/>
        FIK762,
        
        /// <remarks/>
        ESR_orange,
        
        /// <remarks/>
        BelSMS101,
        
        /// <remarks/>
        BelSMS102,
        
        /// <remarks/>
        Finnish,
        
        /// <remarks/>
        FIK751,
        
        /// <remarks/>
        FIK752,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_InclTax
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_InterCompanyAllowIndirectCreation
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_InterCompanyAutoCreateOrders
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_InterCompanyDirectDelivery
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_InterCompanyCustomer
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_InventProfileType_RU
    {
        
        /// <remarks/>
        NotSpecified,
        
        /// <remarks/>
        General,
        
        /// <remarks/>
        CommissionAgent,
        
        /// <remarks/>
        CommissionPrincipalAgent,
        
        /// <remarks/>
        Bailee,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_InventProfileUseRelated_RU
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_SalesInvoicePostingType_RU
    {
        
        /// <remarks/>
        Standard,
        
        /// <remarks/>
        GoodsInRoute,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_LtDocRegister
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_RFIDItemTagging
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ListcodeId
    {
        
        /// <remarks/>
        IncludeNot,
        
        /// <remarks/>
        EUTrade,
        
        /// <remarks/>
        ProductionOnToll,
        
        /// <remarks/>
        TriangularEUTrade,
        
        /// <remarks/>
        TriangularProductionOnToll,
        
        /// <remarks/>
        PropertyMoving_CZ,
        
        /// <remarks/>
        TriangularIntermediateRole_HU,
        
        /// <remarks/>
        EUService,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_OneTimeCustomer
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_RFIDPalletTagging
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_ItemReservation
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Automatic,
        
        /// <remarks/>
        Explosion,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ReturnReplacementCreated
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_ReturnStatusHeader
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Created,
        
        /// <remarks/>
        Open,
        
        /// <remarks/>
        Canceled,
        
        /// <remarks/>
        Closed,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_SalesStatus
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Backorder,
        
        /// <remarks/>
        Delivered,
        
        /// <remarks/>
        Invoiced,
        
        /// <remarks/>
        Canceled,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_SalesType
    {
        
        /// <remarks/>
        Journal,
        
        /// <remarks/>
        Del_Quotation,
        
        /// <remarks/>
        Subscription,
        
        /// <remarks/>
        Sales,
        
        /// <remarks/>
        ReturnItem,
        
        /// <remarks/>
        Blanket,
        
        /// <remarks/>
        ItemReq,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_SalesSettlementType
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        OpenTransact,
        
        /// <remarks/>
        SelectedTransact,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ShipCarrierBlindShipment
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_ShipCarrierDlvType
    {
        
        /// <remarks/>
        Misc,
        
        /// <remarks/>
        Ground,
        
        /// <remarks/>
        Air,
        
        /// <remarks/>
        PickUp,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ShipCarrierExpeditedShipment
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ShipCarrierFuelSurcharge
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ShipCarrierResidentialDest
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_SalesLine
    {
        
        private string activityNumberField;
        
        private string assetId_RUField;
        
        private string barCodeField;
        
        private string barCodeTypeField;
        
        private string blanketRefTransIdField;
        
        private System.Nullable<AxdExtType_LineStopped> blockedField;
        
        private bool blockedFieldSpecified;
        
        private System.Nullable<AxdExtType_RFIDCaseTagging> caseTaggingField;
        
        private bool caseTaggingFieldSpecified;
        
        private System.Nullable<AxdExtType_LineComplete> completeField;
        
        private bool completeFieldSpecified;
        
        private System.Nullable<System.DateTime> confirmedDlvField;
        
        private bool confirmedDlvFieldSpecified;
        
        private string correctionDesc_PLField;
        
        private System.Nullable<decimal> costPriceField;
        
        private bool costPriceFieldSpecified;
        
        private string currencyCodeField;
        
        private string custAccountField;
        
        private string custGroupField;
        
        private System.Nullable<int> customerLineNumField;
        
        private bool customerLineNumFieldSpecified;
        
        private string customerRefField;
        
        private System.Nullable<System.DateTime> customsDocDate_MXField;
        
        private bool customsDocDate_MXFieldSpecified;
        
        private string customsDocNumber_MXField;
        
        private string customsName_MXField;
        
        private System.Nullable<decimal> deliveredIntotalField;
        
        private bool deliveredIntotalFieldSpecified;
        
        private string deliveryAddressField;
        
        private string deliveryBuilding_RUField;
        
        private string deliveryCityField;
        
        private string deliveryCountryRegionIdField;
        
        private string deliveryCountyField;
        
        private System.Nullable<AxdEnum_SalesDeliveryDateControlType> deliveryDateControlTypeField;
        
        private bool deliveryDateControlTypeFieldSpecified;
        
        private string deliveryEstate_RUField;
        
        private string deliveryFlat_RUField;
        
        private string deliveryNameField;
        
        private string deliverySettlementId_RUField;
        
        private string deliveryStateField;
        
        private string deliveryStreetField;
        
        private string deliveryStreetId_RUField;
        
        private string deliveryTownId_RUField;
        
        private System.Nullable<AxdExtType_TradeLineDlvTypeId> deliveryTypeField;
        
        private bool deliveryTypeFieldSpecified;
        
        private string deliveryZipCodeField;
        
        private string[] dimensionField;
        
        private string dlvModeField;
        
        private string eInvoiceAccountCodeField;
        
        private System.Nullable<decimal> expectedRetQtyField;
        
        private bool expectedRetQtyFieldSpecified;
        
        private string externalItemIdField;
        
        private string interCompanyInventTransIdField;
        
        private System.Nullable<decimal> inventDeliverNowField;
        
        private bool inventDeliverNowFieldSpecified;
        
        private string inventDimIdField;
        
        private string inventRefIdField;
        
        private string inventRefTransIdField;
        
        private System.Nullable<AxdEnum_InventRefType> inventRefTypeField;
        
        private bool inventRefTypeFieldSpecified;
        
        private string inventTransIdField;
        
        private string inventTransIdReturnField;
        
        private string itemBOMIdField;
        
        private string itemIdField;
        
        private string itemPBAIdField;
        
        private System.Nullable<AxdExtType_ReturnItemReplaced> itemReplacedField;
        
        private bool itemReplacedFieldSpecified;
        
        private string itemRouteIdField;
        
        private System.Nullable<AxdExtType_RFIDItemTagging> itemTaggingField;
        
        private bool itemTaggingFieldSpecified;
        
        private string ledgerAccountField;
        
        private System.Nullable<decimal> lineAmountField;
        
        private bool lineAmountFieldSpecified;
        
        private System.Nullable<decimal> lineDiscField;
        
        private bool lineDiscFieldSpecified;
        
        private string lineHeaderField;
        
        private System.Nullable<decimal> lineNumField;
        
        private bool lineNumFieldSpecified;
        
        private System.Nullable<decimal> linePercentField;
        
        private bool linePercentFieldSpecified;
        
        private System.Nullable<decimal> multiLnDiscField;
        
        private bool multiLnDiscFieldSpecified;
        
        private System.Nullable<decimal> multiLnPercentField;
        
        private bool multiLnPercentFieldSpecified;
        
        private string nameField;
        
        private System.Nullable<decimal> overDeliveryPctField;
        
        private bool overDeliveryPctFieldSpecified;
        
        private string packingUnitField;
        
        private System.Nullable<decimal> packingUnitQtyField;
        
        private bool packingUnitQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_RFIDPalletTagging> palletTaggingField;
        
        private bool palletTaggingFieldSpecified;
        
        private string portField;
        
        private string postingProfile_RUField;
        
        private System.Nullable<System.DateTime> priceAgreementDate_RUField;
        
        private bool priceAgreementDate_RUFieldSpecified;
        
        private System.Nullable<decimal> priceUnitField;
        
        private bool priceUnitFieldSpecified;
        
        private string projCategoryIdField;
        
        private string projIdField;
        
        private string projLinePropertyIdField;
        
        private string projTransIdField;
        
        private string propertyNumber_MXField;
        
        private string purchorderFormNumField;
        
        private System.Nullable<decimal> qtyOrderedField;
        
        private bool qtyOrderedFieldSpecified;
        
        private System.Nullable<System.DateTime> receiptDateConfirmedField;
        
        private bool receiptDateConfirmedFieldSpecified;
        
        private System.Nullable<System.DateTime> receiptDateRequestedField;
        
        private bool receiptDateRequestedFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> remainInventFinancialField;
        
        private bool remainInventFinancialFieldSpecified;
        
        private System.Nullable<decimal> remainInventPhysicalField;
        
        private bool remainInventPhysicalFieldSpecified;
        
        private System.Nullable<decimal> remainSalesFinancialField;
        
        private bool remainSalesFinancialFieldSpecified;
        
        private System.Nullable<decimal> remainSalesPhysicalField;
        
        private bool remainSalesPhysicalFieldSpecified;
        
        private System.Nullable<AxdEnum_ItemReservation> reservationField;
        
        private bool reservationFieldSpecified;
        
        private System.Nullable<AxdExtType_ReturnAllowReservation> returnAllowReservationField;
        
        private bool returnAllowReservationFieldSpecified;
        
        private System.Nullable<System.DateTime> returnArrivalDateField;
        
        private bool returnArrivalDateFieldSpecified;
        
        private System.Nullable<System.DateTime> returnClosedDateField;
        
        private bool returnClosedDateFieldSpecified;
        
        private System.Nullable<System.DateTime> returnDeadLineField;
        
        private bool returnDeadLineFieldSpecified;
        
        private string returnDispositionCodeIdField;
        
        private System.Nullable<AxdEnum_ReturnStatusLine> returnStatusField;
        
        private bool returnStatusFieldSpecified;
        
        private System.Nullable<decimal> salesDeliverNowField;
        
        private bool salesDeliverNowFieldSpecified;
        
        private string salesGroupField;
        
        private string salesIdField;
        
        private System.Nullable<decimal> salesMarkupField;
        
        private bool salesMarkupFieldSpecified;
        
        private System.Nullable<decimal> salesPriceField;
        
        private bool salesPriceFieldSpecified;
        
        private decimal salesQtyField;
        
        private System.Nullable<AxdEnum_SalesStatus> salesStatusField;
        
        private bool salesStatusFieldSpecified;
        
        private System.Nullable<AxdEnum_SalesType> salesTypeField;
        
        private bool salesTypeFieldSpecified;
        
        private string salesUnitField;
        
        private System.Nullable<AxdEnum_NoYes> scrapField;
        
        private bool scrapFieldSpecified;
        
        private string serviceOrderIdField;
        
        private string shipCarrierAccountField;
        
        private string shipCarrierAccountCodeField;
        
        private System.Nullable<AxdEnum_ShipCarrierDlvType> shipCarrierDlvTypeField;
        
        private bool shipCarrierDlvTypeFieldSpecified;
        
        private string shipCarrierIDField;
        
        private System.Nullable<System.DateTime> shippingDateConfirmedField;
        
        private bool shippingDateConfirmedFieldSpecified;
        
        private System.Nullable<System.DateTime> shippingDateRequestedField;
        
        private bool shippingDateRequestedFieldSpecified;
        
        private string statProcIdField;
        
        private System.Nullable<AxdExtType_IntrastatTriangularDeal> statTriangularDealField;
        
        private bool statTriangularDealFieldSpecified;
        
        private System.Nullable<AxdExtType_TaxAutoGenerated> taxAutogeneratedField;
        
        private bool taxAutogeneratedFieldSpecified;
        
        private string taxGroupField;
        
        private string taxItemGroupField;
        
        private string transactionCodeField;
        
        private string transportField;
        
        private System.Nullable<decimal> underDeliveryPctField;
        
        private bool underDeliveryPctFieldSpecified;
        
        private AxdEntity_InventDim[] inventDimField;
        
        private AxdEntity_DocuRefLine[] docuRefLineField;
        
        private AxdEntity_MarkupTransLine[] markupTransLineField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_SalesLine()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string ActivityNumber
        {
            get
            {
                return this.activityNumberField;
            }
            set
            {
                this.activityNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string AssetId_RU
        {
            get
            {
                return this.assetId_RUField;
            }
            set
            {
                this.assetId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string BarCode
        {
            get
            {
                return this.barCodeField;
            }
            set
            {
                this.barCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string BarCodeType
        {
            get
            {
                return this.barCodeTypeField;
            }
            set
            {
                this.barCodeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string BlanketRefTransId
        {
            get
            {
                return this.blanketRefTransIdField;
            }
            set
            {
                this.blanketRefTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<AxdExtType_LineStopped> Blocked
        {
            get
            {
                return this.blockedField;
            }
            set
            {
                this.blockedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlockedSpecified
        {
            get
            {
                return this.blockedFieldSpecified;
            }
            set
            {
                this.blockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<AxdExtType_RFIDCaseTagging> CaseTagging
        {
            get
            {
                return this.caseTaggingField;
            }
            set
            {
                this.caseTaggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CaseTaggingSpecified
        {
            get
            {
                return this.caseTaggingFieldSpecified;
            }
            set
            {
                this.caseTaggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<AxdExtType_LineComplete> Complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompleteSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=8)]
        public System.Nullable<System.DateTime> ConfirmedDlv
        {
            get
            {
                return this.confirmedDlvField;
            }
            set
            {
                this.confirmedDlvField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfirmedDlvSpecified
        {
            get
            {
                return this.confirmedDlvFieldSpecified;
            }
            set
            {
                this.confirmedDlvFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string CorrectionDesc_PL
        {
            get
            {
                return this.correctionDesc_PLField;
            }
            set
            {
                this.correctionDesc_PLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<decimal> CostPrice
        {
            get
            {
                return this.costPriceField;
            }
            set
            {
                this.costPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CostPriceSpecified
        {
            get
            {
                return this.costPriceFieldSpecified;
            }
            set
            {
                this.costPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string CustAccount
        {
            get
            {
                return this.custAccountField;
            }
            set
            {
                this.custAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string CustGroup
        {
            get
            {
                return this.custGroupField;
            }
            set
            {
                this.custGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<int> CustomerLineNum
        {
            get
            {
                return this.customerLineNumField;
            }
            set
            {
                this.customerLineNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerLineNumSpecified
        {
            get
            {
                return this.customerLineNumFieldSpecified;
            }
            set
            {
                this.customerLineNumFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public string CustomerRef
        {
            get
            {
                return this.customerRefField;
            }
            set
            {
                this.customerRefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=16)]
        public System.Nullable<System.DateTime> CustomsDocDate_MX
        {
            get
            {
                return this.customsDocDate_MXField;
            }
            set
            {
                this.customsDocDate_MXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomsDocDate_MXSpecified
        {
            get
            {
                return this.customsDocDate_MXFieldSpecified;
            }
            set
            {
                this.customsDocDate_MXFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public string CustomsDocNumber_MX
        {
            get
            {
                return this.customsDocNumber_MXField;
            }
            set
            {
                this.customsDocNumber_MXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public string CustomsName_MX
        {
            get
            {
                return this.customsName_MXField;
            }
            set
            {
                this.customsName_MXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public System.Nullable<decimal> DeliveredIntotal
        {
            get
            {
                return this.deliveredIntotalField;
            }
            set
            {
                this.deliveredIntotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveredIntotalSpecified
        {
            get
            {
                return this.deliveredIntotalFieldSpecified;
            }
            set
            {
                this.deliveredIntotalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public string DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
        public string DeliveryBuilding_RU
        {
            get
            {
                return this.deliveryBuilding_RUField;
            }
            set
            {
                this.deliveryBuilding_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public string DeliveryCity
        {
            get
            {
                return this.deliveryCityField;
            }
            set
            {
                this.deliveryCityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public string DeliveryCountryRegionId
        {
            get
            {
                return this.deliveryCountryRegionIdField;
            }
            set
            {
                this.deliveryCountryRegionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
        public string DeliveryCounty
        {
            get
            {
                return this.deliveryCountyField;
            }
            set
            {
                this.deliveryCountyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public System.Nullable<AxdEnum_SalesDeliveryDateControlType> DeliveryDateControlType
        {
            get
            {
                return this.deliveryDateControlTypeField;
            }
            set
            {
                this.deliveryDateControlTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryDateControlTypeSpecified
        {
            get
            {
                return this.deliveryDateControlTypeFieldSpecified;
            }
            set
            {
                this.deliveryDateControlTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
        public string DeliveryEstate_RU
        {
            get
            {
                return this.deliveryEstate_RUField;
            }
            set
            {
                this.deliveryEstate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public string DeliveryFlat_RU
        {
            get
            {
                return this.deliveryFlat_RUField;
            }
            set
            {
                this.deliveryFlat_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
        public string DeliveryName
        {
            get
            {
                return this.deliveryNameField;
            }
            set
            {
                this.deliveryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public string DeliverySettlementId_RU
        {
            get
            {
                return this.deliverySettlementId_RUField;
            }
            set
            {
                this.deliverySettlementId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public string DeliveryState
        {
            get
            {
                return this.deliveryStateField;
            }
            set
            {
                this.deliveryStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public string DeliveryStreet
        {
            get
            {
                return this.deliveryStreetField;
            }
            set
            {
                this.deliveryStreetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
        public string DeliveryStreetId_RU
        {
            get
            {
                return this.deliveryStreetId_RUField;
            }
            set
            {
                this.deliveryStreetId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public string DeliveryTownId_RU
        {
            get
            {
                return this.deliveryTownId_RUField;
            }
            set
            {
                this.deliveryTownId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public System.Nullable<AxdExtType_TradeLineDlvTypeId> DeliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryTypeSpecified
        {
            get
            {
                return this.deliveryTypeFieldSpecified;
            }
            set
            {
                this.deliveryTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
        public string DeliveryZipCode
        {
            get
            {
                return this.deliveryZipCodeField;
            }
            set
            {
                this.deliveryZipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=36)]
        [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable=false)]
        public string[] Dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
        public string DlvMode
        {
            get
            {
                return this.dlvModeField;
            }
            set
            {
                this.dlvModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=38)]
        public string EInvoiceAccountCode
        {
            get
            {
                return this.eInvoiceAccountCodeField;
            }
            set
            {
                this.eInvoiceAccountCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=39)]
        public System.Nullable<decimal> ExpectedRetQty
        {
            get
            {
                return this.expectedRetQtyField;
            }
            set
            {
                this.expectedRetQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpectedRetQtySpecified
        {
            get
            {
                return this.expectedRetQtyFieldSpecified;
            }
            set
            {
                this.expectedRetQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=40)]
        public string ExternalItemId
        {
            get
            {
                return this.externalItemIdField;
            }
            set
            {
                this.externalItemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=41)]
        public string InterCompanyInventTransId
        {
            get
            {
                return this.interCompanyInventTransIdField;
            }
            set
            {
                this.interCompanyInventTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=42)]
        public System.Nullable<decimal> InventDeliverNow
        {
            get
            {
                return this.inventDeliverNowField;
            }
            set
            {
                this.inventDeliverNowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InventDeliverNowSpecified
        {
            get
            {
                return this.inventDeliverNowFieldSpecified;
            }
            set
            {
                this.inventDeliverNowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=43)]
        public string InventDimId
        {
            get
            {
                return this.inventDimIdField;
            }
            set
            {
                this.inventDimIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=44)]
        public string InventRefId
        {
            get
            {
                return this.inventRefIdField;
            }
            set
            {
                this.inventRefIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=45)]
        public string InventRefTransId
        {
            get
            {
                return this.inventRefTransIdField;
            }
            set
            {
                this.inventRefTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=46)]
        public System.Nullable<AxdEnum_InventRefType> InventRefType
        {
            get
            {
                return this.inventRefTypeField;
            }
            set
            {
                this.inventRefTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InventRefTypeSpecified
        {
            get
            {
                return this.inventRefTypeFieldSpecified;
            }
            set
            {
                this.inventRefTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=47)]
        public string InventTransId
        {
            get
            {
                return this.inventTransIdField;
            }
            set
            {
                this.inventTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=48)]
        public string InventTransIdReturn
        {
            get
            {
                return this.inventTransIdReturnField;
            }
            set
            {
                this.inventTransIdReturnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=49)]
        public string ItemBOMId
        {
            get
            {
                return this.itemBOMIdField;
            }
            set
            {
                this.itemBOMIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=50)]
        public string ItemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=51)]
        public string ItemPBAId
        {
            get
            {
                return this.itemPBAIdField;
            }
            set
            {
                this.itemPBAIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=52)]
        public System.Nullable<AxdExtType_ReturnItemReplaced> itemReplaced
        {
            get
            {
                return this.itemReplacedField;
            }
            set
            {
                this.itemReplacedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemReplacedSpecified
        {
            get
            {
                return this.itemReplacedFieldSpecified;
            }
            set
            {
                this.itemReplacedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=53)]
        public string ItemRouteId
        {
            get
            {
                return this.itemRouteIdField;
            }
            set
            {
                this.itemRouteIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=54)]
        public System.Nullable<AxdExtType_RFIDItemTagging> ItemTagging
        {
            get
            {
                return this.itemTaggingField;
            }
            set
            {
                this.itemTaggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemTaggingSpecified
        {
            get
            {
                return this.itemTaggingFieldSpecified;
            }
            set
            {
                this.itemTaggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=55)]
        public string LedgerAccount
        {
            get
            {
                return this.ledgerAccountField;
            }
            set
            {
                this.ledgerAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=56)]
        public System.Nullable<decimal> LineAmount
        {
            get
            {
                return this.lineAmountField;
            }
            set
            {
                this.lineAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineAmountSpecified
        {
            get
            {
                return this.lineAmountFieldSpecified;
            }
            set
            {
                this.lineAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=57)]
        public System.Nullable<decimal> LineDisc
        {
            get
            {
                return this.lineDiscField;
            }
            set
            {
                this.lineDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineDiscSpecified
        {
            get
            {
                return this.lineDiscFieldSpecified;
            }
            set
            {
                this.lineDiscFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=58)]
        public string LineHeader
        {
            get
            {
                return this.lineHeaderField;
            }
            set
            {
                this.lineHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=59)]
        public System.Nullable<decimal> LineNum
        {
            get
            {
                return this.lineNumField;
            }
            set
            {
                this.lineNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineNumSpecified
        {
            get
            {
                return this.lineNumFieldSpecified;
            }
            set
            {
                this.lineNumFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=60)]
        public System.Nullable<decimal> LinePercent
        {
            get
            {
                return this.linePercentField;
            }
            set
            {
                this.linePercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinePercentSpecified
        {
            get
            {
                return this.linePercentFieldSpecified;
            }
            set
            {
                this.linePercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=61)]
        public System.Nullable<decimal> MultiLnDisc
        {
            get
            {
                return this.multiLnDiscField;
            }
            set
            {
                this.multiLnDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultiLnDiscSpecified
        {
            get
            {
                return this.multiLnDiscFieldSpecified;
            }
            set
            {
                this.multiLnDiscFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=62)]
        public System.Nullable<decimal> MultiLnPercent
        {
            get
            {
                return this.multiLnPercentField;
            }
            set
            {
                this.multiLnPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultiLnPercentSpecified
        {
            get
            {
                return this.multiLnPercentFieldSpecified;
            }
            set
            {
                this.multiLnPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=63)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=64)]
        public System.Nullable<decimal> OverDeliveryPct
        {
            get
            {
                return this.overDeliveryPctField;
            }
            set
            {
                this.overDeliveryPctField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverDeliveryPctSpecified
        {
            get
            {
                return this.overDeliveryPctFieldSpecified;
            }
            set
            {
                this.overDeliveryPctFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=65)]
        public string PackingUnit
        {
            get
            {
                return this.packingUnitField;
            }
            set
            {
                this.packingUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=66)]
        public System.Nullable<decimal> PackingUnitQty
        {
            get
            {
                return this.packingUnitQtyField;
            }
            set
            {
                this.packingUnitQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingUnitQtySpecified
        {
            get
            {
                return this.packingUnitQtyFieldSpecified;
            }
            set
            {
                this.packingUnitQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=67)]
        public System.Nullable<AxdExtType_RFIDPalletTagging> PalletTagging
        {
            get
            {
                return this.palletTaggingField;
            }
            set
            {
                this.palletTaggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PalletTaggingSpecified
        {
            get
            {
                return this.palletTaggingFieldSpecified;
            }
            set
            {
                this.palletTaggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=68)]
        public string Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=69)]
        public string PostingProfile_RU
        {
            get
            {
                return this.postingProfile_RUField;
            }
            set
            {
                this.postingProfile_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=70)]
        public System.Nullable<System.DateTime> PriceAgreementDate_RU
        {
            get
            {
                return this.priceAgreementDate_RUField;
            }
            set
            {
                this.priceAgreementDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceAgreementDate_RUSpecified
        {
            get
            {
                return this.priceAgreementDate_RUFieldSpecified;
            }
            set
            {
                this.priceAgreementDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=71)]
        public System.Nullable<decimal> PriceUnit
        {
            get
            {
                return this.priceUnitField;
            }
            set
            {
                this.priceUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceUnitSpecified
        {
            get
            {
                return this.priceUnitFieldSpecified;
            }
            set
            {
                this.priceUnitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=72)]
        public string ProjCategoryId
        {
            get
            {
                return this.projCategoryIdField;
            }
            set
            {
                this.projCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=73)]
        public string ProjId
        {
            get
            {
                return this.projIdField;
            }
            set
            {
                this.projIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=74)]
        public string ProjLinePropertyId
        {
            get
            {
                return this.projLinePropertyIdField;
            }
            set
            {
                this.projLinePropertyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=75)]
        public string ProjTransId
        {
            get
            {
                return this.projTransIdField;
            }
            set
            {
                this.projTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=76)]
        public string PropertyNumber_MX
        {
            get
            {
                return this.propertyNumber_MXField;
            }
            set
            {
                this.propertyNumber_MXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=77)]
        public string PurchorderFormNum
        {
            get
            {
                return this.purchorderFormNumField;
            }
            set
            {
                this.purchorderFormNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=78)]
        public System.Nullable<decimal> QtyOrdered
        {
            get
            {
                return this.qtyOrderedField;
            }
            set
            {
                this.qtyOrderedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyOrderedSpecified
        {
            get
            {
                return this.qtyOrderedFieldSpecified;
            }
            set
            {
                this.qtyOrderedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=79)]
        public System.Nullable<System.DateTime> ReceiptDateConfirmed
        {
            get
            {
                return this.receiptDateConfirmedField;
            }
            set
            {
                this.receiptDateConfirmedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptDateConfirmedSpecified
        {
            get
            {
                return this.receiptDateConfirmedFieldSpecified;
            }
            set
            {
                this.receiptDateConfirmedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=80)]
        public System.Nullable<System.DateTime> ReceiptDateRequested
        {
            get
            {
                return this.receiptDateRequestedField;
            }
            set
            {
                this.receiptDateRequestedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptDateRequestedSpecified
        {
            get
            {
                return this.receiptDateRequestedFieldSpecified;
            }
            set
            {
                this.receiptDateRequestedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=81)]
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=82)]
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=83)]
        public System.Nullable<decimal> RemainInventFinancial
        {
            get
            {
                return this.remainInventFinancialField;
            }
            set
            {
                this.remainInventFinancialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemainInventFinancialSpecified
        {
            get
            {
                return this.remainInventFinancialFieldSpecified;
            }
            set
            {
                this.remainInventFinancialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=84)]
        public System.Nullable<decimal> RemainInventPhysical
        {
            get
            {
                return this.remainInventPhysicalField;
            }
            set
            {
                this.remainInventPhysicalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemainInventPhysicalSpecified
        {
            get
            {
                return this.remainInventPhysicalFieldSpecified;
            }
            set
            {
                this.remainInventPhysicalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=85)]
        public System.Nullable<decimal> RemainSalesFinancial
        {
            get
            {
                return this.remainSalesFinancialField;
            }
            set
            {
                this.remainSalesFinancialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemainSalesFinancialSpecified
        {
            get
            {
                return this.remainSalesFinancialFieldSpecified;
            }
            set
            {
                this.remainSalesFinancialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=86)]
        public System.Nullable<decimal> RemainSalesPhysical
        {
            get
            {
                return this.remainSalesPhysicalField;
            }
            set
            {
                this.remainSalesPhysicalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemainSalesPhysicalSpecified
        {
            get
            {
                return this.remainSalesPhysicalFieldSpecified;
            }
            set
            {
                this.remainSalesPhysicalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=87)]
        public System.Nullable<AxdEnum_ItemReservation> Reservation
        {
            get
            {
                return this.reservationField;
            }
            set
            {
                this.reservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReservationSpecified
        {
            get
            {
                return this.reservationFieldSpecified;
            }
            set
            {
                this.reservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=88)]
        public System.Nullable<AxdExtType_ReturnAllowReservation> ReturnAllowReservation
        {
            get
            {
                return this.returnAllowReservationField;
            }
            set
            {
                this.returnAllowReservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnAllowReservationSpecified
        {
            get
            {
                return this.returnAllowReservationFieldSpecified;
            }
            set
            {
                this.returnAllowReservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=89)]
        public System.Nullable<System.DateTime> ReturnArrivalDate
        {
            get
            {
                return this.returnArrivalDateField;
            }
            set
            {
                this.returnArrivalDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnArrivalDateSpecified
        {
            get
            {
                return this.returnArrivalDateFieldSpecified;
            }
            set
            {
                this.returnArrivalDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=90)]
        public System.Nullable<System.DateTime> ReturnClosedDate
        {
            get
            {
                return this.returnClosedDateField;
            }
            set
            {
                this.returnClosedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnClosedDateSpecified
        {
            get
            {
                return this.returnClosedDateFieldSpecified;
            }
            set
            {
                this.returnClosedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=91)]
        public System.Nullable<System.DateTime> ReturnDeadLine
        {
            get
            {
                return this.returnDeadLineField;
            }
            set
            {
                this.returnDeadLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnDeadLineSpecified
        {
            get
            {
                return this.returnDeadLineFieldSpecified;
            }
            set
            {
                this.returnDeadLineFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=92)]
        public string ReturnDispositionCodeId
        {
            get
            {
                return this.returnDispositionCodeIdField;
            }
            set
            {
                this.returnDispositionCodeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=93)]
        public System.Nullable<AxdEnum_ReturnStatusLine> ReturnStatus
        {
            get
            {
                return this.returnStatusField;
            }
            set
            {
                this.returnStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnStatusSpecified
        {
            get
            {
                return this.returnStatusFieldSpecified;
            }
            set
            {
                this.returnStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=94)]
        public System.Nullable<decimal> SalesDeliverNow
        {
            get
            {
                return this.salesDeliverNowField;
            }
            set
            {
                this.salesDeliverNowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesDeliverNowSpecified
        {
            get
            {
                return this.salesDeliverNowFieldSpecified;
            }
            set
            {
                this.salesDeliverNowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=95)]
        public string SalesGroup
        {
            get
            {
                return this.salesGroupField;
            }
            set
            {
                this.salesGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=96)]
        public string SalesId
        {
            get
            {
                return this.salesIdField;
            }
            set
            {
                this.salesIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=97)]
        public System.Nullable<decimal> SalesMarkup
        {
            get
            {
                return this.salesMarkupField;
            }
            set
            {
                this.salesMarkupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesMarkupSpecified
        {
            get
            {
                return this.salesMarkupFieldSpecified;
            }
            set
            {
                this.salesMarkupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=98)]
        public System.Nullable<decimal> SalesPrice
        {
            get
            {
                return this.salesPriceField;
            }
            set
            {
                this.salesPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesPriceSpecified
        {
            get
            {
                return this.salesPriceFieldSpecified;
            }
            set
            {
                this.salesPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=99)]
        public decimal SalesQty
        {
            get
            {
                return this.salesQtyField;
            }
            set
            {
                this.salesQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=100)]
        public System.Nullable<AxdEnum_SalesStatus> SalesStatus
        {
            get
            {
                return this.salesStatusField;
            }
            set
            {
                this.salesStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesStatusSpecified
        {
            get
            {
                return this.salesStatusFieldSpecified;
            }
            set
            {
                this.salesStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=101)]
        public System.Nullable<AxdEnum_SalesType> SalesType
        {
            get
            {
                return this.salesTypeField;
            }
            set
            {
                this.salesTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesTypeSpecified
        {
            get
            {
                return this.salesTypeFieldSpecified;
            }
            set
            {
                this.salesTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=102)]
        public string SalesUnit
        {
            get
            {
                return this.salesUnitField;
            }
            set
            {
                this.salesUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=103)]
        public System.Nullable<AxdEnum_NoYes> Scrap
        {
            get
            {
                return this.scrapField;
            }
            set
            {
                this.scrapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScrapSpecified
        {
            get
            {
                return this.scrapFieldSpecified;
            }
            set
            {
                this.scrapFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=104)]
        public string ServiceOrderId
        {
            get
            {
                return this.serviceOrderIdField;
            }
            set
            {
                this.serviceOrderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=105)]
        public string ShipCarrierAccount
        {
            get
            {
                return this.shipCarrierAccountField;
            }
            set
            {
                this.shipCarrierAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=106)]
        public string ShipCarrierAccountCode
        {
            get
            {
                return this.shipCarrierAccountCodeField;
            }
            set
            {
                this.shipCarrierAccountCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=107)]
        public System.Nullable<AxdEnum_ShipCarrierDlvType> ShipCarrierDlvType
        {
            get
            {
                return this.shipCarrierDlvTypeField;
            }
            set
            {
                this.shipCarrierDlvTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipCarrierDlvTypeSpecified
        {
            get
            {
                return this.shipCarrierDlvTypeFieldSpecified;
            }
            set
            {
                this.shipCarrierDlvTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=108)]
        public string ShipCarrierID
        {
            get
            {
                return this.shipCarrierIDField;
            }
            set
            {
                this.shipCarrierIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=109)]
        public System.Nullable<System.DateTime> ShippingDateConfirmed
        {
            get
            {
                return this.shippingDateConfirmedField;
            }
            set
            {
                this.shippingDateConfirmedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateConfirmedSpecified
        {
            get
            {
                return this.shippingDateConfirmedFieldSpecified;
            }
            set
            {
                this.shippingDateConfirmedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=110)]
        public System.Nullable<System.DateTime> ShippingDateRequested
        {
            get
            {
                return this.shippingDateRequestedField;
            }
            set
            {
                this.shippingDateRequestedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateRequestedSpecified
        {
            get
            {
                return this.shippingDateRequestedFieldSpecified;
            }
            set
            {
                this.shippingDateRequestedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=111)]
        public string StatProcId
        {
            get
            {
                return this.statProcIdField;
            }
            set
            {
                this.statProcIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=112)]
        public System.Nullable<AxdExtType_IntrastatTriangularDeal> StatTriangularDeal
        {
            get
            {
                return this.statTriangularDealField;
            }
            set
            {
                this.statTriangularDealField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatTriangularDealSpecified
        {
            get
            {
                return this.statTriangularDealFieldSpecified;
            }
            set
            {
                this.statTriangularDealFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=113)]
        public System.Nullable<AxdExtType_TaxAutoGenerated> TaxAutogenerated
        {
            get
            {
                return this.taxAutogeneratedField;
            }
            set
            {
                this.taxAutogeneratedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAutogeneratedSpecified
        {
            get
            {
                return this.taxAutogeneratedFieldSpecified;
            }
            set
            {
                this.taxAutogeneratedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=114)]
        public string TaxGroup
        {
            get
            {
                return this.taxGroupField;
            }
            set
            {
                this.taxGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=115)]
        public string TaxItemGroup
        {
            get
            {
                return this.taxItemGroupField;
            }
            set
            {
                this.taxItemGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=116)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=117)]
        public string Transport
        {
            get
            {
                return this.transportField;
            }
            set
            {
                this.transportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=118)]
        public System.Nullable<decimal> UnderDeliveryPct
        {
            get
            {
                return this.underDeliveryPctField;
            }
            set
            {
                this.underDeliveryPctField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnderDeliveryPctSpecified
        {
            get
            {
                return this.underDeliveryPctFieldSpecified;
            }
            set
            {
                this.underDeliveryPctFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventDim", Order=119)]
        public AxdEntity_InventDim[] InventDim
        {
            get
            {
                return this.inventDimField;
            }
            set
            {
                this.inventDimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocuRefLine", Order=120)]
        public AxdEntity_DocuRefLine[] DocuRefLine
        {
            get
            {
                return this.docuRefLineField;
            }
            set
            {
                this.docuRefLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarkupTransLine", Order=121)]
        public AxdEntity_MarkupTransLine[] MarkupTransLine
        {
            get
            {
                return this.markupTransLineField;
            }
            set
            {
                this.markupTransLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_LineStopped
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_LineComplete
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_TradeLineDlvTypeId
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        DropShip,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_InventRefType
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Sales,
        
        /// <remarks/>
        Purch,
        
        /// <remarks/>
        Production,
        
        /// <remarks/>
        ProdLine,
        
        /// <remarks/>
        InventJournal,
        
        /// <remarks/>
        CRMQuotation,
        
        /// <remarks/>
        InventTransfer,
        
        /// <remarks/>
        FixedAsset,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ReturnItemReplaced
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_ReturnAllowReservation
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_ReturnStatusLine
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Awaiting,
        
        /// <remarks/>
        Registered,
        
        /// <remarks/>
        Quarantine,
        
        /// <remarks/>
        Received,
        
        /// <remarks/>
        Invoiced,
        
        /// <remarks/>
        Canceled,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_IntrastatTriangularDeal
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_TaxAutoGenerated
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_InventDim
    {
        
        private string configIdField;
        
        private string inventBatchIdField;
        
        private string inventColorIdField;
        
        private string inventDimIdField;
        
        private string inventGTDId_RUField;
        
        private string inventLocationIdField;
        
        private string inventOwnerId_RUField;
        
        private string inventProfileId_RUField;
        
        private string inventSerialIdField;
        
        private string inventSiteIdField;
        
        private string inventSizeIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string wMSLocationIdField;
        
        private string wMSPalletIdField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventDim()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string configId
        {
            get
            {
                return this.configIdField;
            }
            set
            {
                this.configIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string InventBatchId
        {
            get
            {
                return this.inventBatchIdField;
            }
            set
            {
                this.inventBatchIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string InventColorId
        {
            get
            {
                return this.inventColorIdField;
            }
            set
            {
                this.inventColorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string inventDimId
        {
            get
            {
                return this.inventDimIdField;
            }
            set
            {
                this.inventDimIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string InventGTDId_RU
        {
            get
            {
                return this.inventGTDId_RUField;
            }
            set
            {
                this.inventGTDId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string InventLocationId
        {
            get
            {
                return this.inventLocationIdField;
            }
            set
            {
                this.inventLocationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string InventOwnerId_RU
        {
            get
            {
                return this.inventOwnerId_RUField;
            }
            set
            {
                this.inventOwnerId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string InventProfileId_RU
        {
            get
            {
                return this.inventProfileId_RUField;
            }
            set
            {
                this.inventProfileId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public string inventSerialId
        {
            get
            {
                return this.inventSerialIdField;
            }
            set
            {
                this.inventSerialIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string InventSiteId
        {
            get
            {
                return this.inventSiteIdField;
            }
            set
            {
                this.inventSiteIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public string InventSizeId
        {
            get
            {
                return this.inventSizeIdField;
            }
            set
            {
                this.inventSizeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string wMSLocationId
        {
            get
            {
                return this.wMSLocationIdField;
            }
            set
            {
                this.wMSLocationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public string wMSPalletId
        {
            get
            {
                return this.wMSPalletIdField;
            }
            set
            {
                this.wMSPalletIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_AxdEntityAction
    {
        
        /// <remarks/>
        create,
        
        /// <remarks/>
        update,
        
        /// <remarks/>
        replace,
        
        /// <remarks/>
        delete,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_DocuRefLine
    {
        
        private string actualCompanyIdField;
        
        private string authorIdField;
        
        private string contactPersonIdField;
        
        private string encyclopediaItemIdField;
        
        private string nameField;
        
        private string notesField;
        
        private string partyIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string refCompanyIdField;
        
        private System.Nullable<long> refRecIdField;
        
        private bool refRecIdFieldSpecified;
        
        private System.Nullable<int> refTableIdField;
        
        private bool refTableIdFieldSpecified;
        
        private System.Nullable<AxdEnum_DocuRestriction> restrictionField;
        
        private bool restrictionFieldSpecified;
        
        private System.Nullable<AxdEnum_boolean> smmTableField;
        
        private bool smmTableFieldSpecified;
        
        private string typeIdField;
        
        private System.Nullable<long> valueRecIdField;
        
        private bool valueRecIdFieldSpecified;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_DocuRefLine()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string ActualCompanyId
        {
            get
            {
                return this.actualCompanyIdField;
            }
            set
            {
                this.actualCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string AuthorId
        {
            get
            {
                return this.authorIdField;
            }
            set
            {
                this.authorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string ContactPersonId
        {
            get
            {
                return this.contactPersonIdField;
            }
            set
            {
                this.contactPersonIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string EncyclopediaItemId
        {
            get
            {
                return this.encyclopediaItemIdField;
            }
            set
            {
                this.encyclopediaItemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string PartyId
        {
            get
            {
                return this.partyIdField;
            }
            set
            {
                this.partyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string RefCompanyId
        {
            get
            {
                return this.refCompanyIdField;
            }
            set
            {
                this.refCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<long> RefRecId
        {
            get
            {
                return this.refRecIdField;
            }
            set
            {
                this.refRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefRecIdSpecified
        {
            get
            {
                return this.refRecIdFieldSpecified;
            }
            set
            {
                this.refRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<int> RefTableId
        {
            get
            {
                return this.refTableIdField;
            }
            set
            {
                this.refTableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefTableIdSpecified
        {
            get
            {
                return this.refTableIdFieldSpecified;
            }
            set
            {
                this.refTableIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<AxdEnum_DocuRestriction> Restriction
        {
            get
            {
                return this.restrictionField;
            }
            set
            {
                this.restrictionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictionSpecified
        {
            get
            {
                return this.restrictionFieldSpecified;
            }
            set
            {
                this.restrictionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<AxdEnum_boolean> smmTable
        {
            get
            {
                return this.smmTableField;
            }
            set
            {
                this.smmTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool smmTableSpecified
        {
            get
            {
                return this.smmTableFieldSpecified;
            }
            set
            {
                this.smmTableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public string TypeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<long> ValueRecId
        {
            get
            {
                return this.valueRecIdField;
            }
            set
            {
                this.valueRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueRecIdSpecified
        {
            get
            {
                return this.valueRecIdFieldSpecified;
            }
            set
            {
                this.valueRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_DocuRestriction
    {
        
        /// <remarks/>
        Internal,
        
        /// <remarks/>
        External,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_boolean
    {
        
        /// <remarks/>
        @false,
        
        /// <remarks/>
        @true,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_MarkupTransLine
    {
        
        private System.Nullable<decimal> calculatedAmountField;
        
        private bool calculatedAmountFieldSpecified;
        
        private string chargeIndicatorEinvoiceField;
        
        private string currencyCodeField;
        
        private System.Nullable<AxdEnum_DocumentStatus> documentStatusField;
        
        private bool documentStatusFieldSpecified;
        
        private System.Nullable<decimal> facturedAmount_RUField;
        
        private bool facturedAmount_RUFieldSpecified;
        
        private string interCompanyCompanyIdField;
        
        private string interCompanyInvoiceIdField;
        
        private System.Nullable<AxdExtType_InterCompanyMarkupUseValue> interCompanyMarkupUseValueField;
        
        private bool interCompanyMarkupUseValueFieldSpecified;
        
        private System.Nullable<decimal> interCompanyMarkupValueField;
        
        private bool interCompanyMarkupValueFieldSpecified;
        
        private System.Nullable<long> interCompanyRefRecIdField;
        
        private bool interCompanyRefRecIdFieldSpecified;
        
        private System.Nullable<AxdExtType_MarkupKeep> keepField;
        
        private bool keepFieldSpecified;
        
        private System.Nullable<decimal> lineNumField;
        
        private bool lineNumFieldSpecified;
        
        private System.Nullable<AxdExtType_MarkupCategoryType> markupCategoryField;
        
        private bool markupCategoryFieldSpecified;
        
        private string markupCodeField;
        
        private System.Nullable<AxdExtType_MarkupModuleCategory> moduleCategoryField;
        
        private bool moduleCategoryFieldSpecified;
        
        private System.Nullable<AxdExtType_MarkupModule> moduleTypeField;
        
        private bool moduleTypeFieldSpecified;
        
        private System.Nullable<long> origRecIdField;
        
        private bool origRecIdFieldSpecified;
        
        private System.Nullable<int> origTableIdField;
        
        private bool origTableIdFieldSpecified;
        
        private System.Nullable<decimal> postedField;
        
        private bool postedFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> taxAmountField;
        
        private bool taxAmountFieldSpecified;
        
        private System.Nullable<decimal> taxAmountExciseMST_RUField;
        
        private bool taxAmountExciseMST_RUFieldSpecified;
        
        private System.Nullable<decimal> taxAmountVATMST_RUField;
        
        private bool taxAmountVATMST_RUFieldSpecified;
        
        private System.Nullable<AxdExtType_TaxAutoGenerated> taxAutogeneratedField;
        
        private bool taxAutogeneratedFieldSpecified;
        
        private string taxGroupField;
        
        private string taxItemGroupField;
        
        private string taxWriteCodeField;
        
        private System.Nullable<System.DateTime> transDateField;
        
        private bool transDateFieldSpecified;
        
        private System.Nullable<long> transRecIdField;
        
        private bool transRecIdFieldSpecified;
        
        private System.Nullable<int> transTableIdField;
        
        private bool transTableIdFieldSpecified;
        
        private string txtField;
        
        private System.Nullable<decimal> valueField;
        
        private bool valueFieldSpecified;
        
        private System.Nullable<AxdEnum_PurchBookVATDocumentType_Invoice_RU> vATDocumentType_RUField;
        
        private bool vATDocumentType_RUFieldSpecified;
        
        private string voucherField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_MarkupTransLine()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<decimal> CalculatedAmount
        {
            get
            {
                return this.calculatedAmountField;
            }
            set
            {
                this.calculatedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalculatedAmountSpecified
        {
            get
            {
                return this.calculatedAmountFieldSpecified;
            }
            set
            {
                this.calculatedAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string ChargeIndicatorEinvoice
        {
            get
            {
                return this.chargeIndicatorEinvoiceField;
            }
            set
            {
                this.chargeIndicatorEinvoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<AxdEnum_DocumentStatus> DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentStatusSpecified
        {
            get
            {
                return this.documentStatusFieldSpecified;
            }
            set
            {
                this.documentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<decimal> FacturedAmount_RU
        {
            get
            {
                return this.facturedAmount_RUField;
            }
            set
            {
                this.facturedAmount_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FacturedAmount_RUSpecified
        {
            get
            {
                return this.facturedAmount_RUFieldSpecified;
            }
            set
            {
                this.facturedAmount_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string InterCompanyCompanyId
        {
            get
            {
                return this.interCompanyCompanyIdField;
            }
            set
            {
                this.interCompanyCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string InterCompanyInvoiceId
        {
            get
            {
                return this.interCompanyInvoiceIdField;
            }
            set
            {
                this.interCompanyInvoiceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<AxdExtType_InterCompanyMarkupUseValue> InterCompanyMarkupUseValue
        {
            get
            {
                return this.interCompanyMarkupUseValueField;
            }
            set
            {
                this.interCompanyMarkupUseValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyMarkupUseValueSpecified
        {
            get
            {
                return this.interCompanyMarkupUseValueFieldSpecified;
            }
            set
            {
                this.interCompanyMarkupUseValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<decimal> InterCompanyMarkupValue
        {
            get
            {
                return this.interCompanyMarkupValueField;
            }
            set
            {
                this.interCompanyMarkupValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyMarkupValueSpecified
        {
            get
            {
                return this.interCompanyMarkupValueFieldSpecified;
            }
            set
            {
                this.interCompanyMarkupValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<long> InterCompanyRefRecId
        {
            get
            {
                return this.interCompanyRefRecIdField;
            }
            set
            {
                this.interCompanyRefRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyRefRecIdSpecified
        {
            get
            {
                return this.interCompanyRefRecIdFieldSpecified;
            }
            set
            {
                this.interCompanyRefRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<AxdExtType_MarkupKeep> Keep
        {
            get
            {
                return this.keepField;
            }
            set
            {
                this.keepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KeepSpecified
        {
            get
            {
                return this.keepFieldSpecified;
            }
            set
            {
                this.keepFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<decimal> LineNum
        {
            get
            {
                return this.lineNumField;
            }
            set
            {
                this.lineNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineNumSpecified
        {
            get
            {
                return this.lineNumFieldSpecified;
            }
            set
            {
                this.lineNumFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<AxdExtType_MarkupCategoryType> MarkupCategory
        {
            get
            {
                return this.markupCategoryField;
            }
            set
            {
                this.markupCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupCategorySpecified
        {
            get
            {
                return this.markupCategoryFieldSpecified;
            }
            set
            {
                this.markupCategoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string MarkupCode
        {
            get
            {
                return this.markupCodeField;
            }
            set
            {
                this.markupCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<AxdExtType_MarkupModuleCategory> ModuleCategory
        {
            get
            {
                return this.moduleCategoryField;
            }
            set
            {
                this.moduleCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModuleCategorySpecified
        {
            get
            {
                return this.moduleCategoryFieldSpecified;
            }
            set
            {
                this.moduleCategoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<AxdExtType_MarkupModule> ModuleType
        {
            get
            {
                return this.moduleTypeField;
            }
            set
            {
                this.moduleTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModuleTypeSpecified
        {
            get
            {
                return this.moduleTypeFieldSpecified;
            }
            set
            {
                this.moduleTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<long> OrigRecId
        {
            get
            {
                return this.origRecIdField;
            }
            set
            {
                this.origRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrigRecIdSpecified
        {
            get
            {
                return this.origRecIdFieldSpecified;
            }
            set
            {
                this.origRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public System.Nullable<int> OrigTableId
        {
            get
            {
                return this.origTableIdField;
            }
            set
            {
                this.origTableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrigTableIdSpecified
        {
            get
            {
                return this.origTableIdFieldSpecified;
            }
            set
            {
                this.origTableIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public System.Nullable<decimal> Posted
        {
            get
            {
                return this.postedField;
            }
            set
            {
                this.postedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostedSpecified
        {
            get
            {
                return this.postedFieldSpecified;
            }
            set
            {
                this.postedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
        public System.Nullable<decimal> TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountSpecified
        {
            get
            {
                return this.taxAmountFieldSpecified;
            }
            set
            {
                this.taxAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public System.Nullable<decimal> TaxAmountExciseMST_RU
        {
            get
            {
                return this.taxAmountExciseMST_RUField;
            }
            set
            {
                this.taxAmountExciseMST_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountExciseMST_RUSpecified
        {
            get
            {
                return this.taxAmountExciseMST_RUFieldSpecified;
            }
            set
            {
                this.taxAmountExciseMST_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public System.Nullable<decimal> TaxAmountVATMST_RU
        {
            get
            {
                return this.taxAmountVATMST_RUField;
            }
            set
            {
                this.taxAmountVATMST_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountVATMST_RUSpecified
        {
            get
            {
                return this.taxAmountVATMST_RUFieldSpecified;
            }
            set
            {
                this.taxAmountVATMST_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
        public System.Nullable<AxdExtType_TaxAutoGenerated> TaxAutogenerated
        {
            get
            {
                return this.taxAutogeneratedField;
            }
            set
            {
                this.taxAutogeneratedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAutogeneratedSpecified
        {
            get
            {
                return this.taxAutogeneratedFieldSpecified;
            }
            set
            {
                this.taxAutogeneratedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public string TaxGroup
        {
            get
            {
                return this.taxGroupField;
            }
            set
            {
                this.taxGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
        public string TaxItemGroup
        {
            get
            {
                return this.taxItemGroupField;
            }
            set
            {
                this.taxItemGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public string TaxWriteCode
        {
            get
            {
                return this.taxWriteCodeField;
            }
            set
            {
                this.taxWriteCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=28)]
        public System.Nullable<System.DateTime> TransDate
        {
            get
            {
                return this.transDateField;
            }
            set
            {
                this.transDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransDateSpecified
        {
            get
            {
                return this.transDateFieldSpecified;
            }
            set
            {
                this.transDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public System.Nullable<long> TransRecId
        {
            get
            {
                return this.transRecIdField;
            }
            set
            {
                this.transRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransRecIdSpecified
        {
            get
            {
                return this.transRecIdFieldSpecified;
            }
            set
            {
                this.transRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public System.Nullable<int> TransTableId
        {
            get
            {
                return this.transTableIdField;
            }
            set
            {
                this.transTableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransTableIdSpecified
        {
            get
            {
                return this.transTableIdFieldSpecified;
            }
            set
            {
                this.transTableIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public string Txt
        {
            get
            {
                return this.txtField;
            }
            set
            {
                this.txtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
        public System.Nullable<decimal> Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public System.Nullable<AxdEnum_PurchBookVATDocumentType_Invoice_RU> VATDocumentType_RU
        {
            get
            {
                return this.vATDocumentType_RUField;
            }
            set
            {
                this.vATDocumentType_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VATDocumentType_RUSpecified
        {
            get
            {
                return this.vATDocumentType_RUFieldSpecified;
            }
            set
            {
                this.vATDocumentType_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public string Voucher
        {
            get
            {
                return this.voucherField;
            }
            set
            {
                this.voucherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_InterCompanyMarkupUseValue
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_MarkupKeep
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_MarkupCategoryType
    {
        
        /// <remarks/>
        Fixed,
        
        /// <remarks/>
        Pcs,
        
        /// <remarks/>
        Percent,
        
        /// <remarks/>
        InterCompanyPercent,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_MarkupModuleCategory
    {
        
        /// <remarks/>
        Heading,
        
        /// <remarks/>
        Linie,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdExtType_MarkupModule
    {
        
        /// <remarks/>
        Invent,
        
        /// <remarks/>
        Cust,
        
        /// <remarks/>
        Vend,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public enum AxdEnum_PurchBookVATDocumentType_Invoice_RU
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Unknown,
        
        /// <remarks/>
        ContractorsWork_Before2005,
        
        /// <remarks/>
        ContractorsWork_2005,
        
        /// <remarks/>
        BuildingForOwnNeeds_Before2005,
        
        /// <remarks/>
        BuildingForOwnNeeds_2005,
        
        /// <remarks/>
        Goods,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_DocuRefHeader
    {
        
        private string actualCompanyIdField;
        
        private string authorIdField;
        
        private string contactPersonIdField;
        
        private string encyclopediaItemIdField;
        
        private string nameField;
        
        private string notesField;
        
        private string partyIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string refCompanyIdField;
        
        private System.Nullable<long> refRecIdField;
        
        private bool refRecIdFieldSpecified;
        
        private System.Nullable<int> refTableIdField;
        
        private bool refTableIdFieldSpecified;
        
        private System.Nullable<AxdEnum_DocuRestriction> restrictionField;
        
        private bool restrictionFieldSpecified;
        
        private System.Nullable<AxdEnum_boolean> smmTableField;
        
        private bool smmTableFieldSpecified;
        
        private string typeIdField;
        
        private System.Nullable<long> valueRecIdField;
        
        private bool valueRecIdFieldSpecified;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_DocuRefHeader()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string ActualCompanyId
        {
            get
            {
                return this.actualCompanyIdField;
            }
            set
            {
                this.actualCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string AuthorId
        {
            get
            {
                return this.authorIdField;
            }
            set
            {
                this.authorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string ContactPersonId
        {
            get
            {
                return this.contactPersonIdField;
            }
            set
            {
                this.contactPersonIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string EncyclopediaItemId
        {
            get
            {
                return this.encyclopediaItemIdField;
            }
            set
            {
                this.encyclopediaItemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string PartyId
        {
            get
            {
                return this.partyIdField;
            }
            set
            {
                this.partyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string RefCompanyId
        {
            get
            {
                return this.refCompanyIdField;
            }
            set
            {
                this.refCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<long> RefRecId
        {
            get
            {
                return this.refRecIdField;
            }
            set
            {
                this.refRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefRecIdSpecified
        {
            get
            {
                return this.refRecIdFieldSpecified;
            }
            set
            {
                this.refRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<int> RefTableId
        {
            get
            {
                return this.refTableIdField;
            }
            set
            {
                this.refTableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefTableIdSpecified
        {
            get
            {
                return this.refTableIdFieldSpecified;
            }
            set
            {
                this.refTableIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<AxdEnum_DocuRestriction> Restriction
        {
            get
            {
                return this.restrictionField;
            }
            set
            {
                this.restrictionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictionSpecified
        {
            get
            {
                return this.restrictionFieldSpecified;
            }
            set
            {
                this.restrictionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<AxdEnum_boolean> smmTable
        {
            get
            {
                return this.smmTableField;
            }
            set
            {
                this.smmTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool smmTableSpecified
        {
            get
            {
                return this.smmTableFieldSpecified;
            }
            set
            {
                this.smmTableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public string TypeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<long> ValueRecId
        {
            get
            {
                return this.valueRecIdField;
            }
            set
            {
                this.valueRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueRecIdSpecified
        {
            get
            {
                return this.valueRecIdFieldSpecified;
            }
            set
            {
                this.valueRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_MarkupTransHeader
    {
        
        private System.Nullable<decimal> calculatedAmountField;
        
        private bool calculatedAmountFieldSpecified;
        
        private string chargeIndicatorEinvoiceField;
        
        private string currencyCodeField;
        
        private System.Nullable<AxdEnum_DocumentStatus> documentStatusField;
        
        private bool documentStatusFieldSpecified;
        
        private System.Nullable<decimal> facturedAmount_RUField;
        
        private bool facturedAmount_RUFieldSpecified;
        
        private string interCompanyCompanyIdField;
        
        private string interCompanyInvoiceIdField;
        
        private System.Nullable<AxdExtType_InterCompanyMarkupUseValue> interCompanyMarkupUseValueField;
        
        private bool interCompanyMarkupUseValueFieldSpecified;
        
        private System.Nullable<decimal> interCompanyMarkupValueField;
        
        private bool interCompanyMarkupValueFieldSpecified;
        
        private System.Nullable<long> interCompanyRefRecIdField;
        
        private bool interCompanyRefRecIdFieldSpecified;
        
        private System.Nullable<AxdExtType_MarkupKeep> keepField;
        
        private bool keepFieldSpecified;
        
        private System.Nullable<decimal> lineNumField;
        
        private bool lineNumFieldSpecified;
        
        private System.Nullable<AxdExtType_MarkupCategoryType> markupCategoryField;
        
        private bool markupCategoryFieldSpecified;
        
        private string markupCodeField;
        
        private System.Nullable<AxdExtType_MarkupModuleCategory> moduleCategoryField;
        
        private bool moduleCategoryFieldSpecified;
        
        private System.Nullable<AxdExtType_MarkupModule> moduleTypeField;
        
        private bool moduleTypeFieldSpecified;
        
        private System.Nullable<long> origRecIdField;
        
        private bool origRecIdFieldSpecified;
        
        private System.Nullable<int> origTableIdField;
        
        private bool origTableIdFieldSpecified;
        
        private System.Nullable<decimal> postedField;
        
        private bool postedFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> taxAmountField;
        
        private bool taxAmountFieldSpecified;
        
        private System.Nullable<decimal> taxAmountExciseMST_RUField;
        
        private bool taxAmountExciseMST_RUFieldSpecified;
        
        private System.Nullable<decimal> taxAmountVATMST_RUField;
        
        private bool taxAmountVATMST_RUFieldSpecified;
        
        private System.Nullable<AxdExtType_TaxAutoGenerated> taxAutogeneratedField;
        
        private bool taxAutogeneratedFieldSpecified;
        
        private string taxGroupField;
        
        private string taxItemGroupField;
        
        private string taxWriteCodeField;
        
        private System.Nullable<System.DateTime> transDateField;
        
        private bool transDateFieldSpecified;
        
        private System.Nullable<long> transRecIdField;
        
        private bool transRecIdFieldSpecified;
        
        private System.Nullable<int> transTableIdField;
        
        private bool transTableIdFieldSpecified;
        
        private string txtField;
        
        private System.Nullable<decimal> valueField;
        
        private bool valueFieldSpecified;
        
        private System.Nullable<AxdEnum_PurchBookVATDocumentType_Invoice_RU> vATDocumentType_RUField;
        
        private bool vATDocumentType_RUFieldSpecified;
        
        private string voucherField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_MarkupTransHeader()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<decimal> CalculatedAmount
        {
            get
            {
                return this.calculatedAmountField;
            }
            set
            {
                this.calculatedAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalculatedAmountSpecified
        {
            get
            {
                return this.calculatedAmountFieldSpecified;
            }
            set
            {
                this.calculatedAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string ChargeIndicatorEinvoice
        {
            get
            {
                return this.chargeIndicatorEinvoiceField;
            }
            set
            {
                this.chargeIndicatorEinvoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<AxdEnum_DocumentStatus> DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentStatusSpecified
        {
            get
            {
                return this.documentStatusFieldSpecified;
            }
            set
            {
                this.documentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<decimal> FacturedAmount_RU
        {
            get
            {
                return this.facturedAmount_RUField;
            }
            set
            {
                this.facturedAmount_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FacturedAmount_RUSpecified
        {
            get
            {
                return this.facturedAmount_RUFieldSpecified;
            }
            set
            {
                this.facturedAmount_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string InterCompanyCompanyId
        {
            get
            {
                return this.interCompanyCompanyIdField;
            }
            set
            {
                this.interCompanyCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string InterCompanyInvoiceId
        {
            get
            {
                return this.interCompanyInvoiceIdField;
            }
            set
            {
                this.interCompanyInvoiceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<AxdExtType_InterCompanyMarkupUseValue> InterCompanyMarkupUseValue
        {
            get
            {
                return this.interCompanyMarkupUseValueField;
            }
            set
            {
                this.interCompanyMarkupUseValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyMarkupUseValueSpecified
        {
            get
            {
                return this.interCompanyMarkupUseValueFieldSpecified;
            }
            set
            {
                this.interCompanyMarkupUseValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<decimal> InterCompanyMarkupValue
        {
            get
            {
                return this.interCompanyMarkupValueField;
            }
            set
            {
                this.interCompanyMarkupValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyMarkupValueSpecified
        {
            get
            {
                return this.interCompanyMarkupValueFieldSpecified;
            }
            set
            {
                this.interCompanyMarkupValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<long> InterCompanyRefRecId
        {
            get
            {
                return this.interCompanyRefRecIdField;
            }
            set
            {
                this.interCompanyRefRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyRefRecIdSpecified
        {
            get
            {
                return this.interCompanyRefRecIdFieldSpecified;
            }
            set
            {
                this.interCompanyRefRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<AxdExtType_MarkupKeep> Keep
        {
            get
            {
                return this.keepField;
            }
            set
            {
                this.keepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KeepSpecified
        {
            get
            {
                return this.keepFieldSpecified;
            }
            set
            {
                this.keepFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<decimal> LineNum
        {
            get
            {
                return this.lineNumField;
            }
            set
            {
                this.lineNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineNumSpecified
        {
            get
            {
                return this.lineNumFieldSpecified;
            }
            set
            {
                this.lineNumFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<AxdExtType_MarkupCategoryType> MarkupCategory
        {
            get
            {
                return this.markupCategoryField;
            }
            set
            {
                this.markupCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupCategorySpecified
        {
            get
            {
                return this.markupCategoryFieldSpecified;
            }
            set
            {
                this.markupCategoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string MarkupCode
        {
            get
            {
                return this.markupCodeField;
            }
            set
            {
                this.markupCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<AxdExtType_MarkupModuleCategory> ModuleCategory
        {
            get
            {
                return this.moduleCategoryField;
            }
            set
            {
                this.moduleCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModuleCategorySpecified
        {
            get
            {
                return this.moduleCategoryFieldSpecified;
            }
            set
            {
                this.moduleCategoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<AxdExtType_MarkupModule> ModuleType
        {
            get
            {
                return this.moduleTypeField;
            }
            set
            {
                this.moduleTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModuleTypeSpecified
        {
            get
            {
                return this.moduleTypeFieldSpecified;
            }
            set
            {
                this.moduleTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<long> OrigRecId
        {
            get
            {
                return this.origRecIdField;
            }
            set
            {
                this.origRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrigRecIdSpecified
        {
            get
            {
                return this.origRecIdFieldSpecified;
            }
            set
            {
                this.origRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public System.Nullable<int> OrigTableId
        {
            get
            {
                return this.origTableIdField;
            }
            set
            {
                this.origTableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrigTableIdSpecified
        {
            get
            {
                return this.origTableIdFieldSpecified;
            }
            set
            {
                this.origTableIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public System.Nullable<decimal> Posted
        {
            get
            {
                return this.postedField;
            }
            set
            {
                this.postedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostedSpecified
        {
            get
            {
                return this.postedFieldSpecified;
            }
            set
            {
                this.postedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
        public System.Nullable<decimal> TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountSpecified
        {
            get
            {
                return this.taxAmountFieldSpecified;
            }
            set
            {
                this.taxAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public System.Nullable<decimal> TaxAmountExciseMST_RU
        {
            get
            {
                return this.taxAmountExciseMST_RUField;
            }
            set
            {
                this.taxAmountExciseMST_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountExciseMST_RUSpecified
        {
            get
            {
                return this.taxAmountExciseMST_RUFieldSpecified;
            }
            set
            {
                this.taxAmountExciseMST_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public System.Nullable<decimal> TaxAmountVATMST_RU
        {
            get
            {
                return this.taxAmountVATMST_RUField;
            }
            set
            {
                this.taxAmountVATMST_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountVATMST_RUSpecified
        {
            get
            {
                return this.taxAmountVATMST_RUFieldSpecified;
            }
            set
            {
                this.taxAmountVATMST_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
        public System.Nullable<AxdExtType_TaxAutoGenerated> TaxAutogenerated
        {
            get
            {
                return this.taxAutogeneratedField;
            }
            set
            {
                this.taxAutogeneratedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAutogeneratedSpecified
        {
            get
            {
                return this.taxAutogeneratedFieldSpecified;
            }
            set
            {
                this.taxAutogeneratedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public string TaxGroup
        {
            get
            {
                return this.taxGroupField;
            }
            set
            {
                this.taxGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
        public string TaxItemGroup
        {
            get
            {
                return this.taxItemGroupField;
            }
            set
            {
                this.taxItemGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public string TaxWriteCode
        {
            get
            {
                return this.taxWriteCodeField;
            }
            set
            {
                this.taxWriteCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=28)]
        public System.Nullable<System.DateTime> TransDate
        {
            get
            {
                return this.transDateField;
            }
            set
            {
                this.transDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransDateSpecified
        {
            get
            {
                return this.transDateFieldSpecified;
            }
            set
            {
                this.transDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public System.Nullable<long> TransRecId
        {
            get
            {
                return this.transRecIdField;
            }
            set
            {
                this.transRecIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransRecIdSpecified
        {
            get
            {
                return this.transRecIdFieldSpecified;
            }
            set
            {
                this.transRecIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public System.Nullable<int> TransTableId
        {
            get
            {
                return this.transTableIdField;
            }
            set
            {
                this.transTableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransTableIdSpecified
        {
            get
            {
                return this.transTableIdFieldSpecified;
            }
            set
            {
                this.transTableIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public string Txt
        {
            get
            {
                return this.txtField;
            }
            set
            {
                this.txtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
        public System.Nullable<decimal> Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public System.Nullable<AxdEnum_PurchBookVATDocumentType_Invoice_RU> VATDocumentType_RU
        {
            get
            {
                return this.vATDocumentType_RUField;
            }
            set
            {
                this.vATDocumentType_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VATDocumentType_RUSpecified
        {
            get
            {
                return this.vATDocumentType_RUFieldSpecified;
            }
            set
            {
                this.vATDocumentType_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public string Voucher
        {
            get
            {
                return this.voucherField;
            }
            set
            {
                this.voucherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceFindRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceFindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public SalesSalesOrderService.QueryCriteria QueryCriteria;
        
        public SalesOrderServiceFindRequest()
        {
        }
        
        public SalesOrderServiceFindRequest(SalesSalesOrderService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceFindResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceFindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
        public SalesSalesOrderService.AxdSalesOrder SalesOrder;
        
        public SalesOrderServiceFindResponse()
        {
        }
        
        public SalesOrderServiceFindResponse(SalesSalesOrderService.AxdSalesOrder SalesOrder)
        {
            this.SalesOrder = SalesOrder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceCreateRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceCreateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
        public SalesSalesOrderService.AxdSalesOrder SalesOrder;
        
        public SalesOrderServiceCreateRequest()
        {
        }
        
        public SalesOrderServiceCreateRequest(SalesSalesOrderService.AxdSalesOrder SalesOrder)
        {
            this.SalesOrder = SalesOrder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceCreateResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceCreateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesSalesOrderService.EntityKey[] EntityKeyList;
        
        public SalesOrderServiceCreateResponse()
        {
        }
        
        public SalesOrderServiceCreateResponse(SalesSalesOrderService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceReadRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesSalesOrderService.EntityKey[] EntityKeyList;
        
        public SalesOrderServiceReadRequest()
        {
        }
        
        public SalesOrderServiceReadRequest(SalesSalesOrderService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceReadResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
        public SalesSalesOrderService.AxdSalesOrder SalesOrder;
        
        public SalesOrderServiceReadResponse()
        {
        }
        
        public SalesOrderServiceReadResponse(SalesSalesOrderService.AxdSalesOrder SalesOrder)
        {
            this.SalesOrder = SalesOrder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesOrderServiceUpdateRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class SalesOrderServiceUpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesSalesOrderService.EntityKey[] EntityKeyList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
        public SalesSalesOrderService.AxdSalesOrder SalesOrder;
        
        public SalesOrderServiceUpdateRequest()
        {
        }
        
        public SalesOrderServiceUpdateRequest(SalesSalesOrderService.EntityKey[] EntityKeyList, SalesSalesOrderService.AxdSalesOrder SalesOrder)
        {
            this.EntityKeyList = EntityKeyList;
            this.SalesOrder = SalesOrder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateResponse
    {
        
        public updateResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface SalesOrderServiceChannel : SalesSalesOrderService.SalesOrderService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class SalesOrderServiceClient : System.ServiceModel.ClientBase<SalesSalesOrderService.SalesOrderService>, SalesSalesOrderService.SalesOrderService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    ///<param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SalesOrderServiceClient() : 
                base(SalesOrderServiceClient.GetDefaultBinding(), SalesOrderServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_SalesOrderService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesOrderServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SalesOrderServiceClient.GetBindingForEndpoint(endpointConfiguration), SalesOrderServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesOrderServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SalesOrderServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesOrderServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SalesOrderServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesOrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceFindKeysResponse> SalesSalesOrderService.SalesOrderService.findKeysAsync(SalesSalesOrderService.SalesOrderServiceFindKeysRequest request)
        {
            return base.Channel.findKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceFindKeysResponse> findKeysAsync(SalesSalesOrderService.QueryCriteria QueryCriteria)
        {
            SalesSalesOrderService.SalesOrderServiceFindKeysRequest inValue = new SalesSalesOrderService.SalesOrderServiceFindKeysRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((SalesSalesOrderService.SalesOrderService)(this)).findKeysAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesSalesOrderService.deleteResponse> SalesSalesOrderService.SalesOrderService.deleteAsync(SalesSalesOrderService.SalesOrderServiceDeleteRequest request)
        {
            return base.Channel.deleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesSalesOrderService.deleteResponse> deleteAsync(SalesSalesOrderService.EntityKey[] EntityKeyList)
        {
            SalesSalesOrderService.SalesOrderServiceDeleteRequest inValue = new SalesSalesOrderService.SalesOrderServiceDeleteRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((SalesSalesOrderService.SalesOrderService)(this)).deleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceFindResponse> SalesSalesOrderService.SalesOrderService.findAsync(SalesSalesOrderService.SalesOrderServiceFindRequest request)
        {
            return base.Channel.findAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceFindResponse> findAsync(SalesSalesOrderService.QueryCriteria QueryCriteria)
        {
            SalesSalesOrderService.SalesOrderServiceFindRequest inValue = new SalesSalesOrderService.SalesOrderServiceFindRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((SalesSalesOrderService.SalesOrderService)(this)).findAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceCreateResponse> SalesSalesOrderService.SalesOrderService.createAsync(SalesSalesOrderService.SalesOrderServiceCreateRequest request)
        {
            return base.Channel.createAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceCreateResponse> createAsync(SalesSalesOrderService.AxdSalesOrder SalesOrder)
        {
            SalesSalesOrderService.SalesOrderServiceCreateRequest inValue = new SalesSalesOrderService.SalesOrderServiceCreateRequest();
            inValue.SalesOrder = SalesOrder;
            return ((SalesSalesOrderService.SalesOrderService)(this)).createAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceReadResponse> SalesSalesOrderService.SalesOrderService.readAsync(SalesSalesOrderService.SalesOrderServiceReadRequest request)
        {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesSalesOrderService.SalesOrderServiceReadResponse> readAsync(SalesSalesOrderService.EntityKey[] EntityKeyList)
        {
            SalesSalesOrderService.SalesOrderServiceReadRequest inValue = new SalesSalesOrderService.SalesOrderServiceReadRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((SalesSalesOrderService.SalesOrderService)(this)).readAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesSalesOrderService.updateResponse> SalesSalesOrderService.SalesOrderService.updateAsync(SalesSalesOrderService.SalesOrderServiceUpdateRequest request)
        {
            return base.Channel.updateAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesSalesOrderService.updateResponse> updateAsync(SalesSalesOrderService.EntityKey[] EntityKeyList, SalesSalesOrderService.AxdSalesOrder SalesOrder)
        {
            SalesSalesOrderService.SalesOrderServiceUpdateRequest inValue = new SalesSalesOrderService.SalesOrderServiceUpdateRequest();
            inValue.EntityKeyList = EntityKeyList;
            inValue.SalesOrder = SalesOrder;
            return ((SalesSalesOrderService.SalesOrderService)(this)).updateAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_SalesOrderService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_SalesOrderService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/MicrosoftDynamicsAXAif50/salesorderservice.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SalesOrderServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_SalesOrderService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SalesOrderServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_SalesOrderService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_SalesOrderService,
        }
    }
}
