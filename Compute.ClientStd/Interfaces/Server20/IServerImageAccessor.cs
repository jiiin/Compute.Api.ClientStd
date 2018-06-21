namespace DD.CBU.Compute.Api.Client.Interfaces.Server20
{
    using System.Threading.Tasks; 
    using System;

    using DD.CBU.Compute.Api.Contracts.Image20;
    using DD.CBU.Compute.Api.Contracts.Network20;
    using DD.CBU.Compute.Api.Contracts.Requests.Server20;
    using DD.CBU.Compute.Api.Contracts.General;
    using DD.CBU.Compute.Api.Contracts.Requests;

    /// <summary>
    /// The ServerAccessor interface.
    /// </summary>
    public interface IServerImageAccessor
    {          
        /// <summary>
        /// Get the OS images supported on this data center
        /// </summary>
        /// <param name="imageId">
        /// The image Id
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>	
        Task<OsImageType> GetOsImage(Guid imageId);

        /// <summary>
        /// The get OS images supported on this data center
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
        Task<PagedResponse<OsImageType>> GetOsImages(ServerOsImageListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

        /// <summary>
        /// Get the customer images supported on this data center
        /// </summary>
        /// <param name="imageId">
        /// The image Id
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>	
        Task<CustomerImageType> GetCustomerImage(Guid imageId);

        /// <summary>
        /// The get customer images supported on this data center
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
        Task<PagedResponse<CustomerImageType>> GetCustomerImages(ServerCustomerImageListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

        /// <summary>
        /// Edit the customer image metadata
        /// </summary>
        /// <param name="editImageMetadata">
        /// The edit image metadata
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>	
        Task<ResponseType> EditCustomerImageMetadata(EditImageMetadataType editImageMetadata);

        /// <summary>
		/// The import MCP 2.0 customer image to a user-manageable Cluster in a Data Center location.
		/// </summary>
		/// <param name="importImage">
		/// The import image model.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
        Task<ResponseType> ImportCustomerImage(ImportImageType importImage);

        /// <summary>
        /// The export MCP 2.0 customer image.
        /// </summary>
        /// <param name="exportImage">
        /// The export image model.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ResponseType> ExportCustomerImage(ExportImageType exportImage);

        /// <summary>
        /// This API call lists all OVF packages in the FTPS account of the calling organization.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ovfPackages> GetOvfPackage();

        /// <summary>
        /// Get the status of Customer Image Exports that a particular ogranization has  in progress
        /// </summary>
        /// <param name="filteringOptions">Filtering options</param>
        /// <param name="pagingOptions">Paging options</param>
        /// <returns>Customer Image with Exports in progress status</returns>
        Task<PagedResponse<ImageExportInProgressType>> GetCustomerImageExportsInProgress(
            CustomerImageExportInProgressOptions filteringOptions, IPageableRequest pagingOptions);

		/// <summary>
		/// Get the customer images export history.
		/// </summary>
		/// <param name="filteringOptions">Filtering options</param>
		/// <param name="pagingOptions">Paging options</param>
		/// <returns>Customer Image with Exports in progress status</returns>
		Task<PagedResponse<HistoricalImageExportType>> GetCustomerImagesExportHistory(
			CustomerImageExportHistoryOptions filteringOptions, IPageableRequest pagingOptions);

        /// <summary>The move customer image to cluster.</summary>
        /// <param name="moveCustomerImage">The move customer image.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<ResponseType> MoveCustomerImage(MoveCustomerImageType moveCustomerImage);

	    /// <summary>
	    /// The copy MCP 2.0 customer image.
	    /// </summary>
	    /// <param name="copyImage">
	    /// The copy image model.
	    /// </param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    Task<ResponseType> CopyCustomerImage(CopyImageType copyImage);

    }
}
