﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute("geographicRegion", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
public partial class GeographicRegionType
{

	private string nameField;

	private string cloudApiHostField;

	private string cloudUiUrlField;

	private string monitoringUrlField;

	private string ftpsHostField;

	private string timeZoneField;

	private GeographicRegionTypeVpnAccess[] vpnAccessField;

	private string stateField;

	private string idField;

	private bool isHomeField;

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
	public string cloudApiHost
	{
		get
		{
			return this.cloudApiHostField;
		}
		set
		{
			this.cloudApiHostField = value;
		}
	}

	/// <remarks/>
	public string cloudUiUrl
	{
		get
		{
			return this.cloudUiUrlField;
		}
		set
		{
			this.cloudUiUrlField = value;
		}
	}

	/// <remarks/>
	public string monitoringUrl
	{
		get
		{
			return this.monitoringUrlField;
		}
		set
		{
			this.monitoringUrlField = value;
		}
	}

	/// <remarks/>
	public string ftpsHost
	{
		get
		{
			return this.ftpsHostField;
		}
		set
		{
			this.ftpsHostField = value;
		}
	}

	/// <remarks/>
	public string timeZone
	{
		get
		{
			return this.timeZoneField;
		}
		set
		{
			this.timeZoneField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("vpnAccess")]
	public GeographicRegionTypeVpnAccess[] vpnAccess
	{
		get
		{
			return this.vpnAccessField;
		}
		set
		{
			this.vpnAccessField = value;
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
	public bool isHome
	{
		get
		{
			return this.isHomeField;
		}
		set
		{
			this.isHomeField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
public partial class GeographicRegionTypeVpnAccess
{

	private bool defaultField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool @default
	{
		get
		{
			return this.defaultField;
		}
		set
		{
			this.defaultField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
public partial class geographicRegions {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("geographicRegion")]
    public GeographicRegionType[] geographicRegion;
    
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