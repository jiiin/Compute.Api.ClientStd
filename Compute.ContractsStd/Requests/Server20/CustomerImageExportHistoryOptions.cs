using System;

namespace DD.CBU.Compute.Api.ContractsStd.Requests.Server20
{
    /// <summary>
    /// Filtering options for the get customer image export in progress request.
    /// </summary>
    public sealed class CustomerImageExportHistoryOptions : FilterableRequest
    {
        /// <summary>
        /// The "imageExportId" field name.
        /// </summary>
        public const string ImageExportIdField = "imageExportId";

        /// <summary>
        /// The "imageId" field name.
        /// </summary>
        public const string ImageIdField = "imageId";

        /// <summary>
        /// The "datacenterId" field name.
        /// </summary>
        public const string DatacenterIdField = "datacenterId";

        /// <summary>
        /// The "imageName" field name.
        /// </summary>
        public const string ImageNameField = "imageName";

        /// <summary>
        /// The "ovfPackagePrefix" field name.
        /// </summary>
        public const string OvfPackagePrefixField = "ovfPackagePrefix";

        /// <summary>
        /// The "startTime" field name.
        /// </summary>
        public const string StartTimeField = "startTime";

		/// <summary>
		/// The "endTime" field name.
		/// </summary>
		public const string EndTimeField = "endTime";

		/// <summary>
		/// The "userName" field name.
		/// </summary>
		public const string UserNameField = "userName";

		/// <summary>
		/// Gets or sets the imageExportId filter.
		/// </summary>
		public string ImageExportId
        {
            get { return GetFilter<string>(ImageExportIdField); }
            set { SetFilter(ImageExportIdField, value); }
        }

        /// <summary>
        /// Gets or sets the imageId filter.
        /// </summary>
        public string ImageId
        {
            get { return GetFilter<string>(ImageIdField); }
            set { SetFilter(ImageIdField, value); }
        }

        /// <summary>
        /// Gets or sets the datacenterId filter.
        /// </summary>
        public string DatacenterId
        {
            get { return GetFilter<string>(DatacenterIdField); }
            set { SetFilter(DatacenterIdField, value); }
        }

        /// <summary>
        /// Gets or sets the imageName filter.
        /// </summary>
        public string ImageName
        {
            get { return GetFilter<string>(ImageNameField); }
            set { SetFilter(ImageNameField, value); }
        }

        /// <summary>
        /// Gets or sets the ovfPackagePrefix filter.
        /// </summary>
        public string OvfPackagePrefix
        {
            get { return GetFilter<string>(OvfPackagePrefixField); }
            set { SetFilter(OvfPackagePrefixField, value); }
        }

        /// <summary>
        /// Gets or sets the startTime filter.
        /// </summary>
        public DateTimeOffset? StartTime
        {
            get { return GetFilter<DateTimeOffset?>(StartTimeField, FilterOperator.LessThan); }
            set { SetFilter(StartTimeField, FilterOperator.LessThan, value); }
        }

		/// <summary>
		/// Gets or sets the endTime filter.
		/// </summary>
		public DateTimeOffset? EndTime
		{
			get { return GetFilter<DateTimeOffset?>(EndTimeField, FilterOperator.LessThan); }
			set { SetFilter(EndTimeField, FilterOperator.LessThan, value); }
		}

		/// <summary>
		/// Gets or sets the userName filter.
		/// </summary>
		public string UserName
		{
			get { return GetFilter<string>(UserNameField); }
			set { SetFilter(UserNameField, value); }
		}
	}
}
