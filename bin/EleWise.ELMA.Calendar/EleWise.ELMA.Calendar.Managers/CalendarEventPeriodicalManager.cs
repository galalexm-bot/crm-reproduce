using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.PeriodicalEntitySettings;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.Calendar.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CalendarEventPeriodicalManager : BaseEventManager<ICalendarEventPeriodical>, IPeriodicalEntityManager
{
	private int? forwardCreated;

	public CalendarEventManager CalendarEventManager { get; set; }

	public IEntityActionHandler EntityActionHandler { get; set; }

	[NotNull]
	public new static CalendarEventPeriodicalManager Instance => Locator.GetServiceNotNull<CalendarEventPeriodicalManager>();

	public void CreatingPeriodicEntities(IPeriodicalEntity template, bool continueFromLastDate)
	{
		if (template is ICalendarEventPeriodical calendarEventPeriodical && !calendarEventPeriodical.Completed)
		{
			this.CreatePeriodicalEntity(template, continueFromLastDate, startDateIsMain: true, useProductionCalendar: false, moveBeforeHoliday: false);
		}
	}

	public ICollection<IPeriodicalEntity> FindActive()
	{
		InstanceOf<ICalendarEventPeriodicalFilter> instanceOf = new InstanceOf<ICalendarEventPeriodicalFilter>();
		instanceOf.New.Closed = false;
		ICalendarEventPeriodicalFilter @new = instanceOf.New;
		return Find(@new, FetchOptions.All).Cast<IPeriodicalEntity>().ToList();
	}

	public long CountByTemplate(IPeriodicalEntity template, DateTime fromDate)
	{
		InstanceOf<ICalendarEventFilter> instanceOf = new InstanceOf<ICalendarEventFilter>();
		instanceOf.New.TemplateEvent = (ICalendarEventPeriodical)template;
		instanceOf.New.DateRange = new DateTimeRange
		{
			From = fromDate
		};
		instanceOf.New.DisableSecurity = true;
		ICalendarEventFilter @new = instanceOf.New;
		return CalendarEventManager.Count(@new);
	}

	[Transaction]
	public virtual IEntity CreateByTemplate(IPeriodicalEntity template, DateTime startTime, DateTime endTime)
	{
		if (template == null || !(template is ICalendarEventPeriodical))
		{
			return null;
		}
		ICalendarEvent calendarEvent = CalendarEventManager.CloneEvent((ICalendarEvent)template);
		calendarEvent.TemplateEvent = (ICalendarEventPeriodical)template;
		calendarEvent.StartDate = startTime;
		calendarEvent.EndDate = endTime;
		calendarEvent.Save();
		template.CopyReminders(calendarEvent);
		template.UpdateUntilDate(startTime);
		return calendarEvent;
	}

	public int GetForwardCreated()
	{
		if (Locator.Initialized && !forwardCreated.HasValue)
		{
			CalendarSettingsModule service = Locator.GetService<CalendarSettingsModule>();
			if (service != null && service.Settings != null && service.Settings.PeriodCreated > 0)
			{
				forwardCreated = service.Settings.PeriodCreated;
			}
		}
		return forwardCreated ?? 20;
	}

	private IEnumerable<ICalendarEvent> GetActivePeriodicalEvents(ICalendarEventPeriodical obj)
	{
		CalendarEventManager calendarEventManager = CalendarEventManager;
		InstanceOf<ICalendarEventFilter> instanceOf = new InstanceOf<ICalendarEventFilter>();
		instanceOf.New.TemplateEvent = obj;
		instanceOf.New.DisableSecurity = true;
		instanceOf.New.Completed = false;
		instanceOf.New.Query = "StartDate > DateTime('Now')";
		return calendarEventManager.Find(instanceOf.New, new FetchOptions(0, 0, ListSortDirection.Ascending, "StartDate"));
	}

	[PublicApiMember]
	public override void Save(ICalendarEventPeriodical obj)
	{
		if (obj.Completed && !obj.Closed)
		{
			obj.Closed = true;
		}
		if (obj.UntilDate == DateTime.MaxValue)
		{
			obj.UntilDate = null;
		}
		if (obj.UntilDate.HasValue)
		{
			if (!obj.UntilDate.Value.IsEndDamperTime())
			{
				obj.UntilDate = obj.UntilDate.Value.Date.AddDays(1.0).AddTicks(-1L);
			}
			if (obj.LastPeriodDate.HasValue && obj.LastPeriodDate.Value.Date > obj.UntilDate.Value.Date)
			{
				CalendarEventManager calendarEventManager = CalendarEventManager;
				InstanceOf<ICalendarEventFilter> instanceOf = new InstanceOf<ICalendarEventFilter>();
				instanceOf.New.TemplateEvent = obj;
				instanceOf.New.DisableSecurity = true;
				instanceOf.New.Completed = false;
				instanceOf.New.Query = $"StartDate >= DateTime({obj.UntilDate.Value.AddDays(1.0):yyyy, M, d})";
				ICollection<ICalendarEvent> collection = calendarEventManager.Find(instanceOf.New, new FetchOptions(0, 0, ListSortDirection.Ascending, "StartDate"));
				if (collection.Any())
				{
					obj.LastPeriodDate = collection.First().StartDate.AddTicks(-1L);
					collection.Each(delegate(ICalendarEvent i)
					{
						i.Delete();
					});
				}
			}
		}
		base.Save(obj);
		CreatingPeriodicEntities(obj, continueFromLastDate: true);
	}

	public void UpdateEvents(ICalendarEventPeriodical template)
	{
		DateTime? dateTime = ((template.UntilDate.HasValue && template.UntilDate != DateTime.MaxValue) ? template.UntilDate : null);
		if (dateTime.HasValue && !dateTime.Value.IsEndDamperTime())
		{
			dateTime = dateTime.Value.Date.AddDays(1.0).AddTicks(-1L);
		}
		IEnumerable<ICalendarEvent> activePeriodicalEvents = GetActivePeriodicalEvents(template);
		foreach (ICalendarEvent item in activePeriodicalEvents)
		{
			if (!dateTime.HasValue || item.StartDate.Date <= dateTime.Value.Date)
			{
				UpdateEvent(template, item);
				((IEnumerable<ICalendarEventUser>)item.EventUsers).Where((ICalendarEventUser eu) => eu.IsNew()).ForEach(delegate(ICalendarEventUser eu)
				{
					eu.Save();
				});
				item.Save();
			}
		}
	}

	private void UpdateEvent(ICalendarEventPeriodical template, ICalendarEvent @event)
	{
		if (template.Completed)
		{
			@event.Completed = true;
			return;
		}
		CloneHelperBuilder<ICalendarEvent> cloneHelperBuilder = new CloneHelperBuilder<ICalendarEvent>(template).Restrictions(delegate(RestrictionsBuilder<ICalendarEvent> m)
		{
			m.Rule().ForPropertyName((ICalendarEvent e) => e.TemplateEvent).Ignore();
			m.Rule().ForPropertyName((ICalendarEvent e) => e.StartDate).Ignore();
			m.Rule().ForPropertyName((ICalendarEvent e) => e.EndDate).Ignore();
			m.Rule().ForPropertyName((ICalendarEvent e) => e.CreationDate).Ignore();
			m.Rule().ForPropertyName("Period").Ignore();
			m.Rule().ForAllCollections().UpdateMode(CollectionUpdateMode.Match);
			m.Rule().ForCollectionsOfType<ICalendarEventPermission>().UpdateMode((ICalendarEventPermission x, ICalendarEventPermission y) => x.TypeRole == y.TypeRole && x.User == y.User && x.Target == y.Target && x.AllowChief == y.AllowChief);
			m.Rule().ForCollectionsOfType<ICalendarEventUser>().UpdateMode((ICalendarEventUser x, ICalendarEventUser y) => x.User == y.User && x.Status == y.Status);
			m.Rule().ForCollectionsOfType<IAttachment>().UpdateMode((IAttachment x, IAttachment y) => object.Equals(x.File, y.File));
		});
		cloneHelperBuilder.Clone(@event);
		template.CopyReminders(@event);
		@event.TemplateEvent = template;
	}

	public virtual bool CanEdit(ICalendarEventPeriodical @event)
	{
		return CalendarEventManager.CanEdit(@event) && !@event.Closed;
	}

	public void ChangePeriodicity(ICalendarEventPeriodical template)
	{
		if (!template.IsNew())
		{
			IEnumerable<ICalendarEvent> activePeriodicalEvents = GetActivePeriodicalEvents(template);
			foreach (ICalendarEvent item in activePeriodicalEvents)
			{
				CalendarEventManager.Delete(item);
			}
		}
		IPeriodicalEntitySettings periodicalEntitySettings = template.GetPeriodicalEntitySettings();
		template.LastPeriodDate = DateTime.Now;
		template.Save();
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession(string.Empty);
		session.Flush();
		int continueFromLastDate;
		if (periodicalEntitySettings != null)
		{
			DateTime startDate = ((IPeriodicalEntity)template).StartDate;
			DateTime? lastPeriodDate = template.LastPeriodDate;
			continueFromLastDate = ((startDate >= lastPeriodDate) ? 1 : 0);
		}
		else
		{
			continueFromLastDate = 0;
		}
		CreatingPeriodicEntities(template, (byte)continueFromLastDate != 0);
	}

	public void ChangeEventsDates(ICalendarEventPeriodical template, DateTime oldStartDate, DateTime oldEndDate)
	{
		IEnumerable<ICalendarEvent> activePeriodicalEvents = GetActivePeriodicalEvents(template);
		ICalendarEvent calendarEvent = template;
		Func<ICalendarEvent, bool> func = (ICalendarEvent e) => IsEventDateEqualsToTemplate(template, e, oldStartDate, oldEndDate);
		Action<ICalendarEvent> action = delegate(ICalendarEvent e)
		{
			MoveTemplateEvent(e, template, oldStartDate);
		};
		IPeriodicalEntitySettings settings = template.GetPeriodicalEntitySettings();
		if (settings != null)
		{
			func = (ICalendarEvent e) => IsEventDateEqualsToSettings(settings, e, oldStartDate, oldEndDate);
			action = delegate(ICalendarEvent e)
			{
				MoveSettingsEvent(e, template, settings, oldStartDate, oldEndDate);
			};
		}
		foreach (ICalendarEvent item in activePeriodicalEvents)
		{
			if (func(item))
			{
				action(item);
				if ((template.UntilDate.HasValue && item.StartDate.Date <= template.UntilDate.Value.Date) || !template.UntilDate.HasValue)
				{
					UpdateEvent(template, item);
					CalendarEventManager.Save(item);
				}
				else
				{
					item.Delete();
				}
			}
		}
		if (settings != null)
		{
			template.LastPeriodDate = settings.MoveDate(template.LastPeriodDate.Value, oldStartDate, calendarEvent.StartDate);
		}
		else
		{
			template.LastPeriodDate = PeriodicalEntityHelper.MoveDate(template.Period, template.LastPeriodDate.Value, oldStartDate, calendarEvent.StartDate);
		}
		template.Save();
	}

	private static bool IsEventDateEqualsToTemplate(ICalendarEventPeriodical template, ICalendarEvent calendarEvent, DateTime oldStartDate, DateTime oldEndDate)
	{
		DateTime nextDate = template.GetNextDate(oldStartDate, calendarEvent.StartDate.AddMinutes(-1.0));
		DateTime date = nextDate.Add(oldEndDate - oldStartDate);
		return nextDate.EqualsUpToMinute(calendarEvent.StartDate) && date.EqualsUpToMinute(calendarEvent.EndDate);
	}

	private static bool IsEventDateEqualsToSettings(IPeriodicalEntitySettings settings, ICalendarEvent calendarEvent, DateTime oldStartDate, DateTime oldEndDate)
	{
		DateTime nextDate = settings.GetNextDate(oldStartDate, calendarEvent.StartDate.AddMinutes(-1.0));
		DateTime date = nextDate.Add(oldEndDate - oldStartDate);
		return (nextDate.EqualsUpToMinute(calendarEvent.StartDate) && date.EqualsUpToMinute(calendarEvent.EndDate)) || IsEqualsToOldDate(calendarEvent, oldStartDate, oldEndDate);
	}

	private static bool IsEqualsToOldDate(ICalendarEvent calendarEvent, DateTime oldStartDate, DateTime oldEndDate)
	{
		return oldStartDate.EqualsUpToMinute(calendarEvent.StartDate) && oldEndDate.EqualsUpToMinute(calendarEvent.EndDate);
	}

	private static void MoveTemplateEvent(ICalendarEvent calendarEvent, ICalendarEventPeriodical template, DateTime oldStartDate)
	{
		calendarEvent.StartDate = PeriodicalEntityHelper.MoveDate(template.Period, calendarEvent.StartDate, oldStartDate, ((ICalendarEvent)template).StartDate);
		calendarEvent.EndDate = calendarEvent.StartDate.Add(((ICalendarEvent)template).EndDate - ((ICalendarEvent)template).StartDate);
	}

	private static void MoveSettingsEvent(ICalendarEvent calendarEvent, ICalendarEventPeriodical template, IPeriodicalEntitySettings settings, DateTime oldStartDate, DateTime oldEndDate)
	{
		if (IsEqualsToOldDate(calendarEvent, oldStartDate, oldEndDate))
		{
			MoveTemplateEvent(calendarEvent, template, oldStartDate);
			return;
		}
		calendarEvent.StartDate = settings.MoveDate(calendarEvent.StartDate, oldStartDate, ((ICalendarEvent)template).StartDate);
		calendarEvent.EndDate = calendarEvent.StartDate.Add(((ICalendarEvent)template).EndDate - ((ICalendarEvent)template).StartDate);
	}
}
