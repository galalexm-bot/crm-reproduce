using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.BPM.Web.Common.Security;

[Component]
public class InstanceSettingsPermission : InstanceSettingsPermissionBase<ICatalogProfile, ICatalogAccess>
{
	public InstanceSettingsPermission()
		: base((Expression<Func<ICatalogAccess, ICatalogProfile>>)((ICatalogAccess access) => access.CatalogProfile))
	{
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		return base.SecurityService.HasPermission(user, PermissionProvider.AccessManagmentPermission);
	}

	protected override ICollection<ICatalogAccess> GetPermissionHolderCollection(ICatalogProfile target)
	{
		return (ICollection<ICatalogAccess>)target.Permission;
	}
}
