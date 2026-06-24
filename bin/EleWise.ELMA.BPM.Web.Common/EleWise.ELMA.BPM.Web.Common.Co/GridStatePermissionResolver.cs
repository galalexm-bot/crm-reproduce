using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class GridStatePermissionResolver : IGridStatePermissionResolver
{
	public bool HasPermission(string gridId, Guid? provider = null)
	{
		return Locator.GetServiceNotNull<ISecurityService>().HasPermission(EleWise.ELMA.Common.PermissionProvider.ManageGridDefaultSettingsPermission);
	}
}
