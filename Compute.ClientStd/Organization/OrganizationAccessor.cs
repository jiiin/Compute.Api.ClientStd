namespace DD.CBU.Compute.Api.Client.Infrastructure
{
    using System.Threading.Tasks;
    using Contracts.Network20;
    using Interfaces;
    using Interfaces.Organization;
    using Contracts.Organization;

    /// <summary>
    /// The AccountAccessor interface.
    /// </summary>
    public class OrganizationAccessor : IOrganizationAccessor
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
        public OrganizationAccessor(IWebApi apiClient)
        {
            this._apiClient = apiClient;
        }

        /// <summary>
        /// The Get Organization
        /// </summary>
        /// <returns>Geo Regions</returns>
        public async Task<organization> GetOrganization()
        {
            return await _apiClient.GetAsync<organization>(ApiUris.GetOrganization(_apiClient.OrganizationId));
        }

        /// <summary>
        /// The Set Vpn Access.
        /// </summary>
        /// <param name="request">The Set VPN access request.</param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<ResponseType> SetVpnAccess(setVpnAccess request)
        {
            return await _apiClient.PostAsync<setVpnAccess, ResponseType>(ApiUris.SetVpnAccess(_apiClient.OrganizationId), request);
        }
    }
}