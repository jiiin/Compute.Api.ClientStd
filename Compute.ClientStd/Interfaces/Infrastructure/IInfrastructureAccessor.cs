using System;
using DD.CBU.Compute.Api.Contracts.General;

namespace DD.CBU.Compute.Api.Client.Interfaces.Infrastructure
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DD.CBU.Compute.Api.Contracts.Network20;
    using DD.CBU.Compute.Api.Contracts.Requests;
    using DD.CBU.Compute.Api.Contracts.Requests.Infrastructure;
    using Contracts.Infrastructure;

    /// <summary>
    /// The AccountAccessor interface.
    /// </summary>
    public interface IInfrastructureAccessor
    {
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
        Task<IEnumerable<DatacenterType>> GetDataCenters(IPageableRequest pagingOptions = null, DataCenterListOptions filterOptions = null);

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
        Task<PagedResponse<DatacenterType>> GetDataCentersPaginated(IPageableRequest pagingOptions = null, DataCenterListOptions filterOptions = null);

        /// <summary>
        /// The get os images for a data center
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
        Task<PagedResponse<OperatingSystemDetailType>> GetOperatingSystems(IPageableRequest pagingOptions = null, OperatingSystemListOptions filterOptions = null);

        /// <summary>
        /// The gets the operating system detail
        /// </summary>
        /// <param name="operatingSystemId">
        /// The Operating System Id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<OperatingSystemDetailType> GetOperatingSystem(string operatingSystemId);

        /// <summary>The get snap shot windows.</summary>
        /// <param name="datacenterId">The Daacenter Id.</param>
        /// <param name="servicePlan">The Service Plan.</param>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<PagedResponse<SnapshotWindowType>> GetSnapshotWindowPaginated(string datacenterId, string servicePlan, SnapshotWindowListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

        /// <summary>
        /// List all the geographic regions
        /// </summary>
        /// <param name="pagingOptions">Paging options</param>
        /// <param name="filterOptions">Filtering options</param>
        /// <returns>Geo Regions</returns>
        Task<PagedResponse<GeographicRegionType>> ListGeographicRegions(IPageableRequest pagingOptions = null, ListGeographicRegionOptions filterOptions = null);

        /// <summary>
        /// List all Os Units Groups
        /// </summary>
        /// <param name="pagingOptions">Paging options</param>
        /// <param name="filterOptions">Filtering options</param>
        /// <returns>Geo Regions</returns>
        Task<PagedResponse<OsUnitsGroupType>> ListOsUnitsGroups(IPageableRequest pagingOptions = null, ListOsUnitsGroupOptions filterOptions = null);

        /// <summary>
        /// The Get Os Units Group
        /// </summary>
        /// <param name="osUnitsGroupId">The OS units group id</param>
        /// <returns>Geo Regions</returns>
        Task<OsUnitsGroupType> GetOsUnitsGroup(string osUnitsGroupId);
    }
}
