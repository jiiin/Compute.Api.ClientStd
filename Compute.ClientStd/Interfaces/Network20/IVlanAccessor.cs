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
    /// The VlanAccessor interface.
    /// </summary>
    public interface IVlanAccessor
    {
        /// <summary>
        /// 	Retrieves the list of ACL rules associated with a network. This API requires your
        /// 	organization ID and the ID of the target network.
        /// </summary>		
        /// <param name="options">
        /// 	Options for controlling the operation. 
        /// </param>
        /// <returns>
        /// 	The VLAN collection. 
        /// </returns>
        Task<IEnumerable<VlanType>> GetVlans(VlanListOptions options = null);

        /// <summary>
        /// 	Retrieves the list of ACL rules associated with a network. This API requires your
        /// 	organization ID and the ID of the target network.
        /// </summary>		
        /// <param name="options">
        /// 	Options for controlling the operation. 
        /// </param>
        /// <param name="pagingOptions">
        /// 	Options for controlling the paging. 
        /// </param>
        /// <returns>
        /// 	The VLAN collection. 
        /// </returns>
        Task<PagedResponse<VlanType>> GetVlansPaginated(VlanListOptions options = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// 	The get VLAN list. 
        /// </summary>		
        /// <param name="id">
        /// 	The id. 
        /// </param>
        /// <param name="vlanName">
        /// 	The VLAN name. 
        /// </param>
        /// <param name="networkDomainId">
        /// 	The network domain id. 
        /// </param>
        /// <param name="pagingOptions">
        ///     The paging Options.
        /// </param>
        /// <returns>
        /// 	The <see cref="Task"/>. 
        /// </returns>
        [Obsolete("Inconsistent: Use GetVlans(VlanOptions options) or GetVlans(GetVlansPaginated options, PageableRequest pagingOptions) instead.")]
        Task<IEnumerable<VlanType>> GetVlans(Guid id, string vlanName, Guid networkDomainId, PageableRequest pagingOptions = null);

        /// <summary>
        /// 	An IComputeApiClient extension method that gets a VLAN. 
        /// </summary>
        /// <param name="vlanId">
        /// 	The id. 
        /// </param>
        /// <returns>
        /// 	The vlan. 
        /// </returns>
        Task<VlanType> GetVlan(Guid vlanId);

        /// <summary>
        /// Deploys Virtual LAN on a network domain
        /// </summary>
        /// <param name="vlan">
        /// Virtual LAN
        /// </param>
        /// <returns>
        /// Operation status
        /// </returns>
        Task<ResponseType> DeployVlan(DeployVlanType vlan);

        /// <summary>
        /// Edit Virtual LAN on a network domain.
        /// </summary>
        /// <param name="editVlan">
        /// Edit Virtual LAN request.
        /// </param>
        /// <returns>
        /// Operation status
        /// </returns>
        Task<ResponseType> EditVlan(EditVlanType editVlan);

        /// <summary>
        /// API operation to detach an attached VLAN.   users can switch between Detached and Attached VLANs. 
        /// Requires ipv4GatewayAddress input, ipv4GatewayAddress can be ANY valid IPv4 address(i.e.it does NOT have to be on the VLAN range) except:
        ///           The Network Address(x.x.x.0) at the start of range of the VLAN Being Detached on the Network Domain(Q26)
        ///           The Broadcast Address(x.x.x.255) at the end of range of VLAN Being Detached on the Network Domain
        /// Optional ipv6GatewayAddress can be ANY valid IPv6 address(i.e.it does NOT have to be on the VLAN range) except:
        ///           Any of the first 32 IPv6 addresses on the VLAN Being Detached for which the gateway is being submitted.
        ///               per(Q24) answer, the last IPv6 address in the range is a valid address and can be used
        /// </summary>
        /// <param name="detachVlan"></param>
        /// <returns></returns>
        Task<ResponseType> DetachVlan(DetachVlanType detachVlan);

        /// <summary>
        /// API operation to attach (or re-attach) a Detached VLAN.   gatewayAddressing may be LOW or HIGH. Will default to LOW if not specified in request.
        /// </summary>
        /// <param name="attachVlan"></param>
        /// <returns></returns>
        Task<ResponseType> AttachVlan(AttachVlanType attachVlan);

        /// <summary>
        /// Expand Virtual LAN on a network domain.
        /// </summary>
        /// <param name="expandVlan">
        /// Expand Virtual LAN request.
        /// </param>
        /// <returns>
        /// Operation status
        /// </returns>
        Task<ResponseType> ExpandVlan(ExpandVlanType expandVlan);

        /// <summary>
        /// Delete a Virtual LAN 
        /// </summary>
        /// <param name="id">
        /// The id of the VLAN. 
        /// </param>
        /// <returns>
        /// Operation status
        /// </returns>
        Task<ResponseType> DeleteVlan(Guid id);
    }
}
