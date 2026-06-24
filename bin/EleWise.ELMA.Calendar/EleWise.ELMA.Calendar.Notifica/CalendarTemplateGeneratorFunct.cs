using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;

namespace EleWise.ELMA.Calendar.Notifications;

[Component]
public class CalendarTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
{
	public static FormatedValue GetCalendarEventMembers(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count < 1 || context.Parameters[0] == null)
		{
			return null;
		}
		if (!(context.Parameters[0].Value is ICalendarEvent calendarEvent) || !((IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers).Any())
		{
			return null;
		}
		CalendarEventUserStatus? status = null;
		if (context.Parameters[1].Value != null)
		{
			int num = Convert.ToInt32(context.Parameters[1].Value);
			if (Enum.IsDefined(typeof(CalendarEventUserStatus), num))
			{
				status = (CalendarEventUserStatus?)Enum.ToObject(typeof(CalendarEventUserStatus), num);
			}
		}
		return new FormatedValue((from eu in (IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers
			where !status.HasValue || eu.Status == status.Value
			select eu.User).ToList());
	}
}
