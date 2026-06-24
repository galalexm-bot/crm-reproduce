using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar;

[Component]
public class SheduleInstanceSettingsPermission : InstanceSettingsPermissionBase<ISchedule, ISchedulePermission>
{
	public SheduleInstanceSettingsPermission()
		: base((Expression<Func<ISchedulePermission, ISchedule>>)((ISchedulePermission access) => access.Schedule))
	{
	}

	protected override ICollection<ISchedulePermission> GetPermissionHolderCollection(ISchedule target)
	{
		return (ICollection<ISchedulePermission>)target.Permissions;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		if (!(target is ISchedule schedule))
		{
			return false;
		}
		return base.SecurityService.HasPermission(user, PermissionProvider.CalendarAccessPermission) || base.SecurityService.HasPermission(user, PermissionProvider.ScheduleFullPermission, schedule) || schedule.Owner == user;
	}
}
