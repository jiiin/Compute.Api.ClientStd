﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace DD.CBU.Compute.Api.Contracts.Network20
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("node", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)
    ]
    public partial class NodeType
    {

        private string networkDomainIdField;

        private string nameField;

        private string descriptionField;

        private string itemField;

        private IpItemChoiceType itemElementNameField;

        private string stateField;

        private string statusField;

        private NodeTypeHealthMonitor healthMonitorField;

        private int connectionLimitField;

        private int connectionRateLimitField;

        private System.DateTime createTimeField;

        private bool loggingEnabledField;

        private bool loggingEnabledFieldSpecified;

        private string idField;

        private string datacenterIdField;

        /// <remarks/>
        public string networkDomainId
        {
            get { return this.networkDomainIdField; }
            set { this.networkDomainIdField = value; }
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ipv4Address", typeof (string))]
        [System.Xml.Serialization.XmlElementAttribute("ipv6Address", typeof (string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public IpItemChoiceType ItemElementName
        {
            get { return this.itemElementNameField; }
            set { this.itemElementNameField = value; }
        }

        /// <remarks/>
        public string state
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <remarks/>
        public string status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <remarks/>
        public NodeTypeHealthMonitor healthMonitor
        {
            get { return this.healthMonitorField; }
            set { this.healthMonitorField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public int connectionLimit
        {
            get { return this.connectionLimitField; }
            set { this.connectionLimitField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public int connectionRateLimit
        {
            get { return this.connectionRateLimitField; }
            set { this.connectionRateLimitField = value; }
        }

        /// <remarks/>
        public System.DateTime createTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
        }

        /// <remarks/>
        public bool loggingEnabled
        {
            get { return this.loggingEnabledField; }
            set { this.loggingEnabledField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool loggingEnabledSpecified
        {
            get { return this.loggingEnabledFieldSpecified; }
            set { this.loggingEnabledFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId
        {
            get { return this.datacenterIdField; }
            set { this.datacenterIdField = value; }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
    public enum IpItemChoiceType
    {

        /// <remarks/>
        ipv4Address,

        /// <remarks/>
        ipv6Address,
    }
	
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class NodeTypeHealthMonitor
    {

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class nodes
    {

        private NodeType[] nodeField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("node")]
        public NodeType[] node
        {
            get { return this.nodeField; }
            set { this.nodeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber
        {
            get { return this.pageNumberField; }
            set { this.pageNumberField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified
        {
            get { return this.pageNumberFieldSpecified; }
            set { this.pageNumberFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount
        {
            get { return this.pageCountField; }
            set { this.pageCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified
        {
            get { return this.pageCountFieldSpecified; }
            set { this.pageCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount
        {
            get { return this.totalCountField; }
            set { this.totalCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified
        {
            get { return this.totalCountFieldSpecified; }
            set { this.totalCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize
        {
            get { return this.pageSizeField; }
            set { this.pageSizeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified
        {
            get { return this.pageSizeFieldSpecified; }
            set { this.pageSizeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("createNode", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class CreateNodeType
    {

        private string networkDomainIdField;

        private string nameField;

        private string descriptionField;

        private string itemField;

        private IpItemChoiceType itemElementNameField;

        private string statusField;

        private string healthMonitorIdField;

        private int connectionLimitField;

        private int connectionRateLimitField;

        /// <remarks/>
        public string networkDomainId
        {
            get { return this.networkDomainIdField; }
            set { this.networkDomainIdField = value; }
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ipv4Address", typeof (string))]
        [System.Xml.Serialization.XmlElementAttribute("ipv6Address", typeof (string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public IpItemChoiceType ItemElementName
        {
            get { return this.itemElementNameField; }
            set { this.itemElementNameField = value; }
        }

        /// <remarks/>
        public string status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <remarks/>
        public string healthMonitorId
        {
            get { return this.healthMonitorIdField; }
            set { this.healthMonitorIdField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public int connectionLimit
        {
            get { return this.connectionLimitField; }
            set { this.connectionLimitField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public int connectionRateLimit
        {
            get { return this.connectionRateLimitField; }
            set { this.connectionRateLimitField = value; }
        }
    }

  
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("editNode", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class EditNodeType
    {

        private string descriptionField;

        private string statusField;

        private string healthMonitorIdField;

        private int connectionLimitField;

        private int connectionRateLimitField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string healthMonitorId
        {
            get { return this.healthMonitorIdField; }
            set { this.healthMonitorIdField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public int connectionLimit
        {
            get { return this.connectionLimitField; }
            set { this.connectionLimitField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public int connectionRateLimit
        {
            get { return this.connectionRateLimitField; }
            set { this.connectionRateLimitField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("deleteNode", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class DeleteNodeType
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }
}
