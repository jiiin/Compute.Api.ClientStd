namespace DD.CBU.Compute.Api.ContractsStd.Image20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("exportImage", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class ExportImageType
    {

        private string imageIdField;

        private string ovfPackagePrefixField;

        /// <remarks/>
        public string imageId
        {
            get
            {
                return this.imageIdField;
            }
            set
            {
                this.imageIdField = value;
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
    }
}
