﻿namespace DD.CBU.Compute.Api.ClientStd.Interfaces.Network20
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DD.CBU.Compute.Api.ContractsStd.General;
    using DD.CBU.Compute.Api.ContractsStd.Network20;
    using DD.CBU.Compute.Api.ContractsStd.Requests;
    using DD.CBU.Compute.Api.ContractsStd.Requests.Network20;

    /// <summary>
    /// The VlanAccessor interface.
    /// </summary>
    public interface IVlanSecurityGroupAccessor
    {        		
		/// <summary>
		/// Create Security Group
		/// </summary>
		/// <param name="securityGroup">Details regarding the security group</param>
		/// <returns>Response Data</returns>
		Task<ResponseType> CreateSecurityGroup(createSecurityGroup securityGroup);

        /// <summary>
		/// Edit Security Group
		/// </summary>
		/// <param name="securityGroup">Details regarding the security group</param>
		/// <returns>Response Data</returns>
		Task<ResponseType> EditSecurityGroup(editSecurityGroup securityGroup);


        /// <summary>
        /// Delete Security Group
        /// </summary>
        /// <param name="securityGroup">Details regarding the security group</param>
        /// <returns>Response Data</returns>
        Task<ResponseType> DeleteSecurityGroup(DeleteSecurityGroup securityGroup);

        /// <summary>
        /// Get the list of security groups associated with either the server or the vlan
        /// </summary>
        /// <param name="vlanId">Security group associated with the vlan</param>
        /// <param name="serverId">Groups associated with the Nics on the server, only provide wither vlan or serverid</param>
        /// <param name="pagingOptions">Paging options</param>
        /// <param name="filterOptions">Filter Options</param>
        /// <returns></returns>
        Task<PagedResponse<SecurityGroupType>> GetSecurityGroupsPaged(Guid? vlanId, Guid? serverId, PageableRequest pagingOptions = null, SecurityGroupListOptions filterOptions = null);

	    /// <summary>
	    /// List Security groups.
	    /// </summary>
	    /// <param name="pagingOptions">Paging options</param>
	    /// <param name="filterOptions">Filter options</param>
	    /// <returns>List of Security groups</returns>
	    Task<PagedResponse<SecurityGroupType>> GetSecurityGroupsPaginated(PageableRequest pagingOptions = null,
		    SecurityGroupListOptions filterOptions = null);

		/// <summary>
		/// Add Nic to Security Group
		/// </summary>
		/// <param name="nicSecurityGroup">Details regarding the security group and the nic</param>
		/// <returns>Response Data</returns>
		Task<ResponseType> AddNicToSecurityGroup(addNicToSecurityGroup nicSecurityGroup);

        /// <summary>
        /// Remove Nic from Security Group
        /// </summary>
        /// <param name="nicSecurityGroup">Details regarding the security group and the nic</param>
        /// <returns>Response Data</returns>
        Task<ResponseType> RemoveNicFromSecurityGroup(removeNicFromSecurityGroup nicSecurityGroup);

	    /// <summary>
	    /// Add server to the security group
	    /// </summary>
	    /// <param name="serverSecurityGroup">Security group and server details</param>
	    /// <returns>Response Data</returns>
	    Task<ResponseType> AddServerToSecurityGroup(addServerToSecurityGroup serverSecurityGroup);

	    /// <summary>
	    /// Remove server from security group
	    /// </summary>
	    /// <param name="serverSecurityGroup">Security group and server details</param>
	    /// <returns>Response Data</returns>
	    Task<ResponseType> RemoveServerFromSecurityGroup(removeServerFromSecurityGroup serverSecurityGroup);
    }
}