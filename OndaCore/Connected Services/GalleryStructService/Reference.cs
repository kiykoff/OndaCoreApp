//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace GalleryStructService
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public partial class AxdEntity_ItemLevelGroup
    {
        
        private string inventDimIdField;
        
        private string itemIdField;
        
        private string productGroupIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_ItemLevelGroup()
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        public string ProductGroupId
        {
            get
            {
                return this.productGroupIdField;
            }
            set
            {
                this.productGroupIdField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public partial class AxdEntity_FourthLevelGroup
    {
        
        private string childProductGroupIdField;
        
        private string parentProductGroupIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private AxdEntity_ItemLevelGroup[] itemLevelGroupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_FourthLevelGroup()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ChildProductGroupId
        {
            get
            {
                return this.childProductGroupIdField;
            }
            set
            {
                this.childProductGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ParentProductGroupId
        {
            get
            {
                return this.parentProductGroupIdField;
            }
            set
            {
                this.parentProductGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute("ItemLevelGroup", Order=4)]
        public AxdEntity_ItemLevelGroup[] ItemLevelGroup
        {
            get
            {
                return this.itemLevelGroupField;
            }
            set
            {
                this.itemLevelGroupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public partial class AxdEntity_ThirdLevelGroup
    {
        
        private string childProductGroupIdField;
        
        private string parentProductGroupIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private AxdEntity_FourthLevelGroup[] fourthLevelGroupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_ThirdLevelGroup()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ChildProductGroupId
        {
            get
            {
                return this.childProductGroupIdField;
            }
            set
            {
                this.childProductGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ParentProductGroupId
        {
            get
            {
                return this.parentProductGroupIdField;
            }
            set
            {
                this.parentProductGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute("FourthLevelGroup", Order=4)]
        public AxdEntity_FourthLevelGroup[] FourthLevelGroup
        {
            get
            {
                return this.fourthLevelGroupField;
            }
            set
            {
                this.fourthLevelGroupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public partial class AxdEntity_SecondLevelGroup
    {
        
        private string childProductGroupIdField;
        
        private string parentProductGroupIdField;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private AxdEntity_ThirdLevelGroup[] thirdLevelGroupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_SecondLevelGroup()
        {
            this.classField = "entity";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ChildProductGroupId
        {
            get
            {
                return this.childProductGroupIdField;
            }
            set
            {
                this.childProductGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ParentProductGroupId
        {
            get
            {
                return this.parentProductGroupIdField;
            }
            set
            {
                this.parentProductGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute("ThirdLevelGroup", Order=4)]
        public AxdEntity_ThirdLevelGroup[] ThirdLevelGroup
        {
            get
            {
                return this.thirdLevelGroupField;
            }
            set
            {
                this.thirdLevelGroupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public partial class AxdExtType_PackedQueryRun
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public partial class AxdEntity_FirstLevelGroup
    {
        
        private string _DocumentHashField;
        
        private string nameField;
        
        private AxdExtType_PackedQueryRun packedQueryField;
        
        private string productGroupIdField;
        
        private System.Nullable<AxdEnum_InventProductGroupType> productGroupTypeField;
        
        private bool productGroupTypeFieldSpecified;
        
        private System.Nullable<long> recIdField;
        
        private bool recIdFieldSpecified;
        
        private System.Nullable<int> recVersionField;
        
        private bool recVersionFieldSpecified;
        
        private AxdEntity_SecondLevelGroup[] secondLevelGroupField;
        
        private string classField;
        
        private AxdEnum_AxdEntityAction actionField;
        
        private bool actionFieldSpecified;
        
        public AxdEntity_FirstLevelGroup()
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public AxdExtType_PackedQueryRun PackedQuery
        {
            get
            {
                return this.packedQueryField;
            }
            set
            {
                this.packedQueryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ProductGroupId
        {
            get
            {
                return this.productGroupIdField;
            }
            set
            {
                this.productGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<AxdEnum_InventProductGroupType> ProductGroupType
        {
            get
            {
                return this.productGroupTypeField;
            }
            set
            {
                this.productGroupTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductGroupTypeSpecified
        {
            get
            {
                return this.productGroupTypeFieldSpecified;
            }
            set
            {
                this.productGroupTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute("SecondLevelGroup", Order=7)]
        public AxdEntity_SecondLevelGroup[] SecondLevelGroup
        {
            get
            {
                return this.secondLevelGroupField;
            }
            set
            {
                this.secondLevelGroupField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public enum AxdEnum_InventProductGroupType
    {
        
        /// <remarks/>
        Grp,
        
        /// <remarks/>
        Item,
        
        /// <remarks/>
        Category,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
    public partial class AxdWebGalleryStruct
    {
        
        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;
        
        private bool docPurposeFieldSpecified;
        
        private string senderIdField;
        
        private AxdEntity_FirstLevelGroup[] firstLevelGroupField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("FirstLevelGroup", Order=2)]
        public AxdEntity_FirstLevelGroup[] FirstLevelGroup
        {
            get
            {
                return this.firstLevelGroupField;
            }
            set
            {
                this.firstLevelGroupField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="GalleryStructService.WebGalleryStructService")]
    public interface WebGalleryStructService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebGalleryStructService/read", ReplyAction="http://tempuri.org/WebGalleryStructService/readResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GalleryStructService.AifFault), Action="http://tempuri.org/WebGalleryStructService/readAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceReadResponse> readAsync(GalleryStructService.WebGalleryStructServiceReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebGalleryStructService/find", ReplyAction="http://tempuri.org/WebGalleryStructService/findResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GalleryStructService.AifFault), Action="http://tempuri.org/WebGalleryStructService/findAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceFindResponse> findAsync(GalleryStructService.WebGalleryStructServiceFindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebGalleryStructService/findKeys", ReplyAction="http://tempuri.org/WebGalleryStructService/findKeysResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GalleryStructService.AifFault), Action="http://tempuri.org/WebGalleryStructService/findKeysAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceFindKeysResponse> findKeysAsync(GalleryStructService.WebGalleryStructServiceFindKeysRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WebGalleryStructServiceReadRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class WebGalleryStructServiceReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public GalleryStructService.EntityKey[] EntityKeyList;
        
        public WebGalleryStructServiceReadRequest()
        {
        }
        
        public WebGalleryStructServiceReadRequest(GalleryStructService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WebGalleryStructServiceReadResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class WebGalleryStructServiceReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
        public GalleryStructService.AxdWebGalleryStruct WebGalleryStruct;
        
        public WebGalleryStructServiceReadResponse()
        {
        }
        
        public WebGalleryStructServiceReadResponse(GalleryStructService.AxdWebGalleryStruct WebGalleryStruct)
        {
            this.WebGalleryStruct = WebGalleryStruct;
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="WebGalleryStructServiceFindRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class WebGalleryStructServiceFindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public GalleryStructService.QueryCriteria QueryCriteria;
        
        public WebGalleryStructServiceFindRequest()
        {
        }
        
        public WebGalleryStructServiceFindRequest(GalleryStructService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WebGalleryStructServiceFindResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class WebGalleryStructServiceFindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/WebGalleryStruct")]
        public GalleryStructService.AxdWebGalleryStruct WebGalleryStruct;
        
        public WebGalleryStructServiceFindResponse()
        {
        }
        
        public WebGalleryStructServiceFindResponse(GalleryStructService.AxdWebGalleryStruct WebGalleryStruct)
        {
            this.WebGalleryStruct = WebGalleryStruct;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WebGalleryStructServiceFindKeysRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class WebGalleryStructServiceFindKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/QueryCriteria")]
        public GalleryStructService.QueryCriteria QueryCriteria;
        
        public WebGalleryStructServiceFindKeysRequest()
        {
        }
        
        public WebGalleryStructServiceFindKeysRequest(GalleryStructService.QueryCriteria QueryCriteria)
        {
            this.QueryCriteria = QueryCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WebGalleryStructServiceFindKeysResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class WebGalleryStructServiceFindKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKeyList")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/dynamics/2006/02/documents/EntityKey", IsNullable=false)]
        public GalleryStructService.EntityKey[] EntityKeyList;
        
        public WebGalleryStructServiceFindKeysResponse()
        {
        }
        
        public WebGalleryStructServiceFindKeysResponse(GalleryStructService.EntityKey[] EntityKeyList)
        {
            this.EntityKeyList = EntityKeyList;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface WebGalleryStructServiceChannel : GalleryStructService.WebGalleryStructService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class WebGalleryStructServiceClient : System.ServiceModel.ClientBase<GalleryStructService.WebGalleryStructService>, GalleryStructService.WebGalleryStructService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WebGalleryStructServiceClient() : 
                base(WebGalleryStructServiceClient.GetDefaultBinding(), WebGalleryStructServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_WebGalleryStructService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebGalleryStructServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WebGalleryStructServiceClient.GetBindingForEndpoint(endpointConfiguration), WebGalleryStructServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebGalleryStructServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WebGalleryStructServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebGalleryStructServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WebGalleryStructServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebGalleryStructServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceReadResponse> GalleryStructService.WebGalleryStructService.readAsync(GalleryStructService.WebGalleryStructServiceReadRequest request)
        {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceReadResponse> readAsync(GalleryStructService.EntityKey[] EntityKeyList)
        {
            GalleryStructService.WebGalleryStructServiceReadRequest inValue = new GalleryStructService.WebGalleryStructServiceReadRequest();
            inValue.EntityKeyList = EntityKeyList;
            return ((GalleryStructService.WebGalleryStructService)(this)).readAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceFindResponse> GalleryStructService.WebGalleryStructService.findAsync(GalleryStructService.WebGalleryStructServiceFindRequest request)
        {
            return base.Channel.findAsync(request);
        }
        
        public System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceFindResponse> findAsync(GalleryStructService.QueryCriteria QueryCriteria)
        {
            GalleryStructService.WebGalleryStructServiceFindRequest inValue = new GalleryStructService.WebGalleryStructServiceFindRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((GalleryStructService.WebGalleryStructService)(this)).findAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceFindKeysResponse> GalleryStructService.WebGalleryStructService.findKeysAsync(GalleryStructService.WebGalleryStructServiceFindKeysRequest request)
        {
            return base.Channel.findKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<GalleryStructService.WebGalleryStructServiceFindKeysResponse> findKeysAsync(GalleryStructService.QueryCriteria QueryCriteria)
        {
            GalleryStructService.WebGalleryStructServiceFindKeysRequest inValue = new GalleryStructService.WebGalleryStructServiceFindKeysRequest();
            inValue.QueryCriteria = QueryCriteria;
            return ((GalleryStructService.WebGalleryStructService)(this)).findKeysAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_WebGalleryStructService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_WebGalleryStructService))
            {
                return new System.ServiceModel.EndpointAddress("http://ax5-aos1.terracorp.ru:2730/MicrosoftDynamicsAXAif50/webgallerystructservic" +
                        "e.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WebGalleryStructServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_WebGalleryStructService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WebGalleryStructServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_WebGalleryStructService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_WebGalleryStructService,
        }
    }
}
