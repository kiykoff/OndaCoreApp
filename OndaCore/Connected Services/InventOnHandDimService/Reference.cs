//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace InventOnHandDimService
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
    public partial class AxdEntity_InventSum
    {
        
        private string _DocumentHashField;
        
        private System.Nullable<decimal> arrivedField;
        
        private bool arrivedFieldSpecified;
        
        private System.Nullable<decimal> availOrderedField;
        
        private bool availOrderedFieldSpecified;
        
        private System.Nullable<decimal> availPhysicalField;
        
        private bool availPhysicalFieldSpecified;
        
        private System.Nullable<AxdExtType_InventSumClosed> closedField;
        
        private bool closedFieldSpecified;
        
        private System.Nullable<AxdExtType_InventSumClosed> closedQtyField;
        
        private bool closedQtyFieldSpecified;
        
        private System.Nullable<decimal> deductedField;
        
        private bool deductedFieldSpecified;
        
        private string inventDimIdField;
        
        private string itemIdField;
        
        private System.Nullable<System.DateTime> lastUpdDateExpectedField;
        
        private bool lastUpdDateExpectedFieldSpecified;
        
        private System.Nullable<System.DateTime> lastUpdDatePhysicalField;
        
        private bool lastUpdDatePhysicalFieldSpecified;
        
        private System.Nullable<decimal> onOrderField;
        
        private bool onOrderFieldSpecified;
        
        private System.Nullable<decimal> orderedField;
        
        private bool orderedFieldSpecified;
        
        private System.Nullable<decimal> physicalInventField;
        
        private bool physicalInventFieldSpecified;
        
        private System.Nullable<decimal> physicalValueField;
        
        private bool physicalValueFieldSpecified;
        
        private System.Nullable<decimal> pickedField;
        
        private bool pickedFieldSpecified;
        
        private System.Nullable<decimal> postedQtyField;
        
        private bool postedQtyFieldSpecified;
        
        private System.Nullable<decimal> postedValueField;
        
        private bool postedValueFieldSpecified;
        
        private System.Nullable<decimal> quotationIssueField;
        
        private bool quotationIssueFieldSpecified;
        
        private System.Nullable<decimal> quotationReceiptField;
        
        private bool quotationReceiptFieldSpecified;
        
        private System.Nullable<decimal> receivedField;
        
        private bool receivedFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> registeredField;
        
        private bool registeredFieldSpecified;
        
        private System.Nullable<decimal> reservOrderedField;
        
        private bool reservOrderedFieldSpecified;
        
        private System.Nullable<decimal> reservPhysicalField;
        
        private bool reservPhysicalFieldSpecified;
        
        private AxdEntity_InventDim[] inventDimField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventSum()
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
        public System.Nullable<decimal> Arrived
        {
            get
            {
                return this.arrivedField;
            }
            set
            {
                this.arrivedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivedSpecified
        {
            get
            {
                return this.arrivedFieldSpecified;
            }
            set
            {
                this.arrivedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<decimal> AvailOrdered
        {
            get
            {
                return this.availOrderedField;
            }
            set
            {
                this.availOrderedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailOrderedSpecified
        {
            get
            {
                return this.availOrderedFieldSpecified;
            }
            set
            {
                this.availOrderedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<decimal> AvailPhysical
        {
            get
            {
                return this.availPhysicalField;
            }
            set
            {
                this.availPhysicalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailPhysicalSpecified
        {
            get
            {
                return this.availPhysicalFieldSpecified;
            }
            set
            {
                this.availPhysicalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<AxdExtType_InventSumClosed> Closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClosedSpecified
        {
            get
            {
                return this.closedFieldSpecified;
            }
            set
            {
                this.closedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<AxdExtType_InventSumClosed> ClosedQty
        {
            get
            {
                return this.closedQtyField;
            }
            set
            {
                this.closedQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClosedQtySpecified
        {
            get
            {
                return this.closedQtyFieldSpecified;
            }
            set
            {
                this.closedQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<decimal> Deducted
        {
            get
            {
                return this.deductedField;
            }
            set
            {
                this.deductedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeductedSpecified
        {
            get
            {
                return this.deductedFieldSpecified;
            }
            set
            {
                this.deductedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=9)]
        public System.Nullable<System.DateTime> LastUpdDateExpected
        {
            get
            {
                return this.lastUpdDateExpectedField;
            }
            set
            {
                this.lastUpdDateExpectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdDateExpectedSpecified
        {
            get
            {
                return this.lastUpdDateExpectedFieldSpecified;
            }
            set
            {
                this.lastUpdDateExpectedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=10)]
        public System.Nullable<System.DateTime> LastUpdDatePhysical
        {
            get
            {
                return this.lastUpdDatePhysicalField;
            }
            set
            {
                this.lastUpdDatePhysicalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdDatePhysicalSpecified
        {
            get
            {
                return this.lastUpdDatePhysicalFieldSpecified;
            }
            set
            {
                this.lastUpdDatePhysicalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<decimal> OnOrder
        {
            get
            {
                return this.onOrderField;
            }
            set
            {
                this.onOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnOrderSpecified
        {
            get
            {
                return this.onOrderFieldSpecified;
            }
            set
            {
                this.onOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<decimal> Ordered
        {
            get
            {
                return this.orderedField;
            }
            set
            {
                this.orderedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderedSpecified
        {
            get
            {
                return this.orderedFieldSpecified;
            }
            set
            {
                this.orderedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<decimal> PhysicalInvent
        {
            get
            {
                return this.physicalInventField;
            }
            set
            {
                this.physicalInventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhysicalInventSpecified
        {
            get
            {
                return this.physicalInventFieldSpecified;
            }
            set
            {
                this.physicalInventFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<decimal> PhysicalValue
        {
            get
            {
                return this.physicalValueField;
            }
            set
            {
                this.physicalValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhysicalValueSpecified
        {
            get
            {
                return this.physicalValueFieldSpecified;
            }
            set
            {
                this.physicalValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<decimal> Picked
        {
            get
            {
                return this.pickedField;
            }
            set
            {
                this.pickedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PickedSpecified
        {
            get
            {
                return this.pickedFieldSpecified;
            }
            set
            {
                this.pickedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<decimal> PostedQty
        {
            get
            {
                return this.postedQtyField;
            }
            set
            {
                this.postedQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostedQtySpecified
        {
            get
            {
                return this.postedQtyFieldSpecified;
            }
            set
            {
                this.postedQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public System.Nullable<decimal> PostedValue
        {
            get
            {
                return this.postedValueField;
            }
            set
            {
                this.postedValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostedValueSpecified
        {
            get
            {
                return this.postedValueFieldSpecified;
            }
            set
            {
                this.postedValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public System.Nullable<decimal> QuotationIssue
        {
            get
            {
                return this.quotationIssueField;
            }
            set
            {
                this.quotationIssueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotationIssueSpecified
        {
            get
            {
                return this.quotationIssueFieldSpecified;
            }
            set
            {
                this.quotationIssueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public System.Nullable<decimal> QuotationReceipt
        {
            get
            {
                return this.quotationReceiptField;
            }
            set
            {
                this.quotationReceiptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotationReceiptSpecified
        {
            get
            {
                return this.quotationReceiptFieldSpecified;
            }
            set
            {
                this.quotationReceiptFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public System.Nullable<decimal> Received
        {
            get
            {
                return this.receivedField;
            }
            set
            {
                this.receivedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceivedSpecified
        {
            get
            {
                return this.receivedFieldSpecified;
            }
            set
            {
                this.receivedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public System.Nullable<decimal> Registered
        {
            get
            {
                return this.registeredField;
            }
            set
            {
                this.registeredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegisteredSpecified
        {
            get
            {
                return this.registeredFieldSpecified;
            }
            set
            {
                this.registeredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
        public System.Nullable<decimal> ReservOrdered
        {
            get
            {
                return this.reservOrderedField;
            }
            set
            {
                this.reservOrderedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReservOrderedSpecified
        {
            get
            {
                return this.reservOrderedFieldSpecified;
            }
            set
            {
                this.reservOrderedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public System.Nullable<decimal> ReservPhysical
        {
            get
            {
                return this.reservPhysicalField;
            }
            set
            {
                this.reservPhysicalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReservPhysicalSpecified
        {
            get
            {
                return this.reservPhysicalFieldSpecified;
            }
            set
            {
                this.reservPhysicalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventDim", Order=26)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
    public enum AxdExtType_InventSumClosed
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
    public partial class AxdInventOnhandDim
    {
        
        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;
        
        private bool docPurposeFieldSpecified;
        
        private string senderIdField;
        
        private AxdEntity_InventSum[] inventSumField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("InventSum", Order=2)]
        public AxdEntity_InventSum[] InventSum
        {
            get
            {
                return this.inventSumField;
            }
            set
            {
                this.inventSumField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
    public enum AxdEnum_XMLDocPurpose
    {
        
        /// <remarks/>
        Original,
        
        /// <remarks/>
        Duplicate,
        
        /// <remarks/>
        Proforma,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="InventOnHandDimService.InventOnhandDimService")]
    public interface InventOnhandDimService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/create", ReplyAction="http://tempuri.org/InventOnhandDimService/createResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/createAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceCreateResponse> createAsync(InventOnHandDimService.InventOnhandDimServiceCreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/Salam", ReplyAction="http://tempuri.org/InventOnhandDimService/SalamResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/SalamAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceSalamResponse> SalamAsync(InventOnHandDimService.InventOnhandDimServiceSalamRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/update", ReplyAction="http://tempuri.org/InventOnhandDimService/updateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/updateAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.updateResponse> updateAsync(InventOnHandDimService.InventOnhandDimServiceUpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/resultNumber", ReplyAction="http://tempuri.org/InventOnhandDimService/resultNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/resultNumberAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceResultNumberResponse> resultNumberAsync(InventOnHandDimService.InventOnhandDimServiceResultNumberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/find", ReplyAction="http://tempuri.org/InventOnhandDimService/findResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/findAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceFindResponse> findAsync(InventOnHandDimService.InventOnhandDimServiceFindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/read", ReplyAction="http://tempuri.org/InventOnhandDimService/readResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/readAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceReadResponse> readAsync(InventOnHandDimService.InventOnhandDimServiceReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/delete", ReplyAction="http://tempuri.org/InventOnhandDimService/deleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/deleteAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.deleteResponse> deleteAsync(InventOnHandDimService.InventOnhandDimServiceDeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventOnhandDimService/findKeys", ReplyAction="http://tempuri.org/InventOnhandDimService/findKeysResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventOnHandDimService.AifFault), Action="http://tempuri.org/InventOnhandDimService/findKeysAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceFindKeysResponse> findKeysAsync(InventOnHandDimService.InventOnhandDimServiceFindKeysRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceCreateRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceCreateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
        public InventOnHandDimService.AxdInventOnhandDim InventOnhandDim;
        
        public InventOnhandDimServiceCreateRequest()
        {
        }
        
        public InventOnhandDimServiceCreateRequest(InventOnHandDimService.AxdInventOnhandDim InventOnhandDim)
        {
            this.InventOnhandDim = InventOnhandDim;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceCreateResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceCreateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventOnHandDimService.EntityKey[] EntityKeyList;
        
        public InventOnhandDimServiceCreateResponse()
        {
        }
        
        public InventOnhandDimServiceCreateResponse(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceSalamRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceSalamRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventOnHandDimService.EntityKey[] EntityKeyList;
        
        public InventOnhandDimServiceSalamRequest()
        {
        }
        
        public InventOnhandDimServiceSalamRequest(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceSalamResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceSalamResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string response;
        
        public InventOnhandDimServiceSalamResponse()
        {
        }
        
        public InventOnhandDimServiceSalamResponse(string response)
        {
            this.response = response;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceUpdateRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceUpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventOnHandDimService.EntityKey[] EntityKeyList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
        public InventOnHandDimService.AxdInventOnhandDim InventOnhandDim;
        
        public InventOnhandDimServiceUpdateRequest()
        {
        }
        
        public InventOnhandDimServiceUpdateRequest(InventOnHandDimService.EntityKey[] EntityKeyList, InventOnHandDimService.AxdInventOnhandDim InventOnhandDim)
        {
            this.EntityKeyList = EntityKeyList;
            this.InventOnhandDim = InventOnhandDim;
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceResultNumberRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceResultNumberRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventOnHandDimService.EntityKey[] EntityKeyList;
        
        public InventOnhandDimServiceResultNumberRequest()
        {
        }
        
        public InventOnhandDimServiceResultNumberRequest(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceResultNumberResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceResultNumberResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string response;
        
        public InventOnhandDimServiceResultNumberResponse()
        {
        }
        
        public InventOnhandDimServiceResultNumberResponse(string response)
        {
            this.response = response;
        }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceFindRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceFindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public InventOnHandDimService.QueryCriteria QueryCriteria;
        
        public InventOnhandDimServiceFindRequest()
        {
        }
        
        public InventOnhandDimServiceFindRequest(InventOnHandDimService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceFindResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceFindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
        public InventOnHandDimService.AxdInventOnhandDim InventOnhandDim;
        
        public InventOnhandDimServiceFindResponse()
        {
        }
        
        public InventOnhandDimServiceFindResponse(InventOnHandDimService.AxdInventOnhandDim InventOnhandDim)
        {
            this.InventOnhandDim = InventOnhandDim;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceReadRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventOnHandDimService.EntityKey[] EntityKeyList;
        
        public InventOnhandDimServiceReadRequest()
        {
        }
        
        public InventOnhandDimServiceReadRequest(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceReadResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/InventOnhandDim")]
        public InventOnHandDimService.AxdInventOnhandDim InventOnhandDim;
        
        public InventOnhandDimServiceReadResponse()
        {
        }
        
        public InventOnhandDimServiceReadResponse(InventOnHandDimService.AxdInventOnhandDim InventOnhandDim)
        {
            this.InventOnhandDim = InventOnhandDim;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceDeleteRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceDeleteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventOnHandDimService.EntityKey[] EntityKeyList;
        
        public InventOnhandDimServiceDeleteRequest()
        {
        }
        
        public InventOnhandDimServiceDeleteRequest(InventOnHandDimService.EntityKey[] EntityKeyList)
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceFindKeysRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceFindKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public InventOnHandDimService.QueryCriteria QueryCriteria;
        
        public InventOnhandDimServiceFindKeysRequest()
        {
        }
        
        public InventOnhandDimServiceFindKeysRequest(InventOnHandDimService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InventOnhandDimServiceFindKeysResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class InventOnhandDimServiceFindKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventOnHandDimService.EntityKey[] EntityKeyList;
        
        public InventOnhandDimServiceFindKeysResponse()
        {
        }
        
        public InventOnhandDimServiceFindKeysResponse(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface InventOnhandDimServiceChannel : InventOnHandDimService.InventOnhandDimService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class InventOnhandDimServiceClient : System.ServiceModel.ClientBase<InventOnHandDimService.InventOnhandDimService>, InventOnHandDimService.InventOnhandDimService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InventOnhandDimServiceClient() : 
                base(InventOnhandDimServiceClient.GetDefaultBinding(), InventOnhandDimServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_InventOnhandDimService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventOnhandDimServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(InventOnhandDimServiceClient.GetBindingForEndpoint(endpointConfiguration), InventOnhandDimServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventOnhandDimServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InventOnhandDimServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventOnhandDimServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InventOnhandDimServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventOnhandDimServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceCreateResponse> InventOnHandDimService.InventOnhandDimService.createAsync(InventOnHandDimService.InventOnhandDimServiceCreateRequest request)
        {
            return base.Channel.createAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceCreateResponse> createAsync(InventOnHandDimService.AxdInventOnhandDim InventOnhandDim)
        {
            InventOnHandDimService.InventOnhandDimServiceCreateRequest inValue = new InventOnHandDimService.InventOnhandDimServiceCreateRequest();
            inValue.InventOnhandDim = InventOnhandDim;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).createAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceSalamResponse> InventOnHandDimService.InventOnhandDimService.SalamAsync(InventOnHandDimService.InventOnhandDimServiceSalamRequest request)
        {
            return base.Channel.SalamAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceSalamResponse> SalamAsync(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            InventOnHandDimService.InventOnhandDimServiceSalamRequest inValue = new InventOnHandDimService.InventOnhandDimServiceSalamRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).SalamAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.updateResponse> InventOnHandDimService.InventOnhandDimService.updateAsync(InventOnHandDimService.InventOnhandDimServiceUpdateRequest request)
        {
            return base.Channel.updateAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.updateResponse> updateAsync(InventOnHandDimService.EntityKey[] EntityKeyList, InventOnHandDimService.AxdInventOnhandDim InventOnhandDim)
        {
            InventOnHandDimService.InventOnhandDimServiceUpdateRequest inValue = new InventOnHandDimService.InventOnhandDimServiceUpdateRequest();
            inValue.EntityKeyList = EntityKeyList;
            inValue.InventOnhandDim = InventOnhandDim;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).updateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceResultNumberResponse> InventOnHandDimService.InventOnhandDimService.resultNumberAsync(InventOnHandDimService.InventOnhandDimServiceResultNumberRequest request)
        {
            return base.Channel.resultNumberAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceResultNumberResponse> resultNumberAsync(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            InventOnHandDimService.InventOnhandDimServiceResultNumberRequest inValue = new InventOnHandDimService.InventOnhandDimServiceResultNumberRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).resultNumberAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceFindResponse> InventOnHandDimService.InventOnhandDimService.findAsync(InventOnHandDimService.InventOnhandDimServiceFindRequest request)
        {
            return base.Channel.findAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceFindResponse> findAsync(InventOnHandDimService.QueryCriteria QueryCriteria)
        {
            InventOnHandDimService.InventOnhandDimServiceFindRequest inValue = new InventOnHandDimService.InventOnhandDimServiceFindRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).findAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceReadResponse> InventOnHandDimService.InventOnhandDimService.readAsync(InventOnHandDimService.InventOnhandDimServiceReadRequest request)
        {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceReadResponse> readAsync(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            InventOnHandDimService.InventOnhandDimServiceReadRequest inValue = new InventOnHandDimService.InventOnhandDimServiceReadRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).readAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.deleteResponse> InventOnHandDimService.InventOnhandDimService.deleteAsync(InventOnHandDimService.InventOnhandDimServiceDeleteRequest request)
        {
            return base.Channel.deleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.deleteResponse> deleteAsync(InventOnHandDimService.EntityKey[] EntityKeyList)
        {
            InventOnHandDimService.InventOnhandDimServiceDeleteRequest inValue = new InventOnHandDimService.InventOnhandDimServiceDeleteRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).deleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceFindKeysResponse> InventOnHandDimService.InventOnhandDimService.findKeysAsync(InventOnHandDimService.InventOnhandDimServiceFindKeysRequest request)
        {
            return base.Channel.findKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventOnHandDimService.InventOnhandDimServiceFindKeysResponse> findKeysAsync(InventOnHandDimService.QueryCriteria QueryCriteria)
        {
            InventOnHandDimService.InventOnhandDimServiceFindKeysRequest inValue = new InventOnHandDimService.InventOnhandDimServiceFindKeysRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((InventOnHandDimService.InventOnhandDimService)(this)).findKeysAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InventOnhandDimService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InventOnhandDimService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/MicrosoftDynamicsAXAif50/inventonhanddimservice" +
                        ".svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return InventOnhandDimServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_InventOnhandDimService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return InventOnhandDimServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_InventOnhandDimService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_InventOnhandDimService,
        }
    }
}
