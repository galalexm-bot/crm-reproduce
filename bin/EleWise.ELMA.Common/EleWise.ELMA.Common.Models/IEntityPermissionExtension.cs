using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.Models;

public interface IEntityPermissionExtension : IEntityPermission, IEntity<long>, IEntity, IIdentified, ISecuritySetIdHolder, IInstanceSettingsPermissionHolder
{
	IUser User { get; set; }

	IUserGroup Group { get; set; }

	IOrganizationItem OrganizationItemPosition { get; set; }

	IOrganizationItem OrganizationItem { get; set; }
}
