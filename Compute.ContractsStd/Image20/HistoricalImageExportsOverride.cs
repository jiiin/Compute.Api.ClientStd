using System.Linq;
using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Api.Contracts.Image20
{
    public partial class HistoricalImageExportIdeControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportIdeDeviceType[] device => Items?.OfType<HistoricalImageExportIdeDeviceType>().ToArray();

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportIdeDiskType[] disk => Items?.OfType<HistoricalImageExportIdeDiskType>().ToArray();
    }

    public partial class HistoricalImageExportSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportSataDeviceType[] device => Items?.OfType<HistoricalImageExportSataDeviceType>().ToArray();

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportSataDiskType[] disk => Items?.OfType<HistoricalImageExportSataDiskType>().ToArray();
    }
}
