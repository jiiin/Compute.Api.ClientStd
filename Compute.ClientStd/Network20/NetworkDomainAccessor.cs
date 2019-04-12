namespace DD.CBU.Compute.Api.Client.Network20
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DD.CBU.Compute.Api.Client.Interfaces;
    using DD.CBU.Compute.Api.Client.Interfaces.Network20;
    using DD.CBU.Compute.Api.Contracts.General;
    using DD.CBU.Compute.Api.Contracts.Network20;
    using DD.CBU.Compute.Api.Contracts.Requests;
    using DD.CBU.Compute.Api.Contracts.Requests.Network20;

    /// <summary>
    /// The network domain.
    /// </summary>
    public class NetworkDomainAccessor : INetworkDomainAccessor
	{
		/// <summary>
		/// The _client.
		/// </summary>
		private readonly IWebApi _apiClient;

		/// <summary>
		/// 	Initializes a new instance of the DD.CBU.Compute.Api.Client.Network20.NetworkDomain
		/// 	class.
		/// </summary>
		/// <param name="apiClient">	The client. </param>
		public NetworkDomainAccessor(IWebApi apiClient)
		{
			_apiClient = apiClient;
		}

        /// <summary>
        /// The get network domains.
        /// </summary>
		/// <param name="filteringOptions">
		/// The filtering options.
		/// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IEnumerable<NetworkDomainType>> GetNetworkDomains(NetworkDomainListOptions filteringOptions = null)
        {
            var response = await GetNetworkDomainsPaginated(filteringOptions, null);
            return response.items;
        }

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
        public async Task<PagedResponse<NetworkDomainType>> GetNetworkDomainsPaginated(NetworkDomainListOptions filteringOptions = null, PageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<networkDomains>(ApiUris.NetworkDomains(_apiClient.OrganizationId), pagingOptions, filteringOptions);
            return new PagedResponse<NetworkDomainType>
            {
                items = response.networkDomain,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

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
		public async Task<PagedResponse<StaticRouteType>> GetStaticRoutesPaginated(StaticRouteListOptions filteringOptions = null, PageableRequest pagingOptions = null)
		{
			var response = await _apiClient.GetAsync<staticRoutes>(ApiUris.StaticRoutes(_apiClient.OrganizationId), pagingOptions, filteringOptions);
			return new PagedResponse<StaticRouteType>
			{
				items = response.staticRoute,
				totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
				pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
				pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
				pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
			};
		}

		/// <summary>
		/// This function create a new custom static route.
		/// </summary>
		/// <param name="networkDomain">
		/// The network Domain.
		/// </param>
		/// <returns>
		/// Response containing status.
		/// </returns>
		public async Task<ResponseType> CreateStaticRoute(CreateStaticRouteType networkDomain)
		{
			return await _apiClient.PostAsync<CreateStaticRouteType, ResponseType>(
				ApiUris.CreateStaticRoute(_apiClient.OrganizationId),
				networkDomain);
		}

        /// <summary>
		/// This function deletes an existing static route.
		/// </summary>
		/// <param name="staticRouteId">
		/// The static route ID.
		/// </param>
		/// <returns>
		/// Response containing status.
		/// </returns>
		public async Task<ResponseType> DeleteStaticRoute(Guid staticRouteId)
        {
            return await _apiClient.PostAsync<DeleteStaticRouteType, ResponseType>(
                ApiUris.DeleteStaticRoute(_apiClient.OrganizationId),
                new DeleteStaticRouteType { id = staticRouteId.ToString() });
        }

        /// <summary>
        /// This function Restores Static Routes to System Static Route Values (erases all current routes).
        /// </summary>
        /// <param name="networkDomainId">
        /// The network domain ID.
        /// </param>
        /// <returns>
        /// Response containing status.
        /// </returns>
        public async Task<ResponseType> RestoreStaticRoute(Guid networkDomainId)
        {
            return await _apiClient.PostAsync<RestoreStaticRouteType, ResponseType>(
                ApiUris.RestoreStaticRoute(_apiClient.OrganizationId),
                new RestoreStaticRouteType { networkDomainId = networkDomainId.ToString() });
        }

        /// <summary>
        /// 	This function gets a network domain from Cloud.
        /// </summary>
        /// <param name="networkDomainId">
        /// 	Network domain id. 
        /// </param>
        /// <returns>
        /// 	The network domain with the supplied id. 
        /// </returns>
        public async Task<NetworkDomainType> GetNetworkDomain(Guid networkDomainId)
        {
            return await _apiClient.GetAsync<NetworkDomainType>(
                ApiUris.NetworkDomain(_apiClient.OrganizationId, networkDomainId));
        }

        /// <summary>
        /// 	This function gets a network domain from Cloud.
        /// </summary>
        /// <param name="networkDomainName">
        /// 	The network domain name. 
        /// </param>
        /// <returns>
        /// 	The network domain with the supplid name.
        /// </returns>
        public async Task<NetworkDomainType> GetNetworkDomain(string networkDomainName)
        {
            var networkDomains = await GetNetworkDomains(new NetworkDomainListOptions { Name = networkDomainName });
            return (networkDomains != null)
                ? networkDomains.FirstOrDefault()
                : null;
        }

        /// <summary>
        /// This function deploys a new network domains to Cloud
        /// </summary>
        /// <param name="networkDomain">
        /// The network Domain.
        /// </param>
        /// <returns>
        /// Response containing status.
        /// </returns>
        public async Task<ResponseType> DeployNetworkDomain(DeployNetworkDomainType networkDomain)
		{
			return await _apiClient.PostAsync<DeployNetworkDomainType, ResponseType>(
                ApiUris.CreateNetworkDomain(_apiClient.OrganizationId),
                networkDomain);
		}

	    /// <summary>
	    /// The modify network domain.
	    /// </summary>
	    /// <param name="networkDomain">
	    /// The network domain.
	    /// </param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    public async Task<ResponseType> ModifyNetworkDomain(EditNetworkDomainType networkDomain)
	    {
			return await _apiClient.PostAsync<EditNetworkDomainType, ResponseType>(
                ApiUris.ModifyNetworkDomain(_apiClient.OrganizationId),
                networkDomain);
	    }

        /// <summary>
        /// Delete the network domain. 
        /// </summary>
        /// <param name="id">
        /// The identifier of the network domain. 
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
		public async Task<ResponseType> DeleteNetworkDomain(Guid id)
		{
			return await _apiClient.PostAsync<DeleteNetworkDomainType, ResponseType>(
			    ApiUris.DeleteNetworkDomain(_apiClient.OrganizationId),
                new DeleteNetworkDomainType { id = id.ToString() });
		}

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
		public async Task<PagedResponse<SnatExclusionType>> GetSnatExclusionsPaginated(SnatExclusionListOptions filteringOptions = null, PageableRequest pagingOptions = null)
		{
			var response = await _apiClient.GetAsync<snatExclusions>(ApiUris.SnatExclusions(_apiClient.OrganizationId), pagingOptions, filteringOptions);
			return new PagedResponse<SnatExclusionType>
			{
				items = response.snatExclusion,
				totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
				pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
				pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
				pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
			};
		}
		/// <summary>
		/// Restores Snat exclusions.
		/// </summary>
		/// <param name="networkDomainId">
		/// The network domain ID.
		/// </param>
		/// <returns>
		/// Response containing status.
		/// </returns>
		public async Task<ResponseType> RestoreSnatExclusions(Guid networkDomainId)
		{
			return await _apiClient.PostAsync<RestoreSnatExclusionsType, ResponseType>(
				ApiUris.RestoreSnatExclusions(_apiClient.OrganizationId),
				new RestoreSnatExclusionsType { networkDomainId = networkDomainId.ToString() });
		}

        /// <summary>
		/// This function create a new custom Snat Exclusion.
		/// </summary>
		/// <param name="SNATExclusion">
		/// The network Domain.
		/// </param>
		/// <returns>
		/// Response containing status.
		/// </returns>
		public async Task<ResponseType> AddSNATExclusion(AddSnatExclusionType SNATExclusion)
        {
            return await _apiClient.PostAsync<AddSnatExclusionType, ResponseType>(
                ApiUris.AddSnatExclusion(_apiClient.OrganizationId),
                SNATExclusion);
        }

        /// <summary>
		/// This function deletes a SNAT Exclusion.
		/// </summary>
		/// <param name="SNATExclusionId">
		/// The static route ID.
		/// </param>
		/// <returns>
		/// Response containing status.
		/// </returns>
		public async Task<ResponseType> RemoveSNATExclusion(Guid SNATExclusionId)
        {
            return await _apiClient.PostAsync<RemoveSnatExclusionType, ResponseType>(
                ApiUris.RemoveSnatExclusion(_apiClient.OrganizationId),
                new RemoveSnatExclusionType { id = SNATExclusionId.ToString() });
        }

    }
}
