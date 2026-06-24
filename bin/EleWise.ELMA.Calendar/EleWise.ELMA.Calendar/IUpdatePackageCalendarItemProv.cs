using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Calendar;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IUpdatePackageCalendarItemProvider
{
	Guid Uid { get; }

	Guid GetPackageTypeUid(Guid typeUid);

	IEnumerable<Guid> GetTypeUids();

	IEntityFilter GetFilter(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate);

	ICalendarItem[] GetItems(Guid typeUid, long[] ids, ICollection<ISchedule> schedules);

	ICalendarItem[] GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate);
}
