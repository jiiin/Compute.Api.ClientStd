namespace DD.CBU.Compute.Api.Client.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts.Infrastructure;
    using DD.CBU.Compute.Api.Client.Interfaces.Infrastructure;
    using DD.CBU.Compute.Api.Contracts.Network20;
    using DD.CBU.Compute.Api.Contracts.Requests;
    using DD.CBU.Compute.Api.Client.Interfaces;
    using DD.CBU.Compute.Api.Contracts.General;
    using DD.CBU.Compute.Api.Contracts.Requests.Infrastructure;

    /// <summary>
	/// The AccountAccessor interface.
	/// </summary>
	public class InfrastructureAccessor : IInfrastructureAccessor
    {
        /// <summary>
		/// The _api client.
		/// </summary>
		private readonly IWebApi _apiClient;

        /// <summary>
        /// Initialises a new instance of the <see cref="InfrastructureAccessor"/> class.
        /// </summary>
        /// <param name="apiClient">
        /// The api client.
        /// </param>
        public InfrastructureAccessor(IWebApi apiClient)
        {
            this._apiClient = apiClient;
        }

        /// <summary>
        /// The get data centers with maintenance statuses.
        /// </summary>
        /// <param name="pagingOptions">
        /// The paging options.
        /// </param>
        /// <param name="filterOptions">
        /// The Filter options
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IEnumerable<DatacenterType>> GetDataCenters(IPageableRequest pagingOptions = null, DataCenterListOptions filterOptions = null)
        {
            datacenters dataCenters = await _apiClient.GetAsync<datacenters>(
                ApiUris.DataCentres(_apiClient.OrganizationId), pagingOptions, filterOptions);
            return dataCenters.datacenter;
        }

        /// <summary>
        /// The get data centers with maintenance statuses.
        /// </summary>
        /// <param name="pagingOptions">
        /// The paging options.
        /// </param>
        /// <param name="filterOptions">
        /// The Filter options
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<PagedResponse<DatacenterType>> GetDataCentersPaginated(IPageableRequest pagingOptions = null, DataCenterListOptions filterOptions = null)
        {
            datacenters dataCenters = await _apiClient.GetAsync<datacenters>(
                ApiUris.DataCentres(_apiClient.OrganizationId), pagingOptions, filterOptions);
            return new PagedResponse<DatacenterType>
            {
                items = dataCenters.datacenter,
                totalCount = dataCenters.totalCountSpecified ? dataCenters.totalCount : (int?)null,
                pageCount = dataCenters.pageCountSpecified ? dataCenters.pageCount : (int?)null,
                pageNumber = dataCenters.pageNumberSpecified ? dataCenters.pageNumber : (int?)null,
                pageSize = dataCenters.pageSizeSpecified ? dataCenters.pageSize : (int?)null
            };
        }

        /// <summary>
        /// Get Operating systems supported at the data center level
        /// </summary>
        /// <param name="pagingOptions">Paging options</param>
        /// <param name="filterOptions">Filtering options</param>
        /// <returns>Operating Systems</returns>
        public async Task<PagedResponse<OperatingSystemDetailType>> GetOperatingSystems(IPageableRequest pagingOptions = null, OperatingSystemListOptions filterOptions = null)
        {
            var response = await _apiClient.GetAsync<operatingSystems>(
              ApiUris.GetMcp2OperatingSystems(_apiClient.OrganizationId),
              pagingOptions,
              filterOptions);

            return new PagedResponse<OperatingSystemDetailType>
            {
                items = response.operatingSystem,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>
        /// The gets the operating system detail
        /// </summary>
        /// <param name="operatingSystemId">
        /// The Operating System Id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<OperatingSystemDetailType> GetOperatingSystem(string operatingSystemId)
        {
            var filter = new OperatingSystemListOptions() { Id = operatingSystemId };
            var response = await _apiClient.GetAsync<operatingSystems>(
             ApiUris.GetMcp2OperatingSystems(_apiClient.OrganizationId),
             null,
             filter);
            return response?.operatingSystem[0];
        }

        /// <summary>The get snap shot windows.</summary>
        /// <param name="datacenterId">The Daacenter Id.</param>
        /// <param name="servicePlan">The Service Plan.</param>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<PagedResponse<SnapshotWindowType>> GetSnapshotWindowPaginated(string datacenterId, string servicePlan, SnapshotWindowListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {

            snapshotWindows response = await _apiClient.GetAsync<snapshotWindows>(
            ApiUris.GetSnapshotWindow(_apiClient.OrganizationId, datacenterId, servicePlan),
            pagingOptions,
            filteringOptions);

            return new PagedResponse<SnapshotWindowType>
            {
                items = response.snapshotWindow,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>
        /// List all the geographic regions
        /// </summary>
        /// <param name="pagingOptions">Paging options</param>
        /// <param name="filterOptions">Filtering options</param>
        /// <returns>Geo Regions</returns>
        public async Task<PagedResponse<GeographicRegionType>> ListGeographicRegions(IPageableRequest pagingOptions = null, ListGeographicRegionOptions filterOptions = null)
        {
            var response = await _apiClient.GetAsync<geographicRegions>(
              ApiUris.ListGeographicRegion(_apiClient.OrganizationId),
              pagingOptions,
              filterOptions);

            return new PagedResponse<GeographicRegionType>
            {
                items = response.geographicRegion,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>
        /// List all Os Units Groups
        /// </summary>
        /// <param name="pagingOptions">Paging options</param>
        /// <param name="filterOptions">Filtering options</param>
        /// <returns>Geo Regions</returns>
        public async Task<PagedResponse<OsUnitsGroupType>> ListOsUnitsGroups(IPageableRequest pagingOptions = null, ListOsUnitsGroupOptions filterOptions = null)
        {
            var response = await _apiClient.GetAsync<osUnitsGroups>(
              ApiUris.ListOsUnitsGroup(_apiClient.OrganizationId),
              pagingOptions,
              filterOptions);

            return new PagedResponse<OsUnitsGroupType>
            {
                items = response.osUnitsGroup,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>
        /// The Get Os Units Group
        /// </summary>
        /// <param name="osUnitsGroupId">The OS units group id</param>
        /// <returns>Geo Regions</returns>
        public async Task<OsUnitsGroupType> GetOsUnitsGroup(string osUnitsGroupId)
        {
            return await _apiClient.GetAsync<OsUnitsGroupType>(ApiUris.GetOsUnitsGroup(_apiClient.OrganizationId, osUnitsGroupId));
        }
    }
}
