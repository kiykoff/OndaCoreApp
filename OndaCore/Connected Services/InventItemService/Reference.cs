//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace InventItemService
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_DefaultInventDimInventSetup
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
        
        public AxdEntity_DefaultInventDimInventSetup()
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventDimInventSetup
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
        
        public AxdEntity_InventDimInventSetup()
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventItemInventSetup
    {
        
        private System.Nullable<AxdExtType_SalesATPInclPlannedOrders> aTPInclPlannedOrdersField;
        
        private bool aTPInclPlannedOrdersFieldSpecified;
        
        private System.Nullable<int> aTPTimeFenceField;
        
        private bool aTPTimeFenceFieldSpecified;
        
        private System.Nullable<AxdExtType_CalendarDays> calendarDaysField;
        
        private bool calendarDaysFieldSpecified;
        
        private System.Nullable<AxdEnum_SalesDeliveryDateControlType> deliveryDateControlTypeField;
        
        private bool deliveryDateControlTypeFieldSpecified;
        
        private System.Nullable<decimal> highestQtyField;
        
        private bool highestQtyFieldSpecified;
        
        private string inventDimIdField;
        
        private string inventDimIdDefaultField;
        
        private string itemIdField;
        
        private System.Nullable<int> leadTimeField;
        
        private bool leadTimeFieldSpecified;
        
        private System.Nullable<decimal> lowestQtyField;
        
        private bool lowestQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> mandatoryInventLocationField;
        
        private bool mandatoryInventLocationFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> mandatoryInventSiteField;
        
        private bool mandatoryInventSiteFieldSpecified;
        
        private System.Nullable<decimal> multipleQtyField;
        
        private bool multipleQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> overrideField;
        
        private bool overrideFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> standardQtyField;
        
        private bool standardQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemStopped> stoppedField;
        
        private bool stoppedFieldSpecified;
        
        private AxdEntity_InventDimInventSetup[] inventDimInventSetupField;
        
        private AxdEntity_DefaultInventDimInventSetup[] defaultInventDimInventSetupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventItemInventSetup()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdExtType_SalesATPInclPlannedOrders> ATPInclPlannedOrders
        {
            get
            {
                return this.aTPInclPlannedOrdersField;
            }
            set
            {
                this.aTPInclPlannedOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ATPInclPlannedOrdersSpecified
        {
            get
            {
                return this.aTPInclPlannedOrdersFieldSpecified;
            }
            set
            {
                this.aTPInclPlannedOrdersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<int> ATPTimeFence
        {
            get
            {
                return this.aTPTimeFenceField;
            }
            set
            {
                this.aTPTimeFenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ATPTimeFenceSpecified
        {
            get
            {
                return this.aTPTimeFenceFieldSpecified;
            }
            set
            {
                this.aTPTimeFenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<AxdExtType_CalendarDays> CalendarDays
        {
            get
            {
                return this.calendarDaysField;
            }
            set
            {
                this.calendarDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalendarDaysSpecified
        {
            get
            {
                return this.calendarDaysFieldSpecified;
            }
            set
            {
                this.calendarDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<decimal> HighestQty
        {
            get
            {
                return this.highestQtyField;
            }
            set
            {
                this.highestQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HighestQtySpecified
        {
            get
            {
                return this.highestQtyFieldSpecified;
            }
            set
            {
                this.highestQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string InventDimIdDefault
        {
            get
            {
                return this.inventDimIdDefaultField;
            }
            set
            {
                this.inventDimIdDefaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<int> LeadTime
        {
            get
            {
                return this.leadTimeField;
            }
            set
            {
                this.leadTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeadTimeSpecified
        {
            get
            {
                return this.leadTimeFieldSpecified;
            }
            set
            {
                this.leadTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<decimal> LowestQty
        {
            get
            {
                return this.lowestQtyField;
            }
            set
            {
                this.lowestQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LowestQtySpecified
        {
            get
            {
                return this.lowestQtyFieldSpecified;
            }
            set
            {
                this.lowestQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<AxdExtType_NoYesId> MandatoryInventLocation
        {
            get
            {
                return this.mandatoryInventLocationField;
            }
            set
            {
                this.mandatoryInventLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MandatoryInventLocationSpecified
        {
            get
            {
                return this.mandatoryInventLocationFieldSpecified;
            }
            set
            {
                this.mandatoryInventLocationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<AxdExtType_NoYesId> MandatoryInventSite
        {
            get
            {
                return this.mandatoryInventSiteField;
            }
            set
            {
                this.mandatoryInventSiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MandatoryInventSiteSpecified
        {
            get
            {
                return this.mandatoryInventSiteFieldSpecified;
            }
            set
            {
                this.mandatoryInventSiteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<decimal> MultipleQty
        {
            get
            {
                return this.multipleQtyField;
            }
            set
            {
                this.multipleQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultipleQtySpecified
        {
            get
            {
                return this.multipleQtyFieldSpecified;
            }
            set
            {
                this.multipleQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<AxdExtType_NoYesId> Override
        {
            get
            {
                return this.overrideField;
            }
            set
            {
                this.overrideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverrideSpecified
        {
            get
            {
                return this.overrideFieldSpecified;
            }
            set
            {
                this.overrideFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<decimal> StandardQty
        {
            get
            {
                return this.standardQtyField;
            }
            set
            {
                this.standardQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StandardQtySpecified
        {
            get
            {
                return this.standardQtyFieldSpecified;
            }
            set
            {
                this.standardQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public System.Nullable<AxdExtType_ItemStopped> Stopped
        {
            get
            {
                return this.stoppedField;
            }
            set
            {
                this.stoppedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StoppedSpecified
        {
            get
            {
                return this.stoppedFieldSpecified;
            }
            set
            {
                this.stoppedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventDimInventSetup", Order=18)]
        public AxdEntity_InventDimInventSetup[] InventDimInventSetup
        {
            get
            {
                return this.inventDimInventSetupField;
            }
            set
            {
                this.inventDimInventSetupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DefaultInventDimInventSetup", Order=19)]
        public AxdEntity_DefaultInventDimInventSetup[] DefaultInventDimInventSetup
        {
            get
            {
                return this.defaultInventDimInventSetupField;
            }
            set
            {
                this.defaultInventDimInventSetupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_SalesATPInclPlannedOrders
    {
        
        /// <remarks/>
        @false,
        
        /// <remarks/>
        @true,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_CalendarDays
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_NoYesId
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemStopped
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_DefaultInventDimPurchSetup
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
        
        public AxdEntity_DefaultInventDimPurchSetup()
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventDimPurchSetup
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
        
        public AxdEntity_InventDimPurchSetup()
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventItemPurchSetup
    {
        
        private System.Nullable<AxdExtType_CalendarDays> calendarDaysField;
        
        private bool calendarDaysFieldSpecified;
        
        private System.Nullable<decimal> highestQtyField;
        
        private bool highestQtyFieldSpecified;
        
        private string inventDimIdField;
        
        private string inventDimIdDefaultField;
        
        private string itemIdField;
        
        private System.Nullable<int> leadTimeField;
        
        private bool leadTimeFieldSpecified;
        
        private System.Nullable<decimal> lowestQtyField;
        
        private bool lowestQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> mandatoryInventLocationField;
        
        private bool mandatoryInventLocationFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> mandatoryInventSiteField;
        
        private bool mandatoryInventSiteFieldSpecified;
        
        private System.Nullable<decimal> multipleQtyField;
        
        private bool multipleQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> overrideField;
        
        private bool overrideFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> standardQtyField;
        
        private bool standardQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemStopped> stoppedField;
        
        private bool stoppedFieldSpecified;
        
        private AxdEntity_InventDimPurchSetup[] inventDimPurchSetupField;
        
        private AxdEntity_DefaultInventDimPurchSetup[] defaultInventDimPurchSetupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventItemPurchSetup()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdExtType_CalendarDays> CalendarDays
        {
            get
            {
                return this.calendarDaysField;
            }
            set
            {
                this.calendarDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalendarDaysSpecified
        {
            get
            {
                return this.calendarDaysFieldSpecified;
            }
            set
            {
                this.calendarDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<decimal> HighestQty
        {
            get
            {
                return this.highestQtyField;
            }
            set
            {
                this.highestQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HighestQtySpecified
        {
            get
            {
                return this.highestQtyFieldSpecified;
            }
            set
            {
                this.highestQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string InventDimIdDefault
        {
            get
            {
                return this.inventDimIdDefaultField;
            }
            set
            {
                this.inventDimIdDefaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<int> LeadTime
        {
            get
            {
                return this.leadTimeField;
            }
            set
            {
                this.leadTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeadTimeSpecified
        {
            get
            {
                return this.leadTimeFieldSpecified;
            }
            set
            {
                this.leadTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<decimal> LowestQty
        {
            get
            {
                return this.lowestQtyField;
            }
            set
            {
                this.lowestQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LowestQtySpecified
        {
            get
            {
                return this.lowestQtyFieldSpecified;
            }
            set
            {
                this.lowestQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<AxdExtType_NoYesId> MandatoryInventLocation
        {
            get
            {
                return this.mandatoryInventLocationField;
            }
            set
            {
                this.mandatoryInventLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MandatoryInventLocationSpecified
        {
            get
            {
                return this.mandatoryInventLocationFieldSpecified;
            }
            set
            {
                this.mandatoryInventLocationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<AxdExtType_NoYesId> MandatoryInventSite
        {
            get
            {
                return this.mandatoryInventSiteField;
            }
            set
            {
                this.mandatoryInventSiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MandatoryInventSiteSpecified
        {
            get
            {
                return this.mandatoryInventSiteFieldSpecified;
            }
            set
            {
                this.mandatoryInventSiteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<decimal> MultipleQty
        {
            get
            {
                return this.multipleQtyField;
            }
            set
            {
                this.multipleQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultipleQtySpecified
        {
            get
            {
                return this.multipleQtyFieldSpecified;
            }
            set
            {
                this.multipleQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<AxdExtType_NoYesId> Override
        {
            get
            {
                return this.overrideField;
            }
            set
            {
                this.overrideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverrideSpecified
        {
            get
            {
                return this.overrideFieldSpecified;
            }
            set
            {
                this.overrideFieldSpecified = value;
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
        public System.Nullable<decimal> StandardQty
        {
            get
            {
                return this.standardQtyField;
            }
            set
            {
                this.standardQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StandardQtySpecified
        {
            get
            {
                return this.standardQtyFieldSpecified;
            }
            set
            {
                this.standardQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<AxdExtType_ItemStopped> Stopped
        {
            get
            {
                return this.stoppedField;
            }
            set
            {
                this.stoppedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StoppedSpecified
        {
            get
            {
                return this.stoppedFieldSpecified;
            }
            set
            {
                this.stoppedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventDimPurchSetup", Order=15)]
        public AxdEntity_InventDimPurchSetup[] InventDimPurchSetup
        {
            get
            {
                return this.inventDimPurchSetupField;
            }
            set
            {
                this.inventDimPurchSetupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DefaultInventDimPurchSetup", Order=16)]
        public AxdEntity_DefaultInventDimPurchSetup[] DefaultInventDimPurchSetup
        {
            get
            {
                return this.defaultInventDimPurchSetupField;
            }
            set
            {
                this.defaultInventDimPurchSetupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_DefaultInventDimSalesSetup
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
        
        public AxdEntity_DefaultInventDimSalesSetup()
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventDimSalesSetup
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
        
        public AxdEntity_InventDimSalesSetup()
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventItemSalesSetup
    {
        
        private System.Nullable<AxdExtType_SalesATPInclPlannedOrders> aTPInclPlannedOrdersField;
        
        private bool aTPInclPlannedOrdersFieldSpecified;
        
        private System.Nullable<int> aTPTimeFenceField;
        
        private bool aTPTimeFenceFieldSpecified;
        
        private System.Nullable<AxdEnum_SalesDeliveryDateControlType> deliveryDateControlTypeField;
        
        private bool deliveryDateControlTypeFieldSpecified;
        
        private System.Nullable<decimal> highestQtyField;
        
        private bool highestQtyFieldSpecified;
        
        private string inventDimIdField;
        
        private string inventDimIdDefaultField;
        
        private string itemIdField;
        
        private System.Nullable<int> leadTimeField;
        
        private bool leadTimeFieldSpecified;
        
        private System.Nullable<decimal> lowestQtyField;
        
        private bool lowestQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> mandatoryInventLocationField;
        
        private bool mandatoryInventLocationFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> mandatoryInventSiteField;
        
        private bool mandatoryInventSiteFieldSpecified;
        
        private System.Nullable<decimal> multipleQtyField;
        
        private bool multipleQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> overrideField;
        
        private bool overrideFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> standardQtyField;
        
        private bool standardQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemStopped> stoppedField;
        
        private bool stoppedFieldSpecified;
        
        private AxdEntity_InventDimSalesSetup[] inventDimSalesSetupField;
        
        private AxdEntity_DefaultInventDimSalesSetup[] defaultInventDimSalesSetupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventItemSalesSetup()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdExtType_SalesATPInclPlannedOrders> ATPInclPlannedOrders
        {
            get
            {
                return this.aTPInclPlannedOrdersField;
            }
            set
            {
                this.aTPInclPlannedOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ATPInclPlannedOrdersSpecified
        {
            get
            {
                return this.aTPInclPlannedOrdersFieldSpecified;
            }
            set
            {
                this.aTPInclPlannedOrdersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<int> ATPTimeFence
        {
            get
            {
                return this.aTPTimeFenceField;
            }
            set
            {
                this.aTPTimeFenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ATPTimeFenceSpecified
        {
            get
            {
                return this.aTPTimeFenceFieldSpecified;
            }
            set
            {
                this.aTPTimeFenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<decimal> HighestQty
        {
            get
            {
                return this.highestQtyField;
            }
            set
            {
                this.highestQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HighestQtySpecified
        {
            get
            {
                return this.highestQtyFieldSpecified;
            }
            set
            {
                this.highestQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string InventDimIdDefault
        {
            get
            {
                return this.inventDimIdDefaultField;
            }
            set
            {
                this.inventDimIdDefaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<int> LeadTime
        {
            get
            {
                return this.leadTimeField;
            }
            set
            {
                this.leadTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeadTimeSpecified
        {
            get
            {
                return this.leadTimeFieldSpecified;
            }
            set
            {
                this.leadTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<decimal> LowestQty
        {
            get
            {
                return this.lowestQtyField;
            }
            set
            {
                this.lowestQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LowestQtySpecified
        {
            get
            {
                return this.lowestQtyFieldSpecified;
            }
            set
            {
                this.lowestQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<AxdExtType_NoYesId> MandatoryInventLocation
        {
            get
            {
                return this.mandatoryInventLocationField;
            }
            set
            {
                this.mandatoryInventLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MandatoryInventLocationSpecified
        {
            get
            {
                return this.mandatoryInventLocationFieldSpecified;
            }
            set
            {
                this.mandatoryInventLocationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<AxdExtType_NoYesId> MandatoryInventSite
        {
            get
            {
                return this.mandatoryInventSiteField;
            }
            set
            {
                this.mandatoryInventSiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MandatoryInventSiteSpecified
        {
            get
            {
                return this.mandatoryInventSiteFieldSpecified;
            }
            set
            {
                this.mandatoryInventSiteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<decimal> MultipleQty
        {
            get
            {
                return this.multipleQtyField;
            }
            set
            {
                this.multipleQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultipleQtySpecified
        {
            get
            {
                return this.multipleQtyFieldSpecified;
            }
            set
            {
                this.multipleQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<AxdExtType_NoYesId> Override
        {
            get
            {
                return this.overrideField;
            }
            set
            {
                this.overrideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverrideSpecified
        {
            get
            {
                return this.overrideFieldSpecified;
            }
            set
            {
                this.overrideFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<decimal> StandardQty
        {
            get
            {
                return this.standardQtyField;
            }
            set
            {
                this.standardQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StandardQtySpecified
        {
            get
            {
                return this.standardQtyFieldSpecified;
            }
            set
            {
                this.standardQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<AxdExtType_ItemStopped> Stopped
        {
            get
            {
                return this.stoppedField;
            }
            set
            {
                this.stoppedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StoppedSpecified
        {
            get
            {
                return this.stoppedFieldSpecified;
            }
            set
            {
                this.stoppedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventDimSalesSetup", Order=17)]
        public AxdEntity_InventDimSalesSetup[] InventDimSalesSetup
        {
            get
            {
                return this.inventDimSalesSetupField;
            }
            set
            {
                this.inventDimSalesSetupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DefaultInventDimSalesSetup", Order=18)]
        public AxdEntity_DefaultInventDimSalesSetup[] DefaultInventDimSalesSetup
        {
            get
            {
                return this.defaultInventDimSalesSetupField;
            }
            set
            {
                this.defaultInventDimSalesSetupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventTableDocuRef
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
        
        public AxdEntity_InventTableDocuRef()
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_DocuRestriction
    {
        
        /// <remarks/>
        Internal,
        
        /// <remarks/>
        External,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventTxt
    {
        
        private string inventDimIdField;
        
        private string itemIdField;
        
        private string languageIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string txtField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventTxt()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventItemLocation
    {
        
        private string countGroupIdField;
        
        private string countingJournalIdField;
        
        private System.Nullable<AxdExtType_InventCountingStarted> countingStartedField;
        
        private bool countingStartedFieldSpecified;
        
        private string inventDimIdField;
        
        private string itemIdField;
        
        private System.Nullable<decimal> pickingLocationMaxQtyField;
        
        private bool pickingLocationMaxQtyFieldSpecified;
        
        private System.Nullable<decimal> pickingLocationRefillMinField;
        
        private bool pickingLocationRefillMinFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<AxdEnum_InventInventLocationNo> useEmptyPalletLocationField;
        
        private bool useEmptyPalletLocationFieldSpecified;
        
        private System.Nullable<AxdEnum_InventInventLocationNoYes> useWMSOrderField;
        
        private bool useWMSOrderFieldSpecified;
        
        private string wMSLocationIdDefaultIssueField;
        
        private string wMSLocationIdDefaultReceiptField;
        
        private string wMSPickingLocationField;
        
        private string wMSStoreZoneIdField;
        
        private AxdEntity_InventDim[] inventDimField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventItemLocation()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string CountGroupId
        {
            get
            {
                return this.countGroupIdField;
            }
            set
            {
                this.countGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string CountingJournalId
        {
            get
            {
                return this.countingJournalIdField;
            }
            set
            {
                this.countingJournalIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<AxdExtType_InventCountingStarted> CountingStarted
        {
            get
            {
                return this.countingStartedField;
            }
            set
            {
                this.countingStartedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountingStartedSpecified
        {
            get
            {
                return this.countingStartedFieldSpecified;
            }
            set
            {
                this.countingStartedFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<decimal> PickingLocationMaxQty
        {
            get
            {
                return this.pickingLocationMaxQtyField;
            }
            set
            {
                this.pickingLocationMaxQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PickingLocationMaxQtySpecified
        {
            get
            {
                return this.pickingLocationMaxQtyFieldSpecified;
            }
            set
            {
                this.pickingLocationMaxQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<decimal> pickingLocationRefillMin
        {
            get
            {
                return this.pickingLocationRefillMinField;
            }
            set
            {
                this.pickingLocationRefillMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pickingLocationRefillMinSpecified
        {
            get
            {
                return this.pickingLocationRefillMinFieldSpecified;
            }
            set
            {
                this.pickingLocationRefillMinFieldSpecified = value;
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
        public System.Nullable<AxdEnum_InventInventLocationNo> UseEmptyPalletLocation
        {
            get
            {
                return this.useEmptyPalletLocationField;
            }
            set
            {
                this.useEmptyPalletLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UseEmptyPalletLocationSpecified
        {
            get
            {
                return this.useEmptyPalletLocationFieldSpecified;
            }
            set
            {
                this.useEmptyPalletLocationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<AxdEnum_InventInventLocationNoYes> useWMSOrder
        {
            get
            {
                return this.useWMSOrderField;
            }
            set
            {
                this.useWMSOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useWMSOrderSpecified
        {
            get
            {
                return this.useWMSOrderFieldSpecified;
            }
            set
            {
                this.useWMSOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string WMSLocationIdDefaultIssue
        {
            get
            {
                return this.wMSLocationIdDefaultIssueField;
            }
            set
            {
                this.wMSLocationIdDefaultIssueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string WMSLocationIdDefaultReceipt
        {
            get
            {
                return this.wMSLocationIdDefaultReceiptField;
            }
            set
            {
                this.wMSLocationIdDefaultReceiptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string wMSPickingLocation
        {
            get
            {
                return this.wMSPickingLocationField;
            }
            set
            {
                this.wMSPickingLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public string wMSStoreZoneId
        {
            get
            {
                return this.wMSStoreZoneIdField;
            }
            set
            {
                this.wMSStoreZoneIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventDim", Order=15)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_InventCountingStarted
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_InventInventLocationNo
    {
        
        /// <remarks/>
        InventLocation,
        
        /// <remarks/>
        No,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_InventInventLocationNoYes
    {
        
        /// <remarks/>
        InventLocation,
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_Invent
    {
        
        private System.Nullable<AxdExtType_PriceAllocateMarkup> allocateMarkupField;
        
        private bool allocateMarkupFieldSpecified;
        
        private System.Nullable<AxdEnum_NoYes> endDiscField;
        
        private bool endDiscFieldSpecified;
        
        private System.Nullable<AxdExtType_InterCompanyBlocked> interCompanyBlockedField;
        
        private bool interCompanyBlockedFieldSpecified;
        
        private string itemIdField;
        
        private string lineDiscField;
        
        private System.Nullable<decimal> markupField;
        
        private bool markupFieldSpecified;
        
        private string markupGroupIdField;
        
        private System.Nullable<decimal> markupSecCur_RUField;
        
        private bool markupSecCur_RUFieldSpecified;
        
        private System.Nullable<AxdEnum_ModuleInventPurchSales> moduleTypeField;
        
        private bool moduleTypeFieldSpecified;
        
        private string multiLineDiscField;
        
        private System.Nullable<decimal> overDeliveryPctField;
        
        private bool overDeliveryPctFieldSpecified;
        
        private System.Nullable<decimal> pcsPriceField;
        
        private bool pcsPriceFieldSpecified;
        
        private System.Nullable<decimal> priceField;
        
        private bool priceFieldSpecified;
        
        private System.Nullable<System.DateTime> priceDateField;
        
        private bool priceDateFieldSpecified;
        
        private System.Nullable<decimal> priceQtyField;
        
        private bool priceQtyFieldSpecified;
        
        private System.Nullable<decimal> priceSecCur_RUField;
        
        private bool priceSecCur_RUFieldSpecified;
        
        private System.Nullable<decimal> priceUnitField;
        
        private bool priceUnitFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string suppItemGroupIdField;
        
        private string taxItemGroupIdField;
        
        private System.Nullable<decimal> underDeliveryPctField;
        
        private bool underDeliveryPctFieldSpecified;
        
        private string unitIdField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_Invent()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdExtType_PriceAllocateMarkup> AllocateMarkup
        {
            get
            {
                return this.allocateMarkupField;
            }
            set
            {
                this.allocateMarkupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllocateMarkupSpecified
        {
            get
            {
                return this.allocateMarkupFieldSpecified;
            }
            set
            {
                this.allocateMarkupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<AxdEnum_NoYes> EndDisc
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDiscSpecified
        {
            get
            {
                return this.endDiscFieldSpecified;
            }
            set
            {
                this.endDiscFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<AxdExtType_InterCompanyBlocked> InterCompanyBlocked
        {
            get
            {
                return this.interCompanyBlockedField;
            }
            set
            {
                this.interCompanyBlockedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyBlockedSpecified
        {
            get
            {
                return this.interCompanyBlockedFieldSpecified;
            }
            set
            {
                this.interCompanyBlockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<decimal> Markup
        {
            get
            {
                return this.markupField;
            }
            set
            {
                this.markupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupSpecified
        {
            get
            {
                return this.markupFieldSpecified;
            }
            set
            {
                this.markupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string MarkupGroupId
        {
            get
            {
                return this.markupGroupIdField;
            }
            set
            {
                this.markupGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<decimal> MarkupSecCur_RU
        {
            get
            {
                return this.markupSecCur_RUField;
            }
            set
            {
                this.markupSecCur_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupSecCur_RUSpecified
        {
            get
            {
                return this.markupSecCur_RUFieldSpecified;
            }
            set
            {
                this.markupSecCur_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<AxdEnum_ModuleInventPurchSales> ModuleType
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<decimal> PcsPrice
        {
            get
            {
                return this.pcsPriceField;
            }
            set
            {
                this.pcsPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PcsPriceSpecified
        {
            get
            {
                return this.pcsPriceFieldSpecified;
            }
            set
            {
                this.pcsPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<decimal> Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=13)]
        public System.Nullable<System.DateTime> PriceDate
        {
            get
            {
                return this.priceDateField;
            }
            set
            {
                this.priceDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceDateSpecified
        {
            get
            {
                return this.priceDateFieldSpecified;
            }
            set
            {
                this.priceDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<decimal> PriceQty
        {
            get
            {
                return this.priceQtyField;
            }
            set
            {
                this.priceQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceQtySpecified
        {
            get
            {
                return this.priceQtyFieldSpecified;
            }
            set
            {
                this.priceQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<decimal> PriceSecCur_RU
        {
            get
            {
                return this.priceSecCur_RUField;
            }
            set
            {
                this.priceSecCur_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSecCur_RUSpecified
        {
            get
            {
                return this.priceSecCur_RUFieldSpecified;
            }
            set
            {
                this.priceSecCur_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public string SuppItemGroupId
        {
            get
            {
                return this.suppItemGroupIdField;
            }
            set
            {
                this.suppItemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public string TaxItemGroupId
        {
            get
            {
                return this.taxItemGroupIdField;
            }
            set
            {
                this.taxItemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public string UnitId
        {
            get
            {
                return this.unitIdField;
            }
            set
            {
                this.unitIdField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_PriceAllocateMarkup
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_NoYes
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_InterCompanyBlocked
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_ModuleInventPurchSales
    {
        
        /// <remarks/>
        Invent,
        
        /// <remarks/>
        Purch,
        
        /// <remarks/>
        Sales,
        
        /// <remarks/>
        DEL_SmmQuotation,
        
        /// <remarks/>
        DEL_Invent2,
        
        /// <remarks/>
        DEL_Invent3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_Purch
    {
        
        private System.Nullable<AxdExtType_PriceAllocateMarkup> allocateMarkupField;
        
        private bool allocateMarkupFieldSpecified;
        
        private System.Nullable<AxdEnum_NoYes> endDiscField;
        
        private bool endDiscFieldSpecified;
        
        private System.Nullable<AxdExtType_InterCompanyBlocked> interCompanyBlockedField;
        
        private bool interCompanyBlockedFieldSpecified;
        
        private string itemIdField;
        
        private string lineDiscField;
        
        private System.Nullable<decimal> markupField;
        
        private bool markupFieldSpecified;
        
        private string markupGroupIdField;
        
        private System.Nullable<decimal> markupSecCur_RUField;
        
        private bool markupSecCur_RUFieldSpecified;
        
        private System.Nullable<AxdEnum_ModuleInventPurchSales> moduleTypeField;
        
        private bool moduleTypeFieldSpecified;
        
        private string multiLineDiscField;
        
        private System.Nullable<decimal> overDeliveryPctField;
        
        private bool overDeliveryPctFieldSpecified;
        
        private System.Nullable<decimal> pcsPriceField;
        
        private bool pcsPriceFieldSpecified;
        
        private System.Nullable<decimal> priceField;
        
        private bool priceFieldSpecified;
        
        private System.Nullable<System.DateTime> priceDateField;
        
        private bool priceDateFieldSpecified;
        
        private System.Nullable<decimal> priceQtyField;
        
        private bool priceQtyFieldSpecified;
        
        private System.Nullable<decimal> priceSecCur_RUField;
        
        private bool priceSecCur_RUFieldSpecified;
        
        private System.Nullable<decimal> priceUnitField;
        
        private bool priceUnitFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string suppItemGroupIdField;
        
        private string taxItemGroupIdField;
        
        private System.Nullable<decimal> underDeliveryPctField;
        
        private bool underDeliveryPctFieldSpecified;
        
        private string unitIdField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_Purch()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdExtType_PriceAllocateMarkup> AllocateMarkup
        {
            get
            {
                return this.allocateMarkupField;
            }
            set
            {
                this.allocateMarkupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllocateMarkupSpecified
        {
            get
            {
                return this.allocateMarkupFieldSpecified;
            }
            set
            {
                this.allocateMarkupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<AxdEnum_NoYes> EndDisc
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDiscSpecified
        {
            get
            {
                return this.endDiscFieldSpecified;
            }
            set
            {
                this.endDiscFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<AxdExtType_InterCompanyBlocked> InterCompanyBlocked
        {
            get
            {
                return this.interCompanyBlockedField;
            }
            set
            {
                this.interCompanyBlockedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyBlockedSpecified
        {
            get
            {
                return this.interCompanyBlockedFieldSpecified;
            }
            set
            {
                this.interCompanyBlockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<decimal> Markup
        {
            get
            {
                return this.markupField;
            }
            set
            {
                this.markupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupSpecified
        {
            get
            {
                return this.markupFieldSpecified;
            }
            set
            {
                this.markupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string MarkupGroupId
        {
            get
            {
                return this.markupGroupIdField;
            }
            set
            {
                this.markupGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<decimal> MarkupSecCur_RU
        {
            get
            {
                return this.markupSecCur_RUField;
            }
            set
            {
                this.markupSecCur_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupSecCur_RUSpecified
        {
            get
            {
                return this.markupSecCur_RUFieldSpecified;
            }
            set
            {
                this.markupSecCur_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<AxdEnum_ModuleInventPurchSales> ModuleType
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<decimal> PcsPrice
        {
            get
            {
                return this.pcsPriceField;
            }
            set
            {
                this.pcsPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PcsPriceSpecified
        {
            get
            {
                return this.pcsPriceFieldSpecified;
            }
            set
            {
                this.pcsPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<decimal> Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=13)]
        public System.Nullable<System.DateTime> PriceDate
        {
            get
            {
                return this.priceDateField;
            }
            set
            {
                this.priceDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceDateSpecified
        {
            get
            {
                return this.priceDateFieldSpecified;
            }
            set
            {
                this.priceDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<decimal> PriceQty
        {
            get
            {
                return this.priceQtyField;
            }
            set
            {
                this.priceQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceQtySpecified
        {
            get
            {
                return this.priceQtyFieldSpecified;
            }
            set
            {
                this.priceQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<decimal> PriceSecCur_RU
        {
            get
            {
                return this.priceSecCur_RUField;
            }
            set
            {
                this.priceSecCur_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSecCur_RUSpecified
        {
            get
            {
                return this.priceSecCur_RUFieldSpecified;
            }
            set
            {
                this.priceSecCur_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public string SuppItemGroupId
        {
            get
            {
                return this.suppItemGroupIdField;
            }
            set
            {
                this.suppItemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public string TaxItemGroupId
        {
            get
            {
                return this.taxItemGroupIdField;
            }
            set
            {
                this.taxItemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public string UnitId
        {
            get
            {
                return this.unitIdField;
            }
            set
            {
                this.unitIdField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_Sales
    {
        
        private System.Nullable<AxdExtType_PriceAllocateMarkup> allocateMarkupField;
        
        private bool allocateMarkupFieldSpecified;
        
        private System.Nullable<AxdEnum_NoYes> endDiscField;
        
        private bool endDiscFieldSpecified;
        
        private System.Nullable<AxdExtType_InterCompanyBlocked> interCompanyBlockedField;
        
        private bool interCompanyBlockedFieldSpecified;
        
        private string itemIdField;
        
        private string lineDiscField;
        
        private System.Nullable<decimal> markupField;
        
        private bool markupFieldSpecified;
        
        private string markupGroupIdField;
        
        private System.Nullable<decimal> markupSecCur_RUField;
        
        private bool markupSecCur_RUFieldSpecified;
        
        private System.Nullable<AxdEnum_ModuleInventPurchSales> moduleTypeField;
        
        private bool moduleTypeFieldSpecified;
        
        private string multiLineDiscField;
        
        private System.Nullable<decimal> overDeliveryPctField;
        
        private bool overDeliveryPctFieldSpecified;
        
        private System.Nullable<decimal> pcsPriceField;
        
        private bool pcsPriceFieldSpecified;
        
        private System.Nullable<decimal> priceField;
        
        private bool priceFieldSpecified;
        
        private System.Nullable<System.DateTime> priceDateField;
        
        private bool priceDateFieldSpecified;
        
        private System.Nullable<decimal> priceQtyField;
        
        private bool priceQtyFieldSpecified;
        
        private System.Nullable<decimal> priceSecCur_RUField;
        
        private bool priceSecCur_RUFieldSpecified;
        
        private System.Nullable<decimal> priceUnitField;
        
        private bool priceUnitFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string suppItemGroupIdField;
        
        private string taxItemGroupIdField;
        
        private System.Nullable<decimal> underDeliveryPctField;
        
        private bool underDeliveryPctFieldSpecified;
        
        private string unitIdField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_Sales()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdExtType_PriceAllocateMarkup> AllocateMarkup
        {
            get
            {
                return this.allocateMarkupField;
            }
            set
            {
                this.allocateMarkupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllocateMarkupSpecified
        {
            get
            {
                return this.allocateMarkupFieldSpecified;
            }
            set
            {
                this.allocateMarkupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<AxdEnum_NoYes> EndDisc
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDiscSpecified
        {
            get
            {
                return this.endDiscFieldSpecified;
            }
            set
            {
                this.endDiscFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<AxdExtType_InterCompanyBlocked> InterCompanyBlocked
        {
            get
            {
                return this.interCompanyBlockedField;
            }
            set
            {
                this.interCompanyBlockedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterCompanyBlockedSpecified
        {
            get
            {
                return this.interCompanyBlockedFieldSpecified;
            }
            set
            {
                this.interCompanyBlockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<decimal> Markup
        {
            get
            {
                return this.markupField;
            }
            set
            {
                this.markupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupSpecified
        {
            get
            {
                return this.markupFieldSpecified;
            }
            set
            {
                this.markupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string MarkupGroupId
        {
            get
            {
                return this.markupGroupIdField;
            }
            set
            {
                this.markupGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public System.Nullable<decimal> MarkupSecCur_RU
        {
            get
            {
                return this.markupSecCur_RUField;
            }
            set
            {
                this.markupSecCur_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupSecCur_RUSpecified
        {
            get
            {
                return this.markupSecCur_RUFieldSpecified;
            }
            set
            {
                this.markupSecCur_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<AxdEnum_ModuleInventPurchSales> ModuleType
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<decimal> PcsPrice
        {
            get
            {
                return this.pcsPriceField;
            }
            set
            {
                this.pcsPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PcsPriceSpecified
        {
            get
            {
                return this.pcsPriceFieldSpecified;
            }
            set
            {
                this.pcsPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<decimal> Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=13)]
        public System.Nullable<System.DateTime> PriceDate
        {
            get
            {
                return this.priceDateField;
            }
            set
            {
                this.priceDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceDateSpecified
        {
            get
            {
                return this.priceDateFieldSpecified;
            }
            set
            {
                this.priceDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<decimal> PriceQty
        {
            get
            {
                return this.priceQtyField;
            }
            set
            {
                this.priceQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceQtySpecified
        {
            get
            {
                return this.priceQtyFieldSpecified;
            }
            set
            {
                this.priceQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<decimal> PriceSecCur_RU
        {
            get
            {
                return this.priceSecCur_RUField;
            }
            set
            {
                this.priceSecCur_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSecCur_RUSpecified
        {
            get
            {
                return this.priceSecCur_RUFieldSpecified;
            }
            set
            {
                this.priceSecCur_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public string SuppItemGroupId
        {
            get
            {
                return this.suppItemGroupIdField;
            }
            set
            {
                this.suppItemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public string TaxItemGroupId
        {
            get
            {
                return this.taxItemGroupIdField;
            }
            set
            {
                this.taxItemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public string UnitId
        {
            get
            {
                return this.unitIdField;
            }
            set
            {
                this.unitIdField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdEntity_InventTable
    {
        
        private string _DocumentHashField;
        
        private System.Nullable<AxdEnum_ABC> aBCContributionMarginField;
        
        private bool aBCContributionMarginFieldSpecified;
        
        private System.Nullable<AxdEnum_ABC> aBCRevenueField;
        
        private bool aBCRevenueFieldSpecified;
        
        private System.Nullable<AxdEnum_ABC> aBCTieUpField;
        
        private bool aBCTieUpFieldSpecified;
        
        private System.Nullable<AxdEnum_ABC> aBCValueField;
        
        private bool aBCValueFieldSpecified;
        
        private string altConfigIdField;
        
        private string altInventColorIdField;
        
        private string altInventSizeIdField;
        
        private string altItemIdField;
        
        private string assetGroupId_RUField;
        
        private string assetId_RUField;
        
        private System.Nullable<AxdExtType_ItemAutoReportFinished> autoReportFinishedField;
        
        private bool autoReportFinishedFieldSpecified;
        
        private string batchNumGroupIdField;
        
        private string bOMCalcGroupIdField;
        
        private System.Nullable<int> bOMLevelField;
        
        private bool bOMLevelFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemBOMManualReceipt> bOMManualReceiptField;
        
        private bool bOMManualReceiptFieldSpecified;
        
        private string bOMUnitIdField;
        
        private string commissionGroupIdField;
        
        private System.Nullable<AxdExtType_ItemConfigSimilar> configSimilarField;
        
        private bool configSimilarFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemConfigurable> configurableField;
        
        private bool configurableFieldSpecified;
        
        private string costGroupIdField;
        
        private System.Nullable<AxdExtType_ItemCostModel> costModelField;
        
        private bool costModelFieldSpecified;
        
        private System.Nullable<decimal> densityField;
        
        private bool densityFieldSpecified;
        
        private System.Nullable<decimal> depthField;
        
        private bool depthFieldSpecified;
        
        private string[] dimensionField;
        
        private string dimGroupIdField;
        
        private System.Nullable<decimal> ePCManagerField;
        
        private bool ePCManagerFieldSpecified;
        
        private System.Nullable<AxdExtType_InventFiscalLIFOAvoidCalc> fiscalLIFOAvoidCalcField;
        
        private bool fiscalLIFOAvoidCalcFieldSpecified;
        
        private string fiscalLIFOGroupField;
        
        private System.Nullable<decimal> fiscalLIFONormalValueField;
        
        private bool fiscalLIFONormalValueFieldSpecified;
        
        private System.Nullable<AxdEnum_InventFiscalLIFONormalValueCalc> fiscalLIFONormalValueCalcField;
        
        private bool fiscalLIFONormalValueCalcFieldSpecified;
        
        private System.Nullable<AxdExtType_ForecastDMPInclude> forecastDMPIncludeField;
        
        private bool forecastDMPIncludeFieldSpecified;
        
        private System.Nullable<decimal> grossDepthField;
        
        private bool grossDepthFieldSpecified;
        
        private System.Nullable<decimal> grossHeightField;
        
        private bool grossHeightFieldSpecified;
        
        private System.Nullable<decimal> grossWidthField;
        
        private bool grossWidthFieldSpecified;
        
        private System.Nullable<decimal> heightField;
        
        private bool heightFieldSpecified;
        
        private string intracodeField;
        
        private System.Nullable<decimal> intrastatWeight_CZField;
        
        private bool intrastatWeight_CZFieldSpecified;
        
        private System.Nullable<decimal> intraUnitField;
        
        private bool intraUnitFieldSpecified;
        
        private string itemBuyerGroupIdField;
        
        private string itemCollectionIdField;
        
        private string itemDepartmentIdField;
        
        private System.Nullable<AxdExtType_ItemDimCombinationAutoCreate> itemDimCombinationAutoCreateField;
        
        private bool itemDimCombinationAutoCreateFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemDimCostPrice> itemDimCostPriceField;
        
        private bool itemDimCostPriceFieldSpecified;
        
        private string itemGroupIdField;
        
        private string itemIdField;
        
        private string itemIdCompanyField;
        
        private string itemMaterialTypeIdField;
        
        private string itemNameField;
        
        private string itemPriceToleranceGroupIdField;
        
        private string itemProducerIdField;
        
        private System.Nullable<AxdEnum_RFIDItemTaggingLevel> itemTaggingLevelField;
        
        private bool itemTaggingLevelFieldSpecified;
        
        private System.Nullable<AxdEnum_ItemType> itemTypeField;
        
        private bool itemTypeFieldSpecified;
        
        private string itemViewIdField;
        
        private string markupCode_RUField;
        
        private System.Nullable<decimal> minimumPalletQuantityField;
        
        private bool minimumPalletQuantityFieldSpecified;
        
        private string modelGroupIdField;
        
        private string nameAliasField;
        
        private System.Nullable<decimal> netWeightField;
        
        private bool netWeightFieldSpecified;
        
        private System.Nullable<int> nGPCode_FRField;
        
        private bool nGPCode_FRFieldSpecified;
        
        private string origCountryRegionIdField;
        
        private string origStateIdField;
        
        private string packagingGroupIdField;
        
        private string packing_RUField;
        
        private System.Nullable<AxdExtType_RFIDPalletTagging> palletTaggingField;
        
        private bool palletTaggingFieldSpecified;
        
        private System.Nullable<AxdExtType_PBAAutostart> pBAAutoStartField;
        
        private bool pBAAutoStartFieldSpecified;
        
        private System.Nullable<AxdExtType_PBAHideApproval> pBAHideApprovalField;
        
        private bool pBAHideApprovalFieldSpecified;
        
        private System.Nullable<AxdExtType_PBAHideDialog> pBAHideDialogField;
        
        private bool pBAHideDialogFieldSpecified;
        
        private string pBAInventItemGroupIdField;
        
        private System.Nullable<AxdExtType_PBAItemAutoGenerated> pBAItemAutoGeneratedField;
        
        private bool pBAItemAutoGeneratedFieldSpecified;
        
        private System.Nullable<AxdEnum_NoYes> pBAItemConfigurableField;
        
        private bool pBAItemConfigurableFieldSpecified;
        
        private System.Nullable<AxdExtType_PBAMandatoryConfig> pBAMandatoryConfigField;
        
        private bool pBAMandatoryConfigFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemPhantom> phantomField;
        
        private bool phantomFieldSpecified;
        
        private string primaryVendorIdField;
        
        private System.Nullable<AxdEnum_ProdFlushingPrincipItem> prodFlushingPrincipField;
        
        private bool prodFlushingPrincipFieldSpecified;
        
        private string prodGroupIdField;
        
        private string prodPoolIdField;
        
        private string projCategoryIdField;
        
        private string propertyIdField;
        
        private System.Nullable<AxdExtType_ItemPurchModel> purchModelField;
        
        private bool purchModelFieldSpecified;
        
        private System.Nullable<decimal> qtyPerLayerField;
        
        private bool qtyPerLayerFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string reqGroupIdField;
        
        private System.Nullable<decimal> salesContributionRatioField;
        
        private bool salesContributionRatioFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemSalesModel> salesModelField;
        
        private bool salesModelFieldSpecified;
        
        private System.Nullable<decimal> salesPercentMarkupField;
        
        private bool salesPercentMarkupFieldSpecified;
        
        private System.Nullable<AxdEnum_SalesPriceModelBasic> salesPriceModelBasicField;
        
        private bool salesPriceModelBasicFieldSpecified;
        
        private string salesTypeIdField;
        
        private System.Nullable<decimal> scrapConstField;
        
        private bool scrapConstFieldSpecified;
        
        private System.Nullable<decimal> scrapVarField;
        
        private bool scrapVarFieldSpecified;
        
        private string serialNumGroupIdField;
        
        private System.Nullable<int> sortCodeField;
        
        private bool sortCodeFieldSpecified;
        
        private string standardConfigIdField;
        
        private string standardInventColorIdField;
        
        private string standardInventSizeIdField;
        
        private System.Nullable<decimal> standardPalletQuantityField;
        
        private bool standardPalletQuantityFieldSpecified;
        
        private System.Nullable<decimal> statisticsFactorField;
        
        private bool statisticsFactorFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemStopExplode> stopExplodeField;
        
        private bool stopExplodeFieldSpecified;
        
        private System.Nullable<decimal> taraWeightField;
        
        private bool taraWeightFieldSpecified;
        
        private System.Nullable<decimal> taxPackagingQtyField;
        
        private bool taxPackagingQtyFieldSpecified;
        
        private System.Nullable<decimal> unitVolumeField;
        
        private bool unitVolumeFieldSpecified;
        
        private System.Nullable<AxdExtType_ItemUseAlternative> useAltItemIdField;
        
        private bool useAltItemIdFieldSpecified;
        
        private System.Nullable<decimal> widthField;
        
        private bool widthFieldSpecified;
        
        private System.Nullable<System.DateTime> wMSArrivalHandlingTimeField;
        
        private bool wMSArrivalHandlingTimeFieldSpecified;
        
        private string wMSPalletTypeIdField;
        
        private System.Nullable<System.DateTime> wMSPickingQtyTimeField;
        
        private bool wMSPickingQtyTimeFieldSpecified;
        
        private AxdEntity_Sales[] salesField;
        
        private AxdEntity_Purch[] purchField;
        
        private AxdEntity_Invent[] inventField;
        
        private AxdEntity_InventItemLocation[] inventItemLocationField;
        
        private AxdEntity_InventTxt[] inventTxtField;
        
        private AxdEntity_InventTableDocuRef[] inventTableDocuRefField;
        
        private AxdEntity_InventItemSalesSetup[] inventItemSalesSetupField;
        
        private AxdEntity_InventItemPurchSetup[] inventItemPurchSetupField;
        
        private AxdEntity_InventItemInventSetup[] inventItemInventSetupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_InventTable()
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
        public System.Nullable<AxdEnum_ABC> ABCContributionMargin
        {
            get
            {
                return this.aBCContributionMarginField;
            }
            set
            {
                this.aBCContributionMarginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ABCContributionMarginSpecified
        {
            get
            {
                return this.aBCContributionMarginFieldSpecified;
            }
            set
            {
                this.aBCContributionMarginFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<AxdEnum_ABC> ABCRevenue
        {
            get
            {
                return this.aBCRevenueField;
            }
            set
            {
                this.aBCRevenueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ABCRevenueSpecified
        {
            get
            {
                return this.aBCRevenueFieldSpecified;
            }
            set
            {
                this.aBCRevenueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<AxdEnum_ABC> ABCTieUp
        {
            get
            {
                return this.aBCTieUpField;
            }
            set
            {
                this.aBCTieUpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ABCTieUpSpecified
        {
            get
            {
                return this.aBCTieUpFieldSpecified;
            }
            set
            {
                this.aBCTieUpFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<AxdEnum_ABC> ABCValue
        {
            get
            {
                return this.aBCValueField;
            }
            set
            {
                this.aBCValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ABCValueSpecified
        {
            get
            {
                return this.aBCValueFieldSpecified;
            }
            set
            {
                this.aBCValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string AltConfigId
        {
            get
            {
                return this.altConfigIdField;
            }
            set
            {
                this.altConfigIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string AltInventColorId
        {
            get
            {
                return this.altInventColorIdField;
            }
            set
            {
                this.altInventColorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string AltInventSizeId
        {
            get
            {
                return this.altInventSizeIdField;
            }
            set
            {
                this.altInventSizeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public string AltItemId
        {
            get
            {
                return this.altItemIdField;
            }
            set
            {
                this.altItemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string AssetGroupId_RU
        {
            get
            {
                return this.assetGroupId_RUField;
            }
            set
            {
                this.assetGroupId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<AxdExtType_ItemAutoReportFinished> AutoReportFinished
        {
            get
            {
                return this.autoReportFinishedField;
            }
            set
            {
                this.autoReportFinishedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoReportFinishedSpecified
        {
            get
            {
                return this.autoReportFinishedFieldSpecified;
            }
            set
            {
                this.autoReportFinishedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string BatchNumGroupId
        {
            get
            {
                return this.batchNumGroupIdField;
            }
            set
            {
                this.batchNumGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string BOMCalcGroupId
        {
            get
            {
                return this.bOMCalcGroupIdField;
            }
            set
            {
                this.bOMCalcGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<int> BOMLevel
        {
            get
            {
                return this.bOMLevelField;
            }
            set
            {
                this.bOMLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BOMLevelSpecified
        {
            get
            {
                return this.bOMLevelFieldSpecified;
            }
            set
            {
                this.bOMLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<AxdExtType_ItemBOMManualReceipt> BOMManualReceipt
        {
            get
            {
                return this.bOMManualReceiptField;
            }
            set
            {
                this.bOMManualReceiptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BOMManualReceiptSpecified
        {
            get
            {
                return this.bOMManualReceiptFieldSpecified;
            }
            set
            {
                this.bOMManualReceiptFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public string BOMUnitId
        {
            get
            {
                return this.bOMUnitIdField;
            }
            set
            {
                this.bOMUnitIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public string CommissionGroupId
        {
            get
            {
                return this.commissionGroupIdField;
            }
            set
            {
                this.commissionGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public System.Nullable<AxdExtType_ItemConfigSimilar> ConfigSimilar
        {
            get
            {
                return this.configSimilarField;
            }
            set
            {
                this.configSimilarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfigSimilarSpecified
        {
            get
            {
                return this.configSimilarFieldSpecified;
            }
            set
            {
                this.configSimilarFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public System.Nullable<AxdExtType_ItemConfigurable> Configurable
        {
            get
            {
                return this.configurableField;
            }
            set
            {
                this.configurableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfigurableSpecified
        {
            get
            {
                return this.configurableFieldSpecified;
            }
            set
            {
                this.configurableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public string CostGroupId
        {
            get
            {
                return this.costGroupIdField;
            }
            set
            {
                this.costGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
        public System.Nullable<AxdExtType_ItemCostModel> CostModel
        {
            get
            {
                return this.costModelField;
            }
            set
            {
                this.costModelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CostModelSpecified
        {
            get
            {
                return this.costModelFieldSpecified;
            }
            set
            {
                this.costModelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public System.Nullable<decimal> Density
        {
            get
            {
                return this.densityField;
            }
            set
            {
                this.densityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DensitySpecified
        {
            get
            {
                return this.densityFieldSpecified;
            }
            set
            {
                this.densityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public System.Nullable<decimal> Depth
        {
            get
            {
                return this.depthField;
            }
            set
            {
                this.depthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepthSpecified
        {
            get
            {
                return this.depthFieldSpecified;
            }
            set
            {
                this.depthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=24)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string DimGroupId
        {
            get
            {
                return this.dimGroupIdField;
            }
            set
            {
                this.dimGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
        public System.Nullable<decimal> EPCManager
        {
            get
            {
                return this.ePCManagerField;
            }
            set
            {
                this.ePCManagerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EPCManagerSpecified
        {
            get
            {
                return this.ePCManagerFieldSpecified;
            }
            set
            {
                this.ePCManagerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public System.Nullable<AxdExtType_InventFiscalLIFOAvoidCalc> FiscalLIFOAvoidCalc
        {
            get
            {
                return this.fiscalLIFOAvoidCalcField;
            }
            set
            {
                this.fiscalLIFOAvoidCalcField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FiscalLIFOAvoidCalcSpecified
        {
            get
            {
                return this.fiscalLIFOAvoidCalcFieldSpecified;
            }
            set
            {
                this.fiscalLIFOAvoidCalcFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
        public string FiscalLIFOGroup
        {
            get
            {
                return this.fiscalLIFOGroupField;
            }
            set
            {
                this.fiscalLIFOGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public System.Nullable<decimal> FiscalLIFONormalValue
        {
            get
            {
                return this.fiscalLIFONormalValueField;
            }
            set
            {
                this.fiscalLIFONormalValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FiscalLIFONormalValueSpecified
        {
            get
            {
                return this.fiscalLIFONormalValueFieldSpecified;
            }
            set
            {
                this.fiscalLIFONormalValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public System.Nullable<AxdEnum_InventFiscalLIFONormalValueCalc> FiscalLIFONormalValueCalc
        {
            get
            {
                return this.fiscalLIFONormalValueCalcField;
            }
            set
            {
                this.fiscalLIFONormalValueCalcField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FiscalLIFONormalValueCalcSpecified
        {
            get
            {
                return this.fiscalLIFONormalValueCalcFieldSpecified;
            }
            set
            {
                this.fiscalLIFONormalValueCalcFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public System.Nullable<AxdExtType_ForecastDMPInclude> ForecastDMPInclude
        {
            get
            {
                return this.forecastDMPIncludeField;
            }
            set
            {
                this.forecastDMPIncludeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForecastDMPIncludeSpecified
        {
            get
            {
                return this.forecastDMPIncludeFieldSpecified;
            }
            set
            {
                this.forecastDMPIncludeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
        public System.Nullable<decimal> grossDepth
        {
            get
            {
                return this.grossDepthField;
            }
            set
            {
                this.grossDepthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossDepthSpecified
        {
            get
            {
                return this.grossDepthFieldSpecified;
            }
            set
            {
                this.grossDepthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public System.Nullable<decimal> grossHeight
        {
            get
            {
                return this.grossHeightField;
            }
            set
            {
                this.grossHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossHeightSpecified
        {
            get
            {
                return this.grossHeightFieldSpecified;
            }
            set
            {
                this.grossHeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public System.Nullable<decimal> grossWidth
        {
            get
            {
                return this.grossWidthField;
            }
            set
            {
                this.grossWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossWidthSpecified
        {
            get
            {
                return this.grossWidthFieldSpecified;
            }
            set
            {
                this.grossWidthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
        public System.Nullable<decimal> Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=36)]
        public string Intracode
        {
            get
            {
                return this.intracodeField;
            }
            set
            {
                this.intracodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
        public System.Nullable<decimal> IntrastatWeight_CZ
        {
            get
            {
                return this.intrastatWeight_CZField;
            }
            set
            {
                this.intrastatWeight_CZField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntrastatWeight_CZSpecified
        {
            get
            {
                return this.intrastatWeight_CZFieldSpecified;
            }
            set
            {
                this.intrastatWeight_CZFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=38)]
        public System.Nullable<decimal> IntraUnit
        {
            get
            {
                return this.intraUnitField;
            }
            set
            {
                this.intraUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntraUnitSpecified
        {
            get
            {
                return this.intraUnitFieldSpecified;
            }
            set
            {
                this.intraUnitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=39)]
        public string ItemBuyerGroupId
        {
            get
            {
                return this.itemBuyerGroupIdField;
            }
            set
            {
                this.itemBuyerGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=40)]
        public string ItemCollectionId
        {
            get
            {
                return this.itemCollectionIdField;
            }
            set
            {
                this.itemCollectionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=41)]
        public string ItemDepartmentId
        {
            get
            {
                return this.itemDepartmentIdField;
            }
            set
            {
                this.itemDepartmentIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=42)]
        public System.Nullable<AxdExtType_ItemDimCombinationAutoCreate> ItemDimCombinationAutoCreate
        {
            get
            {
                return this.itemDimCombinationAutoCreateField;
            }
            set
            {
                this.itemDimCombinationAutoCreateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemDimCombinationAutoCreateSpecified
        {
            get
            {
                return this.itemDimCombinationAutoCreateFieldSpecified;
            }
            set
            {
                this.itemDimCombinationAutoCreateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=43)]
        public System.Nullable<AxdExtType_ItemDimCostPrice> ItemDimCostPrice
        {
            get
            {
                return this.itemDimCostPriceField;
            }
            set
            {
                this.itemDimCostPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemDimCostPriceSpecified
        {
            get
            {
                return this.itemDimCostPriceFieldSpecified;
            }
            set
            {
                this.itemDimCostPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=44)]
        public string ItemGroupId
        {
            get
            {
                return this.itemGroupIdField;
            }
            set
            {
                this.itemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=45)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=46)]
        public string ItemIdCompany
        {
            get
            {
                return this.itemIdCompanyField;
            }
            set
            {
                this.itemIdCompanyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=47)]
        public string ItemMaterialTypeId
        {
            get
            {
                return this.itemMaterialTypeIdField;
            }
            set
            {
                this.itemMaterialTypeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=48)]
        public string ItemName
        {
            get
            {
                return this.itemNameField;
            }
            set
            {
                this.itemNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=49)]
        public string ItemPriceToleranceGroupId
        {
            get
            {
                return this.itemPriceToleranceGroupIdField;
            }
            set
            {
                this.itemPriceToleranceGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=50)]
        public string ItemProducerId
        {
            get
            {
                return this.itemProducerIdField;
            }
            set
            {
                this.itemProducerIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=51)]
        public System.Nullable<AxdEnum_RFIDItemTaggingLevel> ItemTaggingLevel
        {
            get
            {
                return this.itemTaggingLevelField;
            }
            set
            {
                this.itemTaggingLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemTaggingLevelSpecified
        {
            get
            {
                return this.itemTaggingLevelFieldSpecified;
            }
            set
            {
                this.itemTaggingLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=52)]
        public System.Nullable<AxdEnum_ItemType> ItemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemTypeSpecified
        {
            get
            {
                return this.itemTypeFieldSpecified;
            }
            set
            {
                this.itemTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=53)]
        public string ItemViewId
        {
            get
            {
                return this.itemViewIdField;
            }
            set
            {
                this.itemViewIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=54)]
        public string MarkupCode_RU
        {
            get
            {
                return this.markupCode_RUField;
            }
            set
            {
                this.markupCode_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=55)]
        public System.Nullable<decimal> MinimumPalletQuantity
        {
            get
            {
                return this.minimumPalletQuantityField;
            }
            set
            {
                this.minimumPalletQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumPalletQuantitySpecified
        {
            get
            {
                return this.minimumPalletQuantityFieldSpecified;
            }
            set
            {
                this.minimumPalletQuantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=56)]
        public string ModelGroupId
        {
            get
            {
                return this.modelGroupIdField;
            }
            set
            {
                this.modelGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=57)]
        public string NameAlias
        {
            get
            {
                return this.nameAliasField;
            }
            set
            {
                this.nameAliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=58)]
        public System.Nullable<decimal> NetWeight
        {
            get
            {
                return this.netWeightField;
            }
            set
            {
                this.netWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NetWeightSpecified
        {
            get
            {
                return this.netWeightFieldSpecified;
            }
            set
            {
                this.netWeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=59)]
        public System.Nullable<int> NGPCode_FR
        {
            get
            {
                return this.nGPCode_FRField;
            }
            set
            {
                this.nGPCode_FRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NGPCode_FRSpecified
        {
            get
            {
                return this.nGPCode_FRFieldSpecified;
            }
            set
            {
                this.nGPCode_FRFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=60)]
        public string OrigCountryRegionId
        {
            get
            {
                return this.origCountryRegionIdField;
            }
            set
            {
                this.origCountryRegionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=61)]
        public string OrigStateId
        {
            get
            {
                return this.origStateIdField;
            }
            set
            {
                this.origStateIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=62)]
        public string PackagingGroupId
        {
            get
            {
                return this.packagingGroupIdField;
            }
            set
            {
                this.packagingGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=63)]
        public string Packing_RU
        {
            get
            {
                return this.packing_RUField;
            }
            set
            {
                this.packing_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=64)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=65)]
        public System.Nullable<AxdExtType_PBAAutostart> PBAAutoStart
        {
            get
            {
                return this.pBAAutoStartField;
            }
            set
            {
                this.pBAAutoStartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PBAAutoStartSpecified
        {
            get
            {
                return this.pBAAutoStartFieldSpecified;
            }
            set
            {
                this.pBAAutoStartFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=66)]
        public System.Nullable<AxdExtType_PBAHideApproval> PBAHideApproval
        {
            get
            {
                return this.pBAHideApprovalField;
            }
            set
            {
                this.pBAHideApprovalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PBAHideApprovalSpecified
        {
            get
            {
                return this.pBAHideApprovalFieldSpecified;
            }
            set
            {
                this.pBAHideApprovalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=67)]
        public System.Nullable<AxdExtType_PBAHideDialog> PBAHideDialog
        {
            get
            {
                return this.pBAHideDialogField;
            }
            set
            {
                this.pBAHideDialogField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PBAHideDialogSpecified
        {
            get
            {
                return this.pBAHideDialogFieldSpecified;
            }
            set
            {
                this.pBAHideDialogFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=68)]
        public string PBAInventItemGroupId
        {
            get
            {
                return this.pBAInventItemGroupIdField;
            }
            set
            {
                this.pBAInventItemGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=69)]
        public System.Nullable<AxdExtType_PBAItemAutoGenerated> PBAItemAutoGenerated
        {
            get
            {
                return this.pBAItemAutoGeneratedField;
            }
            set
            {
                this.pBAItemAutoGeneratedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PBAItemAutoGeneratedSpecified
        {
            get
            {
                return this.pBAItemAutoGeneratedFieldSpecified;
            }
            set
            {
                this.pBAItemAutoGeneratedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=70)]
        public System.Nullable<AxdEnum_NoYes> PBAItemConfigurable
        {
            get
            {
                return this.pBAItemConfigurableField;
            }
            set
            {
                this.pBAItemConfigurableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PBAItemConfigurableSpecified
        {
            get
            {
                return this.pBAItemConfigurableFieldSpecified;
            }
            set
            {
                this.pBAItemConfigurableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=71)]
        public System.Nullable<AxdExtType_PBAMandatoryConfig> PBAMandatoryConfig
        {
            get
            {
                return this.pBAMandatoryConfigField;
            }
            set
            {
                this.pBAMandatoryConfigField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PBAMandatoryConfigSpecified
        {
            get
            {
                return this.pBAMandatoryConfigFieldSpecified;
            }
            set
            {
                this.pBAMandatoryConfigFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=72)]
        public System.Nullable<AxdExtType_ItemPhantom> Phantom
        {
            get
            {
                return this.phantomField;
            }
            set
            {
                this.phantomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhantomSpecified
        {
            get
            {
                return this.phantomFieldSpecified;
            }
            set
            {
                this.phantomFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=73)]
        public string PrimaryVendorId
        {
            get
            {
                return this.primaryVendorIdField;
            }
            set
            {
                this.primaryVendorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=74)]
        public System.Nullable<AxdEnum_ProdFlushingPrincipItem> ProdFlushingPrincip
        {
            get
            {
                return this.prodFlushingPrincipField;
            }
            set
            {
                this.prodFlushingPrincipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProdFlushingPrincipSpecified
        {
            get
            {
                return this.prodFlushingPrincipFieldSpecified;
            }
            set
            {
                this.prodFlushingPrincipFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=75)]
        public string ProdGroupId
        {
            get
            {
                return this.prodGroupIdField;
            }
            set
            {
                this.prodGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=76)]
        public string ProdPoolId
        {
            get
            {
                return this.prodPoolIdField;
            }
            set
            {
                this.prodPoolIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=77)]
        public string projCategoryId
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=78)]
        public string PropertyId
        {
            get
            {
                return this.propertyIdField;
            }
            set
            {
                this.propertyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=79)]
        public System.Nullable<AxdExtType_ItemPurchModel> PurchModel
        {
            get
            {
                return this.purchModelField;
            }
            set
            {
                this.purchModelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurchModelSpecified
        {
            get
            {
                return this.purchModelFieldSpecified;
            }
            set
            {
                this.purchModelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=80)]
        public System.Nullable<decimal> qtyPerLayer
        {
            get
            {
                return this.qtyPerLayerField;
            }
            set
            {
                this.qtyPerLayerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtyPerLayerSpecified
        {
            get
            {
                return this.qtyPerLayerFieldSpecified;
            }
            set
            {
                this.qtyPerLayerFieldSpecified = value;
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
        public string ReqGroupId
        {
            get
            {
                return this.reqGroupIdField;
            }
            set
            {
                this.reqGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=84)]
        public System.Nullable<decimal> SalesContributionRatio
        {
            get
            {
                return this.salesContributionRatioField;
            }
            set
            {
                this.salesContributionRatioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesContributionRatioSpecified
        {
            get
            {
                return this.salesContributionRatioFieldSpecified;
            }
            set
            {
                this.salesContributionRatioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=85)]
        public System.Nullable<AxdExtType_ItemSalesModel> SalesModel
        {
            get
            {
                return this.salesModelField;
            }
            set
            {
                this.salesModelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesModelSpecified
        {
            get
            {
                return this.salesModelFieldSpecified;
            }
            set
            {
                this.salesModelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=86)]
        public System.Nullable<decimal> SalesPercentMarkup
        {
            get
            {
                return this.salesPercentMarkupField;
            }
            set
            {
                this.salesPercentMarkupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesPercentMarkupSpecified
        {
            get
            {
                return this.salesPercentMarkupFieldSpecified;
            }
            set
            {
                this.salesPercentMarkupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=87)]
        public System.Nullable<AxdEnum_SalesPriceModelBasic> SalesPriceModelBasic
        {
            get
            {
                return this.salesPriceModelBasicField;
            }
            set
            {
                this.salesPriceModelBasicField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesPriceModelBasicSpecified
        {
            get
            {
                return this.salesPriceModelBasicFieldSpecified;
            }
            set
            {
                this.salesPriceModelBasicFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=88)]
        public string SalesTypeId
        {
            get
            {
                return this.salesTypeIdField;
            }
            set
            {
                this.salesTypeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=89)]
        public System.Nullable<decimal> ScrapConst
        {
            get
            {
                return this.scrapConstField;
            }
            set
            {
                this.scrapConstField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScrapConstSpecified
        {
            get
            {
                return this.scrapConstFieldSpecified;
            }
            set
            {
                this.scrapConstFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=90)]
        public System.Nullable<decimal> ScrapVar
        {
            get
            {
                return this.scrapVarField;
            }
            set
            {
                this.scrapVarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScrapVarSpecified
        {
            get
            {
                return this.scrapVarFieldSpecified;
            }
            set
            {
                this.scrapVarFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=91)]
        public string SerialNumGroupId
        {
            get
            {
                return this.serialNumGroupIdField;
            }
            set
            {
                this.serialNumGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=92)]
        public System.Nullable<int> sortCode
        {
            get
            {
                return this.sortCodeField;
            }
            set
            {
                this.sortCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sortCodeSpecified
        {
            get
            {
                return this.sortCodeFieldSpecified;
            }
            set
            {
                this.sortCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=93)]
        public string StandardConfigId
        {
            get
            {
                return this.standardConfigIdField;
            }
            set
            {
                this.standardConfigIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=94)]
        public string StandardInventColorId
        {
            get
            {
                return this.standardInventColorIdField;
            }
            set
            {
                this.standardInventColorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=95)]
        public string StandardInventSizeId
        {
            get
            {
                return this.standardInventSizeIdField;
            }
            set
            {
                this.standardInventSizeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=96)]
        public System.Nullable<decimal> standardPalletQuantity
        {
            get
            {
                return this.standardPalletQuantityField;
            }
            set
            {
                this.standardPalletQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool standardPalletQuantitySpecified
        {
            get
            {
                return this.standardPalletQuantityFieldSpecified;
            }
            set
            {
                this.standardPalletQuantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=97)]
        public System.Nullable<decimal> StatisticsFactor
        {
            get
            {
                return this.statisticsFactorField;
            }
            set
            {
                this.statisticsFactorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatisticsFactorSpecified
        {
            get
            {
                return this.statisticsFactorFieldSpecified;
            }
            set
            {
                this.statisticsFactorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=98)]
        public System.Nullable<AxdExtType_ItemStopExplode> StopExplode
        {
            get
            {
                return this.stopExplodeField;
            }
            set
            {
                this.stopExplodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StopExplodeSpecified
        {
            get
            {
                return this.stopExplodeFieldSpecified;
            }
            set
            {
                this.stopExplodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=99)]
        public System.Nullable<decimal> TaraWeight
        {
            get
            {
                return this.taraWeightField;
            }
            set
            {
                this.taraWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaraWeightSpecified
        {
            get
            {
                return this.taraWeightFieldSpecified;
            }
            set
            {
                this.taraWeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=100)]
        public System.Nullable<decimal> TaxPackagingQty
        {
            get
            {
                return this.taxPackagingQtyField;
            }
            set
            {
                this.taxPackagingQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxPackagingQtySpecified
        {
            get
            {
                return this.taxPackagingQtyFieldSpecified;
            }
            set
            {
                this.taxPackagingQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=101)]
        public System.Nullable<decimal> UnitVolume
        {
            get
            {
                return this.unitVolumeField;
            }
            set
            {
                this.unitVolumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitVolumeSpecified
        {
            get
            {
                return this.unitVolumeFieldSpecified;
            }
            set
            {
                this.unitVolumeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=102)]
        public System.Nullable<AxdExtType_ItemUseAlternative> UseAltItemId
        {
            get
            {
                return this.useAltItemIdField;
            }
            set
            {
                this.useAltItemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UseAltItemIdSpecified
        {
            get
            {
                return this.useAltItemIdFieldSpecified;
            }
            set
            {
                this.useAltItemIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=103)]
        public System.Nullable<decimal> Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WidthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", IsNullable=true, Order=104)]
        public System.Nullable<System.DateTime> WMSArrivalHandlingTime
        {
            get
            {
                return this.wMSArrivalHandlingTimeField;
            }
            set
            {
                this.wMSArrivalHandlingTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WMSArrivalHandlingTimeSpecified
        {
            get
            {
                return this.wMSArrivalHandlingTimeFieldSpecified;
            }
            set
            {
                this.wMSArrivalHandlingTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=105)]
        public string WMSPalletTypeId
        {
            get
            {
                return this.wMSPalletTypeIdField;
            }
            set
            {
                this.wMSPalletTypeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", IsNullable=true, Order=106)]
        public System.Nullable<System.DateTime> WMSPickingQtyTime
        {
            get
            {
                return this.wMSPickingQtyTimeField;
            }
            set
            {
                this.wMSPickingQtyTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WMSPickingQtyTimeSpecified
        {
            get
            {
                return this.wMSPickingQtyTimeFieldSpecified;
            }
            set
            {
                this.wMSPickingQtyTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Sales", Order=107)]
        public AxdEntity_Sales[] Sales
        {
            get
            {
                return this.salesField;
            }
            set
            {
                this.salesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Purch", Order=108)]
        public AxdEntity_Purch[] Purch
        {
            get
            {
                return this.purchField;
            }
            set
            {
                this.purchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Invent", Order=109)]
        public AxdEntity_Invent[] Invent
        {
            get
            {
                return this.inventField;
            }
            set
            {
                this.inventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventItemLocation", Order=110)]
        public AxdEntity_InventItemLocation[] InventItemLocation
        {
            get
            {
                return this.inventItemLocationField;
            }
            set
            {
                this.inventItemLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventTxt", Order=111)]
        public AxdEntity_InventTxt[] InventTxt
        {
            get
            {
                return this.inventTxtField;
            }
            set
            {
                this.inventTxtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventTableDocuRef", Order=112)]
        public AxdEntity_InventTableDocuRef[] InventTableDocuRef
        {
            get
            {
                return this.inventTableDocuRefField;
            }
            set
            {
                this.inventTableDocuRefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventItemSalesSetup", Order=113)]
        public AxdEntity_InventItemSalesSetup[] InventItemSalesSetup
        {
            get
            {
                return this.inventItemSalesSetupField;
            }
            set
            {
                this.inventItemSalesSetupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventItemPurchSetup", Order=114)]
        public AxdEntity_InventItemPurchSetup[] InventItemPurchSetup
        {
            get
            {
                return this.inventItemPurchSetupField;
            }
            set
            {
                this.inventItemPurchSetupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventItemInventSetup", Order=115)]
        public AxdEntity_InventItemInventSetup[] InventItemInventSetup
        {
            get
            {
                return this.inventItemInventSetupField;
            }
            set
            {
                this.inventItemInventSetupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_ABC
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemAutoReportFinished
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemBOMManualReceipt
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemConfigSimilar
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemConfigurable
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemCostModel
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_InventFiscalLIFOAvoidCalc
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_InventFiscalLIFONormalValueCalc
    {
        
        /// <remarks/>
        Never,
        
        /// <remarks/>
        Manual,
        
        /// <remarks/>
        Automatic,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ForecastDMPInclude
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemDimCombinationAutoCreate
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemDimCostPrice
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_RFIDItemTaggingLevel
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        ItemLevel,
        
        /// <remarks/>
        CaseLevel,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_ItemType
    {
        
        /// <remarks/>
        Item,
        
        /// <remarks/>
        BOM,
        
        /// <remarks/>
        Service,
        
        /// <remarks/>
        Asset_RU,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_RFIDPalletTagging
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_PBAAutostart
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_PBAHideApproval
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_PBAHideDialog
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_PBAItemAutoGenerated
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_PBAMandatoryConfig
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemPhantom
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_ProdFlushingPrincipItem
    {
        
        /// <remarks/>
        Start,
        
        /// <remarks/>
        Finish,
        
        /// <remarks/>
        Manual,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemPurchModel
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemSalesModel
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Contributionratio,
        
        /// <remarks/>
        PercentMarkup,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdEnum_SalesPriceModelBasic
    {
        
        /// <remarks/>
        PurchPrice,
        
        /// <remarks/>
        CostPrice,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemStopExplode
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public enum AxdExtType_ItemUseAlternative
    {
        
        /// <remarks/>
        Never,
        
        /// <remarks/>
        InventWhen0,
        
        /// <remarks/>
        Always,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
    public partial class AxdItem
    {
        
        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;
        
        private bool docPurposeFieldSpecified;
        
        private string senderIdField;
        
        private AxdEntity_InventTable[] inventTableField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("InventTable", Order=2)]
        public AxdEntity_InventTable[] InventTable
        {
            get
            {
                return this.inventTableField;
            }
            set
            {
                this.inventTableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/services", ConfigurationName="InventItemService.ItemService")]
    public interface ItemService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/read", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/readResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventItemService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/readAifFaultFa" +
            "ult", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceReadResponse> readAsync(InventItemService.ItemServiceReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/find", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/findResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventItemService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/findAifFaultFa" +
            "ult", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceFindResponse> findAsync(InventItemService.ItemServiceFindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/findKeys", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/findKeysRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventItemService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/findKeysAifFau" +
            "ltFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceFindKeysResponse> findKeysAsync(InventItemService.ItemServiceFindKeysRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/create", ReplyAction="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/createResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(InventItemService.AifFault), Action="http://schemas.microsoft.com/dynamics/2008/01/services/ItemService/createAifFault" +
            "Fault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceCreateResponse> createAsync(InventItemService.ItemServiceCreateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceReadRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventItemService.EntityKey[] EntityKeyList;
        
        public ItemServiceReadRequest()
        {
        }
        
        public ItemServiceReadRequest(InventItemService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceReadResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
        public InventItemService.AxdItem Item;
        
        public ItemServiceReadResponse()
        {
        }
        
        public ItemServiceReadResponse(InventItemService.AxdItem Item)
        {
            this.Item = Item;
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceFindRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceFindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public InventItemService.QueryCriteria QueryCriteria;
        
        public ItemServiceFindRequest()
        {
        }
        
        public ItemServiceFindRequest(InventItemService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceFindResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceFindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
        public InventItemService.AxdItem Item;
        
        public ItemServiceFindResponse()
        {
        }
        
        public ItemServiceFindResponse(InventItemService.AxdItem Item)
        {
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceFindKeysRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceFindKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public InventItemService.QueryCriteria QueryCriteria;
        
        public ItemServiceFindKeysRequest()
        {
        }
        
        public ItemServiceFindKeysRequest(InventItemService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceFindKeysResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceFindKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventItemService.EntityKey[] EntityKeyList;
        
        public ItemServiceFindKeysResponse()
        {
        }
        
        public ItemServiceFindKeysResponse(InventItemService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceCreateRequest", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceCreateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Item")]
        public InventItemService.AxdItem Item;
        
        public ItemServiceCreateRequest()
        {
        }
        
        public ItemServiceCreateRequest(InventItemService.AxdItem Item)
        {
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemServiceCreateResponse", WrapperNamespace="http://schemas.microsoft.com/dynamics/2008/01/services", IsWrapped=true)]
    public partial class ItemServiceCreateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public InventItemService.EntityKey[] EntityKeyList;
        
        public ItemServiceCreateResponse()
        {
        }
        
        public ItemServiceCreateResponse(InventItemService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ItemServiceChannel : InventItemService.ItemService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ItemServiceClient : System.ServiceModel.ClientBase<InventItemService.ItemService>, InventItemService.ItemService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ItemServiceClient() : 
                base(ItemServiceClient.GetDefaultBinding(), ItemServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ItemService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ItemServiceClient.GetBindingForEndpoint(endpointConfiguration), ItemServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ItemServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ItemServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceReadResponse> InventItemService.ItemService.readAsync(InventItemService.ItemServiceReadRequest request)
        {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventItemService.ItemServiceReadResponse> readAsync(InventItemService.EntityKey[] EntityKeyList)
        {
            InventItemService.ItemServiceReadRequest inValue = new InventItemService.ItemServiceReadRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((InventItemService.ItemService)(this)).readAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceFindResponse> InventItemService.ItemService.findAsync(InventItemService.ItemServiceFindRequest request)
        {
            return base.Channel.findAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventItemService.ItemServiceFindResponse> findAsync(InventItemService.QueryCriteria QueryCriteria)
        {
            InventItemService.ItemServiceFindRequest inValue = new InventItemService.ItemServiceFindRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((InventItemService.ItemService)(this)).findAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceFindKeysResponse> InventItemService.ItemService.findKeysAsync(InventItemService.ItemServiceFindKeysRequest request)
        {
            return base.Channel.findKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventItemService.ItemServiceFindKeysResponse> findKeysAsync(InventItemService.QueryCriteria QueryCriteria)
        {
            InventItemService.ItemServiceFindKeysRequest inValue = new InventItemService.ItemServiceFindKeysRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((InventItemService.ItemService)(this)).findKeysAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InventItemService.ItemServiceCreateResponse> InventItemService.ItemService.createAsync(InventItemService.ItemServiceCreateRequest request)
        {
            return base.Channel.createAsync(request);
        }
        
        public System.Threading.Tasks.Task<InventItemService.ItemServiceCreateResponse> createAsync(InventItemService.AxdItem Item)
        {
            InventItemService.ItemServiceCreateRequest inValue = new InventItemService.ItemServiceCreateRequest();
            inValue.Item = Item;
            return ((InventItemService.ItemService)(this)).createAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ItemService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ItemService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/MicrosoftDynamicsAXAif50/itemservice.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ItemServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ItemService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ItemServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ItemService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ItemService,
        }
    }
}
