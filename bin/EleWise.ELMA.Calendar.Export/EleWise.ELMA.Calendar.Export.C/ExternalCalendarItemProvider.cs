using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Calendar.Export.Managers;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Export.Security;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Export.Components;

[Component]
public class ExternalCalendarItemProvider : ICalendarItemProvider
{
	private static readonly Guid uid = new Guid("{CB91A552-A39B-45CB-A0A2-13155F9D48FC}");

	public ScheduleManager ScheduleManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	public ExternalCalendarManager ExternalCalendarManager { get; set; }

	public Guid Uid => uid;

	public bool External => true;

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(EleWise.ELMA.Security.Models.IUser user, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		return GetItems(ScheduleManager.GetUserSchedule(user), startDate, endDate, checkPermission, showExpired);
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(ISchedule schedule, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		return GetItems(new Collection<ISchedule> { schedule }, startDate, endDate, checkPermission, showExpired);
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		List<ICalendarItem> list = new List<ICalendarItem>();
		foreach (IExternalCalendar item in ExternalCalendarManager.FindCalendars(schedules, !checkPermission))
		{
			list.AddRange(ExternalCalendarManager.GetCalendarEvents(item, startDate, endDate));
		}
		return list;
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
		IEnumerable<IExternalCalendar> enumerable = ExternalCalendarManager.FindCalendars(schedules, disableSecurity: true);
		Dictionary<ISchedule, ICollection<ICalendarItem>> dictionary = new Dictionary<ISchedule, ICollection<ICalendarItem>>();
		foreach (IExternalCalendar item in enumerable)
		{
			if (item.Schedule == null)
			{
				continue;
			}
			IEnumerable<ExternalCalendarItem> calendarEvents = ExternalCalendarManager.GetCalendarEvents(item, startDate, endDate);
			if (calendarEvents.Any())
			{
				bool hasPermission = SecurityService.HasPermission(ExternalCalendarPermissionProvider.ViewCalendarPermission, item);
				IEnumerable<ICalendarItem> enumerable2 = calendarEvents.Select((Func<ExternalCalendarItem, ICalendarItem>)delegate(ExternalCalendarItem x)
				{
					x.OnlyInfo = !hasPermission;
					return x;
				});
				dictionary[item.Schedule] = (dictionary.ContainsKey(item.Schedule) ? dictionary[item.Schedule].Concat(enumerable2).ToList() : enumerable2.ToList());
			}
		}
		return dictionary;
	}

	public ICalendarItem AddItem(EleWise.ELMA.Security.Models.IUser user, string id, DateTime startDate, DateTime endDate, bool removeOther)
	{
		throw new NotSupportedException();
	}

	public ICalendarItem ModifyTime(string id, int dayDelta, int minuteDelta, bool moved)
	{
		throw new NotSupportedException();
	}

	public void Remove(string id)
	{
		throw new NotSupportedException();
	}
}
