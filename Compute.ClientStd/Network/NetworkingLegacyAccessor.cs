namespace DD.CBU.Compute.Api.ClientStd.Network
{
	using DD.CBU.Compute.Api.ClientStd.Interfaces;
	using DD.CBU.Compute.Api.ClientStd.Interfaces.Network;

	/// <summary>	A standard implementation of Network 2.0 access methods. </summary>
	public class NetworkingLegacyAccessor : INetworkingLegacyAccessor
	{	
		/// <summary>
		/// 	Initializes a new instance of the DD.CBU.Compute.Api.ClientStd.Network20.Networking
		/// 	class.
		/// </summary>
		/// <param name="apiClient">
		/// The api Client.
		/// </param>
		public NetworkingLegacyAccessor(IWebApi apiClient)
		{
			this.Network = new NetworkAccessor(apiClient);
			this.NetworkVip = new NetworkVipAccessor(apiClient);		
		}

		/// <summary>
		/// Gets the network.
		/// </summary>
		public INetworkAccessor Network { get; private set; }

		/// <summary>
		/// Gets the network vip.
		/// </summary>
		public INetworkVipAccessor NetworkVip { get; private set; }
	}
}
