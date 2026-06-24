using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar;

[Component]
public class CalendarItemProvider : ICalendarItemProvider, ICrossingCalendarProvider, IUpdatePackageCalendarItemProvider, IModifyTimeCalendarItemProvider
{
	private readonly Guid _uid = new Guid("{7239C3D9-6FC1-49A5-BA24-72E3C85F3CDA}");

	private EleWise.ELMA.Security.Models.IUser CurrentUser => AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	public CalendarEventManager CalendarManager { get; set; }

	public ScheduleManager ScheduleManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	[NotNull]
	public IAuthenticationService AuthenticationService { get; set; }

	public Guid Uid => _uid;

	public bool External => false;

	public IEnumerable<Guid> TypeUids => new Guid[1] { InterfaceActivator.UID<ICalendarEvent>() };

	public Guid GetPackageTypeUid(Guid typeUid)
	{
		return (typeUid == InterfaceActivator.UID<ICalendarEvent>()) ? new Guid("585EACC4-1F8F-41A0-BD3F-0D4FD2A48627") : Guid.Empty;
	}

	public IEnumerable<Guid> GetTypeUids()
	{
		yield return InterfaceActivator.UID<ICalendarEvent>();
	}

	public IEntityFilter GetFilter(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		return GetFilterPrivate(schedules, startDate, endDate);
	}

	public ICalendarItem[] GetItems(Guid typeUid, long[] ids, ICollection<ISchedule> schedules)
	{
		return ((IEnumerable<ICalendarEvent>)CalendarManager.FindByIdArray(ids)).Select((Func<ICalendarEvent, ICalendarItem>)((ICalendarEvent t) => new CalendarEventItem(t, CurrentUser))).ToArray();
	}

