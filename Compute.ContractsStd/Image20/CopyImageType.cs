using DD.CBU.Compute.Api.Contracts.Network20;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute("copyImage", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
public partial class CopyImageType
{

	private string targetImageNameField;

	private string targetImageDescriptionField;

	private string itemField;

	private ItemChoiceType itemElementNameField;

	private string ovfPackagePrefixField;

	private ApplyTagByIdType[] tagByIdField;

	private ApplyTagType[] tagField;

	private string sourceImageIdField;

	/// <remarks/>
	public string targetImageName
	{
		get
		{
			return this.targetImageNameField;
		}
		set
		{
			this.targetImageNameField = value;
		}
	}

	/// <remarks/>
	public string targetImageDescription
	{
		get
		{
			return this.targetImageDescriptionField;
		}
		set
		{
			this.targetImageDescriptionField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("clusterId", typeof(string))]
	[System.Xml.Serialization.XmlElementAttribute("datacenterId", typeof(string))]
	[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
	public string Item
	{
		get
		{
			return this.itemField;
		}
		set
		{
			this.itemField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public ItemChoiceType ItemElementName
	{
		get
		{
			return this.itemElementNameField;
		}
		set
		{
			this.itemElementNameField = value;
		}
	}

	/// <remarks/>
	public string ovfPackagePrefix
	{
		get
		{
			return this.ovfPackagePrefixField;
		}
		set
		{
			this.ovfPackagePrefixField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("tagById")]
	public ApplyTagByIdType[] tagById
	{
		get
		{
			return this.tagByIdField;
		}
		set
		{
			this.tagByIdField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("tag")]
	public ApplyTagType[] tag
	{
		get
		{
			return this.tagField;
		}
		set
		{
			this.tagField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string sourceImageId
	{
		get
		{
			return this.sourceImageIdField;
		}
		set
		{
			this.sourceImageIdField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
public enum ItemChoiceType
{

	/// <remarks/>
	clusterId,

	/// <remarks/>
	datacenterId,
}