using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 100)]
public class LeadSimpleEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return LeadActions.AddCommentGuid;
			yield return LeadActions.InHandGuid;
			yield return LeadActions.QualifiedGuid;
			yield return LeadActions.UnqualifiedGuid;
			yield return LeadActions.ActivatedGuid;
			yield return LeadActions.DublicateGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<ILead>();
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
		if (@event.Action.Uid == LeadActions.AddCommentGuid)
		{
			return RenderAddComment(html, @event, historyLoader, string.Empty);
		}
		if (@event.Action.Uid == LeadActions.InHandGuid)
		{
			return RenderAddComment(html, @event, historyLoader, SR.T("Взят в работу"));
		}
		if (@event.Action.Uid == LeadActions.QualifiedGuid)
		{
			return RenderAddComment(html, @event, historyLoader, SR.T("Квалифицирован"));
		}
		if (@event.Action.Uid == LeadActions.UnqualifiedGuid)
		{
			return RenderAddComment(html, @event, historyLoader, SR.T("Неуспех"));
		}
		if (@event.Action.Uid == LeadActions.ActivatedGuid)
		{
			return RenderAddComment(html, @event, historyLoader, SR.T("Активирован"));
		}
		if (@event.Action.Uid == LeadActions.DublicateGuid)
		{
			return RenderAddComment(html, @event, historyLoader, SR.T("Дубль"));
		}
		return null;
	}

	private IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventSubject)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CommentLeadHistoryModel commentEvent = new CommentLeadHistoryModel(@event, eventSubject);
		ILead lead = (ILead)@event.New;
		if (lead.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)lead.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		return commentEvent;
	}
}
