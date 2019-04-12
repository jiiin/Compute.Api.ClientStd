using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client.Interfaces;
using DD.CBU.Compute.Api.Client.Interfaces.Network20;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Network20;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Network20;

namespace DD.CBU.Compute.Api.Client.Network20
{
    /// <summary>
    /// SSL accessor
    /// </summary>
    public class SslAccessor : ISslAccessor
    {
        /// <summary>
        /// The _client.
        /// </summary>
        private readonly IWebApi _apiClient;

        /// <summary>
        /// Initializes a new instance of SslAccessor
        /// </summary>
        /// <param name="apiClient">The client.</param>
        public SslAccessor(IWebApi apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// Get SSL Domain Certificate for given Id.
        /// </summary>
        /// <param name="sslDomainCertificateId">The SSL Domain Certificate Id</param>
        /// <returns>The SSL Domain Certificate/></returns>
        public async Task<SslDomainCertificateType> GetSslDomainCertificate(Guid sslDomainCertificateId)
        {
            return await _apiClient.GetAsync<SslDomainCertificateType>(
                ApiUris.GetSslDomainCertificate(_apiClient.OrganizationId, sslDomainCertificateId));
        }

        /// <summary>
        /// Retrieves SSL Domain Certificates.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of paged collection of <see cref="SslDomainCertificateType"/></returns>
        public async Task<PagedResponse<SslDomainCertificateType>> GetSslDomainCertificatesPaginated(
            SslDomainCertificateListOptions options = null, PageableRequest pagingOptions = null)
        {
            var response =
                await
                    _apiClient.GetAsync<sslDomainCertificates>(
                        ApiUris.ListSslDomainCertificates(_apiClient.OrganizationId), pagingOptions, options);

            return new PagedResponse<SslDomainCertificateType>
            {
                items = response.sslDomainCertificate,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?) null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?) null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?) null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?) null
            };
        }

        /// <summary>
        /// Get SSL Certificate Chain for given Id.
        /// </summary>
        /// <param name="sslCertificateChainId">The SSL Certificate Chain Id</param>
        /// <returns>The SSL Certificate Chain <see cref="SslCertificateChainType"/></returns>
        public async Task<SslCertificateChainType> GetSslCertificateChain(Guid sslCertificateChainId)
        {
            return await _apiClient.GetAsync<SslCertificateChainType>(
                ApiUris.GetSslCertificateChain(_apiClient.OrganizationId, sslCertificateChainId));
        }

        /// <summary>
        /// Retrieves SSL Domain Certificate Chaines.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslCertificateChains"/></returns>
        public async Task<PagedResponse<SslCertificateChainType>> GetSslCertificateChainesPaginated(
            SslCertificateChainListOptions options = null, PageableRequest pagingOptions = null)
        {
            var response =
                await
                    _apiClient.GetAsync<sslCertificateChains>(
                        ApiUris.ListSslCertificateChains(_apiClient.OrganizationId), pagingOptions, options);

            return new PagedResponse<SslCertificateChainType>
            {
                items = response.sslCertificateChain,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?) null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?) null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?) null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?) null
            };
        }

        /// <summary>
        /// Get SSL Offload Profile for given Id.
        /// </summary>
        /// <param name="sslOffloadProfileId">The SSL Offload Profile Id</param>
        /// <returns>The SSL Offload Profile/></returns>
        public async Task<SslOffloadProfileType> GetSslOffloadProfile(Guid sslOffloadProfileId)
        {
            return await _apiClient.GetAsync<SslOffloadProfileType>(
                ApiUris.GetSslSslOffloadProfile(_apiClient.OrganizationId, sslOffloadProfileId));
        }

        /// <summary>
        /// Retrieves SSL Offload Profiles.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslOffloadProfiles"/></returns>
        public async Task<PagedResponse<SslOffloadProfileType>> GetSslOffloadProfilesPaginated(SslOffloadProfileListOptions options = null, PageableRequest pagingOptions = null)
        {
            var response =
                await
                    _apiClient.GetAsync<sslOffloadProfiles>(
                        ApiUris.ListSslOffloadProfile(_apiClient.OrganizationId), pagingOptions, options);

            return new PagedResponse<SslOffloadProfileType>
            {
                items = response.sslOffloadProfile,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>
        /// Add a SSL Domain Certificate and Key to a Network Domain
        /// </summary>
        /// <param name="sslDomainCertificate">Details regarding the SSL Domain Certificate</param>
        /// <returns>Response Data</returns>
        public async Task<ResponseType> AddSslDomainCertificate(importSslDomainCertificate sslDomainCertificate)
        {
            return
                await
                    _apiClient.PostAsync<importSslDomainCertificate, ResponseType>(
                        ApiUris.ImportSslDomainCertificate(_apiClient.OrganizationId), sslDomainCertificate);
        }

        /// <summary>
        /// Add a SSL Domain Certificate Chain to a Network Domain
        /// </summary>
        /// <param name="sslCertificateChain">Details regarding the SSL Certificate Chain</param>
        /// <returns>Response Data</returns>
        public async Task<ResponseType> AddSslCertificateChain(importSslCertificateChain sslCertificateChain)
        {
            return
                await
                    _apiClient.PostAsync<importSslCertificateChain, ResponseType>(
                        ApiUris.ImportSslCertificateChain(_apiClient.OrganizationId), sslCertificateChain);
        }

        /// <summary>
        /// Create an SSL Offload Profile on a Network Domain
        /// </summary>
        /// <param name="sslOffloadProfile">Details regarding the SSL Offload Profile</param>
        /// <returns>Response Data</returns>
        public async Task<ResponseType> CreateSslOffloadProfile(createSslOffloadProfile sslOffloadProfile)
        {
            return
                await
                    _apiClient.PostAsync<createSslOffloadProfile, ResponseType>(
                        ApiUris.CreateSslOffloadProfile(_apiClient.OrganizationId), sslOffloadProfile);
        }

        /// <summary>
        /// Edit an SSL Offload Profile on a Network Domain
        /// </summary>
        /// <param name="sslOffloadProfile">Details regarding the SSL Offload Profile</param>
        /// <returns>Response Data</returns>
        public async Task<ResponseType> EditSslOffloadProfile(editSslOffloadProfile sslOffloadProfile)
        {
            return
                await
                    _apiClient.PostAsync<editSslOffloadProfile, ResponseType>(
                        ApiUris.EditSslOffloadProfile(_apiClient.OrganizationId), sslOffloadProfile);
        }

        /// <summary>
        /// Deletes SSL Domain Certificate.
        /// </summary>
        /// <param name="sslDomainCertificateId">The SSL Domain Certificate id.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        public async Task<ResponseType> DeleteSslDomainCertificate(Guid sslDomainCertificateId)
        {
            return
                await
                    _apiClient.PostAsync<deleteSslDomainCertificateIdType, ResponseType>(
                        ApiUris.DeleteSslDomainCertificate(_apiClient.OrganizationId),
                        new deleteSslDomainCertificateIdType { id = sslDomainCertificateId.ToString()});
        }

        /// <summary>
        /// Deletes SSL Certificate Chain.
        /// </summary>
        /// <param name="sslCertificateChainId">The SSL Certificate Chain id.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        public async Task<ResponseType> DeleteSslCertificateChain(Guid sslCertificateChainId)
        {
            return
                await
                    _apiClient.PostAsync<deleteSslCertificateChainIdType, ResponseType>(
                        ApiUris.DeleteSslCertificateChain(_apiClient.OrganizationId),
                        new deleteSslCertificateChainIdType { id = sslCertificateChainId.ToString()});

        }

        /// <summary>
        /// Deletes SSL Offload Profile.
        /// </summary>
        /// <param name="sslOffloadProfileId">The SSL Offload Profile id.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        public async Task<ResponseType> DeleteSslOffloadProfile(Guid sslOffloadProfileId)
        {
            return
                await
                    _apiClient.PostAsync<deleteSslOffloadProfileIdType, ResponseType>(
                        ApiUris.DeleteSslOffloadProfile(_apiClient.OrganizationId),
                        new deleteSslOffloadProfileIdType { id = sslOffloadProfileId.ToString()});
        }
    }
}