	ICalendarItem[] IUpdatePackageCalendarItemProvider.GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		return GetItems(schedules, startDate, endDate).ToArray();
	}

	private ICalendarEventFilter GetFilterPrivate(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true)
	{
		InstanceOf<ICalendarEventFilter> instanceOf = new InstanceOf<ICalendarEventFilter>();
		instanceOf.New.DateRange = new DateTimeRange
		{
			From = startDate,
			To = endDate
		};
		instanceOf.New.Schedules = (ISet<ISchedule>)(object)new HashedSet<ISchedule>(schedules);
		instanceOf.New.DisableSecurity = !checkPermission;
		return instanceOf.New;
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(EleWise.ELMA.Security.Models.IUser user, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		return GetItems(ScheduleManager.GetUserSchedule(user), startDate, endDate, checkPermission, showExpired);
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(ISchedule schedule, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		return GetItems(new List<ISchedule> { schedule }, startDate, endDate, checkPermission, showExpired);
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		return ((IEnumerable<ICalendarEvent>)CalendarManager.Find(GetFilterPrivate(schedules, startDate, endDate, checkPermission), FetchOptions.All)).Select((Func<ICalendarEvent, ICalendarItem>)((ICalendarEvent t) => new CalendarEventItem(t, CurrentUser))).ToArray();
	}

	public ICollection<ICalendarPlannedItem> GetRePlannedItems(EleWise.ELMA.Security.Models.IUser user)
	{
		return new Collection<ICalendarPlannedItem>();
	}

	public ICollection<ICalendarPlannedItem> GetUnPlannedItems(EleWise.ELMA.Security.Models.IUser user)
	{
		return new Collection<ICalendarPlannedItem>();
	}

	public IDictionary<ISchedule, ICollection<ICalendarItem>> CrossingItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		startDate = startDate.AddSeconds(1.0);
		endDate = endDate.AddSeconds(-1.0);
		InstanceOf<ICalendarEventFilter> instanceOf = new InstanceOf<ICalendarEventFilter>();
		instanceOf.New.DateRange = new DateTimeRange
		{
			From = startDate,
			To = endDate
		};
		instanceOf.New.Schedules = (ISet<ISchedule>)(object)new HashedSet<ISchedule>(schedules);
		ICalendarEventFilter filter = instanceOf.New;
		List<ICalendarEvent> list = new List<ICalendarEvent>();
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			list = CalendarManager.Find(filter, FetchOptions.All).ToList();
		});
		Dictionary<ISchedule, ICollection<ICalendarItem>> source = ((IEnumerable<ISchedule>)schedules).ToDictionary((Func<ISchedule, ISchedule>)((ISchedule schedule) => schedule), (Func<ISchedule, ICollection<ICalendarItem>>)delegate(ISchedule schedule)
		{
			bool hasPermission = SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, schedule);
			return (from e in list
				where (from eu in (IEnumerable<ICalendarEventUser>)e.EventUsers
					where eu.Status == CalendarEventUserStatus.Participant
					select eu.User).Contains(schedule.Owner) || ((ICollection<ISchedule>)e.Schedules).Contains(schedule)
				select new CalendarEventItem(e, CurrentUser)
				{
					OnlyInfo = (!hasPermission && !SecurityService.HasPermission(PermissionProvider.ViewEventPermission, e))
				}).Cast<ICalendarItem>().ToList();
		});
		return source.Where((KeyValuePair<ISchedule, ICollection<ICalendarItem>> s) => s.Value.Any()).ToDictionary((KeyValuePair<ISchedule, ICollection<ICalendarItem>> s) => s.Key, (KeyValuePair<ISchedule, ICollection<ICalendarItem>> s) => s.Value);
	}

	public ICalendarItem AddItem(EleWise.ELMA.Security.Models.IUser user, string id, DateTime startDate, DateTime endDate, bool removeOther)
	{
		return null;
	}

	public ICalendarItem ModifyTime(string id, int dayDelta, int minuteDelta, bool moved)
	{
		ICalendarEvent calendarEvent = CheckEvent(id);
		DateTime startDate = (moved ? calendarEvent.StartDate.AddDays(dayDelta).AddMinutes(minuteDelta) : calendarEvent.StartDate);
		DateTime endDate = calendarEvent.EndDate.AddDays(dayDelta).AddMinutes(minuteDelta);
		CalendarManager.ChangeTime(calendarEvent, startDate, endDate, null);
		return new CalendarEventItem(calendarEvent, CurrentUser);
	}

	public ICalendarItem ModifyTime(string id, DateTime startDate, DateTime endDate)
	{
		ICalendarEvent @event = CheckEvent(id);
		CalendarManager.ChangeTime(@event, startDate, endDate, null);
		return new CalendarEventItem(@event, CurrentUser);
	}

	private ICalendarEvent CheckEvent(string id)
	{
		ICalendarEvent evnt = null;
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			evnt = CalendarManager.LoadOrNull(long.Parse(id));
		});
		if (evnt == null)
		{
			throw new Exception(SR.T("Не найдено событие"));
		}
		if (!CalendarManager.CanEdit(evnt))
		{
			throw new Exception(SR.T("Событие закрыто или нет доступа на изменение"));
		}
		return evnt;
	}

	public void Remove(string id)
	{
		ICalendarEvent evnt = null;
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			evnt = CalendarManager.LoadOrNull(long.Parse(id));
		});
		if (evnt == null)
		{
			throw new Exception(SR.T("Не найдено событие"));
		}
		if (!CalendarManager.CanDeleteEvent(evnt, all: false))
		{
			throw new Exception(SR.T("Событие закрыто или нет доступа на изменение"));
		}
		CalendarManager.DeleteEvent(evnt, all: false);
	}

	public void FillData(Guid typeUid, long id, ICollection<EleWise.ELMA.Security.Models.IUser> owners, ICollection<ISchedule> schedules)
	{
		ICalendarEvent calendarEvent = EntityManager<ICalendarEvent>.Instance.Load(id);
		foreach (ICalendarEventUser item in (IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers)
		{
			owners.Add(item.User);
		}
		foreach (ISchedule item2 in (IEnumerable<ISchedule>)calendarEvent.Schedules)
		{
			schedules.Add(item2);
		}
	}
}
