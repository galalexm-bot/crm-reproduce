using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Calendar.Export.Extensions;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using Ical.Net;
using Ical.Net.DataTypes;
using Ical.Net.Interfaces;
using Ical.Net.Interfaces.Components;
using Ical.Net.Interfaces.DataTypes;
using Ical.Net.Interfaces.Evaluation;

namespace EleWise.ELMA.Calendar.Export.Components;

[Component]
public class iCalEventConverter : IExternalCalendarEventConverter
{
	private const string UID_S = "{2C085ED2-7074-4F84-A080-8E825F4C5CC5}";

	public string Name => "iCal";

	public Guid Uid => new Guid("{2C085ED2-7074-4F84-A080-8E825F4C5CC5}");

	public IEnumerable<ExternalCalendarItem> Deserialize(string sourceId, string calendarContent, DateTime startDate, DateTime endDate)
	{
		using StringReader stringReader = new StringReader(calendarContent);
		IICalendarCollection source;
		try
		{
			source = Calendar.LoadFromStream((TextReader)stringReader);
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка разбора данных календаря"), exception);
			yield break;
		}
		foreach (IEvent ev in ((IEnumerable<ICalendar>)source).SelectMany((ICalendar ical) => (IEnumerable<IEvent>)ical.get_Events()))
		{
			if (((IRecurrable)ev).get_RecurrenceRules().Count == 0)
			{
				ExternalCalendarItem externalCalendarItem = Convert(sourceId, ev);
				if ((externalCalendarItem.StartDate < startDate && externalCalendarItem.EndDate >= startDate) || (externalCalendarItem.StartDate >= startDate && externalCalendarItem.StartDate <= endDate))
				{
					yield return externalCalendarItem;
				}
				continue;
			}
			HashSet<Occurrence> occurrences = ((IGetOccurrences)ev).GetOccurrences(startDate.ToUniversalTime(), endDate.ToUniversalTime());
			foreach (Occurrence item in occurrences)
			{
				yield return ConvertOccurance(sourceId, ev, item);
			}
		}
	}

	private EventStatus ConvertEventStatus(EventStatus status)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
		return (int)status switch
		{
			1 => EventStatus.Confirmed, 
			0 => EventStatus.Tentative, 
			2 => EventStatus.Cancelled, 
			_ => EventStatus.Undefined, 
		};
	}

	private ExternalCalendarItem ConvertOccurance(string sourceId, IEvent @event, Occurrence occur)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		return new ExternalCalendarItem
		{
			Id = ((IUniqueComponent)@event).get_Uid(),
			SourceTypeUid = new Guid("{2C085ED2-7074-4F84-A080-8E825F4C5CC5}"),
			SourceId = sourceId,
			Theme = ((IRecurringComponent)@event).get_Summary(),
			Place = @event.get_Location(),
			Status = ConvertEventStatus(@event.get_Status()),
			Description = ((IRecurringComponent)@event).get_Description(),
			IsPeriodical = true,
			StartDate = GetStartRutimeDateTime(occur.get_Period().get_StartTime(), @event.get_IsAllDay()),
			EndDate = GetEndRuntimeDateTime(occur.get_Period().get_EndTime(), @event.get_IsAllDay())
		};
	}

	private ExternalCalendarItem Convert(string sourceId, IEvent @event)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		DateTime startRutimeDateTime = GetStartRutimeDateTime(((IRecurrable)@event).get_Start(), @event.get_IsAllDay());
		DateTime endDate = ((@event.get_End() == null) ? startRutimeDateTime : GetEndRuntimeDateTime(@event.get_End(), @event.get_IsAllDay()));
		return new ExternalCalendarItem
		{
			Id = ((IUniqueComponent)@event).get_Uid(),
			SourceTypeUid = new Guid("{2C085ED2-7074-4F84-A080-8E825F4C5CC5}"),
			SourceId = sourceId,
			Theme = ((IRecurringComponent)@event).get_Summary(),
			Place = @event.get_Location(),
			Status = ConvertEventStatus(@event.get_Status()),
			Description = ((IRecurringComponent)@event).get_Description(),
			IsPeriodical = false,
			StartDate = startRutimeDateTime,
			EndDate = endDate
		};
	}

	private DateTime GetStartRutimeDateTime(IDateTime startDateTime, bool isAllDay)
	{
		DateTime result = startDateTime.get_AsUtc().ToLocalTime();
		if (!isAllDay)
		{
			return result;
		}
		return new DateTime(result.Year, result.Month, result.Day, result.Hour, result.Minute, 10, 0);
	}

	private DateTime GetEndRuntimeDateTime(IDateTime externalEndDateTime, bool isAllDay)
	{
		DateTime result = externalEndDateTime.get_AsUtc().ToLocalTime();
		if (!isAllDay)
		{
			return result;
		}
		return new DateTime(result.Year, result.Month, result.Day, result.Hour, result.Minute, 50, 0).AddMinutes(-1.0);
	}
}
