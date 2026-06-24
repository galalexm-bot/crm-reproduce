using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Common.Security;

[Component]
public class FilterInstanceSettingsPermission : InstanceSettingsPermissionBase<IFilter, IFilterPermission>
{
	public override Permission AdminPermission => PermissionProvider.FullAccessToAllFiltersPermission;

	public FilterInstanceSettingsPermission()
		: base((Expression<Func<IFilterPermission, IFilter>>)((IFilterPermission access) => access.Filter))
	{
	}

	protected override ICollection<IFilterPermission> GetPermissionHolderCollection(IFilter target)
	{
		return (ICollection<IFilterPermission>)target.Permissions;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		IFilter permissionSubject = (IFilter)target;
		return base.SecurityService.HasPermission(user, PermissionProvider.FilterFullAccessPermission, permissionSubject);
	}
}
