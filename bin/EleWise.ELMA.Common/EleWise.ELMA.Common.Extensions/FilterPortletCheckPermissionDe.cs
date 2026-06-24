using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.Extensions;

[Component(Order = 1001)]
public class FilterPortletCheckPermissionDefaultExtensions : IFilterPortletCheckPermission
{
	public bool AvailablePermissionType(Guid TypeUid)
	{
		return true;
	}

	public bool HasPermission(Guid TypeUid)
	{
		return false;
	}
}
