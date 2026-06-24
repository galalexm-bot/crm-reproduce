using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;
using EleWise.ELMA.Workflow.Audit;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component(Order = 100)]
public class EntityUpdateByWorkflowTaskEventRenderer : EntitySimpleEventRender
{
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	protected override IEnumerable<Guid> Actions => new Guid[1] { DefaultEntityActions.UpdateGuid };

	public override bool CanRender(EntityActionEventArgs @event)
	{
		if (@event.ExtendedProperties.TryGetValue("EventType", out var value))
		{
			if (!(value is string text))
			{
				return false;
			}
			return text == EntityUpdateByWorkflowTaskCollector.UID;
		}
		return false;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		HistoryPartViewBlock defaultBlock = base.GetExtraViewBlock(@event);
		if (@event.ExtendedProperties.TryGetValue("RelatedModel", out var value) && value is HistoryCollectorRelatedModel historyCollectorRelatedModel)
		{
			ReferenceOnEntity link = new ReferenceOnEntity(historyCollectorRelatedModel.EntityId, historyCollectorRelatedModel.EntityTypeUid);
			return new HistoryPartViewBlock
			{
				HistoryPartType = defaultBlock.HistoryPartType,
				Index = defaultBlock.Index,
				RenderDelegate = delegate(HtmlHelper html, IHistoryBaseModel model)
				{
					RenderPartialExtensions.RenderPartial(html, "AuditView/UpdateByWorkflowTask", (object)link);
					return defaultBlock.RenderDelegate(html, model);
				}
			};
		}
		return defaultBlock;
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		Contract.ArgumentNotNull(html, "html");
		Contract.ArgumentNotNull(@event, "event");
		Contract.ArgumentNotNull(@event.Action, "event.Action");
		Contract.ArgumentNotNull(historyLoader, "historyLoader");
		if (!(@event.Action.Uid == DefaultEntityActions.UpdateGuid))
		{
			return null;
		}
		return RenderEdit(html, @event, historyLoader);
	}

	private IHistoryBaseModel RenderEdit(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		EditedEntityHistoryModel editedEntityHistoryModel = new EditedEntityHistoryModel(@event, SR.T("Отредактирован в рамках задачи по процессу"));
		editedEntityHistoryModel.OldEntity = (IEntity<long>)@event.Old;
		editedEntityHistoryModel.NewEntity = (IEntity<long>)@event.New;
		if (@event is EditEntityActionEventArgs editEntityActionEventArgs)
		{
			editedEntityHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
		}
		return editedEntityHistoryModel;
	}
}
