namespace DD.CBU.Compute.Api.Client.Interfaces.Server20
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts.General;
    using Contracts.Requests;
    using Contracts.Requests.Snapshot;
    using Contracts.Snapshot;
    using Contracts.Network20;

    /// <summary>
    /// The ServerAccessor interface.
    /// </summary>
    public interface ISnapshotAccessor
    {
        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="serverId">The serve Id</param>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<IEnumerable<SnapshotType>> GetSnapshots(Guid serverId, SnapshotListOptions filteringOptions = null);

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="serverId">The serve Id</param>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<PagedResponse<SnapshotType>> GetSnapshotsPaginated(Guid serverId, SnapshotListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<PagedResponse<SnapshotType>> GetSnapshotsPaginated(SnapshotListOptions filteringOptions, IPageableRequest pagingOptions = null);

        /// <summary>The Create Snapshot Preview Server.</summary>
        /// <param name="request">The Create Snapshot Preview Server Request</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<ResponseType> CreateSnapshotPreviewServer(CreateSnapshotPreviewServerType request);

        /// <summary>The Migrate Snapshot Preview Server.</summary>
        /// <param name="request">The Migrate Snapshot Preview Server Request</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<ResponseType> MigrateSnapshotPreviewServer(MigrateSnapshotPreviewServerType request);

		/// <summary>The Create Snapshot Preview Server.</summary>
		/// <param name="request">The Create Replicated Snapshot Preview Server Request</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<ResponseType> CreateReplicatedSnapshotPreviewServer(CreateReplicatedSnapshotPreviewServerType request);
	}
}