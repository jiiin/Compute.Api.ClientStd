﻿namespace DD.CBU.Compute.Api.ContractsStd.Requests.Server20
{
    using System;

    /// <summary>
    /// Filtering options for the server request.
    /// </summary>
    public sealed class ServerCustomerImageListOptions : FilterableRequest
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
        /// The "createTime" field name.
        /// </summary>
        public const string CreateTimeField = "createTime";

        /// <summary>
        /// The "state" field name.
        /// </summary>
        public const string StateField = "state";

        /// <summary>
        /// The "operatingSystemId" field name.
        /// </summary>
        public const string OperatingSystemIdField = "operatingSystemId";

        /// <summary>
        /// The "operatingSystemFamily" field name.
        /// </summary>
        public const string OperatingSystemFamilyField = "operatingSystemFamily";

        /// <summary>
        /// The "GuestOsCustomization" field name.
        /// </summary>
        public const string GuestOsCustomizationField = "guestOsCustomization";

        /// <summary>
        /// The "ClusterId" field name.
        /// </summary>
        public const string ClusterIdField = "clusterId";

        /// <summary>
        /// The "SourceType" field name.
        /// </summary>
        public const string SourceTypeField = "sourceType";

        /// <summary>
        /// Gets or sets the id filter.
        /// </summary>
        public Guid? Id
        {
            get { return GetFilter<Guid?>(IdField); }
            set { SetFilter(IdField, value); }
        }

        /// <summary>
        /// Gets or sets the DatacenterId filter.
        /// </summary>
        public string DatacenterId
        {
            get { return GetFilter<string>(DatacenterIdField); }
            set { SetFilter(DatacenterIdField, value); }
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
        /// Gets or sets the CreateTimeBefore filter.
        /// </summary>
        public DateTimeOffset? CreateTimeBefore
        {
            get { return GetFilter<DateTimeOffset?>(CreateTimeField, FilterOperator.LessThan); }
            set { SetFilter(CreateTimeField, FilterOperator.LessThan, value); }
        }

        /// <summary>
        /// Gets or sets the CreateTimeAfter filter.
        /// </summary>
        public DateTimeOffset? CreateTimeAfter
        {
            get { return GetFilter<DateTimeOffset?>(CreateTimeField, FilterOperator.GreaterThan); }
            set { SetFilter(CreateTimeField, FilterOperator.GreaterThan, value); }
        }

        /// <summary>
        /// Gets or sets the CreateTimeAfter Inclusive filter.
        /// </summary>
        public DateTimeOffset? CreateTimeMin
        {
            get { return GetFilter<DateTimeOffset?>(CreateTimeField, FilterOperator.LessOrEqual); }
            set { SetFilter(CreateTimeField, FilterOperator.LessOrEqual, value); }
        }

        /// <summary>
        /// Gets or sets the CreateTimeMax filter.
        /// </summary>
        public DateTimeOffset? CreateTimeMax
        {
            get { return GetFilter<DateTimeOffset?>(CreateTimeField, FilterOperator.GreaterOrEqual); }
            set { SetFilter(CreateTimeField, FilterOperator.GreaterOrEqual, value); }
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
        /// Gets or sets the Operating SystemId filter like REDHAT664.
        /// </summary>
        public string OperatingSystemId
        {
            get { return GetFilter<string>(OperatingSystemIdField); }
            set { SetFilter(OperatingSystemIdField, value); }
        }

        /// <summary>
        /// Gets or sets the Operating System Family filter. eg : UNIX
        /// </summary>
        public string OperatingSystemFamily
        {
            get { return GetFilter<string>(OperatingSystemFamilyField); }
            set { SetFilter(OperatingSystemFamilyField, value); }
        }

        /// <summary>
        /// Gets or sets the Guest Os Customization filter.
        /// </summary>
        public bool? GuestOsCustomization
        {
            get { return GetFilter<bool>(GuestOsCustomizationField); }
            set { SetFilter(GuestOsCustomizationField, value); }
        }

        /// <summary>
        /// Gets or sets the cluster id filter.
        /// </summary>
        public string ClusterId
        {
            get { return GetFilter<string>(ClusterIdField); }
            set { SetFilter(ClusterIdField, value); }
        }

        /// <summary>
        /// Gets or sets the source type filter.
        /// </summary>
        public string SourceType
        {
            get { return GetFilter<string>(SourceTypeField); }
            set { SetFilter(SourceTypeField, value); }
        }
    }
}
