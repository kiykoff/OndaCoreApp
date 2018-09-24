//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace ContactPersonsSrv
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/services", ConfigurationName="ContactPersonsSrv.ContactPersonsService")]
    public interface ContactPersonsService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/find" +
            "Keys", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/find" +
            "KeysResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ContactPersonsSrv.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/find" +
            "KeysAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceFindKeysResponse> findKeysAsync(ContactPersonsSrv.ContactPersonsServiceFindKeysRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/find" +
            "", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/find" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(ContactPersonsSrv.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/find" +
            "AifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceFindResponse> findAsync(ContactPersonsSrv.ContactPersonsServiceFindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/crea" +
            "te", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/crea" +
            "teResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ContactPersonsSrv.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/crea" +
            "teAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceCreateResponse> createAsync(ContactPersonsSrv.ContactPersonsServiceCreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/upda" +
            "te", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/upda" +
            "teResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ContactPersonsSrv.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/upda" +
            "teAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ContactPersonsSrv.updateResponse> updateAsync(ContactPersonsSrv.ContactPersonsServiceUpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/dele" +
            "te", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/dele" +
            "teResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ContactPersonsSrv.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/dele" +
            "teAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ContactPersonsSrv.deleteResponse> deleteAsync(ContactPersonsSrv.ContactPersonsServiceDeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/read" +
            "", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/read" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(ContactPersonsSrv.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ContactPersonsService/read" +
            "AifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceReadResponse> readAsync(ContactPersonsSrv.ContactPersonsServiceReadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceFindKeysRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceFindKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public ContactPersonsSrv.QueryCriteria QueryCriteria;
        
        public ContactPersonsServiceFindKeysRequest()
        {
        }
        
        public ContactPersonsServiceFindKeysRequest(ContactPersonsSrv.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceFindKeysResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceFindKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public ContactPersonsSrv.EntityKey[] EntityKeyList;
        
        public ContactPersonsServiceFindKeysResponse()
        {
        }
        
        public ContactPersonsServiceFindKeysResponse(ContactPersonsSrv.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public partial class AxdContactPersons
    {
        
        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;
        
        private bool docPurposeFieldSpecified;
        
        private string senderIdField;
        
        private AxdEntity_ContactPerson[] contactPersonField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("ContactPerson", Order=2)]
        public AxdEntity_ContactPerson[] ContactPerson
        {
            get
            {
                return this.contactPersonField;
            }
            set
            {
                this.contactPersonField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public partial class AxdEntity_ContactPerson
    {
        
        private string _DocumentHashField;
        
        private string addressField;
        
        private System.Nullable<System.DateTime> anniversaryField;
        
        private bool anniversaryFieldSpecified;
        
        private string assistantNameField;
        
        private string assistantPhoneField;
        
        private string billingInformationField;
        
        private System.Nullable<System.DateTime> birthDateField;
        
        private bool birthDateFieldSpecified;
        
        private string building_RUField;
        
        private string callbackPhoneNumberField;
        
        private string carPhoneNumberField;
        
        private string cellularPhoneField;
        
        private string characterField;
        
        private string childrenNamesField;
        
        private string citizenshipField;
        
        private string cityField;
        
        private string companyNameField;
        
        private string computerNetworkNameField;
        
        private string contactPersonIdField;
        
        private string contactPersonParentIdField;
        
        private string countryRegionIdField;
        
        private string countyField;
        
        private string custAccountField;
        
        private string decisionField;
        
        private string departmentField;
        
        private System.Nullable<AxdExtType_smmContactDirectMail> directMailField;
        
        private bool directMailFieldSpecified;
        
        private string docuGreeting1Field;
        
        private string docuGreeting2Field;
        
        private string docuIntro1Field;
        
        private string docuIntro2Field;
        
        private string emailField;
        
        private string email2Field;
        
        private string email3Field;
        
        private string estate_RUField;
        
        private string firstNameField;
        
        private string flat_RUField;
        
        private string fTPSiteField;
        
        private string functionField;
        
        private System.Nullable<AxdEnum_Gender> genderField;
        
        private bool genderFieldSpecified;
        
        private string governmentIDNumberField;
        
        private string hobbiesField;
        
        private string homeFaxNumberField;
        
        private string homePhoneNumberField;
        
        private string iMAddressField;
        
        private System.Nullable<AxdExtType_smmImported> importedField;
        
        private bool importedFieldSpecified;
        
        private string initialsField;
        
        private string internetFreeBusyAddressField;
        
        private string iSDNNumberField;
        
        private AxdExtType_smmDateTimeLastEdit lastEditAxDateTimeField;
        
        private string lastNameField;
        
        private System.Nullable<AxdExtType_smmLeftCompany> leftCompanyField;
        
        private bool leftCompanyFieldSpecified;
        
        private string loyaltyField;
        
        private string mainresponsibleField;
        
        private System.Nullable<AxdEnum_EmplMaritalStatus> maritalStatusField;
        
        private bool maritalStatusFieldSpecified;
        
        private string memoField;
        
        private string middleNameField;
        
        private string mileageField;
        
        private string nameField;
        
        private string nativeLanguageField;
        
        private string nickNameField;
        
        private string officeLocationField;
        
        private string organizationalIDNumberField;
        
        private string orgPartyIdField;
        
        private string otherFaxNumberField;
        
        private string otherPhoneNumberField;
        
        private string outlookCategoriesField;
        
        private string pagerField;
        
        private string partyIdField;
        
        private string payeeDocument_RUField;
        
        private string personalHomePageField;
        
        private string phoneField;
        
        private string phoneLocalField;
        
        private string primaryPhoneNumberField;
        
        private string professionField;
        
        private string radioPhoneNumberField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<AxdEnum_smmSensitivity> sensitivityField;
        
        private bool sensitivityFieldSpecified;
        
        private string settlementId_RUField;
        
        private string sMSField;
        
        private string socialTitleField;
        
        private string spouseField;
        
        private string stateField;
        
        private string streetField;
        
        private string streetId_RUField;
        
        private string suffixField;
        
        private string telefaxField;
        
        private string telexField;
        
        private System.Nullable<System.DateTime> timeAvailableFromField;
        
        private bool timeAvailableFromFieldSpecified;
        
        private System.Nullable<System.DateTime> timeAvailableToField;
        
        private bool timeAvailableToFieldSpecified;
        
        private string titleField;
        
        private string townId_RUField;
        
        private string tTYTDDPhoneNumberField;
        
        private string uRLField;
        
        private string vendAccountField;
        
        private System.Nullable<AxdExtType_smmContactVIP> vIPField;
        
        private bool vIPFieldSpecified;
        
        private System.Nullable<AxdExtType_WebRequestWebAccess> webRequestAccessField;
        
        private bool webRequestAccessFieldSpecified;
        
        private string zipcodeField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_ContactPerson()
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
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=2)]
        public System.Nullable<System.DateTime> Anniversary
        {
            get
            {
                return this.anniversaryField;
            }
            set
            {
                this.anniversaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnniversarySpecified
        {
            get
            {
                return this.anniversaryFieldSpecified;
            }
            set
            {
                this.anniversaryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string AssistantName
        {
            get
            {
                return this.assistantNameField;
            }
            set
            {
                this.assistantNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string AssistantPhone
        {
            get
            {
                return this.assistantPhoneField;
            }
            set
            {
                this.assistantPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string BillingInformation
        {
            get
            {
                return this.billingInformationField;
            }
            set
            {
                this.billingInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=6)]
        public System.Nullable<System.DateTime> birthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool birthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                this.birthDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string Building_RU
        {
            get
            {
                return this.building_RUField;
            }
            set
            {
                this.building_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public string CallbackPhoneNumber
        {
            get
            {
                return this.callbackPhoneNumberField;
            }
            set
            {
                this.callbackPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string CarPhoneNumber
        {
            get
            {
                return this.carPhoneNumberField;
            }
            set
            {
                this.carPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public string CellularPhone
        {
            get
            {
                return this.cellularPhoneField;
            }
            set
            {
                this.cellularPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string Character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string ChildrenNames
        {
            get
            {
                return this.childrenNamesField;
            }
            set
            {
                this.childrenNamesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string Citizenship
        {
            get
            {
                return this.citizenshipField;
            }
            set
            {
                this.citizenshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public string ComputerNetworkName
        {
            get
            {
                return this.computerNetworkNameField;
            }
            set
            {
                this.computerNetworkNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public string ContactPersonParentId
        {
            get
            {
                return this.contactPersonParentIdField;
            }
            set
            {
                this.contactPersonParentIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public string CountryRegionId
        {
            get
            {
                return this.countryRegionIdField;
            }
            set
            {
                this.countryRegionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public string Decision
        {
            get
            {
                return this.decisionField;
            }
            set
            {
                this.decisionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public string Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
        public System.Nullable<AxdExtType_smmContactDirectMail> DirectMail
        {
            get
            {
                return this.directMailField;
            }
            set
            {
                this.directMailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectMailSpecified
        {
            get
            {
                return this.directMailFieldSpecified;
            }
            set
            {
                this.directMailFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public string DocuGreeting1
        {
            get
            {
                return this.docuGreeting1Field;
            }
            set
            {
                this.docuGreeting1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
        public string DocuGreeting2
        {
            get
            {
                return this.docuGreeting2Field;
            }
            set
            {
                this.docuGreeting2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public string DocuIntro1
        {
            get
            {
                return this.docuIntro1Field;
            }
            set
            {
                this.docuIntro1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
        public string DocuIntro2
        {
            get
            {
                return this.docuIntro2Field;
            }
            set
            {
                this.docuIntro2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public string Email2
        {
            get
            {
                return this.email2Field;
            }
            set
            {
                this.email2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public string Email3
        {
            get
            {
                return this.email3Field;
            }
            set
            {
                this.email3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
        public string Estate_RU
        {
            get
            {
                return this.estate_RUField;
            }
            set
            {
                this.estate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public string Flat_RU
        {
            get
            {
                return this.flat_RUField;
            }
            set
            {
                this.flat_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
        public string FTPSite
        {
            get
            {
                return this.fTPSiteField;
            }
            set
            {
                this.fTPSiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=36)]
        public string Function
        {
            get
            {
                return this.functionField;
            }
            set
            {
                this.functionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
        public System.Nullable<AxdEnum_Gender> Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=38)]
        public string GovernmentIDNumber
        {
            get
            {
                return this.governmentIDNumberField;
            }
            set
            {
                this.governmentIDNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=39)]
        public string Hobbies
        {
            get
            {
                return this.hobbiesField;
            }
            set
            {
                this.hobbiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=40)]
        public string HomeFaxNumber
        {
            get
            {
                return this.homeFaxNumberField;
            }
            set
            {
                this.homeFaxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=41)]
        public string HomePhoneNumber
        {
            get
            {
                return this.homePhoneNumberField;
            }
            set
            {
                this.homePhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=42)]
        public string IMAddress
        {
            get
            {
                return this.iMAddressField;
            }
            set
            {
                this.iMAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=43)]
        public System.Nullable<AxdExtType_smmImported> Imported
        {
            get
            {
                return this.importedField;
            }
            set
            {
                this.importedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImportedSpecified
        {
            get
            {
                return this.importedFieldSpecified;
            }
            set
            {
                this.importedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=44)]
        public string Initials
        {
            get
            {
                return this.initialsField;
            }
            set
            {
                this.initialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=45)]
        public string InternetFreeBusyAddress
        {
            get
            {
                return this.internetFreeBusyAddressField;
            }
            set
            {
                this.internetFreeBusyAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=46)]
        public string ISDNNumber
        {
            get
            {
                return this.iSDNNumberField;
            }
            set
            {
                this.iSDNNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=47)]
        public AxdExtType_smmDateTimeLastEdit LastEditAxDateTime
        {
            get
            {
                return this.lastEditAxDateTimeField;
            }
            set
            {
                this.lastEditAxDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=48)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=49)]
        public System.Nullable<AxdExtType_smmLeftCompany> LeftCompany
        {
            get
            {
                return this.leftCompanyField;
            }
            set
            {
                this.leftCompanyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeftCompanySpecified
        {
            get
            {
                return this.leftCompanyFieldSpecified;
            }
            set
            {
                this.leftCompanyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=50)]
        public string Loyalty
        {
            get
            {
                return this.loyaltyField;
            }
            set
            {
                this.loyaltyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=51)]
        public string Mainresponsible
        {
            get
            {
                return this.mainresponsibleField;
            }
            set
            {
                this.mainresponsibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=52)]
        public System.Nullable<AxdEnum_EmplMaritalStatus> MaritalStatus
        {
            get
            {
                return this.maritalStatusField;
            }
            set
            {
                this.maritalStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaritalStatusSpecified
        {
            get
            {
                return this.maritalStatusFieldSpecified;
            }
            set
            {
                this.maritalStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=53)]
        public string Memo
        {
            get
            {
                return this.memoField;
            }
            set
            {
                this.memoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=54)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=55)]
        public string Mileage
        {
            get
            {
                return this.mileageField;
            }
            set
            {
                this.mileageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=56)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=57)]
        public string NativeLanguage
        {
            get
            {
                return this.nativeLanguageField;
            }
            set
            {
                this.nativeLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=58)]
        public string NickName
        {
            get
            {
                return this.nickNameField;
            }
            set
            {
                this.nickNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=59)]
        public string OfficeLocation
        {
            get
            {
                return this.officeLocationField;
            }
            set
            {
                this.officeLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=60)]
        public string OrganizationalIDNumber
        {
            get
            {
                return this.organizationalIDNumberField;
            }
            set
            {
                this.organizationalIDNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=61)]
        public string OrgPartyId
        {
            get
            {
                return this.orgPartyIdField;
            }
            set
            {
                this.orgPartyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=62)]
        public string OtherFaxNumber
        {
            get
            {
                return this.otherFaxNumberField;
            }
            set
            {
                this.otherFaxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=63)]
        public string OtherPhoneNumber
        {
            get
            {
                return this.otherPhoneNumberField;
            }
            set
            {
                this.otherPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=64)]
        public string OutlookCategories
        {
            get
            {
                return this.outlookCategoriesField;
            }
            set
            {
                this.outlookCategoriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=65)]
        public string Pager
        {
            get
            {
                return this.pagerField;
            }
            set
            {
                this.pagerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=66)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=67)]
        public string PayeeDocument_RU
        {
            get
            {
                return this.payeeDocument_RUField;
            }
            set
            {
                this.payeeDocument_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=68)]
        public string PersonalHomePage
        {
            get
            {
                return this.personalHomePageField;
            }
            set
            {
                this.personalHomePageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=69)]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=70)]
        public string PhoneLocal
        {
            get
            {
                return this.phoneLocalField;
            }
            set
            {
                this.phoneLocalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=71)]
        public string PrimaryPhoneNumber
        {
            get
            {
                return this.primaryPhoneNumberField;
            }
            set
            {
                this.primaryPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=72)]
        public string Profession
        {
            get
            {
                return this.professionField;
            }
            set
            {
                this.professionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=73)]
        public string RadioPhoneNumber
        {
            get
            {
                return this.radioPhoneNumberField;
            }
            set
            {
                this.radioPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=74)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=75)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=76)]
        public System.Nullable<AxdEnum_smmSensitivity> Sensitivity
        {
            get
            {
                return this.sensitivityField;
            }
            set
            {
                this.sensitivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SensitivitySpecified
        {
            get
            {
                return this.sensitivityFieldSpecified;
            }
            set
            {
                this.sensitivityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=77)]
        public string SettlementId_RU
        {
            get
            {
                return this.settlementId_RUField;
            }
            set
            {
                this.settlementId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=78)]
        public string SMS
        {
            get
            {
                return this.sMSField;
            }
            set
            {
                this.sMSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=79)]
        public string SocialTitle
        {
            get
            {
                return this.socialTitleField;
            }
            set
            {
                this.socialTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=80)]
        public string Spouse
        {
            get
            {
                return this.spouseField;
            }
            set
            {
                this.spouseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=81)]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=82)]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=83)]
        public string StreetId_RU
        {
            get
            {
                return this.streetId_RUField;
            }
            set
            {
                this.streetId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=84)]
        public string Suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=85)]
        public string Telefax
        {
            get
            {
                return this.telefaxField;
            }
            set
            {
                this.telefaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=86)]
        public string Telex
        {
            get
            {
                return this.telexField;
            }
            set
            {
                this.telexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", IsNullable=true, Order=87)]
        public System.Nullable<System.DateTime> TimeAvailableFrom
        {
            get
            {
                return this.timeAvailableFromField;
            }
            set
            {
                this.timeAvailableFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeAvailableFromSpecified
        {
            get
            {
                return this.timeAvailableFromFieldSpecified;
            }
            set
            {
                this.timeAvailableFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", IsNullable=true, Order=88)]
        public System.Nullable<System.DateTime> TimeAvailableTo
        {
            get
            {
                return this.timeAvailableToField;
            }
            set
            {
                this.timeAvailableToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeAvailableToSpecified
        {
            get
            {
                return this.timeAvailableToFieldSpecified;
            }
            set
            {
                this.timeAvailableToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=89)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=90)]
        public string TownId_RU
        {
            get
            {
                return this.townId_RUField;
            }
            set
            {
                this.townId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=91)]
        public string TTYTDDPhoneNumber
        {
            get
            {
                return this.tTYTDDPhoneNumberField;
            }
            set
            {
                this.tTYTDDPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=92)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=93)]
        public string VendAccount
        {
            get
            {
                return this.vendAccountField;
            }
            set
            {
                this.vendAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=94)]
        public System.Nullable<AxdExtType_smmContactVIP> VIP
        {
            get
            {
                return this.vIPField;
            }
            set
            {
                this.vIPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VIPSpecified
        {
            get
            {
                return this.vIPFieldSpecified;
            }
            set
            {
                this.vIPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=95)]
        public System.Nullable<AxdExtType_WebRequestWebAccess> WebRequestAccess
        {
            get
            {
                return this.webRequestAccessField;
            }
            set
            {
                this.webRequestAccessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebRequestAccessSpecified
        {
            get
            {
                return this.webRequestAccessFieldSpecified;
            }
            set
            {
                this.webRequestAccessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=96)]
        public string Zipcode
        {
            get
            {
                return this.zipcodeField;
            }
            set
            {
                this.zipcodeField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdExtType_smmContactDirectMail
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdEnum_Gender
    {
        
        /// <remarks/>
        Unknown,
        
        /// <remarks/>
        Male,
        
        /// <remarks/>
        Female,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdExtType_smmImported
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public partial class AxdExtType_smmDateTimeLastEdit : AxdType_DateTime
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AxdExtType_smmDateTimeLastEdit))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public partial class AxdType_DateTime
    {
        
        private System.DateTime localDateTimeField;
        
        private bool localDateTimeFieldSpecified;
        
        private AxdEnum_Timezone timezoneField;
        
        private bool timezoneFieldSpecified;
        
        private System.DateTime valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime localDateTime
        {
            get
            {
                return this.localDateTimeField;
            }
            set
            {
                this.localDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool localDateTimeSpecified
        {
            get
            {
                return this.localDateTimeFieldSpecified;
            }
            set
            {
                this.localDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdEnum_Timezone timezone
        {
            get
            {
                return this.timezoneField;
            }
            set
            {
                this.timezoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timezoneSpecified
        {
            get
            {
                return this.timezoneFieldSpecified;
            }
            set
            {
                this.timezoneFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdEnum_Timezone
    {
        
        /// <remarks/>
        GMTMINUS1200INTERNATIONALDATELINEWEST,
        
        /// <remarks/>
        GMTMINUS1100MIDWAYISLAND_SAMOA,
        
        /// <remarks/>
        GMTMINUS1000HAWAII,
        
        /// <remarks/>
        GMTMINUS0900ALASKA,
        
        /// <remarks/>
        GMTMINUS0800PACIFICTIME,
        
        /// <remarks/>
        GMTMINUS0800TIJUANA_BAJACALIFORNIA,
        
        /// <remarks/>
        GMTMINUS0700ARIZONA,
        
        /// <remarks/>
        GMTMINUS0700MOUNTAINTIME,
        
        /// <remarks/>
        GMTMINUS0700CHIHUAHUA_LAPAZ_MAZATLAN,
        
        /// <remarks/>
        GMTMINUS0600CENTRALAMERICA,
        
        /// <remarks/>
        GMTMINUS0600CENTRALTIME,
        
        /// <remarks/>
        GMTMINUS0600GUADALAJARA_MEXICOCITY,
        
        /// <remarks/>
        GMTMINUS0600SASKATCHEWAN,
        
        /// <remarks/>
        GMTMINUS0500BOGOTA_LIMA_QUITO_RIOBRANCO,
        
        /// <remarks/>
        GMTMINUS0500EASTERNTIME,
        
        /// <remarks/>
        GMTMINUS0500INDIANA,
        
        /// <remarks/>
        GMTMINUS0400ATLANTICTIME,
        
        /// <remarks/>
        GMTMINUS0400LAPAZ,
        
        /// <remarks/>
        GMTMINUS0400MANAUS,
        
        /// <remarks/>
        GMTMINUS0400SANTIAGO,
        
        /// <remarks/>
        GMTMINUS0430CARACAS,
        
        /// <remarks/>
        GMTMINUS0330NEWFOUNDLAND,
        
        /// <remarks/>
        GMTMINUS0300BRASILIA,
        
        /// <remarks/>
        GMTMINUS0300BUENOSAIRES_GEORGETOWN,
        
        /// <remarks/>
        GMTMINUS0300GREENLAND,
        
        /// <remarks/>
        GMTMINUS0300MONTEVIDEO,
        
        /// <remarks/>
        GMTMINUS0200MIDATLANTIC,
        
        /// <remarks/>
        GMTMINUS0100AZORES,
        
        /// <remarks/>
        GMTMINUS0100CAPEVERDIS,
        
        /// <remarks/>
        GMT_CASABLANCA_MONTROVIA_REYKJAVIK,
        
        /// <remarks/>
        GMT_DUBLIN_EDINBURGH_LISBON_LONDON,
        
        /// <remarks/>
        GMTPLUS0100_AMSTERDAM_BERLIN_BERN_ROME,
        
        /// <remarks/>
        GMTPLUS0100BELGRADE_BRATISLAVA_BUDAPEST,
        
        /// <remarks/>
        GMTPLUS0100BRUSSELS_COPENHAGEN_MADRID,
        
        /// <remarks/>
        GMTPLUS0100SARAJEVO_SKOPJE_WARSAW_ZAGREB,
        
        /// <remarks/>
        GMTPLUS0100WESTCENTRALAFRICA,
        
        /// <remarks/>
        GMTPLUS0200AMMAN,
        
        /// <remarks/>
        GMTPLUS0200ATHENS_BUCHAREST_ISTANBUL,
        
        /// <remarks/>
        GMTPLUS0200BEIRUT,
        
        /// <remarks/>
        GMTPLUS0200MINSK,
        
        /// <remarks/>
        GMTPLUS0200CAIRO,
        
        /// <remarks/>
        GMTPLUS0200HARARE_PRETORIA,
        
        /// <remarks/>
        GMTPLUS0200HELSINKI_KYIV_RIGA_VILNIUS,
        
        /// <remarks/>
        GMTPLUS0200JERUSALEM,
        
        /// <remarks/>
        GMTPLUS0200WINDHOEK,
        
        /// <remarks/>
        GMTPLUS0300BAGHDAD,
        
        /// <remarks/>
        GMTPLUS0300KUWAIT_RIYADH,
        
        /// <remarks/>
        GMTPLUS0300MOSCOW_STPETERSBURG_VOLGOGRAD,
        
        /// <remarks/>
        GMTPLUS0300NAIROBI,
        
        /// <remarks/>
        GMTPLUS0300TBILISI,
        
        /// <remarks/>
        GMTPLUS0330TEHRAN,
        
        /// <remarks/>
        GMTPLUS0400ABUDHABI_MUSCAT,
        
        /// <remarks/>
        GMTPLUS0400BAKU,
        
        /// <remarks/>
        GMTPLUS0400CAUCASUSSTANDARDTIME,
        
        /// <remarks/>
        GMTPLUS0400YEREVAN,
        
        /// <remarks/>
        GMTPLUS0430KABUL,
        
        /// <remarks/>
        GMTPLUS0500EKATERINBURG,
        
        /// <remarks/>
        GMTPLUS0500ISLAMABAD_KARACHI_TASHKENT,
        
        /// <remarks/>
        GMTPLUS0530CHENNAI_KOLKATA_MUMBAI,
        
        /// <remarks/>
        GMTPLUS0530SRIJAYAWARDENEPURA,
        
        /// <remarks/>
        GMTPLUS0545KATHMANDU,
        
        /// <remarks/>
        GMTPLUS0600ALMATY_NOVOSIBIRSK,
        
        /// <remarks/>
        GMTPLUS0600ASTANA_DHAKA,
        
        /// <remarks/>
        GMTPLUS0630_YANGON,
        
        /// <remarks/>
        GMTPLUS0700_BANGKOK_HANOI_JAKARTA,
        
        /// <remarks/>
        GMTPLUS0700KRASNOYARSK,
        
        /// <remarks/>
        GMTPLUS0800BEIJING_CHONGQING_HONGKONG,
        
        /// <remarks/>
        GMTPLUS0800IRKUTSK_ULAANBATAAR,
        
        /// <remarks/>
        GMTPLUS0800KUALALUMPUR_SINGAPORE,
        
        /// <remarks/>
        GMTPLUS0800PERTH,
        
        /// <remarks/>
        GMTPLUS0800TAIPEI,
        
        /// <remarks/>
        GMTPLUS0900OSAKA_SAPPORO_TOKYO,
        
        /// <remarks/>
        GMTPLUS0900SEOUL,
        
        /// <remarks/>
        GMTPLUS0900YAKUTSK,
        
        /// <remarks/>
        GMTPLUS0930ADELAIDE,
        
        /// <remarks/>
        GMTPLUS0930DARWIN,
        
        /// <remarks/>
        GMTPLUS1000BRISBANE,
        
        /// <remarks/>
        GMTPLUS1000CANBERRA_MELBOURNE_SYDNEY,
        
        /// <remarks/>
        GMTPLUS1000GUAM_PORTMORESBY,
        
        /// <remarks/>
        GMTPLUS1000HOBART,
        
        /// <remarks/>
        GMTPLUS1000VLADIVOSTOK,
        
        /// <remarks/>
        GMTPLUS1100MAGADAN_SOLOMONIS,
        
        /// <remarks/>
        GMTPLUS1200AUCKLAND_WELLINGTON,
        
        /// <remarks/>
        GMTPLUS1200FIJI_KAMCHATKA_MARSHALLIS,
        
        /// <remarks/>
        GMTPLUS1300NUKU_ALOFA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdExtType_smmLeftCompany
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdEnum_EmplMaritalStatus
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Married,
        
        /// <remarks/>
        Single,
        
        /// <remarks/>
        Widowed,
        
        /// <remarks/>
        Divorced,
        
        /// <remarks/>
        Cohabiting,
        
        /// <remarks/>
        RegisteredPartnership,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdEnum_smmSensitivity
    {
        
        /// <remarks/>
        Normal,
        
        /// <remarks/>
        Personal,
        
        /// <remarks/>
        Privat,
        
        /// <remarks/>
        Confidential,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdExtType_smmContactVIP
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
    public enum AxdExtType_WebRequestWebAccess
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceFindRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceFindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public ContactPersonsSrv.QueryCriteria QueryCriteria;
        
        public ContactPersonsServiceFindRequest()
        {
        }
        
        public ContactPersonsServiceFindRequest(ContactPersonsSrv.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceFindResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceFindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
        public ContactPersonsSrv.AxdContactPersons ContactPersons;
        
        public ContactPersonsServiceFindResponse()
        {
        }
        
        public ContactPersonsServiceFindResponse(ContactPersonsSrv.AxdContactPersons ContactPersons)
        {
            this.ContactPersons = ContactPersons;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceCreateRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceCreateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
        public ContactPersonsSrv.AxdContactPersons ContactPersons;
        
        public ContactPersonsServiceCreateRequest()
        {
        }
        
        public ContactPersonsServiceCreateRequest(ContactPersonsSrv.AxdContactPersons ContactPersons)
        {
            this.ContactPersons = ContactPersons;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceCreateResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceCreateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public ContactPersonsSrv.EntityKey[] EntityKeyList;
        
        public ContactPersonsServiceCreateResponse()
        {
        }
        
        public ContactPersonsServiceCreateResponse(ContactPersonsSrv.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceUpdateRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceUpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public ContactPersonsSrv.EntityKey[] EntityKeyList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
        public ContactPersonsSrv.AxdContactPersons ContactPersons;
        
        public ContactPersonsServiceUpdateRequest()
        {
        }
        
        public ContactPersonsServiceUpdateRequest(ContactPersonsSrv.EntityKey[] EntityKeyList, ContactPersonsSrv.AxdContactPersons ContactPersons)
        {
            this.EntityKeyList = EntityKeyList;
            this.ContactPersons = ContactPersons;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceDeleteRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceDeleteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public ContactPersonsSrv.EntityKey[] EntityKeyList;
        
        public ContactPersonsServiceDeleteRequest()
        {
        }
        
        public ContactPersonsServiceDeleteRequest(ContactPersonsSrv.EntityKey[] EntityKeyList)
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceReadRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public ContactPersonsSrv.EntityKey[] EntityKeyList;
        
        public ContactPersonsServiceReadRequest()
        {
        }
        
        public ContactPersonsServiceReadRequest(ContactPersonsSrv.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContactPersonsServiceReadResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ContactPersonsServiceReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/ContactPersons")]
        public ContactPersonsSrv.AxdContactPersons ContactPersons;
        
        public ContactPersonsServiceReadResponse()
        {
        }
        
        public ContactPersonsServiceReadResponse(ContactPersonsSrv.AxdContactPersons ContactPersons)
        {
            this.ContactPersons = ContactPersons;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ContactPersonsServiceChannel : ContactPersonsSrv.ContactPersonsService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ContactPersonsServiceClient : System.ServiceModel.ClientBase<ContactPersonsSrv.ContactPersonsService>, ContactPersonsSrv.ContactPersonsService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ContactPersonsServiceClient() : 
                base(ContactPersonsServiceClient.GetDefaultBinding(), ContactPersonsServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ContactPersonsService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContactPersonsServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ContactPersonsServiceClient.GetBindingForEndpoint(endpointConfiguration), ContactPersonsServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContactPersonsServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ContactPersonsServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContactPersonsServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ContactPersonsServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContactPersonsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceFindKeysResponse> ContactPersonsSrv.ContactPersonsService.findKeysAsync(ContactPersonsSrv.ContactPersonsServiceFindKeysRequest request)
        {
            return base.Channel.findKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceFindKeysResponse> findKeysAsync(ContactPersonsSrv.QueryCriteria QueryCriteria)
        {
            ContactPersonsSrv.ContactPersonsServiceFindKeysRequest inValue = new ContactPersonsSrv.ContactPersonsServiceFindKeysRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((ContactPersonsSrv.ContactPersonsService)(this)).findKeysAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceFindResponse> ContactPersonsSrv.ContactPersonsService.findAsync(ContactPersonsSrv.ContactPersonsServiceFindRequest request)
        {
            return base.Channel.findAsync(request);
        }
        
        public System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceFindResponse> findAsync(ContactPersonsSrv.QueryCriteria QueryCriteria)
        {
            ContactPersonsSrv.ContactPersonsServiceFindRequest inValue = new ContactPersonsSrv.ContactPersonsServiceFindRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((ContactPersonsSrv.ContactPersonsService)(this)).findAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceCreateResponse> ContactPersonsSrv.ContactPersonsService.createAsync(ContactPersonsSrv.ContactPersonsServiceCreateRequest request)
        {
            return base.Channel.createAsync(request);
        }
        
        public System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceCreateResponse> createAsync(ContactPersonsSrv.AxdContactPersons ContactPersons)
        {
            ContactPersonsSrv.ContactPersonsServiceCreateRequest inValue = new ContactPersonsSrv.ContactPersonsServiceCreateRequest();
            inValue.ContactPersons = ContactPersons;
            return ((ContactPersonsSrv.ContactPersonsService)(this)).createAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ContactPersonsSrv.updateResponse> ContactPersonsSrv.ContactPersonsService.updateAsync(ContactPersonsSrv.ContactPersonsServiceUpdateRequest request)
        {
            return base.Channel.updateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ContactPersonsSrv.updateResponse> updateAsync(ContactPersonsSrv.EntityKey[] EntityKeyList, ContactPersonsSrv.AxdContactPersons ContactPersons)
        {
            ContactPersonsSrv.ContactPersonsServiceUpdateRequest inValue = new ContactPersonsSrv.ContactPersonsServiceUpdateRequest();
            inValue.EntityKeyList = EntityKeyList;
            inValue.ContactPersons = ContactPersons;
            return ((ContactPersonsSrv.ContactPersonsService)(this)).updateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ContactPersonsSrv.deleteResponse> ContactPersonsSrv.ContactPersonsService.deleteAsync(ContactPersonsSrv.ContactPersonsServiceDeleteRequest request)
        {
            return base.Channel.deleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ContactPersonsSrv.deleteResponse> deleteAsync(ContactPersonsSrv.EntityKey[] EntityKeyList)
        {
            ContactPersonsSrv.ContactPersonsServiceDeleteRequest inValue = new ContactPersonsSrv.ContactPersonsServiceDeleteRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((ContactPersonsSrv.ContactPersonsService)(this)).deleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceReadResponse> ContactPersonsSrv.ContactPersonsService.readAsync(ContactPersonsSrv.ContactPersonsServiceReadRequest request)
        {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<ContactPersonsSrv.ContactPersonsServiceReadResponse> readAsync(ContactPersonsSrv.EntityKey[] EntityKeyList)
        {
            ContactPersonsSrv.ContactPersonsServiceReadRequest inValue = new ContactPersonsSrv.ContactPersonsServiceReadRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((ContactPersonsSrv.ContactPersonsService)(this)).readAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ContactPersonsService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ContactPersonsService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/MicrosoftDynamicsAXAif50/contactpersonsservice." +
                        "svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ContactPersonsServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ContactPersonsService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ContactPersonsServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ContactPersonsService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ContactPersonsService,
        }
    }
}
