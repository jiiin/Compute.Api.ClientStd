using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Api.Contracts.Network20
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("staticRoute", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class StaticRouteType
	{

		private string networkDomainIdField;

		private string nameField;

		private string descriptionField;

		private string typeField;

		private string ipVersionField;

		private string destinationNetworkAddressField;

		private int destinationPrefixSizeField;

		private string nextHopAddressField;

		private string nextHopAddressVlanIdField;

		private string stateField;

		private System.DateTime createTimeField;

		private string idField;

		private string datacenterIdField;

		/// <remarks/>
		public string networkDomainId
		{
			get
			{
				return this.networkDomainIdField;
			}
			set
			{
				this.networkDomainIdField = value;
			}
		}

		/// <remarks/>
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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string type
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
		public string ipVersion
		{
			get
			{
				return this.ipVersionField;
			}
			set
			{
				this.ipVersionField = value;
			}
		}

		/// <remarks/>
		public string destinationNetworkAddress
		{
			get
			{
				return this.destinationNetworkAddressField;
			}
			set
			{
				this.destinationNetworkAddressField = value;
			}
		}

		/// <remarks/>
		public int destinationPrefixSize
		{
			get
			{
				return this.destinationPrefixSizeField;
			}
			set
			{
				this.destinationPrefixSizeField = value;
			}
		}

		/// <remarks/>
		public string nextHopAddress
		{
			get
			{
				return this.nextHopAddressField;
			}
			set
			{
				this.nextHopAddressField = value;
			}
		}

		/// <remarks/>
		public string nextHopAddressVlanId
		{
			get
			{
				return this.nextHopAddressVlanIdField;
			}
			set
			{
				this.nextHopAddressVlanIdField = value;
			}
		}

		/// <remarks/>
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
		public System.DateTime createTime
		{
			get
			{
				return this.createTimeField;
			}
			set
			{
				this.createTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string datacenterId
		{
			get
			{
				return this.datacenterIdField;
			}
			set
			{
				this.datacenterIdField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class staticRoutes
	{

		private StaticRouteType[] staticRouteField;

		private int pageNumberField;

		private bool pageNumberFieldSpecified;

		private int pageCountField;

		private bool pageCountFieldSpecified;

		private int totalCountField;

		private bool totalCountFieldSpecified;

		private int pageSizeField;

		private bool pageSizeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("staticRoute")]
		public StaticRouteType[] staticRoute
		{
			get
			{
				return this.staticRouteField;
			}
			set
			{
				this.staticRouteField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageNumber
		{
			get
			{
				return this.pageNumberField;
			}
			set
			{
				this.pageNumberField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageNumberSpecified
		{
			get
			{
				return this.pageNumberFieldSpecified;
			}
			set
			{
				this.pageNumberFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageCount
		{
			get
			{
				return this.pageCountField;
			}
			set
			{
				this.pageCountField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageCountSpecified
		{
			get
			{
				return this.pageCountFieldSpecified;
			}
			set
			{
				this.pageCountFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int totalCount
		{
			get
			{
				return this.totalCountField;
			}
			set
			{
				this.totalCountField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool totalCountSpecified
		{
			get
			{
				return this.totalCountFieldSpecified;
			}
			set
			{
				this.totalCountFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageSize
		{
			get
			{
				return this.pageSizeField;
			}
			set
			{
				this.pageSizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageSizeSpecified
		{
			get
			{
				return this.pageSizeFieldSpecified;
			}
			set
			{
				this.pageSizeFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("deleteStaticRoute", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class DeleteStaticRouteType
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


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("restoreStaticRoutes", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class RestoreStaticRouteType
	{

		private string networkDomainIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string networkDomainId
		{
			get { return this.networkDomainIdField; }
			set { this.networkDomainIdField = value; }
		}
	}
}
