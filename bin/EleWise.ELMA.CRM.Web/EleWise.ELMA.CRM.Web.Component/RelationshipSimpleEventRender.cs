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
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 100)]
public class RelationshipSimpleEventRender : BaseAuditEventRender
{
	private UserManager userManager;

	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
			yield return RelationshipActions.EditGuid;
			yield return RelationshipActions.AddCommentGuid;
			yield return RelationshipActions.CompleteGuid;
			yield return RelationshipActions.ChangeTimeGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<IRelationship>();
			yield return InterfaceActivator.UID<IRelationshipCall>();
			yield return InterfaceActivator.UID<IRelationshipMail>();
			yield return InterfaceActivator.UID<IRelationshipMeeting>();
		}
	}

	public RelationshipSimpleEventRender(UserManager userManager)
	{
		this.userManager = userManager;
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
		if (@event.Action.Uid == RelationshipActions.AddCommentGuid)
		{
			return RenderAddComment(html, @event, historyLoader, string.Empty);
		}
		if (@event.Action.Uid == RelationshipActions.CompleteGuid)
		{
			return RenderAddComment(html, @event, historyLoader, SR.T("Выполнено"));
		}
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCreateChanges(html, @event, historyLoader);
		}
		if (@event.Action.Uid == RelationshipActions.ChangeTimeGuid)
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Время изменено"));
		}
		if (@event.Action.Uid == RelationshipActions.EditGuid)
		{
			return RenderEditChanges(html, @event, historyLoader);
		}
		return null;
	}

	private IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventSubject)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CommentRelationshipHistoryModel commentEvent = new CommentRelationshipHistoryModel(@event, eventSubject);
		IRelationship relationship = (IRelationship)@event.New;
		if (relationship.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)relationship.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		return commentEvent;
	}

	private IHistoryBaseModel RenderEditChanges(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipCall>())
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Звонок изменён"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipMeeting>())
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Встреча изменена"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipMail>())
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Письмо изменено"));
		}
		return null;
	}

	private IHistoryBaseModel RenderCreateChanges(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipCall>())
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Звонок создан"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipMeeting>())
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Встреча создана"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipMail>())
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Письмо создано"));
		}
		return null;
	}

	private IHistoryBaseModel RenderChanges(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventText)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		RelationshipChangesHistoryModel historyModel = new RelationshipChangesHistoryModel(@event, eventText);
		IRelationship relationship = (IRelationship)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Metadata.Uid, DefaultEntityActions.UpdateGuid, relationship.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			historyModel.OldEntity = (IRelationship)entityActionEventArgs.Old;
			historyModel.NewEntity = (IRelationship)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				historyModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.Where((PropertyMetadata p) => !historyModel.BaseProperties.Contains(p.Uid)).ToList();
			}
		}
		if (relationship.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)relationship.Comments).Contains(c));
			historyModel.Comment = comment;
		}
		if (historyModel.OldEntity != null && historyModel.NewEntity != null)
		{
			string text = historyModel.OldEntity.RelationshipUsersHash ?? "";
			string text2 = historyModel.NewEntity.RelationshipUsersHash ?? "";
			if (!text.Equals(text2))
			{
				List<long> oldUsersId = (from x in text.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select x).Select(long.Parse).ToList();
				List<long> newUsersId = (from x in text2.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select x).Select(long.Parse).ToList();
				List<long> removedUsersId = oldUsersId.Where((long c) => !newUsersId.Contains(c)).ToList();
				List<long> addedUsersId = newUsersId.Where((long c) => !oldUsersId.Contains(c)).ToList();
				IEnumerable<long> source = removedUsersId.Union(addedUsersId);
				ICollection<IUser> source2 = userManager.FindByIdArray(source.ToArray());
				historyModel.NewEventUsers = source2.Where((IUser c) => addedUsersId.Any((long d) => d == c.Id)).ToList();
				historyModel.OldEventUsers = source2.Where((IUser c) => removedUsersId.Any((long d) => d == c.Id)).ToList();
			}
		}
		return historyModel;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == RelationshipActions.ChangeTimeGuid)
		{
			return ChangeTimeViewBlock();
		}
		if (@event.Action.Uid == RelationshipActions.EditGuid)
		{
			return EditViewBlock();
		}
		return null;
	}

	private HistoryPartViewBlock ChangeTimeViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Relationship.ChangeTime", (object)model)
		};
	}

	private HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Relationship.Edit", (object)model)
		};
	}
}
