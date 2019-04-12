using System;

namespace DD.CBU.Compute.Api.Contracts.Requests.Network20
{
    /// <summary>
    /// Filtering options for SSL Domain Certificate Chain
    /// </summary>
    public class SslCertificateChainListOptions : FilterableRequest
    {
        /// <summary>
        /// The "id" field name.
        /// </summary>
        public const string IdField = "id";

        /// <summary>
        /// The "name" field name.
        /// </summary>
        public const string NameField = "name";

        /// <summary>
        /// The "state" field name.
        /// </summary>
        public const string StateField = "state";

        /// <summary>
        /// The "networkDomainId" field name.
        /// </summary>
        public const string NetworkDomainIdField = "networkDomainId";

        /// <summary>
        /// The "datacenterId" field name.
        /// </summary>
        public const string DatacenterIdField = "datacenterId";

        /// <summary>
        /// The "createTime" field name.
        /// </summary>
        public const string CreateTimeField = "createTime";

        /// <summary>
        /// The "expiryTime" field name.
        /// </summary>
        public const string ExpiryTimeField = "expiryTime";

        /// <summary>
        /// Gets or sets the id filter.
        /// </summary>
        public Guid? Id
        {
            get { return GetFilter<Guid?>(IdField); }
            set { SetFilter(IdField, value); }
        }

        /// <summary>
        /// Gets or sets the Name filter.
        /// </summary>
        public string Name
        {
            get { return GetFilter<string>(NameField); }
            set { SetFilter(NameField, value); }
        }

        /// <summary>
        /// Identifies state.
        /// </summary>
        public string State
        {
            get { return GetFilter<string>(StateField); }
            set { SetFilter(StateField, value); }
        }

        /// <summary>
        /// Gets or sets the CreateTime filter.
        /// </summary>
        public DateTimeOffset? CreateTime
        {
            get { return GetFilter<DateTimeOffset?>(CreateTimeField); }
            set { SetFilter(CreateTimeField, value); }
        }

        /// <summary>
        /// Gets or sets the ExpiryTime filter.
        /// </summary>
        public DateTimeOffset? ExpiryTime
        {
            get { return GetFilter<DateTimeOffset?>(ExpiryTimeField); }
            set { SetFilter(ExpiryTimeField, value); }
        }

        /// <summary>	
        /// Identifies an individual Network Domain.
        /// </summary>
        public Guid? NetworkDomainId
        {
            get { return GetFilter<Guid?>(NetworkDomainIdField); }
            set { SetFilter(NetworkDomainIdField, value); }
        }

        /// <summary>	
        /// Identifies an Vlan.
        /// </summary>
        public Guid? DatacenterId
        {
            get { return GetFilter<Guid?>(DatacenterIdField); }
            set { SetFilter(DatacenterIdField, value); }
        }
    }
}
