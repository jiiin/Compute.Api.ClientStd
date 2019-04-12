using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Network20;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Network20;

namespace DD.CBU.Compute.Api.Client.Interfaces.Network20
{
    /// <summary>
    /// SSL accessor
    /// </summary>
    public interface ISslAccessor
    {
        /// <summary>
        /// Get SSL Domain Certificate for given Id.
        /// </summary>
        /// <param name="sslDomainCertificateId">The SSL Domain Certificate Id</param>
        /// <returns>The SSL Domain Certificate/></returns>
        Task<SslDomainCertificateType> GetSslDomainCertificate(Guid sslDomainCertificateId);

        /// <summary>
        /// Retrieves SSL Domain Certificates.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of paged collection of <see cref="SslDomainCertificateType"/></returns>
        Task<PagedResponse<SslDomainCertificateType>> GetSslDomainCertificatesPaginated(SslDomainCertificateListOptions options = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// Get SSL Certificate Chain for given Id.
        /// </summary>
        /// <param name="sslCertificateChainId">The SSL Certificate Chain Id</param>
        /// <returns>The SSL Certificate Chain <see cref="SslCertificateChainType"/></returns>
        Task<SslCertificateChainType> GetSslCertificateChain(Guid sslCertificateChainId);

        /// <summary>
        /// Retrieves SSL Domain Certificate Chaines.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslCertificateChains"/></returns>
        Task<PagedResponse<SslCertificateChainType>> GetSslCertificateChainesPaginated(SslCertificateChainListOptions options = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// Get SSL Offload Profile for given Id.
        /// </summary>
        /// <param name="sslOffloadProfileId">The SSL Offload Profile Id</param>
        /// <returns>The SSL Offload Profile/></returns>
        Task<SslOffloadProfileType> GetSslOffloadProfile(Guid sslOffloadProfileId);

        /// <summary>
        /// Retrieves SSL Offload Profiles.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslOffloadProfiles"/></returns>
        Task<PagedResponse<SslOffloadProfileType>> GetSslOffloadProfilesPaginated(SslOffloadProfileListOptions options = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// Add a SSL Domain Certificate and Key to a Network Domain
        /// </summary>
        /// <param name="sslDomainCertificate">Details regarding the SSL Domain Certificate</param>
        /// <returns>Response Data</returns>
        Task<ResponseType> AddSslDomainCertificate(importSslDomainCertificate sslDomainCertificate);
        
        /// <summary>
        /// Add a SSL Domain Certificate Chain to a Network Domain
        /// </summary>
        /// <param name="sslCertificateChain">Details regarding the SSL Certificate Chain</param>
        /// <returns>Response Data</returns>
        Task<ResponseType> AddSslCertificateChain(importSslCertificateChain sslCertificateChain);

        /// <summary>
        /// Create an SSL Offload Profile on a Network Domain
        /// </summary>
        /// <param name="sslOffloadProfile">Details regarding the SSL Offload Profile</param>
        /// <returns>Response Data</returns>
        Task<ResponseType> CreateSslOffloadProfile(createSslOffloadProfile sslOffloadProfile);

        /// <summary>
        /// Edit an SSL Offload Profile on a Network Domain
        /// </summary>
        /// <param name="sslOffloadProfile">Details regarding the SSL Offload Profile</param>
        /// <returns>Response Data</returns>
        Task<ResponseType> EditSslOffloadProfile(editSslOffloadProfile sslOffloadProfile);

        /// <summary>
        /// Deletes SSL Domain Certificate.
        /// </summary>
        /// <param name="sslDomainCertificateId">The SSL Domain Certificate id.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        Task<ResponseType> DeleteSslDomainCertificate(Guid sslDomainCertificateId);

        /// <summary>
        /// Deletes SSL Certificate Chain.
        /// </summary>
        /// <param name="sslCertificateChainId">The SSL Certificate Chain id.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        Task<ResponseType> DeleteSslCertificateChain(Guid sslCertificateChainId);
        
        /// <summary>
        /// Deletes SSL Offload Profile.
        /// </summary>
        /// <param name="sslOffloadProfileId">The SSL Offload Profile id.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        Task<ResponseType> DeleteSslOffloadProfile(Guid sslOffloadProfileId);
    }
}
