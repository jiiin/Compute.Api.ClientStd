namespace DD.CBU.Compute.Api.ClientStd.Interfaces.Server
{
	/// <summary>
	/// The ServerManagementLegacyAccessor interface.
	/// </summary>
	public interface IServerManagementLegacyAccessor
	{
		/// <summary>
		/// Gets the server.
		/// </summary>
		IServerAccessor Server { get; }

		/// <summary>
		/// Gets the server image.
		/// </summary>
		IServerImagesAccessor ServerImage { get; }
	}
}
