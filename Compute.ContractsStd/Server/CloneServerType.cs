using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Api.Contracts.Server
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("cloneServer", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class CloneServerType
    {

        /// <remarks/>
        public string imageName;

        /// <remarks/>
        public string description;

        /// <remarks/>
        public string clusterId;

        /// <remarks/>
        public bool guestOsCustomization;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool guestOsCustomizationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tagById")]
        public ApplyTagByIdType[] tagById;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public ApplyTagType[] tag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;
    }
}
