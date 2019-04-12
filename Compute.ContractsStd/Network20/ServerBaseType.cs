namespace DD.CBU.Compute.Api.Contracts.Network20
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("servers", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class ServersSummaryResposeType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("server")]
        public ServerSummaryType[] server;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("server", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class ServerDetailType : ServerBaseType
    {
        /// <remarks/>
        public SnapshotServiceDetailType snapshotService;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerSummaryType : ServerBaseType
    {
        /// <remarks/>
        public SnapshotServiceSummaryType snapshotService;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerSummaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerDetailType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerBaseType
    {

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string description;

        /// <remarks/>
        public ClusterType cluster;

        /// <remarks/>
        public CpuType cpu;

        /// <remarks/>
        public uint memoryGb;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scsiController")]
        public ServerScsiControllerType[] scsiController;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sataController")]
        public ServerSataControllerType[] sataController;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ideController")]
        public ServerIdeControllerType[] ideController;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("floppy")]
        public ServerFloppyType[] floppy;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("networkInfo", typeof(ServerBaseTypeNetworkInfo))]
        [System.Xml.Serialization.XmlElementAttribute("nic", typeof(ServerBaseTypeNic))]
        public object Item;

        /// <remarks/>
        public ServerBaseTypeBackup backup;

        /// <remarks/>
        public ServerBaseTypeMonitoring monitoring;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("specialTrait")]
        public string[] specialTrait;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("softwareLabel")]
        public string[] softwareLabel;

        /// <remarks/>
        public ServerSourceType source;

        /// <remarks/>
        public System.DateTime createTime;

        /// <remarks/>
        public bool deployed;

        /// <remarks/>
        public bool started;

        /// <remarks/>
        public string state;

        /// <remarks/>
        public string deploymentMode;

        /// <remarks/>
        public GuestType guest;

        /// <remarks/>
        public VirtualHardwareType virtualHardware;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consistencyGroup", typeof(ServerBaseTypeConsistencyGroup))]
        [System.Xml.Serialization.XmlElementAttribute("drsEligible", typeof(ServerBaseTypeDrsEligible))]
        public object Item1;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public TagWithIdAndNameType[] tag;

        /// <remarks/>
        public ProgressType progress;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerFloppyType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int driveNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int key;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool keySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeGbSpecified;

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
    public partial class ServerSourceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerBaseTypeNetworkInfo
    {

        /// <remarks/>
        public NicType primaryNic;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalNic")]
        public NicType[] additionalNic;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkDomainId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerBaseTypeNic
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string privateIpv4;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerBaseTypeBackup
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string servicePlan;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerBaseTypeMonitoring
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string monitoringId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string servicePlan;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerBaseTypeConsistencyGroup
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serverRole;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerBaseTypeDrsEligible
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SnapshotServiceDetailType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class SnapshotServiceSummaryType
    {

        private string servicePlanField;

        private string stateField;

        private bool manualSnapshotInProgressField;

        private string replicationTargetDatacenterIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string servicePlan
        {
            get
            {
                return this.servicePlanField;
            }
            set
            {
                this.servicePlanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool manualSnapshotInProgress
        {
            get
            {
                return this.manualSnapshotInProgressField;
            }
            set
            {
                this.manualSnapshotInProgressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string replicationTargetDatacenterId
        {
            get
            {
                return this.replicationTargetDatacenterIdField;
            }
            set
            {
                this.replicationTargetDatacenterIdField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class SnapshotServiceDetailType : SnapshotServiceSummaryType
    {

        /// <remarks/>
        public SnapshotServiceDetailTypeWindow window;

        /// <remarks/>
        public SnapshotServiceDetailTypePreSnapshotScript preSnapshotScript;

        /// <remarks/>
        public SnapshotServiceDetailTypePostSnapshotScript postSnapshotScript;
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class SnapshotServiceDetailTypeWindow
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dayOfWeek;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startHour;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class SnapshotServiceDetailTypePreSnapshotScript
    {

        /// <remarks/>
        public string path;

        /// <remarks/>
        public string description;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int timeoutSeconds;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string failureHandling;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class SnapshotServiceDetailTypePostSnapshotScript
    {

        /// <remarks/>
        public string path;

        /// <remarks/>
        public string description;
    }
}