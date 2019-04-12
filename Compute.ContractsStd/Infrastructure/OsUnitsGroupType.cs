using System.Linq;

namespace DD.CBU.Compute.Api.Contracts.Infrastructure
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class EmptyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("osUnitsGroup", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class OsUnitsGroupType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cpuRange", typeof(OsUnitsGroupTypeCpuRange))]
        [System.Xml.Serialization.XmlElementAttribute("noUsage", typeof(EmptyType))]
        [System.Xml.Serialization.XmlElementAttribute("perCpu", typeof(OsUnitsGroupTypePerCpu))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName;
    }

    public partial class OsUnitsGroupType
    {
        /// Note, Os Units Group will have either cpuRange, noUsage or perCpu
        /// <summary>	Gets or sets the Os Units Group Items. </summary>
        /// <value>	The Os Units Group Items. </value>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public OsUnitsGroupTypeCpuRange[] cpuRange
        {
            get
            {
                var ranges = Items.OfType<OsUnitsGroupTypeCpuRange>().ToArray();
                return ranges != null && ranges.Count() > 0 ? ranges : null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public OsUnitsGroupTypePerCpu perCpu
        {
            get
            {
                var perCpu = Items?.OfType<OsUnitsGroupTypePerCpu>().ToArray();
                return perCpu != null && perCpu.Count() > 0 ? perCpu[0] : null;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class OsUnitsGroupTypeCpuRange
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int unitsPerHour;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int begin;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int end;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class OsUnitsGroupTypePerCpu
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int unitsPerHour;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class osUnitsGroups
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("osUnitsGroup")]
        public OsUnitsGroupType[] osUnitsGroup;

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
}