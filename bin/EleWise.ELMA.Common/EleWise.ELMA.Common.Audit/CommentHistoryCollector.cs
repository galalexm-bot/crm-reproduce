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
internal class CommentHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	private readonly Guid collectorGuid;

	private EntityActionHistoryManager entityActionHistoryManager;

	public CommentHistoryCollector(EntityActionHistoryManager entityActionHistoryManager)
	{
		this.entityActionHistoryManager = entityActionHistoryManager;
		collectorGuid = new Guid("97467DCB-0BD3-4815-B1D3-6FCCC377629C");
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		if (relatedEventList == null)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		Type attachmentType = InterfaceActivator.TypeOf<IComment>();
		return relatedEventList.Where((EntityActionEventArgs c) => c.EntityType == attachmentType && c.Action != null && c.Action.Uid == DefaultEntityActions.CreateGuid);
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		return Enumerable.Empty<HistoryCollectorRelatedModel>();
	}
}
