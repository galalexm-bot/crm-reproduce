using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar;

[Component]
internal class CalendarInstancePermissionDelegate : IPermissionsDelegate
{
	public ISecurityService SecurityService { get; set; }

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		return type != null && type.IsInheritOrSame<ICalendarEvent>() && (permission == PermissionProvider.ViewEventPermission || permission == PermissionProvider.EditEventPermission);
	}

	public bool HasPermission(EleWise.ELMA.Security.IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		if (target == null || permission == null)
		{
			return false;
		}
		if (!(target is ICalendarEvent calendarEvent))
		{
			return false;
		}
		if (calendarEvent.CreationAuthor != null && calendarEvent.CreationAuthor == user)
		{
			return true;
		}
		if (permission == PermissionProvider.EditEventPermission)
		{
			return false;
		}
		List<ISchedule> list = new List<ISchedule>();
		if (calendarEvent.Schedules != null && ((IEnumerable<ISchedule>)calendarEvent.Schedules).Any())
		{
			list.AddRange((IEnumerable<ISchedule>)calendarEvent.Schedules);
		}
		ScheduleManager instance = ScheduleManager.Instance;
		InstanceOf<IScheduleFilter> instanceOf = new InstanceOf<IScheduleFilter>();
		instanceOf.New.Owners = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>((ICollection<EleWise.ELMA.Security.Models.IUser>)(from eu in (IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers
			where eu.Status == CalendarEventUserStatus.Participant
			select eu.User).ToList());
		instanceOf.New.DisableSecurity = true;
		list.AddRange(instance.Find(instanceOf.New, FetchOptions.All));
		if (list.Any())
		{
			Permission schedulePermission = ((permission == PermissionProvider.ViewEventPermission) ? PermissionProvider.ScheduleViewPermission : PermissionProvider.ScheduleEditPermission);
			return list.All((ISchedule schedule) => SecurityService.HasPermission(schedulePermission, schedule));
		}
		return false;
	}
}
