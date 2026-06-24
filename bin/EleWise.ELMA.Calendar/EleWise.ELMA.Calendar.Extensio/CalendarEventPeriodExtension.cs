using System;
using System.Linq;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.Extensions;

public static class CalendarEventPeriodExtension
{
	public static string ToString(this CalendarEventPeriod period, DateTime? displayStartDateTime)
	{
		switch (period)
		{
		case CalendarEventPeriod.Weekly:
			return SR.T("по {0:ddd}", displayStartDateTime);
		case CalendarEventPeriod.Monthly:
			return SR.T("{0:%d}-го", displayStartDateTime);
		case CalendarEventPeriod.Quarterly:
			if (displayStartDateTime.HasValue)
			{
				DateTime dateTime = displayStartDateTime.Value;
				if (dateTime.Month > 2)
				{
					dateTime = dateTime.AddYears(1999 - dateTime.Year);
				}
				DateTime[] array = (from d in new DateTime[4]
					{
						dateTime,
						dateTime.AddMonths(3),
						dateTime.AddMonths(6),
						dateTime.AddMonths(9)
					}
					select d.AddYears(2000 - d.Year) into d
					orderby d
					select d).ToArray();
				if (array[0].Month == 2 && array[0].Day == 29)
				{
					return SR.T("{0:28(d) MMMM}, {1:d MMMM}, {2:d MMMM}, {3:d MMMM}", array[0], array[1], array[2], array[3]);
				}
				return SR.T("{0:d MMMM}, {1:d MMMM}, {2:d MMMM}, {3:d MMMM}", array[0], array[1], array[2], array[3]);
			}
			return string.Empty;
		case CalendarEventPeriod.Yearly:
			return SR.T("{0:d MMMM}", displayStartDateTime);
		default:
			return string.Empty;
		}
	}
}
