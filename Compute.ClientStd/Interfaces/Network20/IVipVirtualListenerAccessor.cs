using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.ContractsStd.General;
using DD.CBU.Compute.Api.ContractsStd.Network20;
using DD.CBU.Compute.Api.ContractsStd.Requests;
using DD.CBU.Compute.Api.ContractsStd.Requests.Network20;

namespace DD.CBU.Compute.Api.ClientStd.Interfaces.Network20
{
    /// <summary>
    /// The VIP Virtual Listener Management interface.
    /// </summary>
    public interface IVipVirtualListenerAccessor
    {
        /// <summary>
        /// Creates a VirtualListener on a Network Domain in an MCP 2.0 data center location.
        /// </summary>
        /// <param name="virtualListener">The create virtual listener.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        Task<ResponseType> CreateVirtualListener(createVirtualListener virtualListener);

        /// <summary>
        /// Retrieves all of the VirtualListeners on a particular Network Domain at an MCP 2.0 data center.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <returns>The async task of collection of <see cref="VirtualListenerType"/></returns>
        Task<IEnumerable<VirtualListenerType>> GetVirtualListeners(VirtualListenerListOptions options = null);

        /// <summary>
        /// Retrieves all of the VirtualListeners on a particular Network Domain at an MCP 2.0 data center.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions"> The paging Options.</param>
        /// <returns>The async task of <see cref="PagedResponse{VirtualListenerType}"/></returns>
        Task<PagedResponse<VirtualListenerType>> GetVirtualListenersPaginated(VirtualListenerListOptions options = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// Returns details of a single VirtualListener.
        /// </summary>
        /// <param name="virtualListenerId">The VirtualListener id.</param>
        /// <returns>The async task of <see cref="VirtualListenerType"/></returns>
        Task<VirtualListenerType> GetVirtualListener(Guid virtualListenerId);

        /// <summary>
        /// Updates the mutable properties of a VirtualListener.
        /// </summary>
        /// <param name="virtualListener">The edit virtualListener.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        Task<ResponseType> EditVirtualListener(editVirtualListener virtualListener);

        /// <summary>
        /// Deletes a VirtualListener.
        /// </summary>
        /// <param name="virtualListenerId">The VirtualListener id.</param>
        /// <returns>The async task of <see cref="ResponseType"/></returns>
        Task<ResponseType> DeleteVirtualListener(Guid virtualListenerId);
    }
}