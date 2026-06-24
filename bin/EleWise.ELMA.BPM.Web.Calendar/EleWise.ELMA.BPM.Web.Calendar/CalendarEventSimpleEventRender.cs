using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(Order = 100)]
public class CalendarEventSimpleEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return CalendarEventActions.AddCommentGuid;
			yield return CalendarEventActions.ChangeTimeGuid;
			yield return CalendarEventActions.CompleteGuid;
			yield return CalendarEventActions.EditGuid;
			yield return DefaultEntityActions.CreateGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<ICalendarEvent>();
			yield return InterfaceActivator.UID<ICalendarEventPeriodical>();
		}
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (@event.Action.Uid == CalendarEventActions.EditGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		if (@event.Action.Uid == CalendarEventActions.AddCommentGuid)
		{
			return RenderCommentAction(html, @event, historyLoader, string.Empty);
		}
		if (@event.Action.Uid == CalendarEventActions.ChangeTimeGuid)
		{
			return RenderChangeTime(html, @event, historyLoader);
		}
		if (@event.Action.Uid == CalendarEventActions.CompleteGuid)
		{
			return RenderCommentAction(html, @event, historyLoader, SR.T("Событие завершено"));
		}
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCommentAction(html, @event, historyLoader, SR.T("Событие создано"));
		}
		return null;
	}

	private IHistoryBaseModel RenderCommentAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventTheme)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ICalendarEvent calendarEvent = @event.New as ICalendarEvent;
		CommentCalendarEventHistoryModel commentEvent = new CommentCalendarEventHistoryModel(@event, eventTheme);
		if (calendarEvent != null && calendarEvent.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)calendarEvent.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		if (calendarEvent != null && calendarEvent.Attachments != null)
		{
			List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)calendarEvent.Attachments).Contains(a)
				select a).ToList();
			commentEvent.Attachments = attachments;
		}
		return commentEvent;
	}

	private IHistoryBaseModel RenderUserEdit(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		EditCalendarEventHistoryModel userEditEvent = new EditCalendarEventHistoryModel(@event, SR.T("Событие изменено"));
		ICalendarEvent calendarEvent = (ICalendarEvent)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<ICalendarEvent>(), DefaultEntityActions.UpdateGuid, calendarEvent.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditEvent.OldEntity = (ICalendarEvent)entityActionEventArgs.Old;
			userEditEvent.NewEntity = (ICalendarEvent)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditEvent.ChangedProperties = (from p in editEntityActionEventArgs.ChangedProperties.ToList()
					where !userEditEvent.BaseProperties.Contains(p.Uid)
					select p).ToList();
			}
		}
		if (calendarEvent.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)calendarEvent.Comments).Contains(c));
			userEditEvent.Comment = comment;
		}
		if (calendarEvent.Attachments != null)
		{
			List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)calendarEvent.Attachments).Contains(a)
				select a).ToList();
			userEditEvent.Attachments = attachments;
		}
		if (userEditEvent.OldEntity != null && userEditEvent.NewEntity != null)
		{
			string text = userEditEvent.OldEntity.EventUsersHash ?? "";
			string text2 = userEditEvent.NewEntity.EventUsersHash ?? "";
			if (!text.Equals(text2))
			{
				List<long> oldEventUsers = (from x in text.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select x).Select(long.Parse).ToList();
				List<long> newEventUsers = (from x in text2.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select x).Select(long.Parse).ToList();
				List<long> removedEventUsers = oldEventUsers.Where((long c) => !newEventUsers.Contains(c)).ToList();
				List<long> addedEventUsers = newEventUsers.Where((long c) => !oldEventUsers.Contains(c)).ToList();
				IEnumerable<long> source = removedEventUsers.Union(addedEventUsers);
				ICollection<ICalendarEventUser> source2 = AbstractNHEntityManager<ICalendarEventUser, long>.Instance.FindByIdArray(source.ToArray());
				userEditEvent.NewEventUsers = source2.Where((ICalendarEventUser c) => addedEventUsers.Any((long d) => d == c.Id)).ToList();
				userEditEvent.OldEventUsers = source2.Where((ICalendarEventUser c) => removedEventUsers.Any((long d) => d == c.Id)).ToList();
			}
		}
		return userEditEvent;
	}

	private IHistoryBaseModel RenderChangeTime(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ChangeDateCalendarEventHistoryModel changeDateCalendarEventHistoryModel = new ChangeDateCalendarEventHistoryModel(@event, SR.T("Время события изменено"));
		ICalendarEvent calendarEvent = (ICalendarEvent)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<ICalendarEvent>(), DefaultEntityActions.UpdateGuid, calendarEvent.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			changeDateCalendarEventHistoryModel.OldEntity = (ICalendarEvent)entityActionEventArgs.Old;
			changeDateCalendarEventHistoryModel.NewEntity = (ICalendarEvent)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				changeDateCalendarEventHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		if (calendarEvent.Comments != null)
		{
			IComment comment2 = (changeDateCalendarEventHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)calendarEvent.Comments).Contains(c)));
		}
		return changeDateCalendarEventHistoryModel;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == CalendarEventActions.EditGuid)
		{
			return EditViewBlock();
		}
		if (@event.Action.Uid == CalendarEventActions.ChangeTimeGuid)
		{
			return ChangeTimeViewBlock();
		}
		return null;
	}

	private HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/CalendarEvent.Edit", (object)model)
		};
	}

	private HistoryPartViewBlock ChangeTimeViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/CalendarEvent.ChangeTime", (object)model)
		};
	}
}
