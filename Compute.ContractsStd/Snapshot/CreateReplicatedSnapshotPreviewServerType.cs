namespace DD.CBU.Compute.Api.Contracts.Snapshot
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("createReplicatedSnapshotPreviewServer", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class CreateReplicatedSnapshotPreviewServerType
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
		[System.Xml.Serialization.XmlElementAttribute("nic")]
		public CreateReplicatedSnapshotPreviewServerTypeNic[] nic;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("tagById")]
		public ApplyTagByIdType[] tagById;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("tag")]
		public ApplyTagType[] tag;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string replicatedSnapshotId;
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class CreateReplicatedSnapshotPreviewServerTypeNic
	{

		/// <remarks/>
		public string vlanId;

		/// <remarks/>
		public string privateIpv4;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string sourceNicId;
	}
}