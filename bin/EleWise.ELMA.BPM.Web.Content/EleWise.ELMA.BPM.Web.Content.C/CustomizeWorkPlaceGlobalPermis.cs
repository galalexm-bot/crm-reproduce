using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class CustomizeWorkPlaceGlobalPermissionsDelegate : IGlobalPermissionsDelegate
{
	public ISecurityService SecurityService => Locator.GetService<ISecurityService>();

	public bool HasPermission(EleWise.ELMA.Security.IUser user, Permission permission, IEnumerable<Guid> userPermissionUids)
	{
		if (permission == null || permission.Id != EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission.Id || !WorkPlaceExtensions.CustomizerEnabled)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser user2 = (WorkPlaceExtensions.CustomizatorId.HasValue ? UserManager.Instance.LoadOrNull(WorkPlaceExtensions.CustomizatorId.Value) : null);
		if (user2 != null)
		{
			return SecurityService.HasPermission(user2, permission);
		}
		return false;
	}
}
