using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.BPM.Web.Common.Security;

[Component]
public class PropertyInstanceSettingsPermission : InstanceSettingsPermissionBase<IPropertyProfile, IPropertyAccess>
{
	public PropertyInstanceSettingsPermission()
		: base((Expression<Func<IPropertyAccess, IPropertyProfile>>)((IPropertyAccess access) => access.PropertyProfile))
	{
	}

	protected override ICollection<IPropertyAccess> GetPermissionHolderCollection(IPropertyProfile target)
	{
		return (ICollection<IPropertyAccess>)target.Permission;
	}
}
