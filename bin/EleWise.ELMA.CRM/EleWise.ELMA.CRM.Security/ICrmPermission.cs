using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Security;

public interface ICrmPermission
{
	IUser User { get; set; }

	bool CanRead { get; set; }

	bool CanEdit { get; set; }

	bool FullAccess { get; set; }

	ICategory Category { get; set; }

	IUserGroup UserGroup { get; set; }

	IOrganizationItem OrganizationItem { get; set; }
}
