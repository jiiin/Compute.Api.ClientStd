namespace DD.CBU.Compute.Api.Contracts.Requests.Snapshot
{
    using System;

    /// <summary>
    /// Filtering options for the server request.
    /// </summary>
    public class SnapshotListOptions : FilterableRequest
    {
        /// <summary>
        /// The "id" field name.
        /// </summary>
        public const string IdField = "id";

        /// <summary>
        /// The "serverId" field name.
        /// </summary>
        public const string ServerIdField = "serverId";

        /// <summary>
        /// The "startTime" field name.
        /// </summary>
        public const string StartTimeField = "startTime";

		/// <summary>
		/// The "expiryTime" field name.
		/// </summary>
		public const string ExpiryTimeField = "expiryTime";

		/// <summary>
		/// The "state" field name.
		/// </summary>
		public const string StateField = "state";

        /// <summary>
        /// The "type" field name.
        /// </summary>
        public const string TypeField = "type";

		/// <summary>
		/// The "indexState" field name.
		/// </summary>
		public const string IndexStateField = "indexState";

		/// <summary>
		/// The "description" field name.
		/// </summary>
		public const string DescriptionField = "description";

		/// <summary>
		/// Gets or sets the StartTimeBefore filter.
		/// </summary>
		public DateTimeOffset? StartTimeBefore
        {
            get { return GetFilter<DateTimeOffset?>(StartTimeField, FilterOperator.LessThan); }
            set { SetFilter(StartTimeField, FilterOperator.LessThan, value); }
        }

        /// <summary>
        /// Gets or sets the StartTimeAfter filter.
        /// </summary>
        public DateTimeOffset? StartTimeAfter
        {
            get { return GetFilter<DateTimeOffset?>(StartTimeField, FilterOperator.GreaterThan); }
            set { SetFilter(StartTimeField, FilterOperator.GreaterThan, value); }
        }

		/// <summary>
		/// Gets or sets the ExpiryTimeBefore filter.
		/// </summary>
		public DateTimeOffset? ExpiryTimeBefore
		{
			get { return GetFilter<DateTimeOffset?>(ExpiryTimeField, FilterOperator.LessThan); }
			set { SetFilter(ExpiryTimeField, FilterOperator.LessThan, value); }
		}

		/// <summary>
		/// Gets or sets the ExpiryTimeAfter filter.
		/// </summary>
		public DateTimeOffset? ExpiryTimeAfter
		{
			get { return GetFilter<DateTimeOffset?>(ExpiryTimeField, FilterOperator.GreaterThan); }
			set { SetFilter(ExpiryTimeField, FilterOperator.GreaterThan, value); }
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
        /// Identifies an individual Id.
        /// </summary>
        public Guid? Id
        {
            get { return GetFilter<Guid?>(IdField); }
            set { SetFilter(IdField, value); }
        }

        /// <summary>	
        /// Identifies an individual Server Id.
        /// </summary>
        public Guid? ServerId
        {
            get { return GetFilter<Guid?>(ServerIdField); }
            set { SetFilter(ServerIdField, value); }
        }

        /// <summary>
        /// Gets or sets the State filter.
        /// </summary>
        public string Type
        {
            get { return GetFilter<string>(TypeField); }
            set { SetFilter(TypeField, value); }
        }

		/// <summary>
		/// Gets or sets the IndexState filter.
		/// </summary>
		public string IndexState
		{
			get { return GetFilter<string>(IndexStateField); }
			set { SetFilter(IndexStateField, value); }
		}

		/// <summary>
		/// Gets or sets the Description filter.
		/// </summary>
		public string Description
		{
			get { return GetFilter<string>(DescriptionField); }
			set { SetFilter(DescriptionField, value); }
		}
	}
}