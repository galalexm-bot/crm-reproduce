using System;

namespace EleWise.ELMA.Security.Models;

public interface IAbstractPropertyAccess
{
	IUser User { get; set; }

	IUserGroup Group { get; set; }

	IOrganizationItem OrganizationItemPosition { get; set; }

	IOrganizationItem OrganizationItem { get; set; }

	Guid? AssignedPropertyUid { get; set; }

	Guid? AssignedPropertyEntityUid { get; set; }

	Guid GetPropertyGuid();

	PropertyPermissionType GetPermissionType();
}
