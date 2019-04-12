namespace DD.CBU.Compute.Api.Client.Interfaces.Organization
{
    using System.Threading.Tasks;
    using Contracts.Network20;
    using Contracts.Organization;

    /// <summary>
    /// The OrganizationAccessor interface.
    /// </summary>
    public interface IOrganizationAccessor
    {
        /// <summary>
        /// The get organization.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<organization> GetOrganization();

        /// <summary>
        /// The Set Vpn Access.
        /// </summary>
        /// <param name="request">The Set VPN access request.</param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ResponseType> SetVpnAccess(setVpnAccess request);
    }
}