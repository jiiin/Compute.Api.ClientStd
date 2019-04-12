namespace DD.CBU.Compute.Api.Contracts.Requests.Network20
{
    using System;

    /// <summary>
    /// Filtering options for the network request.
    /// </summary>
    public sealed class SnatExclusionListOptions : FilterableRequest
	{
        /// <summary>
        /// The "id" field name.
        /// </summary>
        public const string IdField = "id";

        /// <summary>
        /// The "datacenterId" field name.
        /// </summary>
        public const string DatacenterIdField = "datacenterId";

        /// <summary>
        /// The "type" field name.
        /// </summary>
        public const string TypeField = "type";

        /// <summary>
        /// The "state" field name.
        /// </summary>
        public const string StateField = "state";

		/// <summary>
		/// The "networkDomainId" field name.
		/// </summary>
		public const string NetworkDomainIdField = "networkDomainId";

		/// <summary>
		/// The "nextHopAddressVlanId" field name.
		/// </summary>
		public const string SourceIpv4NetworkAddressField = "sourceIpv4NetworkAddress";

		/// <summary>
		/// Gets or sets the id filter.
		/// </summary>
		public Guid? Id
        {
            get { return GetFilter<Guid?>(IdField); }
            set { SetFilter(IdField, value); }
        }

		/// <summary>	
		/// Filter by Network Domain.
		/// </summary>
		public Guid NetworkDomainId
		{
			get { return GetFilter<Guid>(NetworkDomainIdField); }
			set { SetFilter(NetworkDomainIdField, value); }
		}

		/// <summary>	
		/// Filter by Next Hop Address Vlan Id.
		/// </summary>
		public string SourceIpv4NetworkAddress
		{
			get { return GetFilter<string>(SourceIpv4NetworkAddressField); }
			set { SetFilter(SourceIpv4NetworkAddressField, value); }
		}

		/// <summary>	
		/// Identifies an individual Data Center.
		/// </summary>
		public string DatacenterId
        {
            get { return GetFilter<string>(DatacenterIdField); }
            set { SetFilter(DatacenterIdField, value); }
        }

        /// <summary>
        /// Gets or sets the Type filter.
        /// </summary>
        public string Type
        {
            get { return GetFilter<string>(TypeField); }
            set { SetFilter(TypeField, value); }
        }

        /// <summary>
        /// Gets or sets the State filter.
        /// </summary>
        public string State
        {
            get { return GetFilter<string>(StateField); }
            set { SetFilter(StateField, value); }
        }
	}
}
