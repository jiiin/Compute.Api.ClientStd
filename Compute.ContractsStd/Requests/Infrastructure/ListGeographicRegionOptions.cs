namespace DD.CBU.Compute.Api.Contracts.Requests.Infrastructure
{
    /// <summary>
    /// Filtering options for the operating system request.
    /// </summary>
    public sealed class ListGeographicRegionOptions : FilterableRequest
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
        /// The "isHome" field name.
        /// </summary>
        public const string IsHomeField = "isHome";

		/// <summary>
        /// The "state" field name.
        /// </summary>
        public const string StateField = "state";

		/// <summary>
		/// Gets or sets the id filter.
		/// </summary>
		public string Id
        {
            get { return GetFilter<string>(IdField); }
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
        /// Gets or sets the is home filter.
        /// </summary>
        public bool? IsHome
        {
            get { return GetFilter<bool?>(IsHomeField); }
            set { SetFilter(IsHomeField, value); }
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
