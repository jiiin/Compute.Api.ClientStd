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
	[System.Xml.Serialization.XmlRootAttribute("snatExclusion", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class SnatExclusionType
	{

		private string networkDomainIdField;

		private string typeField;

		private string destinationIpv4NetworkAddressField;

		private int destinationIpv4PrefixSizeField;

		private string descriptionField;

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
		public string destinationIpv4NetworkAddress
        {
			get
			{
				return this.destinationIpv4NetworkAddressField;
			}
			set
			{
				this.destinationIpv4NetworkAddressField = value;
			}
		}

		/// <remarks/>
		public int destinationIpv4PrefixSize
        {
			get
			{
				return this.destinationIpv4PrefixSizeField;
			}
			set
			{
				this.destinationIpv4PrefixSizeField = value;
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
	public partial class snatExclusions
	{

		private SnatExclusionType[] snatExclusionField;

		private int pageNumberField;

		private bool pageNumberFieldSpecified;

		private int pageCountField;

		private bool pageCountFieldSpecified;

		private int totalCountField;

		private bool totalCountFieldSpecified;

		private int pageSizeField;

		private bool pageSizeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("snatExclusion")]
		public SnatExclusionType[] snatExclusion
		{
			get
			{
				return this.snatExclusionField;
			}
			set
			{
				this.snatExclusionField = value;
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
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("restoreSnatExclusions", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class RestoreSnatExclusionsType
	{

		private string networkDomainIdField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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
	}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("addSnatExclusion", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class AddSnatExclusionType
    {

        private string networkDomainIdField;

        private string destinationIpv4NetworkAddressField;

        private int destinationIpv4PrefixSizeField;

        private string descriptionField;

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
        public string destinationIpv4NetworkAddress
        {
            get
            {
                return this.destinationIpv4NetworkAddressField;
            }
            set
            {
                this.destinationIpv4NetworkAddressField = value;
            }
        }

        /// <remarks/>
        public int destinationIpv4PrefixSize
        {
            get
            {
                return this.destinationIpv4PrefixSizeField;
            }
            set
            {
                this.destinationIpv4PrefixSizeField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("removeSnatExclusion", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class RemoveSnatExclusionType
    {

        private string idField;

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
    }
}
