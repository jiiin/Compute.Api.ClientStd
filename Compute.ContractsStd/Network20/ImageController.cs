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
    public partial class ImageFloppyType
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
        public string speed;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageIdeDeviceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageSataDeviceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageDeviceType
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageIdeDeviceType : ImageDeviceType
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
    public partial class ImageSataDeviceType : ImageDeviceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sataId;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageIdeDiskType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageSataDiskType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageScsiDiskType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageDiskType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int iops;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iopsSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageIdeDiskType : ImageDiskType
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
    public partial class ImageSataDiskType : ImageDiskType
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
    public partial class ImageScsiDiskType : ImageDiskType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int scsiId;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageIdeControllerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageSataControllerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageScsiControllerType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageControllerType
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageIdeControllerType : ImageControllerType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device", typeof(ImageIdeDeviceType))]
        [System.Xml.Serialization.XmlElementAttribute("disk", typeof(ImageIdeDiskType))]
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
    public partial class ImageSataControllerType : ImageControllerType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device", typeof(ImageSataDeviceType))]
        [System.Xml.Serialization.XmlElementAttribute("disk", typeof(ImageSataDiskType))]
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
    public partial class ImageScsiControllerType : ImageControllerType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("disk")]
        public ImageScsiDiskType[] disk;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int busNumber;
    }
}
