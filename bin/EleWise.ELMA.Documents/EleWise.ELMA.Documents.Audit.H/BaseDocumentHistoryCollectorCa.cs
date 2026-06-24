using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.History.Components;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Audit.History;

public abstract class BaseDocumentHistoryCollectorCachable : BaseHistoryCollectorCachable
{
	protected BaseDocumentHistoryCollectorCachable(IEntityActionHistoryCollectorRelated collectorRelated, Guid collectorGuid, Guid entityTypeGuid)
		: base(collectorRelated, collectorGuid, entityTypeGuid, InterfaceActivator.UID<IDocument>())
	{
	}
}
