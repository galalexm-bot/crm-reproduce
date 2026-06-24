using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Attributes;
using NHibernate;

namespace EleWise.ELMA.History.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEntityHistoryCollectorCacheble
{
	Guid CachableCollectorGuid { get; }

	Guid OldCollectorGuid { get; }

	Guid EntityTypeGuid { get; }

	Guid BaseActionObject { get; }

	IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid entityTypeUid);

	IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(ICriteria criteria);

	ICriteria GetCriteria(long id, Guid entityTypeUid);

	bool CanUse(long id, Guid actionObject);
}
