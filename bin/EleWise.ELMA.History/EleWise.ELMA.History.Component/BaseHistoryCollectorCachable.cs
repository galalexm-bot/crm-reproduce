using System;
using System.Collections.Generic;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.History.ExtensionPoints;
using NHibernate;

namespace EleWise.ELMA.History.Components;

public abstract class BaseHistoryCollectorCachable : IEntityHistoryCollectorCacheble
{
	private readonly Guid thisCollectorGuid;

	private readonly Guid entityTypeGuid;

	private readonly Guid baseActionObject;

	protected readonly IEntityActionHistoryCollectorRelated CollectorRelated;

	public static bool StateCollecting { get; set; }

	public virtual Guid OldCollectorGuid
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public Guid EntityTypeGuid => entityTypeGuid;

	public Guid BaseActionObject => baseActionObject;

	public Guid CachableCollectorGuid => thisCollectorGuid;

	public BaseHistoryCollectorCachable(IEntityActionHistoryCollectorRelated collectorRelated, Guid collectorGuid, Guid entityTypeGuid, Guid baseActionObject)
	{
		CollectorRelated = collectorRelated;
		thisCollectorGuid = collectorGuid;
		this.entityTypeGuid = entityTypeGuid;
		this.baseActionObject = baseActionObject;
	}

	public virtual bool CanUse(long id, Guid actionObject)
	{
		return CollectorRelated.CanUse(id, actionObject);
	}

	public abstract ICriteria GetCriteria(long id, Guid entityTypeUid);

	public IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid entityTypeUid)
	{
		return RelatedObjects(GetCriteria(id, entityTypeUid));
	}

	public abstract IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(ICriteria criteria);
}
