using System;
using System.Collections.Generic;
using System.Linq;

namespace DD.CBU.Compute.Api.Contracts.Network20
{

    public partial class ServerSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerSataDeviceType[] device => Items?.OfType<ServerSataDeviceType>().ToArray();

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerSataDiskType[] disk => Items?.OfType<ServerSataDiskType>().ToArray();
    }

    public partial class ServerIdeControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerIdeDeviceType[] device => Items?.OfType<ServerIdeDeviceType>().ToArray();

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerIdeDiskType[] disk => Items?.OfType<ServerIdeDiskType>().ToArray();
    }
}