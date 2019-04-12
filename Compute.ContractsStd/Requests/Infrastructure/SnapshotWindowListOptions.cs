namespace DD.CBU.Compute.Api.Contracts.Requests.Infrastructure
{
    /// <summary>
    /// Filtering options for the operating system request.
    /// </summary>
    public sealed class SnapshotWindowListOptions : FilterableRequest
    {
        /// <summary>
        /// The "id" field name.
        /// </summary>
        public const string IdField = "id";

		/// <summary>
		/// The "dayOfWeek" field name.
		/// </summary>
		public const string DayOfWeekField = "dayOfWeek";

		/// <summary>
		/// The "StartHour" field name.
		/// </summary>
		public const string StartHourField = "startHour";

		/// <summary>
		/// The "DatacenterId" field name.
		/// </summary>
		public const string DatacenterIdField = "datacenterId";

		/// <summary>
		/// The "slotsAvailable" field name.
		/// </summary>
		public const string SlotsAvailableField = "slotsAvailable";

		/// <summary>
		/// Gets or sets the id filter.
		/// </summary>
		public string Id
        {
            get { return GetFilter<string>(IdField); }
            set { SetFilter(IdField, value); }
        }

		/// <summary>
		/// Gets or sets the DayOfWeek filter.
		/// </summary>
		public string DayOfWeek
		{
            get { return GetFilter<string>(DayOfWeekField); }
            set { SetFilter(DayOfWeekField, value); }
        }

		/// <summary>
		/// Gets or sets the Start Hour filter.
		/// </summary>
		public int? StartHour
		{
            get { return GetFilter<int?>(StartHourField); }
            set { SetFilter(StartHourField, value); }
        }

		/// <summary>
		/// Gets or sets the Datacenter Id filter.
		/// </summary>
		public string DatacenterId
		{
			get { return GetFilter<string>(DatacenterIdField); }
			set { SetFilter(DatacenterIdField, value); }
		}

		/// <summary>
		/// Gets or sets Slots Available filter.
		/// </summary>
		public bool? SlotsAvailable
		{
			get { return GetFilter<bool?>(SlotsAvailableField); }
			set { SetFilter(SlotsAvailableField, value); }
		}
	}
}
