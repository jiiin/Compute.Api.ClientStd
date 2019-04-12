namespace DD.CBU.Compute.Api.Contracts.Snapshot
{ 
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("createSnapshotPreviewServer", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class CreateSnapshotPreviewServerType
    {
        /// <remarks/>
        public string serverName;

        /// <remarks/>
        public string serverDescription;

        /// <remarks/>
        public string targetClusterId;

        /// <remarks/>
        public bool serverStarted;

        /// <remarks/>
        public bool nicsConnected;

		/// <remarks/>
		public bool preserveMacAddresses;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("tagById")] public ApplyTagByIdType[] tagById;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")] public ApplyTagType[] tag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] public string snapshotId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ApplyTagByIdType
    {
        /// <remarks/>
        public string tagKeyId;

        /// <remarks/>
        public string value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ApplyTagType
    {
        /// <remarks/>
        public string tagKeyName;

        /// <remarks/>
        public string value;
    }
}