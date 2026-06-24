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
public class MarketingBaseSimpleEventRender : BaseAuditEventRender
{
	private readonly string marketingBaseStatusName = "Status";

	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return MarketingBaseActions.AddCommentGuid;
			yield return MarketingBaseActions.ActivateGuid;
			yield return MarketingBaseActions.ArchiveGuid;
			yield return DefaultEntityActions.CreateGuid;
			yield return DefaultEntityActions.UpdateGuid;
		}
	}

	protected override IEnumerable<Guid> Objects => new Guid[3]
	{
		InterfaceActivator.UID<IMarketingGroup>(),
		InterfaceActivator.UID<IMarketingActivity>(),
		InterfaceActivator.UID<IMarketingEffect>()
	};

	public override bool CanRender(EntityActionEventArgs @event)
	{
		if (!base.CanRender(@event))
		{
			return false;
		}
		if (@event is EditEntityActionEventArgs editEntityActionEventArgs)
		{
			return !editEntityActionEventArgs.ChangedProperties.Any((PropertyMetadata c) => c.Name == marketingBaseStatusName);
		}
		return true;
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
		if (@event.Action.Uid == MarketingBaseActions.AddCommentGuid)
		{
			return RenderAddComment(@event, historyLoader, string.Empty);
		}
		if (@event.Action.Uid == MarketingBaseActions.ArchiveGuid)
		{
			return RenderAddComment(@event, historyLoader, SR.T("Перемещено(а) в архив"));
		}
		if (@event.Action.Uid == MarketingBaseActions.ActivateGuid)
		{
			return RenderAddComment(@event, historyLoader, SR.T("Восстановлено(а) из архива"));
		}
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCreateChanges(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
		{
			return RenderUpdateChanges(html, @event, historyLoader);
		}
		return null;
	}

	private IHistoryBaseModel RenderAddComment(EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string text)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CommentMarketingBaseHistoryModel commentEvent = new CommentMarketingBaseHistoryModel(@event, text);
		IMarketingBase marketing = (IMarketingBase)@event.New;
		if (marketing.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)marketing.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		return commentEvent;
	}

	private IHistoryBaseModel RenderCreateChanges(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingGroup>())
		{
			return RenderChanges(@event, historyLoader, SR.T("Группа маркетинговых мероприятий создана"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingActivity>())
		{
			return RenderChanges(@event, historyLoader, SR.T("Маркетинговое мероприятие создано"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingEffect>())
		{
			return RenderChanges(@event, historyLoader, SR.T("Маркетинговое воздействие создано"));
		}
		return null;
	}

	private IHistoryBaseModel RenderUpdateChanges(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingGroup>())
		{
			return RenderChanges(@event, historyLoader, SR.T("Группа маркетинговых мероприятий изменена"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingActivity>())
		{
			return RenderChanges(@event, historyLoader, SR.T("Маркетинговое мероприятие изменено"));
		}
		if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingEffect>())
		{
			return RenderChanges(@event, historyLoader, SR.T("Маркетинговое воздействие изменено"));
		}
		return null;
	}

	private IHistoryBaseModel RenderChanges(EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventText)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		MarketingBaseChangesHistoryModel historyModel = new MarketingBaseChangesHistoryModel(@event, eventText);
		IMarketingBase marketingBase = (IMarketingBase)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Metadata.Uid, DefaultEntityActions.UpdateGuid, marketingBase.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			historyModel.OldEntity = (IMarketingBase)entityActionEventArgs.Old;
			historyModel.NewEntity = (IMarketingBase)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				historyModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.Where((PropertyMetadata p) => !historyModel.BaseProperties.Contains(p.Uid)).ToList();
			}
		}
		if (marketingBase.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)marketingBase.Comments).Contains(c));
			historyModel.Comment = comment;
		}
		return historyModel;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
		{
			return UpdateViewBlock();
		}
		return null;
	}

	private HistoryPartViewBlock UpdateViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Marketing.Update", (object)model)
		};
	}
}
