//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace DirPartyTableService
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdType_Container
    {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("container", typeof(AxdType_Container), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(AxdType_ContainerElement), Order=0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdType_ContainerElement
    {
        
        private AxdType_ContainerElementTypeRestrictions typeField;
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AxdType_ContainerElementTypeRestrictions type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
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
        [System.Xml.Serialization.XmlTextAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdType_ContainerElementTypeRestrictions
    {
        
        /// <remarks/>
        blob,
        
        /// <remarks/>
        date,
        
        /// <remarks/>
        datetime,
        
        /// <remarks/>
        @enum,
        
        /// <remarks/>
        @int,
        
        /// <remarks/>
        int64,
        
        /// <remarks/>
        real,
        
        /// <remarks/>
        str,
        
        /// <remarks/>
        guid,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdExtType_DocuValueFile
    {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("container", typeof(AxdType_Container), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(AxdType_ContainerElement), Order=0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdEntity_DocuValue
    {
        
        private AxdExtType_DocuValueFile fileField;
        
        private string fileNameField;
        
        private string fileTypeField;
        
        private string nameField;
        
        private string originalFileNameField;
        
        private string pathField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_DocuValue()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public AxdExtType_DocuValueFile File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string FileType
        {
            get
            {
                return this.fileTypeField;
            }
            set
            {
                this.fileTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string OriginalFileName
        {
            get
            {
                return this.originalFileNameField;
            }
            set
            {
                this.originalFileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdEntity_DocuRef
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
        
        private AxdEntity_DocuValue[] docuValueField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_DocuRef()
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
        [System.Xml.Serialization.XmlElementAttribute("DocuValue", Order=16)]
        public AxdEntity_DocuValue[] DocuValue
        {
            get
            {
                return this.docuValueField;
            }
            set
            {
                this.docuValueField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_DocuRestriction
    {
        
        /// <remarks/>
        Internal,
        
        /// <remarks/>
        External,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdEntity_EmplTable
    {
        
        private System.Nullable<AxdExtType_smmActivateAnswer> activateAnswerField;
        
        private bool activateAnswerFieldSpecified;
        
        private System.Nullable<System.DateTime> activityEndTimeField;
        
        private bool activityEndTimeFieldSpecified;
        
        private System.Nullable<int> activityReminderMinutesField;
        
        private bool activityReminderMinutesFieldSpecified;
        
        private System.Nullable<System.DateTime> activityStartTimeField;
        
        private bool activityStartTimeFieldSpecified;
        
        private System.Nullable<AxdEnum_NoYes> advHolder_RUField;
        
        private bool advHolder_RUFieldSpecified;
        
        private string altNumField;
        
        private System.Nullable<System.DateTime> birthDateField;
        
        private bool birthDateFieldSpecified;
        
        private string calendarIdField;
        
        private System.Nullable<System.DateTime> deceasedDateField;
        
        private bool deceasedDateFieldSpecified;
        
        private string[] dimensionField;
        
        private string dispatchTeamIdField;
        
        private System.Nullable<AxdExtType_smmEMailSaveCopy> eMailSaveCopyField;
        
        private bool eMailSaveCopyFieldSpecified;
        
        private System.Nullable<AxdEnum_EmplGender> emplGenderField;
        
        private bool emplGenderFieldSpecified;
        
        private string emplGroupId_RUField;
        
        private string emplIdField;
        
        private string emplIdentNumberField;
        
        private System.Nullable<AxdEnum_RHRMBirthPlaceType> hRMBirthPlaceType_RUField;
        
        private bool hRMBirthPlaceType_RUFieldSpecified;
        
        private string hRMContinuityDateText_RUField;
        
        private string hRMCountryRegionBirthId_RUField;
        
        private string hRMCountyBirth_RUField;
        
        private System.Nullable<System.DateTime> hRMCreateDate_RUField;
        
        private bool hRMCreateDate_RUFieldSpecified;
        
        private string hRMEducationTypeId_RUField;
        
        private System.Nullable<AxdEnum_RHRMKindOfWork> hRMKindOfWork_RUField;
        
        private bool hRMKindOfWork_RUFieldSpecified;
        
        private string hRMLabourContract_RUField;
        
        private System.Nullable<System.DateTime> hRMLabourContractDate_RUField;
        
        private bool hRMLabourContractDate_RUFieldSpecified;
        
        private string hRMMilitaryCategory_RUField;
        
        private System.Nullable<AxdEnum_NoYes> hRMMilitaryConscript_RUField;
        
        private bool hRMMilitaryConscript_RUFieldSpecified;
        
        private string hRMMilitaryGroup_RUField;
        
        private string hRMMilitaryRank_RUField;
        
        private string hRMMilitaryRegistration_RUField;
        
        private System.Nullable<AxdEnum_NoYes> hRMMilitaryReserved_RUField;
        
        private bool hRMMilitaryReserved_RUFieldSpecified;
        
        private System.Nullable<AxdEnum_RHRMMilitaryService> hRMMilitaryService_RUField;
        
        private bool hRMMilitaryService_RUFieldSpecified;
        
        private System.Nullable<AxdEnum_RHRMMilitaryServiceAbleBodied> hRMMilitaryServiceAbleBodied_RUField;
        
        private bool hRMMilitaryServiceAbleBodied_RUFieldSpecified;
        
        private string hRMMilitarySpeciality_RUField;
        
        private string hRMMilitarySpecialRegistration_RUField;
        
        private System.Nullable<AxdEnum_RHRMMilitaryTakeOffRegister> hRMMilitaryTakeOffRegister_RUField;
        
        private bool hRMMilitaryTakeOffRegister_RUFieldSpecified;
        
        private System.Nullable<AxdEnum_NoYes> hRMMobilization_RUField;
        
        private bool hRMMobilization_RUFieldSpecified;
        
        private string hRMNationalityId_RUField;
        
        private string hRMNorthSeniorityDateText_RUField;
        
        private System.Nullable<System.DateTime> hRMPensionAssignDate_RUField;
        
        private bool hRMPensionAssignDate_RUFieldSpecified;
        
        private string hRMPersonnelCategory_RUField;
        
        private string hRMSeniorityDateText_RUField;
        
        private System.Nullable<AxdEnum_RHRMSortOfWork> hRMSortOfWork_RUField;
        
        private bool hRMSortOfWork_RUFieldSpecified;
        
        private string hRMSpecialityDateText_RUField;
        
        private string hRMStateBirth_RUField;
        
        private System.Nullable<System.DateTime> hRMTermDate_RUField;
        
        private bool hRMTermDate_RUFieldSpecified;
        
        private string hRMTownBirth_RUField;
        
        private string hRMUnhealthySeniorityDateText_RUField;
        
        private string identityCardCode_RUField;
        
        private string identityCardIssueBy_RUField;
        
        private System.Nullable<System.DateTime> identityCardIssueDate_RUField;
        
        private bool identityCardIssueDate_RUFieldSpecified;
        
        private string identityCardNumber_RUField;
        
        private string identityCardSeries_RUField;
        
        private System.Nullable<AxdExtType_smmInclPrivateAppointments> inclPrivateAppointmentsField;
        
        private bool inclPrivateAppointmentsFieldSpecified;
        
        private System.Nullable<AxdExtType_smmInclPrivateTasks> inclPrivateTasksField;
        
        private bool inclPrivateTasksFieldSpecified;
        
        private System.Nullable<AxdExtType_smmInclRecurringAppointments> inclRecurringAppointmentsField;
        
        private bool inclRecurringAppointmentsFieldSpecified;
        
        private string itemBuyerGroupIdField;
        
        private string nameField;
        
        private string outlookCalendarFolderNameField;
        
        private string outlookContactFolderNameField;
        
        private string outlookTaskFolderNameField;
        
        private string outlookUserIDField;
        
        private string partyIdField;
        
        private System.Nullable<AxdExtType_NoYesId> payBankPayment_RUField;
        
        private bool payBankPayment_RUFieldSpecified;
        
        private System.Nullable<AxdExtType_NoYesId> payBlocked_RUField;
        
        private bool payBlocked_RUFieldSpecified;
        
        private System.Nullable<System.DateTime> payBlockedFrom_RUField;
        
        private bool payBlockedFrom_RUFieldSpecified;
        
        private string payCalendarId_RUField;
        
        private System.Nullable<System.DateTime> payEmploymentDate_RUField;
        
        private bool payEmploymentDate_RUFieldSpecified;
        
        private string payFormType_RUField;
        
        private string payGniCode_RUField;
        
        private string payHRMOrganizationId_RUField;
        
        private string payINN_RUField;
        
        private string payINNPF_RUField;
        
        private string payMainEmplId_RuField;
        
        private System.Nullable<AxdEnum_RPayPensionInsureCategory> payPensionInsureCategory_RUField;
        
        private bool payPensionInsureCategory_RUFieldSpecified;
        
        private System.Nullable<System.DateTime> payResignedDate_RUField;
        
        private bool payResignedDate_RUFieldSpecified;
        
        private string pBAUserProfileField;
        
        private string projPeriodIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string reqAttentionField;
        
        private string reqLocationIdField;
        
        private string reqSiteIdField;
        
        private System.Nullable<int> smmSynchronizeDaysBackField;
        
        private bool smmSynchronizeDaysBackFieldSpecified;
        
        private System.Nullable<int> smmSynchronizeDaysForwardField;
        
        private bool smmSynchronizeDaysForwardFieldSpecified;
        
        private System.Nullable<AxdEnum_HRMEmplStatus> statusField;
        
        private bool statusFieldSpecified;
        
        private string syncEntityIdField;
        
        private string syncTransIdCreateField;
        
        private System.Nullable<long> syncVersionField;
        
        private bool syncVersionFieldSpecified;
        
        private string titleField;
        
        private string trainingField;
        
        private System.Nullable<AxdExtType_ProjValidateOption> validateEmplCategoryField;
        
        private bool validateEmplCategoryFieldSpecified;
        
        private System.Nullable<AxdExtType_ProjValidateOption> validateProjEmplField;
        
        private bool validateProjEmplFieldSpecified;
        
        private string workTypeId_WField;
        
        private AxdEntity_DocuRef[] docuRefField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_EmplTable()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<AxdExtType_smmActivateAnswer> ActivateAnswer
        {
            get
            {
                return this.activateAnswerField;
            }
            set
            {
                this.activateAnswerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActivateAnswerSpecified
        {
            get
            {
                return this.activateAnswerFieldSpecified;
            }
            set
            {
                this.activateAnswerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", IsNullable=true, Order=1)]
        public System.Nullable<System.DateTime> ActivityEndTime
        {
            get
            {
                return this.activityEndTimeField;
            }
            set
            {
                this.activityEndTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActivityEndTimeSpecified
        {
            get
            {
                return this.activityEndTimeFieldSpecified;
            }
            set
            {
                this.activityEndTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<int> ActivityReminderMinutes
        {
            get
            {
                return this.activityReminderMinutesField;
            }
            set
            {
                this.activityReminderMinutesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActivityReminderMinutesSpecified
        {
            get
            {
                return this.activityReminderMinutesFieldSpecified;
            }
            set
            {
                this.activityReminderMinutesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> ActivityStartTime
        {
            get
            {
                return this.activityStartTimeField;
            }
            set
            {
                this.activityStartTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActivityStartTimeSpecified
        {
            get
            {
                return this.activityStartTimeFieldSpecified;
            }
            set
            {
                this.activityStartTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<AxdEnum_NoYes> AdvHolder_RU
        {
            get
            {
                return this.advHolder_RUField;
            }
            set
            {
                this.advHolder_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdvHolder_RUSpecified
        {
            get
            {
                return this.advHolder_RUFieldSpecified;
            }
            set
            {
                this.advHolder_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string AltNum
        {
            get
            {
                return this.altNumField;
            }
            set
            {
                this.altNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=6)]
        public System.Nullable<System.DateTime> BirthDate
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
        public bool BirthDateSpecified
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
        public string CalendarId
        {
            get
            {
                return this.calendarIdField;
            }
            set
            {
                this.calendarIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=8)]
        public System.Nullable<System.DateTime> DeceasedDate
        {
            get
            {
                return this.deceasedDateField;
            }
            set
            {
                this.deceasedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeceasedDateSpecified
        {
            get
            {
                return this.deceasedDateFieldSpecified;
            }
            set
            {
                this.deceasedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public string DispatchTeamId
        {
            get
            {
                return this.dispatchTeamIdField;
            }
            set
            {
                this.dispatchTeamIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<AxdExtType_smmEMailSaveCopy> eMailSaveCopy
        {
            get
            {
                return this.eMailSaveCopyField;
            }
            set
            {
                this.eMailSaveCopyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eMailSaveCopySpecified
        {
            get
            {
                return this.eMailSaveCopyFieldSpecified;
            }
            set
            {
                this.eMailSaveCopyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<AxdEnum_EmplGender> EmplGender
        {
            get
            {
                return this.emplGenderField;
            }
            set
            {
                this.emplGenderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmplGenderSpecified
        {
            get
            {
                return this.emplGenderFieldSpecified;
            }
            set
            {
                this.emplGenderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string EmplGroupId_RU
        {
            get
            {
                return this.emplGroupId_RUField;
            }
            set
            {
                this.emplGroupId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string EmplId
        {
            get
            {
                return this.emplIdField;
            }
            set
            {
                this.emplIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public string EmplIdentNumber
        {
            get
            {
                return this.emplIdentNumberField;
            }
            set
            {
                this.emplIdentNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<AxdEnum_RHRMBirthPlaceType> HRMBirthPlaceType_RU
        {
            get
            {
                return this.hRMBirthPlaceType_RUField;
            }
            set
            {
                this.hRMBirthPlaceType_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMBirthPlaceType_RUSpecified
        {
            get
            {
                return this.hRMBirthPlaceType_RUFieldSpecified;
            }
            set
            {
                this.hRMBirthPlaceType_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public string HRMContinuityDateText_RU
        {
            get
            {
                return this.hRMContinuityDateText_RUField;
            }
            set
            {
                this.hRMContinuityDateText_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=18)]
        public string HRMCountryRegionBirthId_RU
        {
            get
            {
                return this.hRMCountryRegionBirthId_RUField;
            }
            set
            {
                this.hRMCountryRegionBirthId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=19)]
        public string HRMCountyBirth_RU
        {
            get
            {
                return this.hRMCountyBirth_RUField;
            }
            set
            {
                this.hRMCountyBirth_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=20)]
        public System.Nullable<System.DateTime> HRMCreateDate_RU
        {
            get
            {
                return this.hRMCreateDate_RUField;
            }
            set
            {
                this.hRMCreateDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMCreateDate_RUSpecified
        {
            get
            {
                return this.hRMCreateDate_RUFieldSpecified;
            }
            set
            {
                this.hRMCreateDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=21)]
        public string HRMEducationTypeId_RU
        {
            get
            {
                return this.hRMEducationTypeId_RUField;
            }
            set
            {
                this.hRMEducationTypeId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public System.Nullable<AxdEnum_RHRMKindOfWork> HRMKindOfWork_RU
        {
            get
            {
                return this.hRMKindOfWork_RUField;
            }
            set
            {
                this.hRMKindOfWork_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMKindOfWork_RUSpecified
        {
            get
            {
                return this.hRMKindOfWork_RUFieldSpecified;
            }
            set
            {
                this.hRMKindOfWork_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public string HRMLabourContract_RU
        {
            get
            {
                return this.hRMLabourContract_RUField;
            }
            set
            {
                this.hRMLabourContract_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=24)]
        public System.Nullable<System.DateTime> HRMLabourContractDate_RU
        {
            get
            {
                return this.hRMLabourContractDate_RUField;
            }
            set
            {
                this.hRMLabourContractDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMLabourContractDate_RUSpecified
        {
            get
            {
                return this.hRMLabourContractDate_RUFieldSpecified;
            }
            set
            {
                this.hRMLabourContractDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public string HRMMilitaryCategory_RU
        {
            get
            {
                return this.hRMMilitaryCategory_RUField;
            }
            set
            {
                this.hRMMilitaryCategory_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
        public System.Nullable<AxdEnum_NoYes> HRMMilitaryConscript_RU
        {
            get
            {
                return this.hRMMilitaryConscript_RUField;
            }
            set
            {
                this.hRMMilitaryConscript_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMMilitaryConscript_RUSpecified
        {
            get
            {
                return this.hRMMilitaryConscript_RUFieldSpecified;
            }
            set
            {
                this.hRMMilitaryConscript_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public string HRMMilitaryGroup_RU
        {
            get
            {
                return this.hRMMilitaryGroup_RUField;
            }
            set
            {
                this.hRMMilitaryGroup_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
        public string HRMMilitaryRank_RU
        {
            get
            {
                return this.hRMMilitaryRank_RUField;
            }
            set
            {
                this.hRMMilitaryRank_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public string HRMMilitaryRegistration_RU
        {
            get
            {
                return this.hRMMilitaryRegistration_RUField;
            }
            set
            {
                this.hRMMilitaryRegistration_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public System.Nullable<AxdEnum_NoYes> HRMMilitaryReserved_RU
        {
            get
            {
                return this.hRMMilitaryReserved_RUField;
            }
            set
            {
                this.hRMMilitaryReserved_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMMilitaryReserved_RUSpecified
        {
            get
            {
                return this.hRMMilitaryReserved_RUFieldSpecified;
            }
            set
            {
                this.hRMMilitaryReserved_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public System.Nullable<AxdEnum_RHRMMilitaryService> HRMMilitaryService_RU
        {
            get
            {
                return this.hRMMilitaryService_RUField;
            }
            set
            {
                this.hRMMilitaryService_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMMilitaryService_RUSpecified
        {
            get
            {
                return this.hRMMilitaryService_RUFieldSpecified;
            }
            set
            {
                this.hRMMilitaryService_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=32)]
        public System.Nullable<AxdEnum_RHRMMilitaryServiceAbleBodied> HRMMilitaryServiceAbleBodied_RU
        {
            get
            {
                return this.hRMMilitaryServiceAbleBodied_RUField;
            }
            set
            {
                this.hRMMilitaryServiceAbleBodied_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMMilitaryServiceAbleBodied_RUSpecified
        {
            get
            {
                return this.hRMMilitaryServiceAbleBodied_RUFieldSpecified;
            }
            set
            {
                this.hRMMilitaryServiceAbleBodied_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public string HRMMilitarySpeciality_RU
        {
            get
            {
                return this.hRMMilitarySpeciality_RUField;
            }
            set
            {
                this.hRMMilitarySpeciality_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public string HRMMilitarySpecialRegistration_RU
        {
            get
            {
                return this.hRMMilitarySpecialRegistration_RUField;
            }
            set
            {
                this.hRMMilitarySpecialRegistration_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
        public System.Nullable<AxdEnum_RHRMMilitaryTakeOffRegister> HRMMilitaryTakeOffRegister_RU
        {
            get
            {
                return this.hRMMilitaryTakeOffRegister_RUField;
            }
            set
            {
                this.hRMMilitaryTakeOffRegister_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMMilitaryTakeOffRegister_RUSpecified
        {
            get
            {
                return this.hRMMilitaryTakeOffRegister_RUFieldSpecified;
            }
            set
            {
                this.hRMMilitaryTakeOffRegister_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=36)]
        public System.Nullable<AxdEnum_NoYes> HRMMobilization_RU
        {
            get
            {
                return this.hRMMobilization_RUField;
            }
            set
            {
                this.hRMMobilization_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMMobilization_RUSpecified
        {
            get
            {
                return this.hRMMobilization_RUFieldSpecified;
            }
            set
            {
                this.hRMMobilization_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
        public string HRMNationalityId_RU
        {
            get
            {
                return this.hRMNationalityId_RUField;
            }
            set
            {
                this.hRMNationalityId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=38)]
        public string HRMNorthSeniorityDateText_RU
        {
            get
            {
                return this.hRMNorthSeniorityDateText_RUField;
            }
            set
            {
                this.hRMNorthSeniorityDateText_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=39)]
        public System.Nullable<System.DateTime> HRMPensionAssignDate_RU
        {
            get
            {
                return this.hRMPensionAssignDate_RUField;
            }
            set
            {
                this.hRMPensionAssignDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMPensionAssignDate_RUSpecified
        {
            get
            {
                return this.hRMPensionAssignDate_RUFieldSpecified;
            }
            set
            {
                this.hRMPensionAssignDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=40)]
        public string HRMPersonnelCategory_RU
        {
            get
            {
                return this.hRMPersonnelCategory_RUField;
            }
            set
            {
                this.hRMPersonnelCategory_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=41)]
        public string HRMSeniorityDateText_RU
        {
            get
            {
                return this.hRMSeniorityDateText_RUField;
            }
            set
            {
                this.hRMSeniorityDateText_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=42)]
        public System.Nullable<AxdEnum_RHRMSortOfWork> HRMSortOfWork_RU
        {
            get
            {
                return this.hRMSortOfWork_RUField;
            }
            set
            {
                this.hRMSortOfWork_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMSortOfWork_RUSpecified
        {
            get
            {
                return this.hRMSortOfWork_RUFieldSpecified;
            }
            set
            {
                this.hRMSortOfWork_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=43)]
        public string HRMSpecialityDateText_RU
        {
            get
            {
                return this.hRMSpecialityDateText_RUField;
            }
            set
            {
                this.hRMSpecialityDateText_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=44)]
        public string HRMStateBirth_RU
        {
            get
            {
                return this.hRMStateBirth_RUField;
            }
            set
            {
                this.hRMStateBirth_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=45)]
        public System.Nullable<System.DateTime> HRMTermDate_RU
        {
            get
            {
                return this.hRMTermDate_RUField;
            }
            set
            {
                this.hRMTermDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HRMTermDate_RUSpecified
        {
            get
            {
                return this.hRMTermDate_RUFieldSpecified;
            }
            set
            {
                this.hRMTermDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=46)]
        public string HRMTownBirth_RU
        {
            get
            {
                return this.hRMTownBirth_RUField;
            }
            set
            {
                this.hRMTownBirth_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=47)]
        public string HRMUnhealthySeniorityDateText_RU
        {
            get
            {
                return this.hRMUnhealthySeniorityDateText_RUField;
            }
            set
            {
                this.hRMUnhealthySeniorityDateText_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=48)]
        public string IdentityCardCode_RU
        {
            get
            {
                return this.identityCardCode_RUField;
            }
            set
            {
                this.identityCardCode_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=49)]
        public string IdentityCardIssueBy_RU
        {
            get
            {
                return this.identityCardIssueBy_RUField;
            }
            set
            {
                this.identityCardIssueBy_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=50)]
        public System.Nullable<System.DateTime> IdentityCardIssueDate_RU
        {
            get
            {
                return this.identityCardIssueDate_RUField;
            }
            set
            {
                this.identityCardIssueDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdentityCardIssueDate_RUSpecified
        {
            get
            {
                return this.identityCardIssueDate_RUFieldSpecified;
            }
            set
            {
                this.identityCardIssueDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=51)]
        public string IdentityCardNumber_RU
        {
            get
            {
                return this.identityCardNumber_RUField;
            }
            set
            {
                this.identityCardNumber_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=52)]
        public string IdentityCardSeries_RU
        {
            get
            {
                return this.identityCardSeries_RUField;
            }
            set
            {
                this.identityCardSeries_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=53)]
        public System.Nullable<AxdExtType_smmInclPrivateAppointments> InclPrivateAppointments
        {
            get
            {
                return this.inclPrivateAppointmentsField;
            }
            set
            {
                this.inclPrivateAppointmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InclPrivateAppointmentsSpecified
        {
            get
            {
                return this.inclPrivateAppointmentsFieldSpecified;
            }
            set
            {
                this.inclPrivateAppointmentsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=54)]
        public System.Nullable<AxdExtType_smmInclPrivateTasks> InclPrivateTasks
        {
            get
            {
                return this.inclPrivateTasksField;
            }
            set
            {
                this.inclPrivateTasksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InclPrivateTasksSpecified
        {
            get
            {
                return this.inclPrivateTasksFieldSpecified;
            }
            set
            {
                this.inclPrivateTasksFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=55)]
        public System.Nullable<AxdExtType_smmInclRecurringAppointments> InclRecurringAppointments
        {
            get
            {
                return this.inclRecurringAppointmentsField;
            }
            set
            {
                this.inclRecurringAppointmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InclRecurringAppointmentsSpecified
        {
            get
            {
                return this.inclRecurringAppointmentsFieldSpecified;
            }
            set
            {
                this.inclRecurringAppointmentsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=56)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=57)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=58)]
        public string OutlookCalendarFolderName
        {
            get
            {
                return this.outlookCalendarFolderNameField;
            }
            set
            {
                this.outlookCalendarFolderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=59)]
        public string OutlookContactFolderName
        {
            get
            {
                return this.outlookContactFolderNameField;
            }
            set
            {
                this.outlookContactFolderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=60)]
        public string OutlookTaskFolderName
        {
            get
            {
                return this.outlookTaskFolderNameField;
            }
            set
            {
                this.outlookTaskFolderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=61)]
        public string OutlookUserID
        {
            get
            {
                return this.outlookUserIDField;
            }
            set
            {
                this.outlookUserIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=62)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=63)]
        public System.Nullable<AxdExtType_NoYesId> PayBankPayment_RU
        {
            get
            {
                return this.payBankPayment_RUField;
            }
            set
            {
                this.payBankPayment_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayBankPayment_RUSpecified
        {
            get
            {
                return this.payBankPayment_RUFieldSpecified;
            }
            set
            {
                this.payBankPayment_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=64)]
        public System.Nullable<AxdExtType_NoYesId> PayBlocked_RU
        {
            get
            {
                return this.payBlocked_RUField;
            }
            set
            {
                this.payBlocked_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayBlocked_RUSpecified
        {
            get
            {
                return this.payBlocked_RUFieldSpecified;
            }
            set
            {
                this.payBlocked_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=65)]
        public System.Nullable<System.DateTime> PayBlockedFrom_RU
        {
            get
            {
                return this.payBlockedFrom_RUField;
            }
            set
            {
                this.payBlockedFrom_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayBlockedFrom_RUSpecified
        {
            get
            {
                return this.payBlockedFrom_RUFieldSpecified;
            }
            set
            {
                this.payBlockedFrom_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=66)]
        public string PayCalendarId_RU
        {
            get
            {
                return this.payCalendarId_RUField;
            }
            set
            {
                this.payCalendarId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=67)]
        public System.Nullable<System.DateTime> PayEmploymentDate_RU
        {
            get
            {
                return this.payEmploymentDate_RUField;
            }
            set
            {
                this.payEmploymentDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayEmploymentDate_RUSpecified
        {
            get
            {
                return this.payEmploymentDate_RUFieldSpecified;
            }
            set
            {
                this.payEmploymentDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=68)]
        public string PayFormType_RU
        {
            get
            {
                return this.payFormType_RUField;
            }
            set
            {
                this.payFormType_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=69)]
        public string PayGniCode_RU
        {
            get
            {
                return this.payGniCode_RUField;
            }
            set
            {
                this.payGniCode_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=70)]
        public string PayHRMOrganizationId_RU
        {
            get
            {
                return this.payHRMOrganizationId_RUField;
            }
            set
            {
                this.payHRMOrganizationId_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=71)]
        public string PayINN_RU
        {
            get
            {
                return this.payINN_RUField;
            }
            set
            {
                this.payINN_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=72)]
        public string PayINNPF_RU
        {
            get
            {
                return this.payINNPF_RUField;
            }
            set
            {
                this.payINNPF_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=73)]
        public string PayMainEmplId_Ru
        {
            get
            {
                return this.payMainEmplId_RuField;
            }
            set
            {
                this.payMainEmplId_RuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=74)]
        public System.Nullable<AxdEnum_RPayPensionInsureCategory> PayPensionInsureCategory_RU
        {
            get
            {
                return this.payPensionInsureCategory_RUField;
            }
            set
            {
                this.payPensionInsureCategory_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPensionInsureCategory_RUSpecified
        {
            get
            {
                return this.payPensionInsureCategory_RUFieldSpecified;
            }
            set
            {
                this.payPensionInsureCategory_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=75)]
        public System.Nullable<System.DateTime> PayResignedDate_RU
        {
            get
            {
                return this.payResignedDate_RUField;
            }
            set
            {
                this.payResignedDate_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayResignedDate_RUSpecified
        {
            get
            {
                return this.payResignedDate_RUFieldSpecified;
            }
            set
            {
                this.payResignedDate_RUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=76)]
        public string PBAUserProfile
        {
            get
            {
                return this.pBAUserProfileField;
            }
            set
            {
                this.pBAUserProfileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=77)]
        public string ProjPeriodId
        {
            get
            {
                return this.projPeriodIdField;
            }
            set
            {
                this.projPeriodIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=78)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=79)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=80)]
        public string ReqAttention
        {
            get
            {
                return this.reqAttentionField;
            }
            set
            {
                this.reqAttentionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=81)]
        public string ReqLocationId
        {
            get
            {
                return this.reqLocationIdField;
            }
            set
            {
                this.reqLocationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=82)]
        public string ReqSiteId
        {
            get
            {
                return this.reqSiteIdField;
            }
            set
            {
                this.reqSiteIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=83)]
        public System.Nullable<int> smmSynchronizeDaysBack
        {
            get
            {
                return this.smmSynchronizeDaysBackField;
            }
            set
            {
                this.smmSynchronizeDaysBackField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool smmSynchronizeDaysBackSpecified
        {
            get
            {
                return this.smmSynchronizeDaysBackFieldSpecified;
            }
            set
            {
                this.smmSynchronizeDaysBackFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=84)]
        public System.Nullable<int> smmSynchronizeDaysForward
        {
            get
            {
                return this.smmSynchronizeDaysForwardField;
            }
            set
            {
                this.smmSynchronizeDaysForwardField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool smmSynchronizeDaysForwardSpecified
        {
            get
            {
                return this.smmSynchronizeDaysForwardFieldSpecified;
            }
            set
            {
                this.smmSynchronizeDaysForwardFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=85)]
        public System.Nullable<AxdEnum_HRMEmplStatus> status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=86)]
        public string SyncEntityId
        {
            get
            {
                return this.syncEntityIdField;
            }
            set
            {
                this.syncEntityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=87)]
        public string SyncTransIdCreate
        {
            get
            {
                return this.syncTransIdCreateField;
            }
            set
            {
                this.syncTransIdCreateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=88)]
        public System.Nullable<long> SyncVersion
        {
            get
            {
                return this.syncVersionField;
            }
            set
            {
                this.syncVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SyncVersionSpecified
        {
            get
            {
                return this.syncVersionFieldSpecified;
            }
            set
            {
                this.syncVersionFieldSpecified = value;
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
        public string Training
        {
            get
            {
                return this.trainingField;
            }
            set
            {
                this.trainingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=91)]
        public System.Nullable<AxdExtType_ProjValidateOption> ValidateEmplCategory
        {
            get
            {
                return this.validateEmplCategoryField;
            }
            set
            {
                this.validateEmplCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidateEmplCategorySpecified
        {
            get
            {
                return this.validateEmplCategoryFieldSpecified;
            }
            set
            {
                this.validateEmplCategoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=92)]
        public System.Nullable<AxdExtType_ProjValidateOption> ValidateProjEmpl
        {
            get
            {
                return this.validateProjEmplField;
            }
            set
            {
                this.validateProjEmplField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidateProjEmplSpecified
        {
            get
            {
                return this.validateProjEmplFieldSpecified;
            }
            set
            {
                this.validateProjEmplFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=93)]
        public string WorkTypeId_W
        {
            get
            {
                return this.workTypeId_WField;
            }
            set
            {
                this.workTypeId_WField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocuRef", Order=94)]
        public AxdEntity_DocuRef[] DocuRef
        {
            get
            {
                return this.docuRefField;
            }
            set
            {
                this.docuRefField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdExtType_smmActivateAnswer
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_NoYes
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdExtType_smmEMailSaveCopy
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_EmplGender
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Male,
        
        /// <remarks/>
        Female,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_RHRMBirthPlaceType
    {
        
        /// <remarks/>
        Standard,
        
        /// <remarks/>
        Special,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_RHRMKindOfWork
    {
        
        /// <remarks/>
        Permanent,
        
        /// <remarks/>
        Temporary,
        
        /// <remarks/>
        CertainTime,
        
        /// <remarks/>
        Seasonal,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_RHRMMilitaryService
    {
        
        /// <remarks/>
        Liable,
        
        /// <remarks/>
        NotLiable,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_RHRMMilitaryServiceAbleBodied
    {
        
        /// <remarks/>
        Able,
        
        /// <remarks/>
        LowBoundAble,
        
        /// <remarks/>
        BoundAble,
        
        /// <remarks/>
        TempUnAble,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_RHRMMilitaryTakeOffRegister
    {
        
        /// <remarks/>
        Register,
        
        /// <remarks/>
        InAge,
        
        /// <remarks/>
        OnStateOfHealth,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_RHRMSortOfWork
    {
        
        /// <remarks/>
        Direct,
        
        /// <remarks/>
        Pluralistically,
        
        /// <remarks/>
        CivilContract,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdExtType_smmInclPrivateAppointments
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdExtType_smmInclPrivateTasks
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdExtType_smmInclRecurringAppointments
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdExtType_NoYesId
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_RPayPensionInsureCategory
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        WageEarner,
        
        /// <remarks/>
        AgriculturalEarner,
        
        /// <remarks/>
        Unemployed,
        
        /// <remarks/>
        VoluntarilyPayment,
        
        /// <remarks/>
        NaturalPerson,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_HRMEmplStatus
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Employed,
        
        /// <remarks/>
        Resigned,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdExtType_ProjValidateOption
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdEntity_DirPartyTable
    {
        
        private string _DocumentHashField;
        
        private string firstNameField;
        
        private string generationalSuffixField;
        
        private string iNN_RUField;
        
        private string languageIdField;
        
        private string lastNameField;
        
        private string memoField;
        
        private string middleNameField;
        
        private string nameField;
        
        private string nameAliasField;
        
        private string partyIdField;
        
        private System.Nullable<AxdEnum_DirPersonNameOrder> personNameOrderField;
        
        private bool personNameOrderFieldSpecified;
        
        private string prefixField;
        
        private string professionalSuffixField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string salutationField;
        
        private AxdEnum_DirPartyType typeField;
        
        private AxdEntity_EmplTable[] emplTableField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_DirPartyTable()
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string GenerationalSuffix
        {
            get
            {
                return this.generationalSuffixField;
            }
            set
            {
                this.generationalSuffixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string INN_RU
        {
            get
            {
                return this.iNN_RUField;
            }
            set
            {
                this.iNN_RUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<AxdEnum_DirPersonNameOrder> PersonNameOrder
        {
            get
            {
                return this.personNameOrderField;
            }
            set
            {
                this.personNameOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PersonNameOrderSpecified
        {
            get
            {
                return this.personNameOrderFieldSpecified;
            }
            set
            {
                this.personNameOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string Prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string ProfessionalSuffix
        {
            get
            {
                return this.professionalSuffixField;
            }
            set
            {
                this.professionalSuffixField = value;
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
        public string Salutation
        {
            get
            {
                return this.salutationField;
            }
            set
            {
                this.salutationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public AxdEnum_DirPartyType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmplTable", Order=18)]
        public AxdEntity_EmplTable[] EmplTable
        {
            get
            {
                return this.emplTableField;
            }
            set
            {
                this.emplTableField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_DirPersonNameOrder
    {
        
        /// <remarks/>
        FirstMiddleLast,
        
        /// <remarks/>
        FirstLastMiddle,
        
        /// <remarks/>
        MiddleLastFirst,
        
        /// <remarks/>
        MiddleLastCommaFirst,
        
        /// <remarks/>
        MiddleFirstLast,
        
        /// <remarks/>
        Manual,
        
        /// <remarks/>
        LastFirstMiddle,
        
        /// <remarks/>
        LastCommaFirstMiddle,
        
        /// <remarks/>
        LastMiddleFirst,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public enum AxdEnum_DirPartyType
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Person,
        
        /// <remarks/>
        Organization,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
    public partial class AxdDirPartyTableCustom
    {
        
        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;
        
        private bool docPurposeFieldSpecified;
        
        private string senderIdField;
        
        private AxdEntity_DirPartyTable[] dirPartyTableField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("DirPartyTable", Order=2)]
        public AxdEntity_DirPartyTable[] DirPartyTable
        {
            get
            {
                return this.dirPartyTableField;
            }
            set
            {
                this.dirPartyTableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="DirPartyTableService.DirPartyTableCustomService")]
    public interface DirPartyTableCustomService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DirPartyTableCustomService/find", ReplyAction="http://tempuri.org/DirPartyTableCustomService/findResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DirPartyTableService.AifFault), Action="http://tempuri.org/DirPartyTableCustomService/findAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceFindResponse> findAsync(DirPartyTableService.DirPartyTableCustomServiceFindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DirPartyTableCustomService/read", ReplyAction="http://tempuri.org/DirPartyTableCustomService/readResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DirPartyTableService.AifFault), Action="http://tempuri.org/DirPartyTableCustomService/readAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceReadResponse> readAsync(DirPartyTableService.DirPartyTableCustomServiceReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DirPartyTableCustomService/findKeys", ReplyAction="http://tempuri.org/DirPartyTableCustomService/findKeysResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DirPartyTableService.AifFault), Action="http://tempuri.org/DirPartyTableCustomService/findKeysAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceFindKeysResponse> findKeysAsync(DirPartyTableService.DirPartyTableCustomServiceFindKeysRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DirPartyTableCustomServiceFindRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class DirPartyTableCustomServiceFindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public DirPartyTableService.QueryCriteria QueryCriteria;
        
        public DirPartyTableCustomServiceFindRequest()
        {
        }
        
        public DirPartyTableCustomServiceFindRequest(DirPartyTableService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DirPartyTableCustomServiceFindResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class DirPartyTableCustomServiceFindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
        public DirPartyTableService.AxdDirPartyTableCustom DirPartyTableCustom;
        
        public DirPartyTableCustomServiceFindResponse()
        {
        }
        
        public DirPartyTableCustomServiceFindResponse(DirPartyTableService.AxdDirPartyTableCustom DirPartyTableCustom)
        {
            this.DirPartyTableCustom = DirPartyTableCustom;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DirPartyTableCustomServiceReadRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class DirPartyTableCustomServiceReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public DirPartyTableService.EntityKey[] EntityKeyList;
        
        public DirPartyTableCustomServiceReadRequest()
        {
        }
        
        public DirPartyTableCustomServiceReadRequest(DirPartyTableService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DirPartyTableCustomServiceReadResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class DirPartyTableCustomServiceReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/DirPartyTableCustom")]
        public DirPartyTableService.AxdDirPartyTableCustom DirPartyTableCustom;
        
        public DirPartyTableCustomServiceReadResponse()
        {
        }
        
        public DirPartyTableCustomServiceReadResponse(DirPartyTableService.AxdDirPartyTableCustom DirPartyTableCustom)
        {
            this.DirPartyTableCustom = DirPartyTableCustom;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DirPartyTableCustomServiceFindKeysRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class DirPartyTableCustomServiceFindKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public DirPartyTableService.QueryCriteria QueryCriteria;
        
        public DirPartyTableCustomServiceFindKeysRequest()
        {
        }
        
        public DirPartyTableCustomServiceFindKeysRequest(DirPartyTableService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DirPartyTableCustomServiceFindKeysResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class DirPartyTableCustomServiceFindKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public DirPartyTableService.EntityKey[] EntityKeyList;
        
        public DirPartyTableCustomServiceFindKeysResponse()
        {
        }
        
        public DirPartyTableCustomServiceFindKeysResponse(DirPartyTableService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface DirPartyTableCustomServiceChannel : DirPartyTableService.DirPartyTableCustomService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class DirPartyTableCustomServiceClient : System.ServiceModel.ClientBase<DirPartyTableService.DirPartyTableCustomService>, DirPartyTableService.DirPartyTableCustomService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DirPartyTableCustomServiceClient() : 
                base(DirPartyTableCustomServiceClient.GetDefaultBinding(), DirPartyTableCustomServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_DirPartyTableCustomService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DirPartyTableCustomServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(DirPartyTableCustomServiceClient.GetBindingForEndpoint(endpointConfiguration), DirPartyTableCustomServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DirPartyTableCustomServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DirPartyTableCustomServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DirPartyTableCustomServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DirPartyTableCustomServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DirPartyTableCustomServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceFindResponse> DirPartyTableService.DirPartyTableCustomService.findAsync(DirPartyTableService.DirPartyTableCustomServiceFindRequest request)
        {
            return base.Channel.findAsync(request);
        }
        
        public System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceFindResponse> findAsync(DirPartyTableService.QueryCriteria QueryCriteria)
        {
            DirPartyTableService.DirPartyTableCustomServiceFindRequest inValue = new DirPartyTableService.DirPartyTableCustomServiceFindRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((DirPartyTableService.DirPartyTableCustomService)(this)).findAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceReadResponse> DirPartyTableService.DirPartyTableCustomService.readAsync(DirPartyTableService.DirPartyTableCustomServiceReadRequest request)
        {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceReadResponse> readAsync(DirPartyTableService.EntityKey[] EntityKeyList)
        {
            DirPartyTableService.DirPartyTableCustomServiceReadRequest inValue = new DirPartyTableService.DirPartyTableCustomServiceReadRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((DirPartyTableService.DirPartyTableCustomService)(this)).readAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceFindKeysResponse> DirPartyTableService.DirPartyTableCustomService.findKeysAsync(DirPartyTableService.DirPartyTableCustomServiceFindKeysRequest request)
        {
            return base.Channel.findKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<DirPartyTableService.DirPartyTableCustomServiceFindKeysResponse> findKeysAsync(DirPartyTableService.QueryCriteria QueryCriteria)
        {
            DirPartyTableService.DirPartyTableCustomServiceFindKeysRequest inValue = new DirPartyTableService.DirPartyTableCustomServiceFindKeysRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((DirPartyTableService.DirPartyTableCustomService)(this)).findKeysAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_DirPartyTableCustomService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_DirPartyTableCustomService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/MicrosoftDynamicsAXAif50/dirpartytablecustomser" +
                        "vice.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return DirPartyTableCustomServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_DirPartyTableCustomService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return DirPartyTableCustomServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_DirPartyTableCustomService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_DirPartyTableCustomService,
        }
    }
}
