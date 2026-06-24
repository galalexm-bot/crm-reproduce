using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Messages.Web.Components;

[Component(Order = 50)]
public class DiscussionEventRender : BaseAuditEventRender
{
	private DiscussionObjectManager discussionObjectManager;

	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<IDiscussionObject>();
		}
	}

	public DiscussionEventRender(DiscussionObjectManager discussionObjectManager)
	{
		this.discussionObjectManager = discussionObjectManager;
	}

	public override bool CanRender(EntityActionEventArgs @event)
	{
		if (base.CanRender(@event) && @event.New is IDiscussionObject discussionObject && discussionObject.Message != null)
		{
			return true;
		}
		return false;
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		EntityActionEventArgs entityActionEventArgs = discussionObjectManager.DiscussionRendererEvent(@event);
		if (entityActionEventArgs != null && entityActionEventArgs.New != null)
		{
			entityActionEventArgs.New.Refresh();
		}
		return new DiscussionHistoryModel(entityActionEventArgs, SR.T("Начато обсуждение"))
		{
			Message = (IChannelMessage)entityActionEventArgs.New
		};
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return DeliveryViewBlock();
		}
		return null;
	}

	private HistoryPartViewBlock DeliveryViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/ChannelMessage.Discussion", (object)model)
		};
	}
}
