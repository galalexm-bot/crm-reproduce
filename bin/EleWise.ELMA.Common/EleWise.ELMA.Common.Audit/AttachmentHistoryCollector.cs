using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.Audit;

[Component]
internal class AttachmentHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	private EntityActionHistoryManager entityActionHistoryManager;

	private readonly Guid collectorGuid;

	public AttachmentHistoryCollector(EntityActionHistoryManager entityActionHistoryManager)
	{
		this.entityActionHistoryManager = entityActionHistoryManager;
		collectorGuid = new Guid("F212FFDD-770E-42E7-A45D-6398AACA7BD1");
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		if (relatedEventList == null)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		Type attachmentType = InterfaceActivator.TypeOf<IAttachment>();
		return relatedEventList.Where((EntityActionEventArgs c) => c.EntityType == attachmentType && c.Action != null && c.Action.Uid == DefaultEntityActions.CreateGuid);
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		return Enumerable.Empty<HistoryCollectorRelatedModel>();
	}
}
