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
public class SaleSimpleEventRender : BaseAuditEventRender
{
	private string saleStatusName;

	private string saleStageName;

	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
			yield return DefaultEntityActions.UpdateGuid;
			yield return SaleActions.AddCommentGuid;
			yield return SaleActions.ChangeStatusGuid;
			yield return SaleActions.ChangeStageGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<ISale>();
		}
	}

	public SaleSimpleEventRender()
	{
		saleStatusName = "SaleStatus";
		saleStageName = "SaleStage";
	}

	public override bool CanRender(EntityActionEventArgs @event)
	{
		if (!base.CanRender(@event))
		{
			return false;
		}
		if (@event is EditEntityActionEventArgs editEntityActionEventArgs)
		{
			return !editEntityActionEventArgs.ChangedProperties.Any((PropertyMetadata c) => c.Name == saleStatusName || c.Name == saleStageName);
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
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Сделка создана"));
		}
		if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Сделка изменена"));
		}
		if (@event.Action.Uid == SaleActions.AddCommentGuid)
		{
			return RenderAddComment(html, @event, historyLoader);
		}
		if (@event.Action.Uid == SaleActions.ChangeStatusGuid)
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Статус сделки изменен"));
		}
		if (@event.Action.Uid == SaleActions.ChangeStageGuid)
		{
			return RenderChanges(html, @event, historyLoader, SR.T("Стадия сделки изменена"));
		}
		return null;
	}

	private IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CommentSaleHistoryModel commentEvent = new CommentSaleHistoryModel(@event, string.Empty);
		ISale sale = (ISale)@event.New;
		if (sale.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)sale.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		return commentEvent;
	}

	protected IHistoryBaseModel RenderChanges(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventText)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		SaleChangesHistoryModel historyModel = new SaleChangesHistoryModel(@event, eventText);
		ISale sale = (ISale)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<ISale>(), DefaultEntityActions.UpdateGuid, sale.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			historyModel.OldEntity = (ISale)entityActionEventArgs.Old;
			historyModel.NewEntity = (ISale)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				historyModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.Where((PropertyMetadata p) => !historyModel.BaseProperties.Contains(p.Uid)).ToList();
			}
		}
		if (sale.Comments != null && historyModel.ChangedProperties != null && historyModel.ChangedProperties.Any())
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)sale.Comments).Contains(c));
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
		if (@event.Action.Uid == SaleActions.ChangeStatusGuid)
		{
			return ChangeStatusViewBlock();
		}
		if (@event.Action.Uid == SaleActions.ChangeStageGuid)
		{
			return ChangeStageViewBlock();
		}
		return null;
	}

	private HistoryPartViewBlock UpdateViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Sale.UpdateView", (object)model)
		};
	}

	private HistoryPartViewBlock ChangeStatusViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Sale.ChangeStatus", (object)model)
		};
	}

	private HistoryPartViewBlock ChangeStageViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Sale.ChangeStage", (object)model)
		};
	}
}
