using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component(Order = int.MaxValue)]
public class CalendarEventWorkLogExtension : WorkLogExtensionBase<ICalendarEvent>
{
	public static readonly Guid uid = new Guid("{EC75C5D2-216D-42E9-BB30-C194C4FA02EA}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is ICalendarEvent calendarEvent))
		{
			return null;
		}
		return calendarEvent.CreationAuthor;
	}

	public override WorkTime? PlanWorkLog(IEntity entity)
	{
		if (entity is IWorkLogItem workLogItem)
		{
			return PlanWorkLog(WorkLogExtensionHelper.LoadObject(workLogItem));
		}
		if (entity is ICalendarEvent calendarEvent)
		{
			return new WorkTime((long)(calendarEvent.EndDate - calendarEvent.StartDate).TotalMinutes);
		}
		return null;
	}
}
