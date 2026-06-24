namespace EleWise.ELMA.CRM.Constans;

public class CRMPermissionConstants
{
	public static class Tables
	{
		public static class Fields
		{
			public const string Id = "Id";

			public const string Uid = "Uid";

			public const string PermissionId = "PermissionId";

			public const string User = "User";

			public const string Group = "Group";

			public const string OrganizationItemPosition = "OrganizationItemPosition";

			public const string UserSecuritySetCacheId = "UserSecuritySetCacheId";

			public const string PermissionRole = "PermissionRole";

			public const string OrganizationItemEmployee = "OrganizationItemEmployee";

			public const string Contractor = "Contractor";

			public const string InheritedFromNumber = "InheritedFromNumber";

			public const string Contact = "Contact";

			public const string Sale = "Sale";

			public const string Lead = "Lead";

			public const string Inpayment = "Inpayment";

			public const string Relationship = "Relationship";
		}

		public const string TableNameContractor = "ContractorPersonPermTmp";

		public const string TableNameContact = "ContactPersonPermTmp";

		public const string TableNameCheckContractorCategTmp = "CheckContractorCategTmp";

		public const string TableNameSale = "SalePersonPermissionTmp";

		public const string TableNameLead = "LeadPersonPermissionTmp";

		public const string TableNameRelationship = "RelationshipPersPermTmp";
	}

	public const string Region = "CRMPermission";

	public const string LockNameReroutePermission = "A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E";

	public const string LastRecalculatePermissionError = "34839AAF-916F-4FEF-917D-21EA38656268";

	public const string CacheTimestamp = "LockNameReroutePermissionTimestamp";
}
