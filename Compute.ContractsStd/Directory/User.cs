namespace DD.CBU.Compute.Api.Contracts.Directory
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("users", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class UsersResponseCollection
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("user")]
        public UserType[] user;

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
    [System.Xml.Serialization.XmlRootAttribute("user", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class UserType : IUser
    {

        /// <remarks/>
        [XmlElementAttribute("userName")]
        public string UserName { get; set; }

        /// <remarks/>
        [XmlElementAttribute("fullName")]
        public string FullName { get; set; }

        /// <remarks/>
        [XmlElementAttribute("firstName")]
        public string FirstName { get; set; }

        /// <remarks/>
        [XmlElementAttribute("lastName")]
        public string LastName { get; set; }

        /// <remarks/>
        [XmlElementAttribute("emailAddress")]
        public string EmailAddress { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("role")]
        public string[] Roles { get; set; }

        /// <remarks/>
        [XmlElementAttribute("phone")]
        public PhoneType Phone { get; set; }

        /// <remarks/>
        [XmlElementAttribute("department")]
        public string Department { get; set; }

        /// <remarks/>
        [XmlElementAttribute("customDefined1")]
        public string CustomDefined1 { get; set; }

        /// <remarks/>
        [XmlElementAttribute("customDefined2")]
        public string CustomDefined2 { get; set; }

        /// <remarks/>
        [XmlElementAttribute("organization")]
        public UserTypeOrganization Organization { get; set; }

        /// <remarks/>
        [XmlElementAttribute("state")]
        public string State { get; set; }

        /// <remarks/>
        [XmlElementAttribute("createTime")]
        public System.DateTime CreateTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createTimeSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Guid OrganizationId { get { return Guid.Parse(Organization.id); } }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class UserTypeOrganization
    {

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string homeGeoName;

        /// <remarks/>
        public string homeGeoApiHost;

        /// <remarks/>
        public string homeGeoId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class PhoneType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string countryCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string number;
    }

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("duoStatus", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class DuoStatusType
	{

		private string enrolmentStatusField;

		private System.DateTime lastLoginTimeField;

		private bool lastLoginTimeFieldSpecified;

		private System.DateTime enrolmentExpiryTimeField;

		private bool enrolmentExpiryTimeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string enrolmentStatus
		{
			get
			{
				return this.enrolmentStatusField;
			}
			set
			{
				this.enrolmentStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public System.DateTime lastLoginTime
		{
			get
			{
				return this.lastLoginTimeField;
			}
			set
			{
				this.lastLoginTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool lastLoginTimeSpecified
		{
			get
			{
				return this.lastLoginTimeFieldSpecified;
			}
			set
			{
				this.lastLoginTimeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public System.DateTime enrolmentExpiryTime
		{
			get
			{
				return this.enrolmentExpiryTimeField;
			}
			set
			{
				this.enrolmentExpiryTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool enrolmentExpiryTimeSpecified
		{
			get
			{
				return this.enrolmentExpiryTimeFieldSpecified;
			}
			set
			{
				this.enrolmentExpiryTimeFieldSpecified = value;
			}
		}
	}
}
