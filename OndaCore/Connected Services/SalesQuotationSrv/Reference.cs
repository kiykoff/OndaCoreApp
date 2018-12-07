//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace SalesQuotationSrv
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_InterCompanyMarkupUseValue
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_MarkupKeep
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_MarkupModuleCategory
    {
        
        /// <remarks/>
        Heading,
        
        /// <remarks/>
        Linie,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_TaxAutoGenerated
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdEnum_DocuRestriction
    {
        
        /// <remarks/>
        Internal,
        
        /// <remarks/>
        External,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public partial class AxdEntity_SalesQuotationLine
    {
        
        private System.Nullable<AxdEnum_LedgerJournalACType> accountTypeField;
        
        private bool accountTypeFieldSpecified;
        
        private string barCodeField;
        
        private string barCodeTypeField;
        
        private System.Nullable<AxdExtType_RFIDCaseTagging> caseTaggingField;
        
        private bool caseTaggingFieldSpecified;
        
        private string companyField;
        
        private System.Nullable<System.DateTime> confirmedDlvField;
        
        private bool confirmedDlvFieldSpecified;
        
        private System.Nullable<decimal> costPriceField;
        
        private bool costPriceFieldSpecified;
        
        private string currencyCodeField;
        
        private string custAccountField;
        
        private string customerRefField;
        
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
        
        private string deliveryZipCodeField;
        
        private string[] dimensionField;
        
        private string dlvModeField;
        
        private System.Nullable<System.DateTime> endDateField;
        
        private bool endDateFieldSpecified;
        
        private string externalItemIdField;
        
        private System.Nullable<decimal> inventDeliverNowField;
        
        private bool inventDeliverNowFieldSpecified;
        
        private string inventDimIdField;
        
        private string inventRefIdField;
        
        private string inventRefTransIdField;
        
        private System.Nullable<AxdEnum_InventRefType> inventRefTypeField;
        
        private bool inventRefTypeFieldSpecified;
        
        private string inventTransIdField;
        
        private string itemBOMIdField;
        
        private string itemIdField;
        
        private string itemPBAIdField;
        
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
        
        private string linePropertyIdField;
        
        private System.Nullable<decimal> multiLnDiscField;
        
        private bool multiLnDiscFieldSpecified;
        
        private System.Nullable<decimal> multiLnPercentField;
        
        private bool multiLnPercentFieldSpecified;
        
        private string nameField;
        
        private System.Nullable<decimal> newSalesPriceField;
        
        private bool newSalesPriceFieldSpecified;
        
        private System.Nullable<decimal> newTotalContributionRatioField;
        
        private bool newTotalContributionRatioFieldSpecified;
        
        private string offsetAccountField;
        
        private System.Nullable<AxdEnum_LedgerJournalACType> offsetAccountTypeField;
        
        private bool offsetAccountTypeFieldSpecified;
        
        private string offsetCompanyField;
        
        private string offsetTxtField;
        
        private System.Nullable<decimal> origCostPriceField;
        
        private bool origCostPriceFieldSpecified;
        
        private System.Nullable<decimal> overDeliveryPctField;
        
        private bool overDeliveryPctFieldSpecified;
        
        private string packingUnitField;
        
        private System.Nullable<decimal> packingUnitQtyField;
        
        private bool packingUnitQtyFieldSpecified;
        
        private System.Nullable<AxdExtType_RFIDPalletTagging> palletTaggingField;
        
        private bool palletTaggingFieldSpecified;
        
        private string portField;
        
        private string priceCalcIdField;
        
        private System.Nullable<decimal> priceUnitField;
        
        private bool priceUnitFieldSpecified;
        
        private string projCategoryIdField;
        
        private string projDescriptionField;
        
        private string projTransCodeField;
        
        private System.Nullable<AxdEnum_QuotationProjTransType> projTransTypeField;
        
        private bool projTransTypeFieldSpecified;
        
        private System.Nullable<decimal> qtyOrderedField;
        
        private bool qtyOrderedFieldSpecified;
        
        private string quotationIdField;
        
        private System.Nullable<AxdEnum_SalesQuotationStatus> quotationStatusField;
        
        private bool quotationStatusFieldSpecified;
        
        private System.Nullable<System.DateTime> receiptDateRequestedField;
        
        private bool receiptDateRequestedFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private System.Nullable<decimal> remainInventPhysicalField;
        
        private bool remainInventPhysicalFieldSpecified;
        
        private System.Nullable<decimal> remainSalesFinancialField;
        
        private bool remainSalesFinancialFieldSpecified;
        
        private System.Nullable<decimal> remainSalesPhysicalField;
        
        private bool remainSalesPhysicalFieldSpecified;
        
        private System.Nullable<decimal> salesDeliverNowField;
        
        private bool salesDeliverNowFieldSpecified;
        
        private string salesGroupField;
        
        private System.Nullable<decimal> salesMarkupField;
        
        private bool salesMarkupFieldSpecified;
        
        private System.Nullable<decimal> salesPriceField;
        
        private bool salesPriceFieldSpecified;
        
        private System.Nullable<decimal> salesQtyField;
        
        private bool salesQtyFieldSpecified;
        
        private string salesUnitField;
        
        private System.Nullable<System.DateTime> shippingDateRequestedField;
        
        private bool shippingDateRequestedFieldSpecified;
        
        private System.Nullable<System.DateTime> startDateField;
        
        private bool startDateFieldSpecified;
        
        private string statProcIdField;
        
        private System.Nullable<AxdExtType_IntrastatTriangularDeal> statTriangularDealField;
        
        private bool statTriangularDealFieldSpecified;
        
        private System.Nullable<AxdExtType_TaxAutoGenerated> taxAutoGeneratedField;
        
        private bool taxAutoGeneratedFieldSpecified;
        
        private string taxGroupField;
        
        private string taxItemGroupField;
        
        private string transactionCodeField;
        
        private System.Nullable<System.DateTime> transDateField;
        
        private bool transDateFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> transferred2ForecastField;
        
        private bool transferred2ForecastFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> transferred2ItemReqField;
        
        private bool transferred2ItemReqFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> transferred2JournalField;
        
        private bool transferred2JournalFieldSpecified;
        
        private string transportField;
        
        private System.Nullable<decimal> underDeliveryPctField;
        
        private bool underDeliveryPctFieldSpecified;
        
        private AxdEntity_InventDim[] inventDimField;
        
        private AxdEntity_DocuRefLine[] docuRefLineField;
        
        private AxdEntity_MarkupTransLine[] markupTransLineField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_SalesQuotationLine()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdEnum_LedgerJournalACType> AccountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountTypeSpecified
        {
            get
            {
                return this.accountTypeFieldSpecified;
            }
            set
            {
                this.accountTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string Company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
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
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=25)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=27)]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=36)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=38)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=39)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=40)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=41)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=42)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=43)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=44)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=45)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=46)]
        public string LinePropertyId
        {
            get
            {
                return this.linePropertyIdField;
            }
            set
            {
                this.linePropertyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=47)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=48)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=49)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=50)]
        public System.Nullable<decimal> NewSalesPrice
        {
            get
            {
                return this.newSalesPriceField;
            }
            set
            {
                this.newSalesPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewSalesPriceSpecified
        {
            get
            {
                return this.newSalesPriceFieldSpecified;
            }
            set
            {
                this.newSalesPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=51)]
        public System.Nullable<decimal> NewTotalContributionRatio
        {
            get
            {
                return this.newTotalContributionRatioField;
            }
            set
            {
                this.newTotalContributionRatioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewTotalContributionRatioSpecified
        {
            get
            {
                return this.newTotalContributionRatioFieldSpecified;
            }
            set
            {
                this.newTotalContributionRatioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=52)]
        public string OffsetAccount
        {
            get
            {
                return this.offsetAccountField;
            }
            set
            {
                this.offsetAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=53)]
        public System.Nullable<AxdEnum_LedgerJournalACType> OffsetAccountType
        {
            get
            {
                return this.offsetAccountTypeField;
            }
            set
            {
                this.offsetAccountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OffsetAccountTypeSpecified
        {
            get
            {
                return this.offsetAccountTypeFieldSpecified;
            }
            set
            {
                this.offsetAccountTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=54)]
        public string OffsetCompany
        {
            get
            {
                return this.offsetCompanyField;
            }
            set
            {
                this.offsetCompanyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=55)]
        public string OffsetTxt
        {
            get
            {
                return this.offsetTxtField;
            }
            set
            {
                this.offsetTxtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=56)]
        public System.Nullable<decimal> OrigCostPrice
        {
            get
            {
                return this.origCostPriceField;
            }
            set
            {
                this.origCostPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrigCostPriceSpecified
        {
            get
            {
                return this.origCostPriceFieldSpecified;
            }
            set
            {
                this.origCostPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=57)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=58)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=59)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=60)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=61)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=62)]
        public string PriceCalcId
        {
            get
            {
                return this.priceCalcIdField;
            }
            set
            {
                this.priceCalcIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=63)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=64)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=65)]
        public string ProjDescription
        {
            get
            {
                return this.projDescriptionField;
            }
            set
            {
                this.projDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=66)]
        public string ProjTransCode
        {
            get
            {
                return this.projTransCodeField;
            }
            set
            {
                this.projTransCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=67)]
        public System.Nullable<AxdEnum_QuotationProjTransType> ProjTransType
        {
            get
            {
                return this.projTransTypeField;
            }
            set
            {
                this.projTransTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProjTransTypeSpecified
        {
            get
            {
                return this.projTransTypeFieldSpecified;
            }
            set
            {
                this.projTransTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=68)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=69)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=70)]
        public System.Nullable<AxdEnum_SalesQuotationStatus> QuotationStatus
        {
            get
            {
                return this.quotationStatusField;
            }
            set
            {
                this.quotationStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotationStatusSpecified
        {
            get
            {
                return this.quotationStatusFieldSpecified;
            }
            set
            {
                this.quotationStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=71)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=72)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=73)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=74)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=75)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=76)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=77)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=78)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=79)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=80)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=81)]
        public System.Nullable<decimal> SalesQty
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesQtySpecified
        {
            get
            {
                return this.salesQtyFieldSpecified;
            }
            set
            {
                this.salesQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=82)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=83)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=84)]
        public System.Nullable<System.DateTime> StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=85)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=86)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=87)]
        public System.Nullable<AxdExtType_TaxAutoGenerated> TaxAutoGenerated
        {
            get
            {
                return this.taxAutoGeneratedField;
            }
            set
            {
                this.taxAutoGeneratedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAutoGeneratedSpecified
        {
            get
            {
                return this.taxAutoGeneratedFieldSpecified;
            }
            set
            {
                this.taxAutoGeneratedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=88)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=89)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=90)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=91)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=92)]
        public System.Nullable<AxdExtType_NoYesId> Transferred2Forecast
        {
            get
            {
                return this.transferred2ForecastField;
            }
            set
            {
                this.transferred2ForecastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Transferred2ForecastSpecified
        {
            get
            {
                return this.transferred2ForecastFieldSpecified;
            }
            set
            {
                this.transferred2ForecastFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=93)]
        public System.Nullable<AxdExtType_NoYesId> Transferred2ItemReq
        {
            get
            {
                return this.transferred2ItemReqField;
            }
            set
            {
                this.transferred2ItemReqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Transferred2ItemReqSpecified
        {
            get
            {
                return this.transferred2ItemReqFieldSpecified;
            }
            set
            {
                this.transferred2ItemReqFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=94)]
        public System.Nullable<AxdExtType_NoYesId> Transferred2Journal
        {
            get
            {
                return this.transferred2JournalField;
            }
            set
            {
                this.transferred2JournalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Transferred2JournalSpecified
        {
            get
            {
                return this.transferred2JournalFieldSpecified;
            }
            set
            {
                this.transferred2JournalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=95)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=96)]
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
        [System.Xml.Serialization.XmlElementAttribute("InventDim", Order=97)]
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
        [System.Xml.Serialization.XmlElementAttribute("DocuRefLine", Order=98)]
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
        [System.Xml.Serialization.XmlElementAttribute("MarkupTransLine", Order=99)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdEnum_LedgerJournalACType
    {
        
        /// <remarks/>
        Ledger,
        
        /// <remarks/>
        Cust,
        
        /// <remarks/>
        Vend,
        
        /// <remarks/>
        Project,
        
        /// <remarks/>
        FixedAssets,
        
        /// <remarks/>
        Bank,
        
        /// <remarks/>
        DEL_CostAcc,
        
        /// <remarks/>
        FixedAssets_RU,
        
        /// <remarks/>
        Employee_RU,
        
        /// <remarks/>
        RDeferrals,
        
        /// <remarks/>
        RCash,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_RFIDCaseTagging
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_RFIDItemTagging
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_RFIDPalletTagging
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdEnum_QuotationProjTransType
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Fee,
        
        /// <remarks/>
        Hour,
        
        /// <remarks/>
        Expense,
        
        /// <remarks/>
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdEnum_SalesQuotationStatus
    {
        
        /// <remarks/>
        Created,
        
        /// <remarks/>
        Sent,
        
        /// <remarks/>
        Confirmed,
        
        /// <remarks/>
        Lost,
        
        /// <remarks/>
        Cancelled,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_IntrastatTriangularDeal
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_NoYesId
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public partial class AxdEntity_SalesQuotationTable
    {
        
        private string _DocumentHashField;
        
        private string busRelAccountField;
        
        private string callListIDField;
        
        private string campaignIdField;
        
        private System.Nullable<AxdExtType_RFIDCaseTagging> caseTaggingField;
        
        private bool caseTaggingFieldSpecified;
        
        private string cashDiscField;
        
        private string commissionGroupField;
        
        private System.Nullable<System.DateTime> confirmDateField;
        
        private bool confirmDateFieldSpecified;
        
        private string contactPersonIdField;
        
        private System.Nullable<int> covStatusField;
        
        private bool covStatusFieldSpecified;
        
        private string currencyCodeField;
        
        private string custAccountField;
        
        private string customerRefField;
        
        private string custPurchaseOrderField;
        
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
        
        private string deliveryZipCodeField;
        
        private string[] dimensionField;
        
        private System.Nullable<decimal> discPercentField;
        
        private bool discPercentFieldSpecified;
        
        private string dlvModeField;
        
        private string dlvReasonField;
        
        private string dlvTermField;
        
        private string docuConclusionField;
        
        private string docuIntroField;
        
        private string docuTitleField;
        
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
        
        private System.Nullable<AxdExtType_InclTax> inclTaxField;
        
        private bool inclTaxFieldSpecified;
        
        private string inventLocationIdField;
        
        private string inventSiteIdField;
        
        private string invoiceAccountField;
        
        private System.Nullable<AxdExtType_RFIDItemTagging> itemTaggingField;
        
        private bool itemTaggingFieldSpecified;
        
        private string languageIdField;
        
        private string lineDiscField;
        
        private System.Nullable<AxdExtType_ListcodeId> listcodeField;
        
        private bool listcodeFieldSpecified;
        
        private string markupGroupField;
        
        private string modelIdField;
        
        private string multiLineDiscField;
        
        private string numberSequenceGroupField;
        
        private string opportunityIdField;
        
        private string origQuotationIdField;
        
        private System.Nullable<AxdExtType_RFIDPalletTagging> palletTaggingField;
        
        private bool palletTaggingFieldSpecified;
        
        private string paymentField;
        
        private string paymModeField;
        
        private string paymSpecField;
        
        private string portField;
        
        private string postingProfileField;
        
        private string priceGroupIdField;
        
        private string projIdRefField;
        
        private string projInvoiceProjIdField;
        
        private string quotationCategoryField;
        
        private System.Nullable<System.DateTime> quotationExpiryDateField;
        
        private bool quotationExpiryDateFieldSpecified;
        
        private string quotationFollowupActivityField;
        
        private System.Nullable<System.DateTime> quotationFollowUpDateField;
        
        private bool quotationFollowUpDateFieldSpecified;
        
        private string quotationIdField;
        
        private string quotationNameField;
        
        private System.Nullable<AxdEnum_SalesQuotationStatus> quotationStatusField;
        
        private bool quotationStatusFieldSpecified;
        
        private System.Nullable<AxdEnum_QuotationType> quotationTypeField;
        
        private bool quotationTypeFieldSpecified;
        
        private string reasonIdField;
        
        private System.Nullable<System.DateTime> receiptDateRequestedField;
        
        private bool receiptDateRequestedFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string salesGroupField;
        
        private string salesIdRefField;
        
        private string salesOriginIdField;
        
        private string salesPoolIdField;
        
        private string salesResponsibleField;
        
        private string salesTakerField;
        
        private string salesUnitIdField;
        
        private string serviceIdField;
        
        private System.Nullable<AxdExtType_SalesSettlementType> settleVoucherField;
        
        private bool settleVoucherFieldSpecified;
        
        private System.Nullable<System.DateTime> shippingDateRequestedField;
        
        private bool shippingDateRequestedFieldSpecified;
        
        private string statProcIdField;
        
        private string taxGroupField;
        
        private System.Nullable<AxdExtType_QuotationTemplateActive> templateActiveField;
        
        private bool templateActiveFieldSpecified;
        
        private string templateGroupIdField;
        
        private string templateNameField;
        
        private string transactionCodeField;
        
        private System.Nullable<AxdExtType_SalesQuotationTransferred> transferredToForecastField;
        
        private bool transferredToForecastFieldSpecified;
        
        private System.Nullable<AxdExtType_SalesQuotationTransferredItemReq> transferredToItemReqField;
        
        private bool transferredToItemReqFieldSpecified;
        
        private string transportField;
        
        private string uRLField;
        
        private string vATNumField;
        
        private AxdEntity_SalesQuotationLine[] salesQuotationLineField;
        
        private AxdEntity_DocuRefHeader[] docuRefHeaderField;
        
        private AxdEntity_MarkupTransHeader[] markupTransHeaderField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_SalesQuotationTable()
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
        public string BusRelAccount
        {
            get
            {
                return this.busRelAccountField;
            }
            set
            {
                this.busRelAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string CallListID
        {
            get
            {
                return this.callListIDField;
            }
            set
            {
                this.callListIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string CampaignId
        {
            get
            {
                return this.campaignIdField;
            }
            set
            {
                this.campaignIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=7)]
        public System.Nullable<System.DateTime> ConfirmDate
        {
            get
            {
                return this.confirmDateField;
            }
            set
            {
                this.confirmDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfirmDateSpecified
        {
            get
            {
                return this.confirmDateFieldSpecified;
            }
            set
            {
                this.confirmDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string CustPurchaseOrder
        {
            get
            {
                return this.custPurchaseOrderField;
            }
            set
            {
                this.custPurchaseOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
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
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=29)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public string DocuConclusion
        {
            get
            {
                return this.docuConclusionField;
            }
            set
            {
                this.docuConclusionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
        public string DocuIntro
        {
            get
            {
                return this.docuIntroField;
            }
            set
            {
                this.docuIntroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=36)]
        public string DocuTitle
        {
            get
            {
                return this.docuTitleField;
            }
            set
            {
                this.docuTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=38)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=39)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=40)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=41)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=42)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=43)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=44)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=45)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=46)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=47)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=48)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=49)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=50)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=51)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=52)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=53)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=54)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=55)]
        public string ModelId
        {
            get
            {
                return this.modelIdField;
            }
            set
            {
                this.modelIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=56)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=57)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=58)]
        public string OpportunityId
        {
            get
            {
                return this.opportunityIdField;
            }
            set
            {
                this.opportunityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=59)]
        public string OrigQuotationId
        {
            get
            {
                return this.origQuotationIdField;
            }
            set
            {
                this.origQuotationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=60)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=61)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=62)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=63)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=64)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=65)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=66)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=67)]
        public string ProjIdRef
        {
            get
            {
                return this.projIdRefField;
            }
            set
            {
                this.projIdRefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=68)]
        public string ProjInvoiceProjId
        {
            get
            {
                return this.projInvoiceProjIdField;
            }
            set
            {
                this.projInvoiceProjIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=69)]
        public string QuotationCategory
        {
            get
            {
                return this.quotationCategoryField;
            }
            set
            {
                this.quotationCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=70)]
        public System.Nullable<System.DateTime> QuotationExpiryDate
        {
            get
            {
                return this.quotationExpiryDateField;
            }
            set
            {
                this.quotationExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotationExpiryDateSpecified
        {
            get
            {
                return this.quotationExpiryDateFieldSpecified;
            }
            set
            {
                this.quotationExpiryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=71)]
        public string QuotationFollowupActivity
        {
            get
            {
                return this.quotationFollowupActivityField;
            }
            set
            {
                this.quotationFollowupActivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=72)]
        public System.Nullable<System.DateTime> QuotationFollowUpDate
        {
            get
            {
                return this.quotationFollowUpDateField;
            }
            set
            {
                this.quotationFollowUpDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotationFollowUpDateSpecified
        {
            get
            {
                return this.quotationFollowUpDateFieldSpecified;
            }
            set
            {
                this.quotationFollowUpDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=73)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=74)]
        public string QuotationName
        {
            get
            {
                return this.quotationNameField;
            }
            set
            {
                this.quotationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=75)]
        public System.Nullable<AxdEnum_SalesQuotationStatus> QuotationStatus
        {
            get
            {
                return this.quotationStatusField;
            }
            set
            {
                this.quotationStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotationStatusSpecified
        {
            get
            {
                return this.quotationStatusFieldSpecified;
            }
            set
            {
                this.quotationStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=76)]
        public System.Nullable<AxdEnum_QuotationType> QuotationType
        {
            get
            {
                return this.quotationTypeField;
            }
            set
            {
                this.quotationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotationTypeSpecified
        {
            get
            {
                return this.quotationTypeFieldSpecified;
            }
            set
            {
                this.quotationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=77)]
        public string ReasonId
        {
            get
            {
                return this.reasonIdField;
            }
            set
            {
                this.reasonIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=78)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=79)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=80)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=81)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=82)]
        public string SalesIdRef
        {
            get
            {
                return this.salesIdRefField;
            }
            set
            {
                this.salesIdRefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=83)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=84)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=85)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=86)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=87)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=88)]
        public string ServiceId
        {
            get
            {
                return this.serviceIdField;
            }
            set
            {
                this.serviceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=89)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=90)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=91)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=92)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=93)]
        public System.Nullable<AxdExtType_QuotationTemplateActive> TemplateActive
        {
            get
            {
                return this.templateActiveField;
            }
            set
            {
                this.templateActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TemplateActiveSpecified
        {
            get
            {
                return this.templateActiveFieldSpecified;
            }
            set
            {
                this.templateActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=94)]
        public string TemplateGroupId
        {
            get
            {
                return this.templateGroupIdField;
            }
            set
            {
                this.templateGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=95)]
        public string TemplateName
        {
            get
            {
                return this.templateNameField;
            }
            set
            {
                this.templateNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=96)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=97)]
        public System.Nullable<AxdExtType_SalesQuotationTransferred> TransferredToForecast
        {
            get
            {
                return this.transferredToForecastField;
            }
            set
            {
                this.transferredToForecastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransferredToForecastSpecified
        {
            get
            {
                return this.transferredToForecastFieldSpecified;
            }
            set
            {
                this.transferredToForecastFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=98)]
        public System.Nullable<AxdExtType_SalesQuotationTransferredItemReq> TransferredToItemReq
        {
            get
            {
                return this.transferredToItemReqField;
            }
            set
            {
                this.transferredToItemReqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransferredToItemReqSpecified
        {
            get
            {
                return this.transferredToItemReqFieldSpecified;
            }
            set
            {
                this.transferredToItemReqFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=99)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=100)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=101)]
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
        [System.Xml.Serialization.XmlElementAttribute("SalesQuotationLine", Order=102)]
        public AxdEntity_SalesQuotationLine[] SalesQuotationLine
        {
            get
            {
                return this.salesQuotationLineField;
            }
            set
            {
                this.salesQuotationLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocuRefHeader", Order=103)]
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
        [System.Xml.Serialization.XmlElementAttribute("MarkupTransHeader", Order=104)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_CustFreightSlipType
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        UPS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_InclTax
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdEnum_QuotationType
    {
        
        /// <remarks/>
        Sales,
        
        /// <remarks/>
        Project,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_QuotationTemplateActive
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_SalesQuotationTransferred
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public enum AxdExtType_SalesQuotationTransferredItemReq
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
    public partial class AxdWebSalesQuotation
    {
        
        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;
        
        private bool docPurposeFieldSpecified;
        
        private string senderIdField;
        
        private AxdEntity_SalesQuotationTable[] salesQuotationTableField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("SalesQuotationTable", Order=2)]
        public AxdEntity_SalesQuotationTable[] SalesQuotationTable
        {
            get
            {
                return this.salesQuotationTableField;
            }
            set
            {
                this.salesQuotationTableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="SalesQuotationSrv.SalesQuotationService")]
    public interface SalesQuotationService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SalesQuotationService/create", ReplyAction="http://tempuri.org/SalesQuotationService/createResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesQuotationSrv.AifFault), Action="http://tempuri.org/SalesQuotationService/createAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceCreateResponse> createAsync(SalesQuotationSrv.SalesQuotationServiceCreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SalesQuotationService/delete", ReplyAction="http://tempuri.org/SalesQuotationService/deleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesQuotationSrv.AifFault), Action="http://tempuri.org/SalesQuotationService/deleteAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesQuotationSrv.deleteResponse> deleteAsync(SalesQuotationSrv.SalesQuotationServiceDeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SalesQuotationService/find", ReplyAction="http://tempuri.org/SalesQuotationService/findResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesQuotationSrv.AifFault), Action="http://tempuri.org/SalesQuotationService/findAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceFindResponse> findAsync(SalesQuotationSrv.SalesQuotationServiceFindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SalesQuotationService/findKeys", ReplyAction="http://tempuri.org/SalesQuotationService/findKeysResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesQuotationSrv.AifFault), Action="http://tempuri.org/SalesQuotationService/findKeysAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceFindKeysResponse> findKeysAsync(SalesQuotationSrv.SalesQuotationServiceFindKeysRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SalesQuotationService/update", ReplyAction="http://tempuri.org/SalesQuotationService/updateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesQuotationSrv.AifFault), Action="http://tempuri.org/SalesQuotationService/updateAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesQuotationSrv.updateResponse> updateAsync(SalesQuotationSrv.SalesQuotationServiceUpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SalesQuotationService/read", ReplyAction="http://tempuri.org/SalesQuotationService/readResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SalesQuotationSrv.AifFault), Action="http://tempuri.org/SalesQuotationService/readAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceReadResponse> readAsync(SalesQuotationSrv.SalesQuotationServiceReadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceCreateRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceCreateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
        public SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation;
        
        public SalesQuotationServiceCreateRequest()
        {
        }
        
        public SalesQuotationServiceCreateRequest(SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation)
        {
            this.WebSalesQuotation = WebSalesQuotation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceCreateResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceCreateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesQuotationSrv.EntityKey[] EntityKeyList;
        
        public SalesQuotationServiceCreateResponse()
        {
        }
        
        public SalesQuotationServiceCreateResponse(SalesQuotationSrv.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceDeleteRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceDeleteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesQuotationSrv.EntityKey[] EntityKeyList;
        
        public SalesQuotationServiceDeleteRequest()
        {
        }
        
        public SalesQuotationServiceDeleteRequest(SalesQuotationSrv.EntityKey[] EntityKeyList)
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceFindRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceFindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public SalesQuotationSrv.QueryCriteria QueryCriteria;
        
        public SalesQuotationServiceFindRequest()
        {
        }
        
        public SalesQuotationServiceFindRequest(SalesQuotationSrv.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceFindResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceFindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
        public SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation;
        
        public SalesQuotationServiceFindResponse()
        {
        }
        
        public SalesQuotationServiceFindResponse(SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation)
        {
            this.WebSalesQuotation = WebSalesQuotation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceFindKeysRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceFindKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public SalesQuotationSrv.QueryCriteria QueryCriteria;
        
        public SalesQuotationServiceFindKeysRequest()
        {
        }
        
        public SalesQuotationServiceFindKeysRequest(SalesQuotationSrv.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceFindKeysResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceFindKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesQuotationSrv.EntityKey[] EntityKeyList;
        
        public SalesQuotationServiceFindKeysResponse()
        {
        }
        
        public SalesQuotationServiceFindKeysResponse(SalesQuotationSrv.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceUpdateRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceUpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesQuotationSrv.EntityKey[] EntityKeyList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
        public SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation;
        
        public SalesQuotationServiceUpdateRequest()
        {
        }
        
        public SalesQuotationServiceUpdateRequest(SalesQuotationSrv.EntityKey[] EntityKeyList, SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation)
        {
            this.EntityKeyList = EntityKeyList;
            this.WebSalesQuotation = WebSalesQuotation;
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceReadRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public SalesQuotationSrv.EntityKey[] EntityKeyList;
        
        public SalesQuotationServiceReadRequest()
        {
        }
        
        public SalesQuotationServiceReadRequest(SalesQuotationSrv.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalesQuotationServiceReadResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SalesQuotationServiceReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebSalesQuotation")]
        public SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation;
        
        public SalesQuotationServiceReadResponse()
        {
        }
        
        public SalesQuotationServiceReadResponse(SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation)
        {
            this.WebSalesQuotation = WebSalesQuotation;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface SalesQuotationServiceChannel : SalesQuotationSrv.SalesQuotationService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class SalesQuotationServiceClient : System.ServiceModel.ClientBase<SalesQuotationSrv.SalesQuotationService>, SalesQuotationSrv.SalesQuotationService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SalesQuotationServiceClient() : 
                base(SalesQuotationServiceClient.GetDefaultBinding(), SalesQuotationServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_SalesQuotationService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesQuotationServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SalesQuotationServiceClient.GetBindingForEndpoint(endpointConfiguration), SalesQuotationServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesQuotationServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SalesQuotationServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesQuotationServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SalesQuotationServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalesQuotationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceCreateResponse> SalesQuotationSrv.SalesQuotationService.createAsync(SalesQuotationSrv.SalesQuotationServiceCreateRequest request)
        {
            return base.Channel.createAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceCreateResponse> createAsync(SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation)
        {
            SalesQuotationSrv.SalesQuotationServiceCreateRequest inValue = new SalesQuotationSrv.SalesQuotationServiceCreateRequest();
            inValue.WebSalesQuotation = WebSalesQuotation;
            return ((SalesQuotationSrv.SalesQuotationService)(this)).createAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesQuotationSrv.deleteResponse> SalesQuotationSrv.SalesQuotationService.deleteAsync(SalesQuotationSrv.SalesQuotationServiceDeleteRequest request)
        {
            return base.Channel.deleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesQuotationSrv.deleteResponse> deleteAsync(SalesQuotationSrv.EntityKey[] EntityKeyList)
        {
            SalesQuotationSrv.SalesQuotationServiceDeleteRequest inValue = new SalesQuotationSrv.SalesQuotationServiceDeleteRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((SalesQuotationSrv.SalesQuotationService)(this)).deleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceFindResponse> SalesQuotationSrv.SalesQuotationService.findAsync(SalesQuotationSrv.SalesQuotationServiceFindRequest request)
        {
            return base.Channel.findAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceFindResponse> findAsync(SalesQuotationSrv.QueryCriteria QueryCriteria)
        {
            SalesQuotationSrv.SalesQuotationServiceFindRequest inValue = new SalesQuotationSrv.SalesQuotationServiceFindRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((SalesQuotationSrv.SalesQuotationService)(this)).findAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceFindKeysResponse> SalesQuotationSrv.SalesQuotationService.findKeysAsync(SalesQuotationSrv.SalesQuotationServiceFindKeysRequest request)
        {
            return base.Channel.findKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceFindKeysResponse> findKeysAsync(SalesQuotationSrv.QueryCriteria QueryCriteria)
        {
            SalesQuotationSrv.SalesQuotationServiceFindKeysRequest inValue = new SalesQuotationSrv.SalesQuotationServiceFindKeysRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((SalesQuotationSrv.SalesQuotationService)(this)).findKeysAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesQuotationSrv.updateResponse> SalesQuotationSrv.SalesQuotationService.updateAsync(SalesQuotationSrv.SalesQuotationServiceUpdateRequest request)
        {
            return base.Channel.updateAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesQuotationSrv.updateResponse> updateAsync(SalesQuotationSrv.EntityKey[] EntityKeyList, SalesQuotationSrv.AxdWebSalesQuotation WebSalesQuotation)
        {
            SalesQuotationSrv.SalesQuotationServiceUpdateRequest inValue = new SalesQuotationSrv.SalesQuotationServiceUpdateRequest();
            inValue.EntityKeyList = EntityKeyList;
            inValue.WebSalesQuotation = WebSalesQuotation;
            return ((SalesQuotationSrv.SalesQuotationService)(this)).updateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceReadResponse> SalesQuotationSrv.SalesQuotationService.readAsync(SalesQuotationSrv.SalesQuotationServiceReadRequest request)
        {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<SalesQuotationSrv.SalesQuotationServiceReadResponse> readAsync(SalesQuotationSrv.EntityKey[] EntityKeyList)
        {
            SalesQuotationSrv.SalesQuotationServiceReadRequest inValue = new SalesQuotationSrv.SalesQuotationServiceReadRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((SalesQuotationSrv.SalesQuotationService)(this)).readAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_SalesQuotationService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_SalesQuotationService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/salesquotationservice.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SalesQuotationServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_SalesQuotationService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SalesQuotationServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_SalesQuotationService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_SalesQuotationService,
        }
    }
}
