using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar;

[Component]
public class ScheduleRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType[] roleTypes = new PermissionRoleType[4] { organizationItem, group, user, author };
		return new PermissionRoleTypeStereotype[3]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISchedule>(), PermissionProvider.ScheduleViewPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISchedule>(), PermissionProvider.ScheduleEditPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISchedule>(), PermissionProvider.ScheduleFullPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
