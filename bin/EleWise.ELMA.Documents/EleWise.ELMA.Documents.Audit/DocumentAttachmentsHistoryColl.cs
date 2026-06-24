using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Audit;

[Component]
internal class DocumentAttachmentsHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	private readonly Guid collectorGuid;

	private EntityActionHistoryManager entityActionHistoryManager;

	public DocumentAttachmentsHistoryCollector(EntityActionHistoryManager entityActionHistoryManager)
	{
		this.entityActionHistoryManager = entityActionHistoryManager;
		collectorGuid = new Guid("D5C48CE2-5DAD-4374-9A96-6DD17C2155C9");
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		if (relatedEventList == null || relatedObjectList == null)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		Type attachmentType = InterfaceActivator.TypeOf<IDocumentAttachment>();
		return relatedEventList.Where((EntityActionEventArgs c) => c.EntityType == attachmentType && c.Action.Uid == DefaultEntityActions.CreateGuid);
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		return Enumerable.Empty<HistoryCollectorRelatedModel>();
	}
}
