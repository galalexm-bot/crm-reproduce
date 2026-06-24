using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.Calendar;

public static class ProductionScheduleDataFactory
{
	public static ProductionScheduleData CreateByEntity(IResourceCalendar productionSchedule, int aggregationPriority = 0)
	{
		return CreateByEntity(productionSchedule, dateTimeIsClient: false, aggregationPriority);
	}

	public static ProductionScheduleData CreateByEntity(IResourceCalendar productionSchedule, bool dateTimeIsClient, int aggregationPriority = 0)
	{
		if (productionSchedule == null)
		{
			return null;
		}
		if (productionSchedule.BaseIntervals == null || !((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals).Any())
		{
			Logger.Log.Error(SR.T("Коллекция базовых интервалов производственного календаря с ID={0} пуста", productionSchedule.Id));
		}
		IEnumerable<TimeInterval> source = ((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals).Select((IBaseTimeInterval bi) => new TimeInterval(bi.Start.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : (dateTimeIsClient ? bi.Finish : bi.Finish.ToClientDateTime(dateTimeIsClient ? null : TZ.Server)).TimeOfDay, !dateTimeIsClient, aggregationPriority));
		List<WeekDay> list = new List<WeekDay>();
		IEnumerable<IGrouping<int?, IWorkTimeInterval>> source2 = from wi in (IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals
			where wi.DayOfWeek.HasValue
			select wi into wwi
			group wwi by wwi.DayOfWeek;
		int i;
		for (i = 1; i <= 7; i++)
		{
			IEnumerable<TimeInterval> enumerable = new List<TimeInterval>();
			IGrouping<int?, IWorkTimeInterval> grouping = source2.FirstOrDefault((IGrouping<int?, IWorkTimeInterval> wwig) => wwig.Key.HasValue && wwig.Key.Value == i);
			if (grouping != null)
			{
				enumerable = grouping.Select((IWorkTimeInterval wwi) => new TimeInterval(wwi.Start.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay, (wwi.Finish.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : wwi.Finish.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay, !dateTimeIsClient, aggregationPriority));
			}
			if (enumerable.Any())
			{
				list.Add(new WeekDay((i != 7) ? ((DayOfWeek)i) : DayOfWeek.Sunday, enumerable, null));
			}
		}
		List<ExceptionalDay> list2 = new List<ExceptionalDay>();
		foreach (IWorkTimeInterval item in ((IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals).Where((IWorkTimeInterval wi) => !wi.DayOfWeek.HasValue))
		{
			DateTime dateTime = item.DateExceptionStart.Value.CorrectDate();
			while (dateTime <= item.DateExceptionFinish.Value.CorrectDate())
			{
				list2.Add(new ExceptionalDay(dateTime, new List<TimeInterval>
				{
					new TimeInterval(item.Start.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay, (item.Finish.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : item.Finish.ToClientDateTime(dateTimeIsClient ? null : TZ.Server).TimeOfDay, aggregationPriority)
				}, null));
				dateTime = dateTime.AddDays(1.0);
			}
		}
		foreach (IHolidayInterval item2 in (IEnumerable<IHolidayInterval>)productionSchedule.HolidayIntervals)
		{
			DateTime dateTime2 = item2.DateStart.CorrectDate();
			while (dateTime2 <= item2.DateFinish.CorrectDate())
			{
				list2.Add(new ExceptionalDay(dateTime2, null, new List<TimeInterval>
				{
					new TimeInterval(TimeSpan.Zero, TimeSpan.FromDays(1.0), aggregationPriority)
				}));
				dateTime2 = dateTime2.AddDays(1.0);
			}
		}
		return new ProductionScheduleData(source.OrderBy((TimeInterval bi) => bi.Start), list.OrderBy((WeekDay wd) => wd.DayOfWeek), list2.OrderBy((ExceptionalDay ed) => ed.Date));
	}

	private static DateTime CorrectDate(this DateTime date)
	{
		if (date.TimeOfDay != TimeSpan.Zero)
		{
			return date.ToClientDateTime(TZ.Server);
		}
		return date;
	}
}
