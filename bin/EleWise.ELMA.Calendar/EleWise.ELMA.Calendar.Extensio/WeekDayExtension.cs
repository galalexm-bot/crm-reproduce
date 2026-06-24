using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.Extensions;

public static class WeekDayExtension
{
	public static IEnumerable<WeekDay> Squash(this IEnumerable<WeekDay> weekDayCollection)
	{
		if (weekDayCollection == null)
		{
			throw new NullReferenceException(SR.T("Коллекция дней недели - \"null\""));
		}
		if (!weekDayCollection.Any())
		{
			return weekDayCollection;
		}
		return from wdc in weekDayCollection
			group wdc by wdc.DayOfWeek into g
			select g.Aggregate(new WeekDay(g.Key, null, null), (WeekDay aggregatedWeekDay, WeekDay weekDay) => aggregatedWeekDay.Merge(weekDay)) into wd
			orderby wd.DayOfWeek
			select wd;
	}
}
