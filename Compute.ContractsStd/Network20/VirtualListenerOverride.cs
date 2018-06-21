namespace DD.CBU.Compute.Api.ContractsStd.Network20
{
    using System.Xml.Serialization;
  
    public partial class editVirtualListener
    {
        private bool poolIdFieldSpecified;
        private bool clientClonePoolIdFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool poolIdSpecified
        {
            get { return this.poolIdFieldSpecified; }
            set { this.poolIdFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool clientClonePoolIdSpecified
        {
            get { return this.clientClonePoolIdFieldSpecified; }
            set { this.clientClonePoolIdFieldSpecified = value; }
        }
    }
}
