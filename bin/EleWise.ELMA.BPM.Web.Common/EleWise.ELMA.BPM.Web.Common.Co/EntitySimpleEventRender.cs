using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = int.MaxValue)]
public class EntitySimpleEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
			yield return DefaultEntityActions.UpdateGuid;
		}
	}

	protected override IEnumerable<Guid> Objects => (from md in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>()
		where md.Type != EntityMetadataType.InterfaceImplementation && md.SaveHistory && md.IdTypeUid == Int64Descriptor.UID && md.IsConfig()
		select md).SelectMany((EntityMetadata md) => new Guid[2] { md.Uid, md.ImplementationUid }).ToList();

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
		if (@event.Action == null)
		{
			throw new ArgumentException("event.Action");
		}
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCreate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
		{
			return RenderEdit(html, @event, historyLoader);
		}
		return null;
	}

	private IHistoryBaseModel RenderCreate(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		return new CreateEntityHistoryModel(@event, SR.T("Создание"))
		{
			Entity = (IEntity<long>)@event.New
		};
	}

	private IHistoryBaseModel RenderEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		EditedEntityHistoryModel editedEntityHistoryModel = new EditedEntityHistoryModel(@event, SR.T("Изменение"));
		IEntity<long> entity = (IEntity<long>)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, entity.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			editedEntityHistoryModel.OldEntity = (IEntity<long>)entityActionEventArgs.Old;
			editedEntityHistoryModel.NewEntity = (IEntity<long>)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				editedEntityHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return editedEntityHistoryModel;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
		{
			return EditViewBlock();
		}
		return null;
	}

	private HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Entity.Edit", (object)model)
		};
	}
}
