using System;

namespace DD.CBU.Compute.Api.Contracts.Requests.Network20
{
    /// <summary>
    /// Filtering options for SSL Offload Profiles
    /// </summary>
    public class SslOffloadProfileListOptions : FilterableRequest
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
        /// The "sslDomainCertificateId" field name.
        /// </summary>
        public const string SslDomainCertificateIdField = "sslDomainCertificateId";

        /// <summary>
        /// The "sslDomainCertificateName" field name.
        /// </summary>
        public const string SslDomainCertificateNameField = "sslDomainCertificateName";

        /// <summary>
        /// The "sslCertificateChainId" field name.
        /// </summary>
        public const string SslCertificateChainIdField = "sslCertificateChainId";

        /// <summary>
        /// The "sslCertificateChainName" field name.
        /// </summary>
        public const string SslCertificateChainNameField = "sslCertificateChainName";

        /// <summary>
        /// The "createTime" field name.
        /// </summary>
        public const string CreateTimeField = "createTime";

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
        /// Gets or sets the Network Domain filter.
        /// </summary>
        public Guid? NetworkDomainId
        {
            get { return GetFilter<Guid?>(NetworkDomainIdField); }
            set { SetFilter(NetworkDomainIdField, value); }
        }

        /// <summary>	
        /// Gets or sets the Datacenter filter.
        /// </summary>
        public Guid? DatacenterId
        {
            get { return GetFilter<Guid?>(DatacenterIdField); }
            set { SetFilter(DatacenterIdField, value); }
        }

        /// <summary>	
        /// Gets or sets the sslDomainCertificateId filter.
        /// </summary>
        public Guid? SslDomainCertificateId
        {
            get { return GetFilter<Guid?>(SslDomainCertificateIdField); }
            set { SetFilter(SslDomainCertificateIdField, value); }
        }

        /// <summary>
        /// Gets or sets the sslDomainCertificateName filter.
        /// </summary>
        public string SslDomainCertificateName
        {
            get { return GetFilter<string>(SslDomainCertificateNameField); }
            set { SetFilter(SslDomainCertificateNameField, value); }
        }

        /// <summary>	
        /// Gets or sets the sslCertificateChainId filter.
        /// </summary>
        public Guid? SslCertificateChainId
        {
            get { return GetFilter<Guid?>(SslCertificateChainIdField); }
            set { SetFilter(SslCertificateChainIdField, value); }
        }

        /// <summary>
        /// Gets or sets the sslCertificateChainName filter.
        /// </summary>
        public string SslCertificateChainName
        {
            get { return GetFilter<string>(SslCertificateChainNameField); }
            set { SetFilter(SslCertificateChainNameField, value); }
        }
    }
}
