namespace DD.CBU.Compute.Api.ContractsStd.Directory
{
	/// <summary>
	///		Provides read-only access to information about a role in the CaaS API.
	/// </summary>
	public interface IRole
	{
		/// <summary>
		///		The name of the CaaS role.
		/// </summary>
		string Name
		{
			get;
		}
	}
}
