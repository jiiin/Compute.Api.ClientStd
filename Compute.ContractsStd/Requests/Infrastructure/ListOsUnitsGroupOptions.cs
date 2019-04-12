namespace DD.CBU.Compute.Api.Contracts.Requests.Infrastructure
{
    /// <summary>
    /// Filtering options for the Os Units Group request.
    /// </summary>
    public sealed class ListOsUnitsGroupOptions : FilterableRequest
    {
        /// <summary>
        /// The "id" field name.
        /// </summary>
        public const string IdField = "id";

        /// <summary>
        /// Gets or sets the id filter.
        /// </summary>
        public string Id
        {
            get { return GetFilter<string>(IdField); }
            set { SetFilter(IdField, value); }
        }
    }
}
