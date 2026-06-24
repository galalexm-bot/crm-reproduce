using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class BaseEventManager<T> : EntityManager<T, long> where T : ICalendarEvent
{
	private T BaseLoad(long? id = null, Guid? uid = null, bool orNull = false)
	{
		if (id.HasValue)
		{
			return orNull ? base.LoadOrNull(id.Value) : base.Load(id.Value);
		}
		if (uid.HasValue)
		{
			return orNull ? base.LoadOrNull(uid.Value) : base.Load(uid.Value);
		}
		throw new ArgumentException(SR.T("Должен быть задан параметр id или uid"));
	}

	[PublicApiMember]
	public override T Load(long id)
	{
		try
		{
			return base.Load(id);
		}
		catch (SecurityException)
		{
			T calendarEvent = default(T);
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				calendarEvent = BaseLoad(id);
			});
			if (CanView(calendarEvent))
			{
				return calendarEvent;
			}
			throw;
		}
	}

	[PublicApiMember]
	public override T LoadOrNull(long id)
	{
		try
		{
			return base.LoadOrNull(id);
		}
		catch (SecurityException)
		{
			T calendarEvent = default(T);
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				calendarEvent = BaseLoad(id, null, orNull: true);
			});
			if (CanView(calendarEvent))
			{
				return calendarEvent;
			}
			throw;
		}
	}

	[PublicApiMember]
	public override T Load(Guid uid)
	{
		try
		{
			return base.Load(uid);
		}
		catch (SecurityException)
		{
			T calendarEvent = default(T);
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				calendarEvent = BaseLoad(null, uid);
			});
			if (CanView(calendarEvent))
			{
				return calendarEvent;
			}
			throw;
		}
	}

	[PublicApiMember]
	public override T LoadOrNull(Guid uid)
	{
		try
		{
			return base.LoadOrNull(uid);
		}
		catch (SecurityException)
		{
			T calendarEvent = default(T);
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				calendarEvent = BaseLoad(null, uid, orNull: true);
			});
			if (CanView(calendarEvent))
			{
				return calendarEvent;
			}
			throw;
		}
	}

	public virtual bool CanView(ICalendarEvent @event)
	{
		if (@event == null)
		{
			return false;
		}
		if (base.SecurityService.CanCheckPermission(PermissionProvider.ViewEventPermission, @event) && base.SecurityService.HasPermission(PermissionProvider.ViewEventPermission, @event))
		{
			return true;
		}
		List<ISchedule> list = new List<ISchedule>();
		if (@event.Schedules != null && ((IEnumerable<ISchedule>)@event.Schedules).Any())
		{
			list.AddRange((IEnumerable<ISchedule>)@event.Schedules);
		}
		ScheduleManager instance = ScheduleManager.Instance;
		InstanceOf<IScheduleFilter> instanceOf = new InstanceOf<IScheduleFilter>();
		instanceOf.New.Owners = (ISet<IUser>)(object)new HashedSet<IUser>((ICollection<IUser>)((IEnumerable<ICalendarEventUser>)@event.EventUsers).Select((ICalendarEventUser eu) => eu.User).ToList());
		instanceOf.New.DisableSecurity = true;
		list.AddRange(instance.Find(instanceOf.New, FetchOptions.All));
		if (base.SecurityService != null && list.Any())
		{
			return list.Any((ISchedule schedule) => base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, schedule) && base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, schedule));
		}
		return false;
	}
}
