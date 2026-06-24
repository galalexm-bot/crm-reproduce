using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 100)]
public class ContactSimpleEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return ContactActions.AddCommentGuid;
			yield return DefaultEntityActions.UpdateGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<IContact>();
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
		if (@event.Action.Uid == ContactActions.AddCommentGuid)
		{
			return RenderAddComment(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		return null;
	}

	private IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CommentContactHistoryModel commentEvent = new CommentContactHistoryModel(@event, string.Empty);
		IContact contact = (IContact)@event.New;
		if (contact.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)contact.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		return commentEvent;
	}

	private IHistoryBaseModel RenderUserEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditContactHistoryModel userEditEvent = new UserEditContactHistoryModel(@event, SR.T("Контакт изменен"));
		IContact contact = (IContact)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, contact.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditEvent.OldEntity = (IContact)entityActionEventArgs.Old;
			userEditEvent.NewEntity = (IContact)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditEvent.ChangedProperties = (from p in editEntityActionEventArgs.ChangedProperties.ToList()
					where !userEditEvent.BaseProperties.Contains(p.Uid)
					select p).ToList();
			}
		}
		return userEditEvent;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event == null || @event.Action == null)
		{
			return null;
		}
		if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
		{
			return new HistoryPartViewBlock
			{
				HistoryPartType = "action",
				Index = 1,
				RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Contact.Edit", (object)model)
			};
		}
		return null;
	}
}
