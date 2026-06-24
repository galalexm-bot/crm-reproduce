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
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 101)]
public class AddressSimpleEventRender : BaseAuditEventRender
{
	private readonly IEnumerable<Guid> actions = new Guid[1] { DefaultEntityActions.UpdateGuid };

	private readonly Guid addressBaseUid = InterfaceActivator.UID<IAddress>();

	protected override IEnumerable<Guid> Actions => actions;

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(addressBaseUid) as EntityMetadata;
			List<Guid> list = MetadataLoader.GetChildClasses(entityMetadata).SelectMany(delegate(ClassMetadata impl)
			{
				EntityMetadata entityMetadata2 = impl as EntityMetadata;
				return new Guid[2] { entityMetadata2.Uid, entityMetadata2.ImplementationUid };
			}).ToList();
			list.AddRange(new Guid[2] { entityMetadata.Uid, entityMetadata.ImplementationUid });
			return list;
		}
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		Contract.ArgumentNotNull(html, "html");
		Contract.ArgumentNotNull(@event, "@event");
		Contract.ArgumentNotNull(historyLoader, "historyLoader");
		if (!(@event.Action.Uid == DefaultEntityActions.UpdateGuid))
		{
			return null;
		}
		return RenderUserEdit(@event);
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event == null || @event.Action == null)
		{
			return null;
		}
		if (!(@event.Action.Uid == DefaultEntityActions.UpdateGuid))
		{
			return null;
		}
		return EditViewBlock();
	}

	private IHistoryBaseModel RenderUserEdit([NotNull] EntityActionEventArgs @event)
	{
		string actionTheme = SR.T("Изменено свойство контрагента{0}", string.Format(": {0}", @event.ExtendedProperties["Theme"]));
		EditedAddressHistoryModel editedAddressHistoryModel = new EditedAddressHistoryModel(@event, actionTheme)
		{
			OldEntity = (@event.Old as IEntity<long>),
			NewEntity = (@event.New as IEntity<long>)
		};
		if (@event is EditEntityActionEventArgs editEntityActionEventArgs)
		{
			editedAddressHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
		}
		if (@event.ExtendedProperties.TryGetValue("RelatedModel", out var value) && value != null)
		{
			IEntity obj = value as IEntity;
			ReferenceOnEntity referenceOnEntity2 = (editedAddressHistoryModel.SlaveObject = new ReferenceOnEntity(objectTypeUId: MetadataLoader.LoadMetadata(obj.GetType()).Uid, objectId: (long)obj.GetId()));
			editedAddressHistoryModel.ActionTheme = SR.T("Изменено свойство контрагента: {0}", referenceOnEntity2.ObjectDispalyName);
			editedAddressHistoryModel.SlavePropertyName = string.Format(": {0}", @event.ExtendedProperties["Theme"]);
		}
		return editedAddressHistoryModel;
	}

	private HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Address.Edit", (object)model)
		};
	}
}
