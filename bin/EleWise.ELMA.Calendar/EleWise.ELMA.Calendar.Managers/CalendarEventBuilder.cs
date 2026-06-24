using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Calendar.Managers;

public class CalendarEventBuilder<TEntity, TBuilder> where TEntity : ICalendarEvent where TBuilder : CalendarEventBuilder<TEntity, TBuilder>
{
	internal TEntity @event;

	public CalendarEventBuilder()
	{
		@event = InterfaceActivator.Create<TEntity>();
		@event.CreationAuthor = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		@event.CreationDate = DateTime.Now;
	}

	public TBuilder Subject(string subject)
	{
		@event.Subject = subject;
		return this as TBuilder;
	}

	public TBuilder Place(string place)
	{
		@event.Place = place;
		return this as TBuilder;
	}

	public TBuilder Description(string description)
	{
		@event.Description = description;
		return this as TBuilder;
	}

	public TBuilder StartDate(DateTime startDate)
	{
		@event.StartDate = startDate;
		return this as TBuilder;
	}

	public TBuilder EndDate(DateTime endDate)
	{
		@event.EndDate = endDate;
		return this as TBuilder;
	}

	public TBuilder Users(params IUser[] users)
	{
		if (users != null)
		{
			foreach (IUser user in users)
			{
				ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
				calendarEventUser.Event = @event;
				calendarEventUser.User = user;
				calendarEventUser.Status = CalendarEventUserStatus.Participant;
				@event.EventUsers.Add(calendarEventUser);
			}
		}
		return this as TBuilder;
	}

	public TBuilder Users(IEnumerable<IUser> users)
	{
		return Users(users.ToArray());
	}

	public TBuilder InformTo(params IUser[] users)
	{
		if (users != null)
		{
			foreach (IUser user in users)
			{
				ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
				calendarEventUser.Event = @event;
				calendarEventUser.User = user;
				calendarEventUser.Status = CalendarEventUserStatus.InfromTo;
				@event.EventUsers.Add(calendarEventUser);
			}
		}
		return this as TBuilder;
	}

	public TBuilder InformTo(IEnumerable<IUser> users)
	{
		return InformTo(users.ToArray());
	}

	public TBuilder Attachments(params IAttachment[] attachments)
	{
		if (attachments != null)
		{
			foreach (IAttachment attachment in attachments)
			{
				IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, attachment, DefaultEntityActions.CreateGuid);
				if (entityActionEventArgs != null)
				{
					serviceNotNull.ActionExecuted(entityActionEventArgs);
				}
				@event.Attachments.Add(attachment);
			}
		}
		return this as TBuilder;
	}

	public TBuilder Attachments(IEnumerable<IAttachment> attachments)
	{
		return Attachments(attachments.ToArray());
	}

	public TBuilder Calendars(params ISchedule[] calendars)
	{
		if (calendars != null)
		{
			foreach (ISchedule schedule in calendars)
			{
				@event.Schedules.Add(schedule);
			}
		}
		return this as TBuilder;
	}

	public TBuilder Calendars(IEnumerable<ISchedule> calendars)
	{
		return Calendars(calendars.ToArray());
	}

	public virtual TEntity Save()
	{
		if (string.IsNullOrEmpty(@event.Subject) || string.IsNullOrWhiteSpace(@event.Subject))
		{
			throw new ArgumentNullException(SR.T("Тема события не заполнена или состоит из одних пробелов"));
		}
		if (!((IEnumerable<ICalendarEventUser>)@event.EventUsers).Any())
		{
			throw new ArgumentNullException(SR.T("Участники события не заполнены"));
		}
		if (@event.StartDate == DateTime.MinValue)
		{
			throw new ArgumentNullException(SR.T("Дата начала события не заполнена"));
		}
		if (@event.EndDate == DateTime.MinValue)
		{
			throw new ArgumentNullException(SR.T("Дата окончания события не заполнена"));
		}
		@event.Save();
		return @event;
	}
}
public class CalendarEventBuilder : CalendarEventBuilder<ICalendarEvent, CalendarEventBuilder>
{
}
