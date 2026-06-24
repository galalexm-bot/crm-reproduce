using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Calendar.Managers;

public class CalendarEventPeriodicalBuilder<TEntity, TBuilder> : CalendarEventBuilder<TEntity, TBuilder> where TEntity : ICalendarEventPeriodical where TBuilder : CalendarEventPeriodicalBuilder<TEntity, TBuilder>
{
	private bool closeEvent;

	public TBuilder UntilDate(DateTime untilDate)
	{
		@event.UntilDate = untilDate;
		return this as TBuilder;
	}

	public TBuilder Close(bool close)
	{
		closeEvent = close;
		return this as TBuilder;
	}

	public TBuilder Periodicity(Periodicity periodicity)
	{
		@event.Period = periodicity;
		return this as TBuilder;
	}

	public override TEntity Save()
	{
		if (closeEvent)
		{
			if (!@event.UntilDate.HasValue)
			{
				throw new ArgumentNullException(SR.T("Дата завершения создания сущности не задана"));
			}
		}
		else
		{
			@event.UntilDate = null;
		}
		return base.Save();
	}
}
public class CalendarEventPeriodicalBuilder : CalendarEventPeriodicalBuilder<ICalendarEventPeriodical, CalendarEventPeriodicalBuilder>
{
}
