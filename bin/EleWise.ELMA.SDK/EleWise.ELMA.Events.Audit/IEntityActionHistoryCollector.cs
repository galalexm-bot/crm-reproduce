using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Events.Audit;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[Obsolete("Данный класс устарел и больше не используется. Используйте IEntityActionHistoryCollectorRelated")]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityActionHistoryCollector
{
	[Obsolete("Метод устарел и больше не используется. Используйте IEntityActionHistoryCollectorRelated.CollectHistory")]
	IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject);
}
