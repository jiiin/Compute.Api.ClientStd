using System;

namespace DD.CBU.Compute.Api.Contracts.Directory
{
    /// <summary>
    ///		Provides read-only access to information about a CaaS account.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        ///		The user login name associated with the account.
        /// </summary>
        string UserName { get; }

        /// <summary>
        ///		The full name of the user associated with the account.
        /// </summary>
        string FullName { get; }

        /// <summary>
        ///		The first name of the user associated with the account.
        /// </summary>
        string FirstName { get; }

        /// <summary>
        ///		The last name of the user associated with the account.
        /// </summary>
        string LastName { get; }

        /// <summary>
        ///		The e-mail address of the user associated with the account.
        /// </summary>
        string EmailAddress { get; }

        /// <summary>
        ///		Roles (if any) to which the account belongs.
        /// </summary>
        string[] Roles { get; }

        /// <summary>
        ///		The Phone number and contry code.
        /// </summary>
        PhoneType Phone { get; }

        /// <summary>
        ///		The name of the department to which the account's user belongs.
        /// </summary>
        string Department { get; }

        /// <summary>
        ///		Custom field 1.
        /// </summary>
        string CustomDefined1 { get; }

        /// <summary>
        ///		Custom field 2.
        /// </summary>
        string CustomDefined2 { get; }

        /// <summary>
        ///		The organisation to which the account belongs.
        /// </summary>
        UserTypeOrganization Organization { get; }

        /// <summary>
        /// The Organization id for the account
        /// </summary>
        Guid OrganizationId { get; }

        /// <summary>
        /// The State of the account.
        /// </summary>
        string State { get; }
    }
}
