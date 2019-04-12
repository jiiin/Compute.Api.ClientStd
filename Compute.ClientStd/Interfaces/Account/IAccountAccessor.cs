using DD.CBU.Compute.Api.Contracts.Network20;
using DD.CBU.Compute.Api.Contracts.Requests.Account20;

namespace DD.CBU.Compute.Api.Client.Interfaces.Account
{
    using System;
    using System.Collections.Generic;
	using System.Threading.Tasks;

	using DD.CBU.Compute.Api.Contracts.Datacenter;
	using DD.CBU.Compute.Api.Contracts.Directory;
	using DD.CBU.Compute.Api.Contracts.General;
    using DD.CBU.Compute.Api.Contracts.Organization;
    using DD.CBU.Compute.Api.Contracts.Requests;
    using DD.CBU.Compute.Api.Contracts.Software;

	/// <summary>
	/// The AccountAccessor interface.
	/// </summary>
	public interface IAccountAccessor
	{
        /// <summary>
        /// The get accounts.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Obsolete("This method is obsolete; use 'GetUsersPaginated' instead")]
        Task<IEnumerable<Account>> GetAccounts();

        /// <summary>
		/// The get accounts with phone number.
		/// </summary>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		[Obsolete("This method is obsolete; use 'GetUsersPaginated' instead")]
        Task<IEnumerable<AccountWithPhoneNumber>> GetAccountsWithPhoneNumber();

        /// <summary>
        /// The get administrator account.
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Obsolete("This method is obsolete; use 'GetUser' instead")]
        Task<AccountWithPhoneNumber> GetAdministratorAccount(string username);

		/// <summary>
		/// The add sub administrator account.
		/// </summary>
		/// <param name="account">
		/// The account.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<Status> AddSubAdministratorAccount(AccountWithPhoneNumber account);

		/// <summary>
		/// The delete sub administrator account.
		/// </summary>
		/// <param name="username">
		/// The username.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<Status> DeleteSubAdministratorAccount(string username);

	    /// <summary>
	    /// The update administrator password.
	    /// </summary>
	    /// <param name="userName">The User Name</param>
	    /// <param name="password">The Password</param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    Task<Status> ChangePassword(string userName, string password);

	    /// <summary>
	    /// The update administrator phone number.
	    /// </summary>
	    /// <param name="userName">The User Name</param>
	    /// <param name="phoneCountryCode">The Phone Country Code</param>
	    /// <param name="phoneNumber">The Phone Number</param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    Task<Status> UpdateAdministratorPhoneNumber(string userName, string phoneCountryCode, string phoneNumber);

        /// <summary>
        /// The update administrator account.
        /// </summary>
        /// <param name="account">
        /// The account.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Status> UpdateAdministratorAccount(AccountWithPhoneNumber account);

		/// <summary>
		/// The get list of multi geography regions.
		/// </summary>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<IEnumerable<Geo>> GetListOfMultiGeographyRegions();
	
		/// <summary>
		/// The get list of software labels.
		/// </summary>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<IEnumerable<SoftwareLabel>> GetListOfSoftwareLabels();

        /// <summary>
        /// The get data centers with maintenance statuses.
        /// </summary>
        /// <param name="pagingOptions">
        /// The paging options.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<DatacenterWithMaintenanceStatusType>> GetDataCentersWithMaintenanceStatuses(IPageableRequest pagingOptions = null);

        /// <summary>
        /// The get data center with maintenance status.
        /// </summary>
        /// <param name="locationId">
        /// The identifier of the datacenter.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<DatacenterWithMaintenanceStatusType> GetDataCenterWithMaintenanceStatus(string locationId);

        /// <summary>
        /// The designate primary administrator account.
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Status> DesignatePrimaryAdministratorAccount(string username);

        /// <summary>
        /// The get two factor authentication status.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<TwoFactorAuthentication> GetTwoFactorAuthenticationStatus();
        
        /// <summary>The set two factor authentication status.</summary>
        /// <param name="status">The status.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Obsolete("Use SetTwoFactorAuthentication methods")]
        Task<Status> SetTwoFactorAuthenticationStatus(TwoFactorAuthentication status);

	    /// <summary>The set two factor authentication status.</summary>
	    /// <param name="status">The status.</param>
	    /// <returns>The <see cref="Task"/>.</returns>
	    Task<ResponseType> SetTwoFactorAuthentication(setTwoFactorAuthentication status);

        /// <summary>
        /// Get the list of accounts for current org using 2.x API.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<PagedResponse<UserType>> GetUsersPaginated(UserListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

        /// <summary>
        /// Get the account details for given user name using 2.x API.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<UserType> GetUser(string userName);

        /// <summary>
        /// Get the account details for current user using 2.x API.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<UserType> GetMyUser();


		/// <summary>
		/// Create User.
		/// </summary>
		/// <param name="user">
		/// user details.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<ResponseType> CreateUser(CreateUserType user);

		/// <summary>
		/// Edit User.
		/// </summary>
		/// <param name="user">
		/// user details.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<ResponseType> EditUser(EditUserType user);

		/// <summary>
		/// Delete User.
		/// </summary>
		/// <param name="user">
		/// user details.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<ResponseType> DeleteUser(DeleteUserType user);

		/// <summary>
		/// Set User Roles.
		/// </summary>
		/// <param name="userRoles">
		/// user roles.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<ResponseType> SetUserRoles(SetUserRolesType userRoles);

		/// <summary>
		/// Change Password.
		/// </summary>
		/// <param name="userPassword">
		/// user password.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<ResponseType> ChangeUserPassword(ChangeUserPasswordType userPassword);

		/// <summary>
		/// Get duo status.
		/// </summary>
		/// <param name="userName"></param>
		/// <returns></returns>
		Task<DuoStatusType> GetDuoStatus(string userName);
	}
}
