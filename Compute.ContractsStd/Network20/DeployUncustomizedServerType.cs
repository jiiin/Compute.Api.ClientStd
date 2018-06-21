namespace DD.CBU.Compute.Api.ContractsStd.Server
{
    using Network20;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("deployUncustomizedServer", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class DeployUncustomizedServerType
    {

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string description;

        /// <remarks/>
        public string imageId;

        /// <remarks/>
        public string clusterId;

        /// <remarks/>
        public bool start;

        /// <remarks/>
        public DeployServerTypeCpu cpu;

        /// <remarks/>
        public uint memoryGb;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool memoryGbSpecified;

        /// <remarks/>
        public DeployServerTypeNetworkInfo networkInfo;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("disk")]
        public DeployServerTypeDisk[] disk;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tagById")]
        public ApplyTagByIdType[] tagById;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public ApplyTagType[] tag;
    }
}