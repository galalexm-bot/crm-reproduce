using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.Extensions;

public static class ExceptionalDayExtension
{
	public static IEnumerable<ExceptionalDay> Squash(this IEnumerable<ExceptionalDay> exceptionalDayCollection)
	{
		if (exceptionalDayCollection == null)
		{
			throw new NullReferenceException(SR.T("Коллекция исключительных дней - \"null\""));
		}
		if (!exceptionalDayCollection.Any())
		{
			return exceptionalDayCollection.OrderBy((ExceptionalDay ed) => ed.Date);
		}
		return from wdc in exceptionalDayCollection
			group wdc by wdc.Date into g
			select g.Aggregate(new ExceptionalDay(g.Key, null, null), (ExceptionalDay aggregatedWeekDay, ExceptionalDay exceptionalDay) => aggregatedWeekDay.Merge(exceptionalDay)) into ed
			orderby ed.Date
			select ed;
	}
}
