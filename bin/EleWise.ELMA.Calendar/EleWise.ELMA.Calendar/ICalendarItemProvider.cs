using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ICalendarItemProvider
{
	Guid Uid { get; }

	bool External { get; }

	ICollection<ICalendarItem> GetItems(IUser user, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false);

	ICollection<ICalendarItem> GetItems(ISchedule schedule, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false);

	ICollection<ICalendarItem> GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false);

	ICollection<ICalendarPlannedItem> GetRePlannedItems(IUser user);

	ICollection<ICalendarPlannedItem> GetUnPlannedItems(IUser user);

	IDictionary<ISchedule, ICollection<ICalendarItem>> CrossingItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate);

	ICalendarItem AddItem(IUser user, string id, DateTime startDate, DateTime endDate, bool removeOther);

	ICalendarItem ModifyTime(string id, int dayDelta, int minuteDelta, bool moved);

	void Remove(string id);
}
