using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Events.Audit;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityActionHistoryCollectorRelated
{
	IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList);

	IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject);

	bool CanUse(long id, Guid actionObject);
}
