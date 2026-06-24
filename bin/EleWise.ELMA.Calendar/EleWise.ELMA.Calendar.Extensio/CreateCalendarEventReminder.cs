using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Calendar.Extensions;

[Component]
public class CreateCalendarEventReminder : ICreateReminderExtended
{
	public bool Check(IReminder reminder)
	{
		if (reminder.RefObject == null || reminder.RefObject.Object == null)
		{
			return false;
		}
		IEntity entity = reminder.RefObject.Object.CastAsRealType();
		return entity is ICalendarEvent calendarEvent && calendarEvent.TemplateEvent != null;
	}

	public IReminder Create(IReminder reminder)
	{
		if (reminder.RefObject == null || reminder.RefObject.Object == null)
		{
			return reminder;
		}
		IEntity entity = reminder.RefObject.Object.CastAsRealType();
		if (!(entity is ICalendarEvent calendarEvent) || calendarEvent.TemplateEvent == null)
		{
			return reminder;
		}
		ICalendarEventPeriodical eventTemplate = calendarEvent.TemplateEvent;
		IReminder reminder2 = InterfaceActivator.Create<IReminder>();
		reminder2.PropertyName = reminder.PropertyName;
		reminder2.RemindTo = reminder.RemindTo;
		reminder2.RefObject = ReferenceOnEntity.Create(eventTemplate);
		reminder.Template = reminder2;
		reminder2.Save();
		ICollection<ICalendarEvent> collection = CalendarEventManager.Instance.Find((ICalendarEvent f) => f.TemplateEvent == eventTemplate && f.StartDate >= DateTime.Now && ((IEnumerable<ICalendarEventUser>)f.EventUsers).Any((ICalendarEventUser u) => u.User.Id == reminder.CreationAuthor.Id));
		foreach (ICalendarEvent item in collection)
		{
			if (item.Id != calendarEvent.Id)
			{
				ReminderManager.Instance.CreateByTemplate(reminder2, item)?.Save();
			}
		}
		return reminder;
	}
}
