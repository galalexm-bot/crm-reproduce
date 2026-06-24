using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Calendar.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CalendarEventManager : BaseEventManager<ICalendarEvent>
{
	internal static string NeedConfirmParticipationKeyName = "NeedConfirmParticipationKeyName";

	internal static string EventStartDateKeyName = "EventStartDateKeyName";

	[NotNull]
	public new static CalendarEventManager Instance => Locator.GetServiceNotNull<CalendarEventManager>();

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	[Transaction]
	[Obsolete("Periodical event logic move to CalendarEventPeriodicalManager")]
	public virtual void Save(ICalendarEvent obj, bool onlySave, bool changePeriod = false)
	{
		Save(obj);
	}

	[Obsolete("Use class PeriodicalEntityHelper")]
	public static DateTime GetNextDate(CalendarEventPeriod period, DateTime fromDate, DateTime currentDate, bool moveBeforeHoliday = false)
	{
		if (period == CalendarEventPeriod.Once)
		{
			return currentDate;
		}
		Periodicity result;
		return Enum.TryParse<Periodicity>(period.ToString(), ignoreCase: true, out result) ? result.GetNextDate(fromDate, currentDate, moveBeforeHoliday) : currentDate;
	}

	[Obsolete("Use class PeriodicalEntityHelper")]
	public static DateTime GetNextDate(CalendarEventPeriod period, DateTime currentDate, bool moveBeforeHoliday = false)
	{
		return GetNextDate(period, currentDate, currentDate, moveBeforeHoliday);
	}

	public static ICalendarEvent CloneEvent(ICalendarEvent @event)
	{
		return CloneHelperBuilder.Create(@event).Restrictions(delegate(RestrictionsBuilder<ICalendarEvent> m)
		{
			m.Rule().ForPropertyName((ICalendarEvent e) => e.TemplateEvent).Ignore();
			m.Rule().ForPropertyName((ICalendarEventUser eu) => eu.Confirmed).Ignore();
			m.Rule().ForPropertyName((ICalendarEventUser eu) => eu.ConfirmDate).Ignore();
			m.Rule().ForPropertyName((ICalendarEventUser eu) => eu.ConfirmComment).Ignore();
			m.Rule().ForPropertyName("Period").Ignore();
			m.Rule().ForPropertyName((ICalendarEvent e) => e.CreationDate).Ignore();
			m.Rule().ForAllCollections().UpdateMode(CollectionUpdateMode.Match);
			m.Rule().ForCollectionsOfType<ICalendarEventPermission>().UpdateMode((ICalendarEventPermission x, ICalendarEventPermission y) => x.TypeRole == y.TypeRole && x.User == y.User && x.Target == y.Target && x.AllowChief == y.AllowChief);
			m.Rule().ForCollectionsOfType<ICalendarEventUser>().UpdateMode((ICalendarEventUser x, ICalendarEventUser y) => x.User == y.User && x.Status == y.Status);
			m.Rule().ForCollectionsOfType<IAttachment>().UpdateMode((IAttachment x, IAttachment y) => object.Equals(x.File, y.File));
		}).Clone(InterfaceActivator.Create<ICalendarEvent>());
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is ICalendarEventFilter calendarEventFilter))
		{
			return;
		}
		if (calendarEventFilter.Schedules != null && ((IEnumerable<ISchedule>)calendarEventFilter.Schedules).Any())
		{
			List<ISchedule> source = ((IEnumerable<ISchedule>)calendarEventFilter.Schedules).Where((ISchedule s) => s.Owner == null).ToList();
			List<IUser> source2 = (from s in (IEnumerable<ISchedule>)calendarEventFilter.Schedules
				where s.Owner != null
				select s.Owner).ToList();
			AbstractCriterion val = null;
			AbstractCriterion val2 = null;
			if (source.Any())
			{
				DetachedCriteria val3 = DetachedCriteria.For(InterfaceActivator.TypeOf<ICalendarEvent>()).CreateAlias("Schedules", "sch", (JoinType)0).Add((ICriterion)(object)Restrictions.In("sch.Id", (ICollection)source.Select((ISchedule e) => e.Id).ToArray()))
					.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id")));
				val = Subqueries.PropertyIn("Id", val3);
			}
			if (source2.Any())
			{
				DetachedCriteria val4 = DetachedCriteria.For(InterfaceActivator.TypeOf<ICalendarEventUser>()).Add((ICriterion)(object)Restrictions.In("User", (ICollection)source2.Select((IUser e) => e.Id).ToArray())).SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Event")));
				val2 = Subqueries.PropertyIn("Id", val4);
			}
			if (val != null && val2 != null)
			{
				criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)val, (ICriterion)(object)val2));
			}
			else if (val != null)
			{
				criteria.Add((ICriterion)(object)val);
			}
			else if (val2 != null)
			{
				criteria.Add((ICriterion)(object)val2);
			}
		}
		if (calendarEventFilter.DateRange.From.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Ge("EndDate", (object)calendarEventFilter.DateRange.From));
		}
		if (calendarEventFilter.DateRange.To.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Le("StartDate", (object)calendarEventFilter.DateRange.To));
		}
		if (!calendarEventFilter.AllTypes)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq(GetTypeUidPropertyName(filter), (object)base.ImplementationTypeUid));
		}
	}

	[Transaction]
	public virtual void CompleteEvent(ICalendarEvent @event, ICommentActionModel actionModel)
	{
		if (@event != null)
		{
			if (actionModel != null && actionModel.Comment != null)
			{
				actionModel.Comment.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
				@event.Comments.Add(actionModel.Comment);
			}
			@event.Completed = true;
			@event.Save();
			EntityActionEventArgs e = new EntityActionEventArgs(null, @event, "f53d81fc-de2e-4d95-843f-2e3d6464b680");
			CommentActionHandler.Process(@event, actionModel);
			CommentActionHandler.ProcessEventArgs(e, actionModel);
			EntityActionHandler.ActionExecuted(e);
		}
	}

	public virtual bool CanEdit(ICalendarEvent @event)
	{
		if (@event == null || @event.Completed)
		{
			return false;
		}
		return base.SecurityService.HasPermission(PermissionProvider.EditEventPermission, @event);
	}

	[ActionCheck("a615693d-1d05-4dbd-97a2-19331a825093")]
	public virtual bool CanChangeTime(ICalendarEvent @event, DateTime startDate, DateTime endDate, IComment comment)
	{
		return startDate < endDate && CanEdit(@event);
	}

	[ActionMethod("a615693d-1d05-4dbd-97a2-19331a825093")]
	[Transaction]
	public virtual ICalendarEvent ChangeTime(ICalendarEvent @event, DateTime startDate, DateTime endDate, IComment comment)
	{
		if (@event == null)
		{
			return null;
		}
		@event.StartDate = startDate;
		@event.EndDate = endDate;
		if (comment != null)
		{
			@event.Comments.Add(comment);
		}
		ResetConfirmationForUsers(@event);
		@event.Save();
		EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, @event, "a615693d-1d05-4dbd-97a2-19331a825093"));
		return @event;
	}

	[ActionCheck("a1ab98cb-4bc5-4292-865f-ee6937b0d92d")]
	public virtual bool CanDeleteEvent(ICalendarEvent @event, bool all)
	{
		try
		{
			if (all && @event.TemplateEvent != null && !CanEdit(@event.TemplateEvent))
			{
				return false;
			}
		}
		catch (ObjectNotFoundException)
		{
			return false;
		}
		return CanEdit(@event);
	}

	[Transaction]
	[ActionMethod("a1ab98cb-4bc5-4292-865f-ee6937b0d92d")]
	public virtual void DeleteEvent(ICalendarEvent @event, bool all)
	{
		if (all && (@event is ICalendarEventPeriodical || @event.TemplateEvent != null))
		{
			ICalendarEventPeriodical calendarEventPeriodical = ((@event is ICalendarEventPeriodical) ? ((ICalendarEventPeriodical)@event) : @event.TemplateEvent);
			InstanceOf<ICalendarEventFilter> instanceOf = new InstanceOf<ICalendarEventFilter>();
			instanceOf.New.DisableSecurity = true;
			instanceOf.New.TemplateEvent = calendarEventPeriodical;
			ICollection<ICalendarEvent> collection = Find(instanceOf.New, FetchOptions.All);
			foreach (ICalendarEvent item in collection)
			{
				item.Delete();
			}
			calendarEventPeriodical.Delete();
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, calendarEventPeriodical, "f5d56c0f-95af-48d5-89a0-ea4e9a336429"));
		}
		else
		{
			@event.Delete();
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, @event, "f5d56c0f-95af-48d5-89a0-ea4e9a336429"));
		}
	}

	[Transaction]
	public virtual string ConfirmParticipation([NotNull] ICalendarEvent @event, [NotNull] IUser user, ConfirmParticipation status, ICommentActionModel actionModel = null)
	{
		if (!@event.ConfirmParticipation || @event is ICalendarEventPeriodical)
		{
			return SR.T("Подтверждение участия не нужно в событии");
		}
		if (@event.Completed)
		{
			return SR.T("Событие завершено");
		}
		ICalendarEventUser calendarEventUser = ((IEnumerable<ICalendarEventUser>)@event.EventUsers).FirstOrDefault((ICalendarEventUser eu) => eu.User.Id == user.Id && eu.Status == CalendarEventUserStatus.Participant);
		if (calendarEventUser != null)
		{
			if (status != 0)
			{
				if (calendarEventUser.Confirmed != status)
				{
					calendarEventUser.Confirmed = status;
					calendarEventUser.ConfirmDate = DateTime.Now;
					calendarEventUser.ConfirmComment = ((actionModel != null && actionModel.Comment != null) ? actionModel.Comment.Text : string.Empty);
					calendarEventUser.Save();
					if (@event.NotifyMeConfirmParticipation)
					{
						EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, calendarEventUser, (status == EleWise.ELMA.Calendar.Models.ConfirmParticipation.Confirmed) ? "cd75c8a4-71a4-4e9a-bf60-9eadd957710a" : "ce7dbd74-250d-405c-9317-090e5c7a9506"));
					}
					return (status == EleWise.ELMA.Calendar.Models.ConfirmParticipation.Confirmed) ? SR.T("Вы подтвердили участие в событии") : SR.T("Вы отказались от участия в событии");
				}
				return SR.T("Вы уже подтверждали участие в событии");
			}
			return SR.T("Невозможно указать неопределённый статус подтверждения участия в событии");
		}
		return SR.T("Вы не являетесь участником события");
	}

	public void ResetConfirmationForUsers(ICalendarEvent @event)
	{
		if (!@event.ConfirmParticipation)
		{
			return;
		}
		foreach (ICalendarEventUser item in ((IEnumerable<ICalendarEventUser>)@event.EventUsers).Where((ICalendarEventUser eu) => eu.Status == CalendarEventUserStatus.Participant))
		{
			item.Confirmed = ((item.User.Id == base.AuthenticationService.GetCurrentUser<IUser>().Id) ? EleWise.ELMA.Calendar.Models.ConfirmParticipation.Confirmed : EleWise.ELMA.Calendar.Models.ConfirmParticipation.None);
			item.ConfirmDate = ((item.User.Id == base.AuthenticationService.GetCurrentUser<IUser>().Id) ? new DateTime?(DateTime.Now) : null);
			item.ConfirmComment = string.Empty;
		}
	}

	public Dictionary<ISchedule, List<ICalendarItem>> CrossingEvents(ICollection<ISchedule> schedules, DateTime fromDate, DateTime toDate, long? currentId, Guid? currentTypeUid)
	{
		IMetadataRuntimeService metadataRuntimeService = MetadataServiceContext.MetadataRuntimeService;
		Type currentType = (currentTypeUid.HasValue ? metadataRuntimeService.GetTypeByUid(currentTypeUid.Value) : null);
		return (from e in ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>().SelectMany((ICalendarItemProvider p) => p.CrossingItems(schedules, fromDate, toDate))
			group e by e.Key).ToDictionary((IGrouping<ISchedule, KeyValuePair<ISchedule, ICollection<ICalendarItem>>> e) => e.Key, delegate(IGrouping<ISchedule, KeyValuePair<ISchedule, ICollection<ICalendarItem>>> e)
		{
			List<ICalendarItem> list = new List<ICalendarItem>();
			foreach (ICalendarItem item in from x in e.SelectMany((KeyValuePair<ISchedule, ICollection<ICalendarItem>> k) => k.Value)
				where !x.Completed
				select x)
			{
				Type typeByUidOrNull = metadataRuntimeService.GetTypeByUidOrNull(item.SourceTypeUid);
				if (!currentId.HasValue || currentType == null || typeByUidOrNull == null || !typeByUidOrNull.IsAssignableFrom(currentType) || currentId.ToString() != item.Id)
				{
					list.Add(item);
				}
			}
			return list;
		});
	}

	public Dictionary<ISchedule, List<ICalendarItem>> CrossingEvents(ICollection<ISchedule> schedules, DateTime fromDate, DateTime toDate, IEntity entity = null)
	{
		long? currentId = ((entity != null) ? ((long?)entity.GetId()) : null);
		Guid? currentTypeUid = null;
		if (entity != null)
		{
			currentTypeUid = MetadataLoader.LoadMetadata(entity.GetType(), inherit: false).Uid;
		}
		return CrossingEvents(schedules, fromDate, toDate, currentId, currentTypeUid);
	}

	public List<IUser> ConfirmParticipationRecipient(ICalendarEvent @event)
	{
		if (@event == null || !@event.ConfirmParticipation || @event is ICalendarEventPeriodical || !((IEnumerable<ICalendarEventUser>)@event.EventUsers).Any())
		{
			return new List<IUser>();
		}
		return (from eu in (IEnumerable<ICalendarEventUser>)@event.EventUsers
			where eu.Status == CalendarEventUserStatus.Participant && eu.Confirmed == EleWise.ELMA.Calendar.Models.ConfirmParticipation.None
			select eu.User).ToList();
	}

	public List<Pair<long, List<WebDataItem>>> GetMessageObjectInfo(long id, List<long> recipients)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("SELECT DISTINCT c.{0} as {1}, c.{9}, c.{13}, cu.{7} as {11}, cu.{5} as {12} FROM {2} INNER JOIN {3} ON cu.{4} = c.{0} AND cu.{6} = 0 AND cu.{7} in ({8}) WHERE c.{0} = {10}", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("TargetId"), serviceNotNull.NoLockTableExpression("CalendarEvent", "c"), serviceNotNull.NoLockTableExpression("CalendarEventUser", "cu"), serviceNotNull.Dialect.QuoteIfNeeded("EventID"), serviceNotNull.Dialect.QuoteIfNeeded("ConfirmedId"), serviceNotNull.Dialect.QuoteIfNeeded("StatusId"), serviceNotNull.Dialect.QuoteIfNeeded("UserID"), string.Join(",", recipients), serviceNotNull.Dialect.QuoteIfNeeded("ConfirmParticipation"), id, serviceNotNull.Dialect.QuoteIfNeeded("Recipient"), serviceNotNull.Dialect.QuoteIfNeeded("Confirmed"), serviceNotNull.Dialect.QuoteIfNeeded("StartDate"));
		List<Pair<long, List<WebDataItem>>> list = new List<Pair<long, List<WebDataItem>>>();
		using (IDataReader dataReader = serviceNotNull.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				List<WebDataItem> list2 = new List<WebDataItem>();
				if (!(dataReader["TargetId"] is DBNull))
				{
					long first = Convert.ToInt64(dataReader["Recipient"]);
					int num = Convert.ToInt32(dataReader["Confirmed"]);
					bool flag = Convert.ToBoolean(dataReader["ConfirmParticipation"]);
					DateTime dateTime = Convert.ToDateTime(dataReader["StartDate"]);
					if (flag && num == 0)
					{
						list2.Add(new WebDataItem
						{
							Name = NeedConfirmParticipationKeyName,
							Value = true.ToString()
						});
					}
					list2.Add(new WebDataItem
					{
						Name = EventStartDateKeyName,
						Value = dateTime.Ticks.ToString()
					});
					list.Add(new Pair<long, List<WebDataItem>>(first, list2));
				}
			}
		}
		return list;
	}

	public virtual bool EventIdNeedConfirmParticipation(ICalendarItem item)
	{
		if (item is CalendarEventItem calendarEventItem)
		{
			long currentUserId = base.AuthenticationService.GetCurrentUser<IUser>().Id;
			ICalendarEvent @event = calendarEventItem.Event;
			if (@event != null)
			{
				ICalendarEventUser calendarEventUser = ((IEnumerable<ICalendarEventUser>)@event.EventUsers).FirstOrDefault((ICalendarEventUser eu) => eu.User.Id == currentUserId && eu.Status == CalendarEventUserStatus.Participant);
				return calendarEventUser != null && @event.ConfirmParticipation && calendarEventUser.Confirmed == EleWise.ELMA.Calendar.Models.ConfirmParticipation.None;
			}
		}
		return false;
	}

	[PublicApiMember]
	public virtual ICalendarEvent Create(IEnumerable<IUser> users, IEnumerable<ISchedule> calendars, DateTime startDate, DateTime endDate, string eventSubject, string eventPlace, string eventDescription)
	{
		ICalendarEvent calendarEvent = InterfaceActivator.Create<ICalendarEvent>();
		calendarEvent.Description = eventDescription ?? "";
		calendarEvent.StartDate = startDate;
		calendarEvent.EndDate = endDate;
		calendarEvent.Subject = eventSubject;
		calendarEvent.Place = eventPlace ?? "";
		foreach (ISchedule calendar in calendars)
		{
			calendarEvent.Schedules.Add(calendar);
		}
		foreach (IUser user in users)
		{
			ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
			calendarEventUser.Event = calendarEvent;
			calendarEventUser.User = user;
			calendarEventUser.Status = CalendarEventUserStatus.Participant;
			calendarEvent.EventUsers.Add(calendarEventUser);
		}
		calendarEvent.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
		calendarEvent.Save();
		return calendarEvent;
	}

	[PublicApiMember]
	public virtual ICalendarEvent Create(IEnumerable<IUser> users, IEnumerable<ISchedule> calendars, DateTime startDate, DateTime endDate, string eventSubject, string eventPlace)
	{
		return Create(users, calendars, startDate, endDate, eventSubject, eventPlace, null);
	}

	[PublicApiMember]
	public virtual IReminder CreateReminder(IUser user, ICalendarEvent calendarEvent, DateTime remindDate)
	{
		IReminder reminder = InterfaceActivator.Create<IReminder>();
		reminder.RefObject = new ReferenceOnEntity(calendarEvent.Id, calendarEvent.TypeUid);
		reminder.RemindDate = remindDate;
		reminder.CreationAuthor = user;
		reminder.Save();
		return reminder;
	}

	[PublicApiMember]
	public virtual IReminder CreateReminder(IUser user, ICalendarEvent calendarEvent, TimeSpan remindToDate)
	{
		IReminder reminder = InterfaceActivator.Create<IReminder>();
		reminder.RefObject = new ReferenceOnEntity(calendarEvent.Id, calendarEvent.TypeUid);
		reminder.RemindTo = remindToDate;
		reminder.CreationAuthor = user;
		reminder.Save();
		return reminder;
	}

	[PublicApiMember]
	public virtual ICalendarEvent Create(IEnumerable<IUser> users, DateTime startDate, DateTime endDate, string eventSubject, string eventPlace, string eventDescription)
	{
		ICalendarEvent calendarEvent = InterfaceActivator.Create<ICalendarEvent>();
		calendarEvent.Description = eventDescription ?? "";
		calendarEvent.StartDate = startDate;
		calendarEvent.EndDate = endDate;
		calendarEvent.Subject = eventSubject;
		calendarEvent.Place = eventPlace ?? "";
		foreach (IUser user in users)
		{
			ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
			calendarEventUser.Event = calendarEvent;
			calendarEventUser.User = user;
			calendarEventUser.Status = CalendarEventUserStatus.Participant;
			calendarEvent.EventUsers.Add(calendarEventUser);
		}
		calendarEvent.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
		calendarEvent.Save();
		return calendarEvent;
	}

	[PublicApiMember]
	public virtual ICalendarEvent Create(IEnumerable<IUser> users, DateTime startDate, DateTime endDate, string eventSubject)
	{
		return Create(users, startDate, endDate, eventSubject, null, null);
	}

	[PublicApiMember]
	public virtual ICalendarEvent Create(IEnumerable<IUser> users, DateTime startDate, DateTime endDate, string eventSubject, string eventPlace)
	{
		return Create(users, startDate, endDate, eventSubject, eventPlace, null);
	}

	[PublicApiMember]
	public bool CheckEvents(DateTime startDate, DateTime endDate, IUser user)
	{
		IScheduleFilter scheduleFilter = InterfaceActivator.Create<IScheduleFilter>();
		scheduleFilter.Owner = user;
		ISchedule schedule = AbstractNHEntityManager<ISchedule, long>.Instance.Find(scheduleFilter, null).FirstOrDefault();
		return CheckEvents(startDate, endDate, schedule);
	}

	[PublicApiMember]
	public bool CheckEvents(DateTime startDate, DateTime endDate, ISchedule schedule)
	{
		Dictionary<ISchedule, List<ICalendarItem>> source = Instance.CrossingEvents(new List<ISchedule> { schedule }, startDate, endDate);
		return source.Any();
	}

	public T ConvertToEntity<T>(ICalendarItem item)
	{
		return (T)ModelHelper.GetEntityManager(typeof(T)).Load(item.Id);
	}

	public List<T> ConvertToEntityList<T>(IEnumerable<ICalendarItem> items)
	{
		List<string> ids = new List<string>();
		items.ForEach(delegate(ICalendarItem q)
		{
			ids.Add(q.Id);
		});
		IEntityManager entityManager = ModelHelper.GetEntityManager(typeof(T));
		object[] idArray = ids.ToArray();
		return entityManager.FindByIdArray(idArray).CastToListOrNull<T>().ToList();
	}

	[PublicApiMember]
	public CalendarItemCollection GetCalendarItems(DateTime startDate, DateTime endDate, ISchedule schedule)
	{
		CalendarItemCollection calendarItemCollection = new CalendarItemCollection();
		Dictionary<ISchedule, List<ICalendarItem>> dictionary = Instance.CrossingEvents(new List<ISchedule> { schedule }, startDate, endDate);
		foreach (KeyValuePair<ISchedule, List<ICalendarItem>> item in dictionary)
		{
			item.Value.ForEach(calendarItemCollection.Add);
		}
		return calendarItemCollection;
	}

	[PublicApiMember]
	public virtual void Delete(ICalendarEvent @event, bool all)
	{
		if (@event == null)
		{
			throw new ArgumentException(SR.T("Событие не может быть null"));
		}
		if (Instance.CanDeleteEvent(@event, all))
		{
			Instance.DeleteEvent(@event, all);
			return;
		}
		throw new Exception(SR.T("Данное событие не может быть удалено"));
	}
}
