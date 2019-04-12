using DD.CBU.Compute.Api.Contracts.Snapshot;

namespace DD.CBU.Compute.Api.Client.Interfaces.Server20
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts.General;
    using Contracts.Network20;
    using Contracts.Requests;
    using Contracts.Requests.Server20;
    using Contracts.Server;
    using ServerType = Contracts.Network20.ServerType;

	/// <summary>
	/// The ServerAccessor interface.
	/// </summary>
	public interface IServerAccessor
	{
		/// <summary>The get mcp 2 deployed servers.</summary>
		/// <param name="filteringOptions">The filtering options.</param>
		/// <param name="pagingOptions">The paging options.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		[Obsolete("Inconsistent: Use 'GetServers' or 'GetServersPaginated' instead.")]
		Task<ServersResponseCollection> GetMcp2DeployedServers(ServerListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

		/// <summary>The get mcp 2 deployed servers.</summary>
		/// <param name="filteringOptions">The filtering options.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<IEnumerable<ServerType>> GetServers(ServerListOptions filteringOptions = null);

	    /// <summary>The get mcp 2 deployed servers.</summary>
	    /// <param name="filteringOptions">The filtering options.</param>
	    /// <returns>The <see cref="Task"/>.</returns>
	    Task<IEnumerable<ServerSummaryType>> ListServers(ServerListOptions filteringOptions = null);

		/// <summary>The get mcp 2 deployed servers.</summary>
		/// <param name="filteringOptions">The filtering options.</param>
		/// <param name="pagingOptions">The paging options.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<PagedResponse<ServerType>> GetServersPaginated(ServerListOptions filteringOptions = null, IPageableRequest pagingOptions = null);
        
        /// <summary>The get mcp 2 deployed servers.</summary>
		/// <param name="filteringOptions">The filtering options.</param>
		/// <param name="pagingOptions">The paging options.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<PagedResponse<ServerSummaryType>> ListServersPaginated(ServerListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

		/// <summary>The get mcp 2 deployed server.</summary>
		/// <param name="serverId">The server id.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		[Obsolete("Inconsistent: Use 'GetServer' instead.")]
		Task<ServerType> GetMcp2DeployedServer(Guid serverId);

		/// <summary>The get mcp 2 deployed server.</summary>
		/// <param name="serverId">The server id.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ServerType> GetServer(Guid serverId);

	    /// <summary>The get mcp 2 deployed server.</summary>
	    /// <param name="serverId">The server id.</param>
	    /// <returns>The <see cref="Task"/>.</returns>
	    Task<ServerDetailType> GetServerDetails(Guid serverId);

		/// <summary>	Deletes the server described by serverId. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> DeleteServer(Guid serverId);

		/// <summary>	Starts a server. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> StartServer(Guid serverId);

		/// <summary>	Shutdown server. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> ShutdownServer(Guid serverId);

		/// <summary>	Reboot server. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> RebootServer(Guid serverId);

		/// <summary>	Resets the server described by serverId. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> ResetServer(Guid serverId);

		/// <summary>	Power off server. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> PowerOffServer(Guid serverId);

		/// <summary>	Updates the v mware tools described by serverId. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> UpdateVmwareTools(Guid serverId);

		/// <summary>	Updates the vistual hardware for serverId. </summary>
		/// <param name="serverId">	The server id. </param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> UpgradeVirtualHardware(Guid serverId);

		/// <summary>Deploys a server to MCP1.0 or MCP 2.0 data centers </summary>
		/// <param name="serverDetails">Details of the server to be deployed</param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> DeployServer(DeployServerType serverDetails);

		/// <summary>Cleans a failed server deployment.</summary>
		/// <param name="serverId">The server id.</param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> CleanServer(Guid serverId);

	    /// <summary>Adds an additional NIC to a server.</summary>
	    /// <param name="serverId">The server id.</param>
	    /// <param name="vlanId">The VLAN id</param>
	    /// <param name="privateIpv4">The Private IP v4 address</param>
	    /// <param name="networkAdapter">The optional network adapter type (E1000 or VMXNET3)</param>
	    /// <param name="connected">The NIC Connection state</param>
	    /// <returns>	A standard CaaS response </returns>
	    Task<ResponseType> AddNic(Guid serverId, Guid? vlanId, string privateIpv4, string networkAdapter = null, bool? connected = null);
		
		/// <summary>Adds an additional NIC to a server.</summary>
		/// <param name="addNicType">The server id.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> AddNic(AddNicType addNicType);

		/// <summary>Exchange Nic Vlans.</summary>
		/// <param name="nicId1">nicId1</param>
		/// <param name="nicId2">nicId2</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> ExchangeNicVlans(string nicId1, string nicId2);

		/// <summary>Removes an additional NIC from a server.</summary>
		/// <param name="nicId">The NIC id.</param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> RemoveNic(Guid nicId);

		/// <summary>The list nics.</summary>
		/// <param name="vlanId">The vlan id.</param>
		/// <param name="filteringOptions">The filtering options.</param>
		/// <param name="pagingOptions">The paging options.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<PagedResponse<NicWithSecurityGroupType>> ListNics(Guid vlanId, ListNicsOptions filteringOptions = null, IPageableRequest pagingOptions = null);

		/// <summary>Updates the Cloud record to match the value set on the deployed server.</summary>
		/// <param name="notifyNicIpChange">The Notify NIC IP change model.</param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> NotifyNicIpChange(NotifyNicIpChangeType notifyNicIpChange);

		/// <summary>Updates compute resource properties of a Server </summary>
		/// <param name="reconfigureServer">Details of the server to be updated</param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> ReconfigureServer(ReconfigureServerType reconfigureServer);

		/// <summary>The add disk.</summary>
		/// <param name="addDisk">The add disk.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> AddDisk(AddDiskType addDisk);

		/// <summary>The remove disk.</summary>
		/// <param name="removeDisk">The remove disk.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> RemoveDisk(RemoveDiskType removeDisk);

		/// <summary>Edit metadata of the server</summary>
		/// <param name="editServerMetadata">Server metadata change model.</param>
		/// <returns>The async type of <see cref="ResponseType"/></returns>
		Task<ResponseType> EditServerMetadata(editServerMetadata editServerMetadata);

		/// <summary>Move server to cluster</summary>
		/// <param name="moveServer">move server model.</param>
		/// <returns>The async type of <see cref="ResponseType"/></returns>
		Task<ResponseType> MoveServer(MoveServerType moveServer);

	    /// <summary>The move server to cluster.</summary>
	    /// <param name="copyServer">The copy server.</param>
	    /// <returns>The <see cref="Task"/>.</returns>
	    Task<ResponseType> CopyServer(CopyServerType copyServer);

		/// <summary>Deploys an un customized server to MCP 2.0 data centers </summary>
		/// <param name="serverDetails">Details of the server to be deployed</param>
		/// <returns>Response containing the server id</returns>
		Task<ResponseType> DeployUncustomizedServer(DeployUncustomizedServerType serverDetails);

		/// <summary>
		/// Clone journal
		/// </summary>
		/// <param name="cloneServerType">Clone Server type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> CloneServer(CloneServerType cloneServerType);

		/// <summary>Change the Network Adaptor of a NIC on a Cloud Server </summary>
		/// <param name="changeNetworkAdapter">Details of the nic's network adapter to be updated</param>
		/// <returns>	A standard CaaS response </returns>
		Task<ResponseType> ChangeNicNetworkAdapter(changeNetworkAdapterType changeNetworkAdapter);

		/// <summary>
		/// Create Anti-Affinity rule
		/// </summary>
		/// <param name="antiAffinityRule"> The request model</param>
		/// <returns></returns>
		Task<ResponseType> CreateAntiAffinityRule(createAntiAffinityRule antiAffinityRule);

		/// <summary>
		/// Delete Anti-Affinity rule
		/// </summary>
		/// <param name="id">Id of the rule to be deleted</param>
		/// <returns></returns>
		Task<ResponseType> DeleteAntiAffinityRule(IdType id);

		/// <summary>The add scsi controller.</summary>
		/// <param name="addScsiController">The add scsi controller.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> AddScsiController(AddScsiControllerType addScsiController);

		/// <summary>The remove scsi controller.</summary>
		/// <param name="removeScsiControllerId">The remove scsi controller id.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> RemoveScsiController(RemoveScsiControllerIdType removeScsiControllerId);

		/// <summary>The remove ISO file.</summary>
		/// <param name="id">The id of device.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> RemoveIsoFile(IdType id);

		/// <summary>The remove FLP file.</summary>
		/// <param name="id">The id of floppy.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> RemoveFlpFile(IdType id);

		/// <summary>
		/// Set Nic Connectivity
		/// </summary>
		/// <param name="setNicConnectivityType">Nic Connectivity Type.</param>
		Task<ResponseType> SetNicConnectivity(SetNicConnectivityType setNicConnectivityType);

        /// <summary>
		/// Set or unset scripts to be run before and/or after a Server Snapshot is taken.
		/// </summary>
		/// <param name="editSnapshotServiceScriptsType">Edit Snapshot Service Scripts Type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> EditSnapshotServiceScripts(EditSnapshotServiceScriptsType editSnapshotServiceScriptsType);

        /// <summary>
        /// Enable snapshot service
        /// </summary>
        /// <param name="enableSnapshotServiceType">Enable Snapshot Service Type.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        Task<ResponseType> EnableSnapshotService(EnableSnapshotServiceType enableSnapshotServiceType);

		/// <summary>
		/// Disable snapshot service
		/// </summary>
		/// <param name="disableSnapshotServiceType">Server Id to disable the snapshot service.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> DisableSnapshotService(DisableSnapshotServiceType disableSnapshotServiceType);

        /// <summary>
		/// Disable snapshot replication
		/// </summary>
		/// <param name="disableReplicationType">Server Id to disable the snapshot replication.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> DisableServerSnapshotReplication(DisableReplicationType disableReplicationType);

        /// <summary>
        /// Initiate manual snapshot
        /// </summary>
        /// <param name="initiateManualSnapshotType">Server Id and description to initiate manual snapshot.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        Task<ResponseType> InitiateManualSnapshot(InitiateManualSnapshotType initiateManualSnapshotType);

		/// <summary>
		/// Delete manual snapshot
		/// </summary>
		/// <param name="id">Snapshot Id to delete manual snapshot.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> DeleteManualSnapshot(DeleteManualSnapshotType id);

	    /// <summary>The change disk iops.</summary>
	    /// <param name="diskIops">The change disk iops.</param>
	    /// <returns>The <see cref="Task"/>.</returns>
	    Task<ResponseType> ChangeDiskIops(ChangeDiskIopsType diskIops);

	    /// <summary>The change disk size.</summary>
	    /// <param name="changeDisk">The change disk size.</param>
	    /// <returns>The <see cref="Task"/>.</returns>
	    Task<ResponseType> ExpandDiskSize(ExpandDiskType changeDisk);

	    /// <summary>The change disk speed and iops.</summary>
	    /// <param name="changeDiskSpeed">The change disk speed.</param>
	    /// <returns>The <see cref="Task"/>.</returns>
	    Task<ResponseType> ChangeDiskSpeed(ChangeDiskSpeedType changeDiskSpeed);

		/// <summary>
		/// Change snapshot service plan
		/// </summary>
		/// <param name="changeSnapshotServicePlanType">Change Snapshot Service Plan Type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> ChangeSnapshotServicePlan(ChangeSnapshotServicePlanType changeSnapshotServicePlanType);

		/// <summary>
		/// Edit Snapshot Metadata
		/// </summary>
		/// <param name="editSnapshotMetadataType">Edit Snapshot Metadata Type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> EditSnapshotMetadata(EditSnapshotMetadataType editSnapshotMetadataType);

		/// <summary>
		/// Restore From Snapshot.
		/// </summary>
		/// <param name="restoreFromSnapshotType">Restore a file or folder from snapshot.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> RestoreFromSnapshot(RestoreFromSnapshotType restoreFromSnapshotType);

		/// <summary>
		/// Enable snapshot replication.
		/// </summary>
		/// <param name="enableReplication">Server Id and datacenter id to initiate manual snapshot.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> EnableSnapshotReplication(EnableReplicationType enableReplication);

		/// <summary>
		/// Create Drs Target Server.
		/// </summary>
		/// <param name="createDrsTargetServer">Drs Target Server details</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> CreateDrsTargetServer(CreateDrsTargetServerType createDrsTargetServer);
	}
}