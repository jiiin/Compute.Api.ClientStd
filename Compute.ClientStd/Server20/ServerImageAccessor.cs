
namespace DD.CBU.Compute.Api.Client.Server20
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DD.CBU.Compute.Api.Contracts.Image20;
    using DD.CBU.Compute.Api.Client.Interfaces;
    using DD.CBU.Compute.Api.Client.Interfaces.Server20;
    using DD.CBU.Compute.Api.Contracts.General;
    using DD.CBU.Compute.Api.Contracts.Network20;
    using DD.CBU.Compute.Api.Contracts.Requests;
    using DD.CBU.Compute.Api.Contracts.Requests.Server20;

    /// <summary>
    /// The server 2.0 image accessor.
    /// </summary>
    public class ServerImageAccessor : IServerImageAccessor
    {
        /// <summary>
        /// The _api client.
        /// </summary>
        private readonly IWebApi _apiClient;

        /// <summary>
        /// Initialises a new instance of the <see cref="ServerAccessor"/> class.
        /// </summary>
        /// <param name="apiClient">
        /// The api client.
        /// </param>
        public ServerImageAccessor(IWebApi apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// Get OS Image
        /// </summary>
        /// <param name="imageId">Image Identifier</param>
        /// <returns>OS Image</returns>
        public async Task<OsImageType> GetOsImage(Guid imageId)
        {
            return await _apiClient.GetAsync<OsImageType>(
              ApiUris.GetMcp2OsImage(_apiClient.OrganizationId, imageId));
        }

        /// <summary>
        /// Get OS Images
        /// </summary>
        /// <param name="filteringOptions">Filtering options</param>
        /// <param name="pagingOptions"></param>
        /// <returns>OS Images</returns>
        public async Task<PagedResponse<OsImageType>> GetOsImages(ServerOsImageListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<osImages>(
                 ApiUris.GetMcp2OsImages(_apiClient.OrganizationId),
                 pagingOptions,
                 filteringOptions);

            return new PagedResponse<OsImageType>
            {
                items = response.osImage,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }
      
        /// <summary>
        /// Get Customer Image
        /// </summary>
        /// <param name="imageId">Image Id</param>
        /// <returns>Customer Image</returns>
        public async Task<CustomerImageType> GetCustomerImage(Guid imageId)
        {
            return await _apiClient.GetAsync<CustomerImageType>(
            ApiUris.GetMcp2CustomerImage(_apiClient.OrganizationId, imageId));
        }

        /// <summary>
        /// Get Customer Images
        /// </summary>
        /// <param name="filteringOptions">Filtering options</param>
        /// <param name="pagingOptions">Paging options</param>
        /// <returns>Customer Images</returns>
        public async Task<PagedResponse<CustomerImageType>> GetCustomerImages(ServerCustomerImageListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<customerImages>(
                ApiUris.GetMcp2CustomerImages(_apiClient.OrganizationId),
                pagingOptions,
                filteringOptions);

            return new PagedResponse<CustomerImageType>
            {
                items = response.customerImage,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

        /// <summary>
        /// Edit Customer Image Metadata
        /// </summary>
        /// <param name="editImageMetadata">Edit Image Metadata</param>
        /// <returns>Response Data</returns>
        public async Task<ResponseType> EditCustomerImageMetadata(EditImageMetadataType editImageMetadata)
        {
            return await _apiClient.PostAsync<EditImageMetadataType, ResponseType>(
            ApiUris.EditMcp2CustomerImageMetadata(_apiClient.OrganizationId), editImageMetadata);  
        }

        /// <summary>
		/// The import MCP 2.0 customer image to a user-manageable Cluster in a Data Center location.
		/// </summary>
		/// <param name="importImage">
		/// The import image model.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		public async Task<ResponseType> ImportCustomerImage(ImportImageType importImage)
        {
            return
                await
                    _apiClient.PostAsync<ImportImageType, ResponseType>(
                        ApiUris.ImportMcp2CustomerImage(_apiClient.OrganizationId), importImage);
        }

        /// <summary>
        /// The export MCP 2.0 customer image.
        /// </summary>
        /// <param name="exportImage">
        /// The export image model.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<ResponseType> ExportCustomerImage(ExportImageType exportImage)
        {
            return
                await
                    _apiClient.PostAsync<ExportImageType, ResponseType>(
                        ApiUris.ExportMcp2CustomerImage(_apiClient.OrganizationId), exportImage);
        }

		/// <summary>
		/// The copy MCP 2.0 customer image.
		/// </summary>
		/// <param name="copyImage">
		/// The copy image model.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		public async Task<ResponseType> CopyCustomerImage(CopyImageType copyImage)
		{
			return
				await
					_apiClient.PostAsync<CopyImageType, ResponseType>(
						ApiUris.CopyCustomerImage(_apiClient.OrganizationId), copyImage);
		}

		/// <summary>
		/// This API call lists all OVF packages in the FTPS account of the calling organization.
		/// </summary>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		public async Task<ovfPackages> GetOvfPackage()
        {
            return
                await
                    _apiClient.GetAsync<ovfPackages>(
                        ApiUris.GetMcp2OvfPackage(_apiClient.OrganizationId));
        }

        /// <summary>
        /// Get the status of Customer Image Exports that a particular ogranization has  in progress
        /// </summary>
        /// <param name="filteringOptions">Filtering options</param>
        /// <param name="pagingOptions">Paging options</param>
        /// <returns>Customer Image with Exports in progress status</returns>
        public async Task<PagedResponse<ImageExportInProgressType>> GetCustomerImageExportsInProgress(CustomerImageExportInProgressOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<imageExportsInProgress>(
                ApiUris.GetMcp2CustomerImageExportsInProgress(_apiClient.OrganizationId),
                pagingOptions,
                filteringOptions);

            return new PagedResponse<ImageExportInProgressType>
            {
                items = response.imageExportInProgress,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }

		/// <summary>
		/// Get the customer images export history.
		/// </summary>
		/// <param name="filteringOptions">Filtering options</param>
		/// <param name="pagingOptions">Paging options</param>
		/// <returns>Customer Image with Exports in progress status</returns>
		public async Task<PagedResponse<HistoricalImageExportType>> GetCustomerImagesExportHistory(CustomerImageExportHistoryOptions filteringOptions = null, IPageableRequest pagingOptions = null)
		{
			var response = await _apiClient.GetAsync<historicalImageExports>(
				ApiUris.GetCustomerImageExportHistory(_apiClient.OrganizationId),
				pagingOptions,
				filteringOptions);

			return new PagedResponse<HistoricalImageExportType>
			{
				items = response.historicalImageExport,
				totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
				pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
				pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
				pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
			};
		}

        /// <summary>The move customer image to cluster.</summary>
        /// <param name="moveCustomerImage">The move customer image.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ResponseType> MoveCustomerImage(MoveCustomerImageType moveCustomerImage)
        {
            return await _apiClient.PostAsync<MoveCustomerImageType, ResponseType>(ApiUris.MoveCustomerImageToCluster(_apiClient.OrganizationId), moveCustomerImage);
        }
    }
}
