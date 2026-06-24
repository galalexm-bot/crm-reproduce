using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Deploy.Import;

[Component]
public class DmsObjectDefaultPermissionsSkipResolver : BaseSkipEntityImportResolver
{
	public override bool IsSupported(Guid typeGuid)
	{
		if (!(typeGuid == InterfaceActivator.UID<IDmsObjectDefaultPermissions>()))
		{
			return typeGuid == InterfaceActivator.UID<IDmsObjectDefaultPermissions>(loadImplementation: false);
		}
		return true;
	}

	public override bool IsSkip(Dictionary<string, object> propValues, Dictionary<string, string> serviceData)
	{
		IUser user = null;
		Guid id = GetId(propValues, "User");
		if (id != Guid.Empty)
		{
			user = UserManager.Instance.LoadOrNull(id);
		}
		if (user != null && !user.IsNew())
		{
			return false;
		}
		IUserGroup userGroup = null;
		Guid id2 = GetId(propValues, "Group");
		if (id2 != Guid.Empty)
		{
			userGroup = UserGroupManager.Instance.LoadOrNull(id2);
		}
		if (userGroup != null)
		{
			return false;
		}
		IOrganizationItem organizationItem = null;
		Guid id3 = GetId(propValues, "OrganizationItemPosition");
		if (id3 != Guid.Empty)
		{
			organizationItem = OrganizationItemManager.Instance.LoadOrNull(id3);
		}
		if (organizationItem != null)
		{
			return false;
		}
		IOrganizationItem organizationItem2 = null;
		Guid id4 = GetId(propValues, "OrganizationItemEmployee");
		if (id4 != Guid.Empty)
		{
			organizationItem2 = OrganizationItemManager.Instance.LoadOrNull(id4);
		}
		return organizationItem2 == null;
	}
}
