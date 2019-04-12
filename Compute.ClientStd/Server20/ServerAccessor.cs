using DD.CBU.Compute.Api.Contracts.Server;
using DD.CBU.Compute.Api.Contracts.Snapshot;

namespace DD.CBU.Compute.Api.Client.Server20
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts.General;
    using Contracts.Network20;
    using Contracts.Requests;
    using Contracts.Requests.Server20;
    using Interfaces;
    using Interfaces.Server20;

    /// <summary>
    /// The server 2.0 accessor.
    /// </summary>
    public class ServerAccessor : IServerAccessor
    {
        /// <summary>
        /// The _api client.
        /// </summary>
        private readonly IWebApi _apiClient;

        /// <summary>Initialises a new instance of the <see cref="ServerAccessor"/> class.</summary>
        /// <param name="apiClient">The api client.</param>
        public ServerAccessor(IWebApi apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Obsolete("Inconsistent: Use 'GetServers' or 'GetServersPaginated' instead.")]
        public async Task<ServersResponseCollection> GetMcp2DeployedServers(ServerListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            ServersResponseCollection servers = await _apiClient.GetAsync<ServersResponseCollection>(
                ApiUris.GetMcp2Servers(_apiClient.OrganizationId),
                pagingOptions,
                filteringOptions);
            return servers;
        }

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<IEnumerable<ServerType>> GetServers(ServerListOptions filteringOptions = null)
        {
            var response = await GetServersPaginated(filteringOptions, null);
            return response.items;
        }

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<IEnumerable<ServerSummaryType>> ListServers(ServerListOptions filteringOptions = null)
        {
            var response = await ListServersPaginated(filteringOptions, null);
            return response.items;
        }

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<PagedResponse<ServerType>> GetServersPaginated(ServerListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<ServersResponseCollection>(
                ApiUris.GetMcp2Servers(_apiClient.OrganizationId),
                pagingOptions,
                filteringOptions);

            return new PagedResponse<ServerType>
            {
                items = response.Server,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<PagedResponse<ServerSummaryType>> ListServersPaginated(ServerListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<ServersSummaryResposeType>(
                ApiUris.ListServers(_apiClient.OrganizationId),
                pagingOptions,
                filteringOptions);

            return new PagedResponse<ServerSummaryType>
            {
                items = response.server,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>The get mcp 2 deployed server.</summary>
        /// <param name="serverId">The server id.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Obsolete("Inconsistent: Use 'GetServer' instead.")]
        public async Task<ServerType> GetMcp2DeployedServer(Guid serverId)
        {
            return await GetServer(serverId);
        }

        /// <summary>The get mcp 2 deployed server.</summary>
        /// <param name="serverId">The server id.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ServerType> GetServer(Guid serverId)
        {
            return await _apiClient.GetAsync<ServerType>(ApiUris.GetMcp2Server(_apiClient.OrganizationId, serverId));
        }

        /// <summary>The get mcp 2 deployed server.</summary>
        /// <param name="serverId">The server id.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ServerDetailType> GetServerDetails(Guid serverId)
        {
            return await _apiClient.GetAsync<ServerDetailType>(ApiUris.GetServerDetails(_apiClient.OrganizationId, serverId));
        }

        /// <summary>	Deletes the server described by serverId. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        /// <seealso cref="M:DD.CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor.DeleteServer(Guid)"/>
        public async Task<ResponseType> DeleteServer(Guid serverId)
        {
            return await _apiClient.PostAsync<DeleteServerType, ResponseType>(ApiUris.DeleteServer(_apiClient.OrganizationId),
                new DeleteServerType { id = serverId.ToString() });
        }

        /// <summary>	Starts a server. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        /// <seealso cref="M:DD.CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor.StartServer(Guid)"/>
        public async Task<ResponseType> StartServer(Guid serverId)
        {
            return await _apiClient.PostAsync<StartServerType, ResponseType>(ApiUris.StartServer(_apiClient.OrganizationId),
                new StartServerType { id = serverId.ToString() });
        }

        /// <summary>	Shutdown server. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        /// <seealso cref="M:DD.CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor.ShutdownServer(Guid)"/>
        public async Task<ResponseType> ShutdownServer(Guid serverId)
        {
            return await _apiClient.PostAsync<ShutdownServerType, ResponseType>(ApiUris.ShutdownServer(_apiClient.OrganizationId),
                new ShutdownServerType { id = serverId.ToString() });
        }

        /// <summary>	Reboot server. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        /// <seealso cref="M:DD.CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor.RebootServer(Guid)"/>
        public async Task<ResponseType> RebootServer(Guid serverId)
        {
            return await _apiClient.PostAsync<RebootServerType, ResponseType>(ApiUris.RebootServer(_apiClient.OrganizationId),
                new RebootServerType { id = serverId.ToString() });
        }

        /// <summary>	Resets the server described by serverId. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        /// <seealso cref="M:DD.CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor.ResetServer(Guid)"/>
        public async Task<ResponseType> ResetServer(Guid serverId)
        {
            return await _apiClient.PostAsync<ResetServerType, ResponseType>(ApiUris.ResetServer(_apiClient.OrganizationId),
                new ResetServerType { id = serverId.ToString() });
        }

        /// <summary>	Power off server. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        /// <seealso cref="M:DD.CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor.PowerOffServer(Guid)"/>
        public async Task<ResponseType> PowerOffServer(Guid serverId)
        {
            return await _apiClient.PostAsync<PowerOffServerType, ResponseType>(ApiUris.PowerOffServer(_apiClient.OrganizationId),
                new PowerOffServerType { id = serverId.ToString() });
        }

        /// <summary>	Updates the v mware tools described by serverId. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        /// <seealso cref="M:DD.CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor.UpdateVmwareTools(Guid)"/>
        public async Task<ResponseType> UpdateVmwareTools(Guid serverId)
        {
            return await _apiClient.PostAsync<UpdateVmwareToolsServerType, ResponseType>(ApiUris.UpdateVmwareTools(_apiClient.OrganizationId),
                new UpdateVmwareToolsServerType { id = serverId.ToString() });
        }

        /// <summary>	Upgrade virtual hardware for the server. </summary>
        /// <param name="serverId">	The server id. </param>
        /// <returns>	A standard CaaS response. </returns>
        public async Task<ResponseType> UpgradeVirtualHardware(Guid serverId)
        {
            return await _apiClient.PostAsync<UpgradeVirtualHardware, ResponseType>(ApiUris.UpgradeVirtualHardware(_apiClient.OrganizationId),
                new UpgradeVirtualHardware { id = serverId.ToString() });
        }

        /// <summary>Deploys a server to MCP1.0 or MCP 2.0 data centers </summary>
        /// <param name="serverDetails">Details of the server to be deployed</param>
        /// <returns>Response containing the server id</returns>
        public async Task<ResponseType> DeployServer(DeployServerType serverDetails)
        {
            return await _apiClient.PostAsync<DeployServerType, ResponseType>(
                ApiUris.DeployMCP20Server(_apiClient.OrganizationId),
                serverDetails);
        }

        /// <summary>Cleans a failed server deployment.</summary>
        /// <param name="serverId">The server id.</param>
        /// <returns>	A standard CaaS response </returns>
        public async Task<ResponseType> CleanServer(Guid serverId)
        {
            return await _apiClient.PostAsync<CleanServerType, ResponseType>(
                ApiUris.CleanServer(_apiClient.OrganizationId),
                new CleanServerType { id = serverId.ToString() });
        }

		/// <summary>Adds an additional NIC to a server.</summary>
		/// <param name="serverId">The server id.</param>
		/// <param name="vlanId">The VLAN id</param>
		/// <param name="privateIpv4">The Private IP v4 address</param>
		/// <param name="networkAdapter">The optional network adapter type (E1000 or VMXNET3)</param>
		/// <param name="connected">The NIC connection state</param>
		/// <returns>The <see cref="Task"/>.</returns>
		[Obsolete("use AddNic(AddNicType addNicType) instead.")]
		public async Task<ResponseType> AddNic(Guid serverId, Guid? vlanId, string privateIpv4, string networkAdapter = null, bool? connected = null)
        {
            if (vlanId == null && string.IsNullOrEmpty(privateIpv4))
            {
                throw new ArgumentNullException("vlanId");
            }

            var nic = new NewNicType
            {
                networkAdapter = networkAdapter
            };

            // Private IP takes priority over vlanId
            // As Setting VlanId will make the api allocate the ip automatically ignoring the privateIp
            if (!string.IsNullOrEmpty(privateIpv4))
            {
                nic.privateIpv4 = privateIpv4;
            }
            else
            {
                nic.vlanId = vlanId.ToString();
            }

            //if (connected != null)
            //{
            //    nic.connected = connected.Value;
            //}

            AddNicType addNicType = new AddNicType
            {
                serverId = serverId.ToString(),
                nic = nic
            };

            return await _apiClient.PostAsync<AddNicType, ResponseType>(ApiUris.AddNic(_apiClient.OrganizationId), addNicType);
        }

		/// <summary>Adds an additional NIC to a server.</summary>
		/// <param name="addNicType">The server id.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		public async Task<ResponseType> AddNic(AddNicType addNicType)
	    {
			return await _apiClient.PostAsync<AddNicType, ResponseType>(ApiUris.AddNic(_apiClient.OrganizationId), addNicType);
		}

	    /// <summary>Exchange Nic Vlans.</summary>
		/// <param name="nicId1">nicId1</param>
		/// <param name="nicId2">nicId2</param>
		/// <returns>The <see cref="Task"/>.</returns>
		public async Task<ResponseType> ExchangeNicVlans(string nicId1, string nicId2)
        {
            if (string.IsNullOrWhiteSpace(nicId1))
            {
                throw new ArgumentNullException("nicId1");
            }

            if (string.IsNullOrWhiteSpace(nicId2))
            {
                throw new ArgumentNullException("nicId2");
            }


            ExchangeNicVlansType exchangeNicVlansType = new ExchangeNicVlansType
            {
                nicId1 = nicId1,
                nicId2 = nicId2
            };

            return await _apiClient.PostAsync<ExchangeNicVlansType, ResponseType>(ApiUris.ExchangeNicVlans(_apiClient.OrganizationId), exchangeNicVlansType);
        }

        /// <summary>Removes an additional NIC from a server.</summary>
        /// <param name="nicId">The NIC id.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> RemoveNic(Guid nicId)
        {
            if (nicId == Guid.Empty)
            {
                throw new ArgumentException("'nicId' cannot be empty.");
            }

            return await _apiClient.PostAsync<RemoveNicType, ResponseType>(
                ApiUris.RemoveNic(_apiClient.OrganizationId),
                new RemoveNicType { id = nicId.ToString() });
        }

        /// <summary>The list nics.</summary>
        /// <param name="vlanId">The vlan id.</param>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<PagedResponse<NicWithSecurityGroupType>> ListNics(Guid vlanId, ListNicsOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            if (vlanId == Guid.Empty)
            {
                throw new ArgumentException("'vlanId' cannot be empty.");
            }

            var response = await _apiClient.GetAsync<nics>(ApiUris.ListNics(_apiClient.OrganizationId, vlanId), pagingOptions, filteringOptions);
            return new PagedResponse<NicWithSecurityGroupType>
            {
                items = response.nic,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>Updates the Cloud record to match the value set on the deployed server.</summary>
        /// <param name="notifyNicIpChange">The Notify NIC IP change model.</param>
        /// <returns>The async type of <see cref="ResponseType"/></returns>
        public async Task<ResponseType> NotifyNicIpChange(NotifyNicIpChangeType notifyNicIpChange)
        {
            return
                await
                    _apiClient.PostAsync<NotifyNicIpChangeType, ResponseType>(
                        ApiUris.NotifyNicIpChange(_apiClient.OrganizationId), notifyNicIpChange);
        }

        /// <summary>Edit metadata of the server</summary>
        /// <param name="editServerMetadata">Server metadata change model.</param>
        /// <returns>The async type of <see cref="ResponseType"/></returns>
        public async Task<ResponseType> EditServerMetadata(editServerMetadata editServerMetadata)
        {
            return await _apiClient.PostAsync<editServerMetadata, ResponseType>(ApiUris.EditServerMetadata(_apiClient.OrganizationId), editServerMetadata);
        }

        /// <summary>Updates compute resource properties of a Server </summary>
        /// <param name="reconfigureServer">Details of the server to be updated</param>
        /// <returns>	A standard CaaS response </returns>
        public async Task<ResponseType> ReconfigureServer(ReconfigureServerType reconfigureServer)
        {
            return await _apiClient.PostAsync<ReconfigureServerType, ResponseType>(
                ApiUris.ReconfigureServer(_apiClient.OrganizationId),
                reconfigureServer);
        }

        /// <summary>The add disk.</summary>
        /// <param name="addDisk">The add disk.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> AddDisk(AddDiskType addDisk)
        {
            return await _apiClient.PostAsync<AddDiskType, ResponseType>(ApiUris.AddDisk(_apiClient.OrganizationId), addDisk);
        }


        /// <summary>The remove disk.</summary>
        /// <param name="removeDisk">The remove disk.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> RemoveDisk(RemoveDiskType removeDisk)
        {
            return await _apiClient.PostAsync<RemoveDiskType, ResponseType>(ApiUris.RemoveDisk(_apiClient.OrganizationId), removeDisk);
        }

        /// <summary>The move server to cluster.</summary>
        /// <param name="moveServer">The move server.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> MoveServer(MoveServerType moveServer)
        {
            return await _apiClient.PostAsync<MoveServerType, ResponseType>(ApiUris.MoveServerToCluster(_apiClient.OrganizationId), moveServer);
        }

        /// <summary>The move server to cluster.</summary>
        /// <param name="copyServer">The copy server.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> CopyServer(CopyServerType copyServer)
        {
            return await _apiClient.PostAsync<CopyServerType, ResponseType>(ApiUris.CopyServer(_apiClient.OrganizationId), copyServer);
        }

        /// <summary>Deploys an un customized server to MCP 2.0 data centers </summary>
        /// <param name="serverDetails">Details of the server to be deployed</param>
        /// <returns>Response containing the server id</returns>
        public async Task<ResponseType> DeployUncustomizedServer(DeployUncustomizedServerType serverDetails)
        {
            return await _apiClient.PostAsync<DeployUncustomizedServerType, ResponseType>(
                ApiUris.DeployUncustomizedServer(_apiClient.OrganizationId),
                serverDetails);
        }

        /// <summary>
        /// Clone journal
        /// </summary>
        /// <param name="cloneServerType">Clone Server type.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        public async Task<ResponseType> CloneServer(CloneServerType cloneServerType)
        {
            return await _apiClient.PostAsync<CloneServerType, ResponseType>(ApiUris.CloneServer(_apiClient.OrganizationId), cloneServerType);
        }

        /// <summary>Change the Network Adaptor of a NIC on a Cloud Server </summary>
        /// <param name="changeNetworkAdapter">Details of the nic's network adapter to be updated</param>
        /// <returns>	A standard CaaS response </returns>
        public async Task<ResponseType> ChangeNicNetworkAdapter(changeNetworkAdapterType changeNetworkAdapter)
        {
            return await _apiClient.PostAsync<changeNetworkAdapterType, ResponseType>(ApiUris.ChangeNicNetworkAdapter(_apiClient.OrganizationId), changeNetworkAdapter);
        }

        /// <summary>
        /// Create Anti Affinity rule
        /// </summary>
        /// <param name="antiAffinityRule"> The request model</param>
        /// <returns></returns>
        public async Task<ResponseType> CreateAntiAffinityRule(createAntiAffinityRule antiAffinityRule)
        {
            return
                await
                    _apiClient.PostAsync<createAntiAffinityRule, ResponseType>(
                        ApiUris.CreateMcp2AntiAffinityRule(_apiClient.OrganizationId), antiAffinityRule);
        }

        /// <summary>
        /// Delete Anti-Affinity rule
        /// </summary>
        /// <param name="id">Id of the rule to be deleted</param>
        /// <returns></returns>
        public async Task<ResponseType> DeleteAntiAffinityRule(IdType id)
        {
            return
                await
                    _apiClient.PostAsync<IdType, ResponseType>(
                        ApiUris.DeleteMcp2AntiAffinityRule(_apiClient.OrganizationId), id);
        }

        /// <summary>The add scsi controller.</summary>
        /// <param name="addScsiController">The add scsi controller.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> AddScsiController(AddScsiControllerType addScsiController)
        {
            return await _apiClient.PostAsync<AddScsiControllerType, ResponseType>(ApiUris.AddScsiController(_apiClient.OrganizationId), addScsiController);
        }

        /// <summary>The remove scsi controller.</summary>
        /// <param name="removeScsiControllerId">The remove scsi controller id.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> RemoveScsiController(RemoveScsiControllerIdType removeScsiControllerId)
        {
            return await _apiClient.PostAsync<RemoveScsiControllerIdType, ResponseType>(ApiUris.RemoveScsiController(_apiClient.OrganizationId), removeScsiControllerId);
        }

        /// <summary>The remove ISO file.</summary>
        /// <param name="id">The Id of device.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> RemoveIsoFile(IdType id)
        {
            return await _apiClient.PostAsync<IdType, ResponseType>(ApiUris.RemoveIsoFile(_apiClient.OrganizationId), id);
        }
        
        /// <summary>The remove Flp file.</summary>
        /// <param name="id">The id of floppy.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> RemoveFlpFile(IdType id)
        {
            return await _apiClient.PostAsync<IdType, ResponseType>(ApiUris.RemoveFlpFile(_apiClient.OrganizationId), id);
        }

		/// <summary>
		/// Set Nic Connectivity
		/// </summary>
		/// <param name="setNicConnectivityType">Nic Connectivity Type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> SetNicConnectivity(SetNicConnectivityType setNicConnectivityType)
		{
			return await _apiClient.PostAsync<SetNicConnectivityType, ResponseType>(ApiUris.SetNicConnectivity(_apiClient.OrganizationId), setNicConnectivityType);
		}


        /// <summary>Set or unset scripts to be run before and/or after a Server Snapshot is taken.</summary>
        /// <param name="editSnapshotServiceScriptsType">Edit Snapshot Service Scripts Type.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        public async Task<ResponseType> EditSnapshotServiceScripts(EditSnapshotServiceScriptsType editSnapshotServiceScriptsType)
        {
            return await _apiClient.PostAsync<EditSnapshotServiceScriptsType, ResponseType>(ApiUris.EditSnapshotServiceScripts(_apiClient.OrganizationId), editSnapshotServiceScriptsType);
        }

        /// <summary>
        /// Enable snapshot service
        /// </summary>
        /// <param name="enableSnapshotServiceType">Enable Snapshot Service Type.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        public async Task<ResponseType> EnableSnapshotService(EnableSnapshotServiceType enableSnapshotServiceType)
		{
			return await _apiClient.PostAsync<EnableSnapshotServiceType, ResponseType>(ApiUris.EnableSnapshotService(_apiClient.OrganizationId), enableSnapshotServiceType);
		}

		/// <summary>
		/// Change snapshot service plan
		/// </summary>
		/// <param name="changeSnapshotServicePlanType">Change Snapshot Service Plan Type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> ChangeSnapshotServicePlan(ChangeSnapshotServicePlanType changeSnapshotServicePlanType)
		{
			return await _apiClient.PostAsync<ChangeSnapshotServicePlanType, ResponseType>(ApiUris.ChangeSnapshotServicePlan(_apiClient.OrganizationId), changeSnapshotServicePlanType);
		}

		/// <summary>
		/// Edit Snapshot Metadata
		/// </summary>
		/// <param name="editSnapshotMetadataType">Edit Snapshot Metadata Type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> EditSnapshotMetadata(EditSnapshotMetadataType editSnapshotMetadataType)
		{
			return await _apiClient.PostAsync<EditSnapshotMetadataType, ResponseType>(ApiUris.EditSnapshotMetadata(_apiClient.OrganizationId), editSnapshotMetadataType);
		}

		/// <summary>
		/// Disable snapshot service
		/// </summary>
		/// <param name="disableSnapshotServiceTypeType">Server Id to disable the snapshot service.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> DisableSnapshotService(DisableSnapshotServiceType disableSnapshotServiceTypeType)
		{
			return await _apiClient.PostAsync<DisableSnapshotServiceType, ResponseType>(ApiUris.DisableSnapshotService(_apiClient.OrganizationId), disableSnapshotServiceTypeType);
		}

        /// <summary>
		/// Disable snapshot replication
		/// </summary>
		/// <param name="disableReplicationType">Server Id to disable the snapshot replication.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> DisableServerSnapshotReplication(DisableReplicationType disableReplicationType)
        {
            return await _apiClient.PostAsync<DisableReplicationType, ResponseType>(ApiUris.DisableServerSnapshotReplication(_apiClient.OrganizationId), disableReplicationType);
        }

        /// <summary>
        /// Restore From Snapshot.
        /// </summary>
        /// <param name="restoreFromSnapshotType">Restore a file or folder from snapshot.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        public async Task<ResponseType> RestoreFromSnapshot(RestoreFromSnapshotType restoreFromSnapshotType)
		{
			return await _apiClient.PostAsync<RestoreFromSnapshotType, ResponseType>(ApiUris.RestoreFromSnapshot(_apiClient.OrganizationId), restoreFromSnapshotType);
		}

		/// <summary>
		/// Initiate manual snapshot
		/// </summary>
		/// <param name="initiateManualSnapshotType">Server Id and description to initiate manual snapshot.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> InitiateManualSnapshot(InitiateManualSnapshotType initiateManualSnapshotType)
	    {
			return await _apiClient.PostAsync<InitiateManualSnapshotType, ResponseType>(ApiUris.InitiateManualSnapshot(_apiClient.OrganizationId), initiateManualSnapshotType);
		}

		/// <summary>
		/// Delete manual snapshot
		/// </summary>
		/// <param name="id">Snapshot Id to delete manual snapshot.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> DeleteManualSnapshot(DeleteManualSnapshotType id)
		{
			return await _apiClient.PostAsync<DeleteManualSnapshotType, ResponseType>(ApiUris.DeleteManualSnapshot(_apiClient.OrganizationId), id);
		}

        /// <summary>The change disk iops.</summary>
        /// <param name="diskIops">The change disk iops.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> ChangeDiskIops(ChangeDiskIopsType diskIops)
        {
            return await _apiClient.PostAsync<ChangeDiskIopsType, ResponseType>(ApiUris.ChangeDiskIops(_apiClient.OrganizationId), diskIops);
        }
        
        /// <summary>The change disk size.</summary>
        /// <param name="changeDisk">The change disk size.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> ExpandDiskSize(ExpandDiskType changeDisk)
        {
            return await _apiClient.PostAsync<ExpandDiskType, ResponseType>(ApiUris.ExpandDiskSize(_apiClient.OrganizationId), changeDisk);
        }
        
        /// <summary>The change disk speed and iops.</summary>
        /// <param name="changeDiskSpeed">The change disk speed.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> ChangeDiskSpeed(ChangeDiskSpeedType changeDiskSpeed)
        {
            return await _apiClient.PostAsync<ChangeDiskSpeedType, ResponseType>(ApiUris.ChangeDikSpeed(_apiClient.OrganizationId), changeDiskSpeed);
        }

		/// <summary>
		/// Enable snapshot replication.
		/// </summary>
		/// <param name="enableReplication">Server Id and datacenter id to initiate manual snapshot.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> EnableSnapshotReplication(EnableReplicationType enableReplication)
		{
			return await _apiClient.PostAsync<EnableReplicationType, ResponseType>(ApiUris.EnableSnapshotReplication(_apiClient.OrganizationId), enableReplication);
		}

		/// <summary>
		/// Create Drs Target Server.
		/// </summary>
		/// <param name="createDrsTargetServer">Drs Target Server details</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		public async Task<ResponseType> CreateDrsTargetServer(CreateDrsTargetServerType createDrsTargetServer)
		{
			return await _apiClient.PostAsync<CreateDrsTargetServerType, ResponseType>(ApiUris.CreateDrsTargetServer(_apiClient.OrganizationId), createDrsTargetServer);
		}
	}
}