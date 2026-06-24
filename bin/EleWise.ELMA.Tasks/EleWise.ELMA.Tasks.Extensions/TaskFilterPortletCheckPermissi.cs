using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Extensions;

[Component(Order = 300)]
public class TaskFilterPortletCheckPermissionExtensions : IFilterPortletCheckPermission
{
	public bool AvailablePermissionType(Guid TypeUid)
	{
		return TypeUid == InterfaceActivator.UID<ITaskBase>();
	}

	public bool HasPermission(Guid TypeUid)
	{
		return Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.TasksAccessPermission);
	}
}
