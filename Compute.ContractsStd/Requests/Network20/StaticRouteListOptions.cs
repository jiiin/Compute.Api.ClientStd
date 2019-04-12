namespace DD.CBU.Compute.Api.Contracts.Requests.Network20
{
    using System;

    /// <summary>
    /// Filtering options for the network request.
    /// </summary>
    public sealed class StaticRouteListOptions : FilterableRequest
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
        /// The "name" field name.
        /// </summary>
        public const string NameField = "name";

        /// <summary>
        /// The "type" field name.
        /// </summary>
        public const string TypeField = "type";

        /// <summary>
        /// The "state" field name.
        /// </summary>
        public const string StateField = "state";

        /// <summary>
        /// The "createTime" field name.
        /// </summary>
        public const string CreateTimeField = "createTime";

		/// <summary>
		/// The "networkDomainId" field name.
		/// </summary>
		public const string NetworkDomainIdField = "networkDomainId";

		/// <summary>
		/// The "nextHopAddressVlanId" field name.
		/// </summary>
		public const string NextHopAddressVlanIdField = "nextHopAddressVlanId";

		/// <summary>
		/// The "ipVersion" field name.
		/// </summary>
		public const string IpVersionField = "ipVersion";

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
		public Guid NextHopAddressVlanId
		{
			get { return GetFilter<Guid>(NextHopAddressVlanIdField); }
			set { SetFilter(NextHopAddressVlanIdField, value); }
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
        /// Identifies Virtual Listeners by their name.
        /// </summary>
        public string Name
        {
            get { return GetFilter<string>(NameField); }
            set { SetFilter(NameField, value); }
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

		/// <summary>	
		/// Filter by Ip version.
		/// </summary>
		public string IpVersion
		{
			get { return GetFilter<string>(IpVersionField); }
			set { SetFilter(IpVersionField, value); }
		}
	}
}
