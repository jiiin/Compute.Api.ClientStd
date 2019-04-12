namespace DD.CBU.Compute.Api.Contracts.Network20
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerIdeDeviceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerSataDeviceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerDeviceType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeGbSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerIdeDeviceType : ServerDeviceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int slot;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerSataDeviceType : ServerDeviceType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sataId;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerIdeDiskType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerScsiDiskType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerSataDiskType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerDiskType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int iops;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerIdeDiskType : ServerDiskType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int slot;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerSataDiskType : ServerDiskType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sataId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerScsiDiskType : ServerDiskType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int scsiId;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerIdeControllerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerScsiControllerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerSataControllerType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerControllerType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string adapterType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int key;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool keySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerIdeControllerType : ServerControllerType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device", typeof(ServerIdeDeviceType))]
        [System.Xml.Serialization.XmlElementAttribute("disk", typeof(ServerIdeDiskType))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int channel;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerSataControllerType : ServerControllerType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device", typeof(ServerSataDeviceType))]
        [System.Xml.Serialization.XmlElementAttribute("disk", typeof(ServerSataDiskType))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int busNumber;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerScsiControllerType : ServerControllerType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("disk")]
        public ServerScsiDiskType[] disk;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int busNumber;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("addScsiController", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class AddScsiControllerType
    {

        /// <remarks/>
        public string serverId;

        /// <remarks/>
        public string adapterType;

        /// <remarks/>
        public int busNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool busNumberSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("removeScsiController", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class RemoveScsiControllerIdType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;
    }
}
