using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Api.Contracts.Server
{

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("createDrsTargetServer", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class CreateDrsTargetServerType
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("clusterId", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("datacenterId", typeof(string))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
		public string Item;

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ClusterDatacenterChoiceType ItemElementName;

		/// <remarks/>
		public string name;

		/// <remarks/>
		public string description;

		/// <remarks/>
		public string targetNetworkDomainId;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("nic")]
		public CreateDrsTargetServerTypeNic[] nic;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("tagById")]
		public ApplyTagByIdType[] tagById;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("tag")]
		public ApplyTagType[] tag;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string sourceServerId;
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class CreateDrsTargetServerTypeNic
	{

		/// <remarks/>
		public string sourceNicId;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("targetPrivateIpv4", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("targetVlanId", typeof(string))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
		public string Item;

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public TargetVlanIdPrivateIpv4ChoiceType ItemElementName;
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
	public enum TargetVlanIdPrivateIpv4ChoiceType
	{

		/// <remarks/>
		targetPrivateIpv4,

		/// <remarks/>
		targetVlanId,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
	public enum ClusterDatacenterChoiceType
	{

		/// <remarks/>
		clusterId,

		/// <remarks/>
		datacenterId,
	}
}
