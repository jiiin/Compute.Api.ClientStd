namespace DD.CBU.Compute.Api.Client.Interfaces.Network20
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DD.CBU.Compute.Api.Contracts.General;
    using DD.CBU.Compute.Api.Contracts.Network20;
    using DD.CBU.Compute.Api.Contracts.Requests;
    using DD.CBU.Compute.Api.Contracts.Requests.Network20;

    /// <summary>
    /// The NetworkDomain interface.
    /// </summary>
    public interface INetworkDomainAccessor
	{
        /// <summary>
        /// The get network domains.
        /// </summary>
		/// <param name="filteringOptions">
		/// The filtering options.
		/// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<NetworkDomainType>> GetNetworkDomains(NetworkDomainListOptions filteringOptions = null);

        /// <summary>
        /// The get network domains.
        /// </summary>
		/// <param name="filteringOptions">
		/// The filtering options.
		/// </param>
        /// <param name="pagingOptions">
        /// The paging options.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<PagedResponse<NetworkDomainType>> GetNetworkDomainsPaginated(NetworkDomainListOptions filteringOptions = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// 	This function gets a network domain from Cloud.
        /// </summary>
        /// <param name="networkDomainId">
        /// 	Network domain id. 
        /// </param>
        /// <returns>
        /// 	The network domain with the supplied id. 
        /// </returns>
        Task<NetworkDomainType> GetNetworkDomain(Guid networkDomainId);

        /// <summary>
        /// 	This function gets a network domain from Cloud.
        /// </summary>
        /// <param name="networkDomainName">
        /// 	The network domain name. 
        /// </param>
        /// <returns>
        /// 	The network domain with the supplid name.
        /// </returns>
        Task<NetworkDomainType> GetNetworkDomain(string networkDomainName);

        /// <summary>
        /// This function deploys a new network domains to Cloud
        /// </summary>
        /// <param name="networkDomain">
        /// The network Domain.
        /// </param>
        /// <returns>
        /// Response containing status.
        /// </returns>
        Task<ResponseType> DeployNetworkDomain(DeployNetworkDomainType networkDomain);

	    /// <summary>
	    /// The modify network domain.
	    /// </summary>
	    /// <param name="networkDomain">
	    /// The network domain.
	    /// </param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    Task<ResponseType> ModifyNetworkDomain(EditNetworkDomainType networkDomain);

        /// <summary>
        /// Delete the network domain. 
        /// </summary>
        /// <param name="id">
        /// The identifier of the network domain. 
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ResponseType> DeleteNetworkDomain(Guid id);

	    /// <summary>
	    /// The get static routes.
	    /// </summary>
	    /// <param name="filteringOptions">
	    /// The filtering options.
	    /// </param>
	    /// <param name="pagingOptions">
	    /// The paging options.
	    /// </param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    Task<PagedResponse<StaticRouteType>> GetStaticRoutesPaginated(StaticRouteListOptions filteringOptions = null,
		    PageableRequest pagingOptions = null);

	    /// <summary>
	    /// This function create a new custom static route.
	    /// </summary>
	    /// <param name="networkDomain">
	    /// The network Domain.
	    /// </param>
	    /// <returns>
	    /// Response containing status.
	    /// </returns>
	    Task<ResponseType> CreateStaticRoute(CreateStaticRouteType networkDomain);

        /// <summary>
        /// Delete the static route. 
        /// </summary>
        /// <param name="staticRouteId">
        /// The identifier of the static route. 
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ResponseType> DeleteStaticRoute(Guid staticRouteId);


        /// <summary>
        /// This function Restores Static Routes to System Static Route Values (erases all current routes).
        /// </summary>
        /// <param name="networkDomainId">
        /// The network domain ID.
        /// </param>
        /// <returns>
        /// Response containing status.
        /// </returns>
        Task<ResponseType> RestoreStaticRoute(Guid networkDomainId);

	    /// <summary>
	    /// The get snat exclusions.
	    /// </summary>
	    /// <param name="filteringOptions">
	    /// The filtering options.
	    /// </param>
	    /// <param name="pagingOptions">
	    /// The paging options.
	    /// </param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    Task<PagedResponse<SnatExclusionType>> GetSnatExclusionsPaginated(
		    SnatExclusionListOptions filteringOptions = null, PageableRequest pagingOptions = null);

	    /// <summary>
	    /// Restores Snat exclusions.
	    /// </summary>
	    /// <param name="networkDomainId">
	    /// The network domain ID.
	    /// </param>
	    /// <returns>
	    /// Response containing status.
	    /// </returns>
	    Task<ResponseType> RestoreSnatExclusions(Guid networkDomainId);

        /// <summary>
        /// This function adds Snat exclusions.
        /// </summary>
        /// <param name="SNATExclusion">
        /// The SNAT Exclusion.
        /// </param>
        /// <returns>
        /// Response containing status.
        /// </returns>
        Task<ResponseType> AddSNATExclusion(AddSnatExclusionType SNATExclusion);

        /// <summary>
        /// Removes the SNAT exclusions. 
        /// </summary>
        /// <param name="SNATExclusionId">
        /// The identifier of the SNAT Exclusion. 
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ResponseType> RemoveSNATExclusion(Guid SNATExclusionId);


    }
}
