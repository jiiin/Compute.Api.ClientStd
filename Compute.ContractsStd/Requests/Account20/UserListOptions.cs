namespace DD.CBU.Compute.Api.Contracts.Requests.Account20
{
    /// <summary>
    /// Filtering options for the user request.
    /// </summary>
    public class UserListOptions : FilterableRequest
    {
        /// <summary>
        /// The "userName" field name.
        /// </summary>
        public const string UserNameField = "userName";

        /// <summary>
        /// The "fullName" field name.
        /// </summary>
        public const string FullNameField = "fullName";

        /// <summary>
        /// The "firstName" field name.
        /// </summary>
        public const string FirstNameField = "firstName";

        /// <summary>
        /// The "lastName" field name.
        /// </summary>
        public const string LastNameField = "lastName";

        /// <summary>
        /// The "emailAddress" field name.
        /// </summary>
        public const string EmailAddressField = "emailAddress";

        /// <summary>
        /// The "phoneCountryCode" field name.
        /// </summary>
        public const string PhoneCountryCodeField = "phoneCountryCode";

        /// <summary>
        /// The "phoneNumber" field name.
        /// </summary>
        public const string PhoneNumberField = "phoneNumber";

        /// <summary>
        /// The "state" field name.
        /// </summary>
        public const string StateField = "state";

        /// <summary>
        /// The "department" field name.
        /// </summary>
        public const string DepartmentField = "department";

        /// <summary>
        /// The "customDefined1" field name.
        /// </summary>
        public const string CustomDefined1Field = "customDefined1";

        /// <summary>
        /// The "customDefined1" field name.
        /// </summary>
        public const string CustomDefined2Field = "customDefined1";

        /// <summary>	
        /// Identifies an individual User name.
        /// </summary>
        public string UserName
        {
            get { return GetFilter<string>(UserNameField); }
            set { SetFilter(UserNameField, value); }
        }

        /// <summary>	
        /// Identifies an individual Full Name.
        /// </summary>
        public string FullName
        {
            get { return GetFilter<string>(FullNameField); }
            set { SetFilter(FullNameField, value); }
        }

        /// <summary>	
        /// Identifies an individual First Name.
        /// </summary>
        public string FirstName
        {
            get { return GetFilter<string>(FirstNameField); }
            set { SetFilter(FirstNameField, value); }
        }

        /// <summary>	
        /// Identifies an individual Last Name.
        /// </summary>
        public string LastName
        {
            get { return GetFilter<string>(LastNameField); }
            set { SetFilter(LastNameField, value); }
        }

        /// <summary>	
        /// Identifies an individual Email Address.
        /// </summary>
        public string EmailAddress
        {
            get { return GetFilter<string>(EmailAddressField); }
            set { SetFilter(EmailAddressField, value); }
        }

        /// <summary>	
        /// Identifies an individual Phone Country Code.
        /// </summary>
        public string PhoneCountryCode
        {
            get { return GetFilter<string>(PhoneCountryCodeField); }
            set { SetFilter(PhoneCountryCodeField, value); }
        }

        /// <summary>	
        /// Identifies an individual Phone Number.
        /// </summary>
        public string PhoneNumber
        {
            get { return GetFilter<string>(PhoneNumberField); }
            set { SetFilter(PhoneNumberField, value); }
        }

        /// <summary>	
        /// Identifies an individual State.
        /// </summary>
        public string State
        {
            get { return GetFilter<string>(StateField); }
            set { SetFilter(StateField, value); }
        }

        /// <summary>	
        /// Identifies an individual Department.
        /// </summary>
        public string Department
        {
            get { return GetFilter<string>(DepartmentField); }
            set { SetFilter(DepartmentField, value); }
        }

        /// <summary>	
        /// Identifies an individual Custom Defined1.
        /// </summary>
        public string CustomDefined1
        {
            get { return GetFilter<string>(CustomDefined1Field); }
            set { SetFilter(CustomDefined1Field, value); }
        }

        /// <summary>	
        /// Identifies an individual Custom Defined2.
        /// </summary>
        public string CustomDefined2
        {
            get { return GetFilter<string>(CustomDefined2Field); }
            set { SetFilter(CustomDefined1Field, value); }
        }
    }
}